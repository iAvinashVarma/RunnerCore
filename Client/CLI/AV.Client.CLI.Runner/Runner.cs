using AV.Middle.Common.Reflection;
using AV.Middle.Common.Section;
using AV.Middle.Extension.Generic;
using AV.Middle.Reflector.IService;
using log4net;
using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Reflection;

namespace AV.Client.CLI.Runner
{
	public sealed class Runner
	{
		private static volatile Runner instance = null;
		private static readonly object mutex = new Object();
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		private Runner()
		{
		}

		public static Runner Instance
		{
			get
			{
				if (instance == null)
				{
					lock (mutex)
					{
						if (instance == null)
						{
							instance = new Runner();
						}
					}
				}
				return instance;
			}
		}

		public void Run(string[] args)
		{
			Run(args.GetHashArguments());
		}

		private void Run(Hashtable hashtable)
		{
			var appSettings = new AppSettings();
			if (hashtable.ContainsKey("?"))
			{
				Help();
			}
			else if (hashtable.ContainsKey("Process"))
			{
				var process = LogHashtable(hashtable, "Process");
				if (!string.IsNullOrEmpty(process))
				{
					if (appSettings.PreRunnerList != null)
						DoProcess<IPreProcess>(hashtable, appSettings.PreRunnerList.FirstOrDefault(r => r.Enable && r.Process.Equals(process, StringComparison.OrdinalIgnoreCase)));
					if (appSettings.RunnerList != null)
						DoProcess<IProcess>(hashtable, appSettings.RunnerList.FirstOrDefault(r => r.Enable && r.Process.Equals(process, StringComparison.OrdinalIgnoreCase)));
					if (appSettings.PostRunnerList != null)
						DoProcess<IPostProcess>(hashtable, appSettings.PostRunnerList.FirstOrDefault(r => r.Enable && r.Process.Equals(process, StringComparison.OrdinalIgnoreCase)));
				}
				else
				{
					logger.Warn($"Invalid Process.");
				}
			}
			else
			{
				if (appSettings.PreRunnerList != null)
					appSettings.PreRunnerList.Where(r => r.Enable).OrderBy(r => r.Sequence).ToList().ForEach(r => DoProcess<IPreProcess>(hashtable, r));
				if (appSettings.RunnerList != null)
					appSettings.RunnerList.Where(r => r.Enable).OrderBy(r => r.Sequence).ToList().ForEach(r => DoProcess<IProcess>(hashtable, r));
				if (appSettings.PostRunnerList != null)
					appSettings.PostRunnerList.Where(r => r.Enable).OrderBy(r => r.Sequence).ToList().ForEach(r => DoProcess<IProcess>(hashtable, r));
			}
		}

		private void DoProcess<T>(Hashtable hashtable, Add runner)
		{
			if (runner != null && !string.IsNullOrEmpty(runner.Type))
			{
				var currentProcess = AssemblyFactory.LoadAssembly<T>(runner.Type);
				if (currentProcess != null)
				{
					if (typeof(T) == typeof(IPreProcess))
					{
						PreRun((IPreProcess)currentProcess, hashtable);
					}
					else if (typeof(T) == typeof(IProcess))
					{
						Run((IProcess)currentProcess, hashtable);
					}
					else if (typeof(T) == typeof(IPostProcess))
					{
						PostRun((IPostProcess)currentProcess, hashtable);
					}
				}
				else
				{
					logger.WarnFormat($"Issue while running {typeof(T).FullName}.");
				}
			}
		}

		private void PreRun(IPreProcess preProcess, Hashtable hashtable)
		{
			preProcess.Hashtable = hashtable;
			if (preProcess.PreValidate())
			{
				preProcess.PreStart();
			}
		}

		private void Run(IProcess process, Hashtable hashtable)
		{
			process.Hashtable = hashtable;
			if (process.Validate())
			{
				process.Start();
			}
		}

		private void PostRun(IPostProcess postProcess, Hashtable hashtable)
		{
			postProcess.Hashtable = hashtable;
			if (postProcess.PostValidate())
			{
				postProcess.PostStart();
			}
		}

		private void Help()
		{
			Console.WriteLine($"{typeof(Program).Assembly.GetName().Name} /Process=UpdateRoles /Directory=C:\\Products\\Tags\\10.6.0 /RolesPath=Roles.XML /Match=Activation /Replace=AppFunctionId /Pattern=*.cs /Contains=PrincipalPermission");
			Console.WriteLine($"{typeof(Program).Assembly.GetName().Name} /Process=ExecuteCommand /FilePath=C:\\AVI\\List.lst /DataSource=localhost /InitialCatalog=Sample /IntegratedSecurity=1{Environment.NewLine}" +
				$"{typeof(Program).Assembly.GetName().Name} /FilePath=C:\\AVI\\List.lst /DataSource=localhost /InitialCatalog=Sample /IntegratedSecurity=0 /UserId=[userId] /Password=[password]");
		}

		private string LogHashtable(Hashtable Hashtable, string key, bool isPath = false)
		{
			var value = string.Empty;
			if (Hashtable.ContainsKey(key) && Hashtable[key] != null)
			{
				var hash = Hashtable[key];
				value = isPath ? Path.GetFullPath(Hashtable[key].ToString()) : Hashtable[key].ToString();
				logger.InfoFormat("Given {0}: {1}", key, value);
			}
			else
				throw new Exception(string.Format("Invalid {0} information.", key));
			return value;
		}
	}
}