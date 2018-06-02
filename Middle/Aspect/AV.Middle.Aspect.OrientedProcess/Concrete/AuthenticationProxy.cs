using log4net;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AV.Middle.Aspect.OrientedProcess.Concrete
{
	public class AuthenticationProxy<T> : DispatchProxy
	{
		private T _decorated;
		private TaskScheduler _taskScheduler;
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		protected override object Invoke(MethodInfo targetMethod, object[] args)
		{
			if (Thread.CurrentPrincipal.IsInRole("Avi"))
			{
				try
				{
					logger.Info($"**********************");
					logger.Info($"User Authenticated - You can execute '{targetMethod.Name}'.");
					var result = targetMethod?.Invoke(_decorated, args);
					return result;
				}
				catch (Exception ex)
				{
					logger.Error($"{ex}");
				}
			}
			logger.Info($"User not authenticated - You can't execute '{targetMethod.Name}'");
			return null;
		}

		public T Create(T decorated, TaskScheduler taskScheduler = null)
		{
			object proxy = Create<T, AuthenticationProxy<T>>();
			((AuthenticationProxy<T>)proxy).SetParameters(decorated, taskScheduler);
			return (T)proxy;
		}

		private void SetParameters(T decorated, TaskScheduler taskScheduler)
		{
			_decorated = decorated;
			_taskScheduler = taskScheduler ?? TaskScheduler.Default;
		}
	}
}
