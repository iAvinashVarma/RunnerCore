using AV.Middle.Common.DAL;
using AV.Middle.Reflector.IService;
using log4net;
using System;
using System.Collections;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;

namespace AV.Middle.Reflector.DatabaseCompiler.SQLServer
{
	public class ScriptCompiler : IProcess
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public Hashtable Hashtable { get; set; }

		public bool Validate()
		{
			return true;
		}

		public void Start()
		{
			logger.Info("Started compiling the scripts.");
			try
			{
				var scriptsFile = Hashtable["FilePath"];
				if (scriptsFile != null)
				{
					var listFile = Path.GetFullPath(Convert.ToString(scriptsFile));
					if (File.Exists(listFile))
					{
						logger.Info($"Given list file: {listFile}.");
						var readScriptFiles = File.ReadAllLines(listFile);
						var integratedSecurity = Hashtable["IntegratedSecurity"] != null && Hashtable["IntegratedSecurity"].ToString() == "1" ? true : false;
						var sqlConnectionStringBuilder = new SqlConnectionStringBuilder
						{
							IntegratedSecurity = integratedSecurity,
							InitialCatalog = Hashtable["InitialCatalog"].ToString(),
							DataSource = Hashtable["DataSource"].ToString()
						};

						if (!integratedSecurity)
						{
							sqlConnectionStringBuilder.UserID = Hashtable["UserId"].ToString();
							sqlConnectionStringBuilder.Password = Hashtable["Password"].ToString();
						}

						logger.Info($"Given connection string : {sqlConnectionStringBuilder.ToString()}");
						foreach (var scriptFile in readScriptFiles)
						{
							var file = Path.GetFullPath(scriptFile.Trim('"'));
							if (File.Exists(file))
							{
								var sqlCmd = SqlCmdFactory.GetFileService(sqlConnectionStringBuilder, file);
								var executeResult = sqlCmd.ExecuteCommand();
								if (executeResult.IsError)
								{
									logger.Error($"Issue in executing {file} - {executeResult.Error}");
								}
								else if (executeResult.IsOutput)
								{
									logger.Warn($"Issue in executing {file} - {executeResult.Output}");
								}
								else
								{
									logger.Info($"Successfully executed {file}");
								}
							}
							else
							{
								logger.Error($"Given file {file} is not valid.");
							}
						}
					}
					else
					{
						logger.Warn($"Given file {listFile} is not valid file path.");
					}
				}
				logger.Info("Completed the process.");
			}
			catch (Exception ex)
			{
				logger.Fatal(ex);
			}
		}
	}
}