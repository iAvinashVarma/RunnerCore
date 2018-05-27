using AV.Middle.Reflector.IService;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AV.Client.CLI.Runner
{
	public class RunProcess
	{
		public void Run<T>(T currentProcess, Hashtable hashtable)
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

		private void PreRun(IPreProcess preProcess, Hashtable hashtable)
		{
			if (hashtable != null) return;
			preProcess.Hashtable = hashtable;
			if (preProcess.PreValidate())
			{
				preProcess.PreStart();
			}
		}

		private void Run(IProcess process, Hashtable hashtable)
		{
			if (hashtable != null) return;
			process.Hashtable = hashtable;
			if (process.Validate())
			{
				process.Start();
			}
		}

		private void PostRun(IPostProcess postProcess, Hashtable hashtable)
		{
			if (hashtable != null) return;
			postProcess.Hashtable = hashtable;
			if (postProcess.PostValidate())
			{
				postProcess.PostStart();
			}
		}
	}
}
