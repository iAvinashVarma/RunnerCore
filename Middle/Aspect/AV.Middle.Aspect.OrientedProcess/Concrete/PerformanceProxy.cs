using log4net;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AV.Middle.Aspect.OrientedProcess.Concrete
{
	public class PerformanceProxy<T> : DispatchProxy
	{
		private T _decorated;
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		protected override object Invoke(MethodInfo targetMethod, object[] args)
		{
			try
			{
				var watch = System.Diagnostics.Stopwatch.StartNew();
				var result = targetMethod?.Invoke(_decorated, args);
				watch.Stop();
				logger.Info($"Time taken to execute {targetMethod.Name} : {watch.ElapsedMilliseconds}.");
				return result;
			}
			catch (Exception ex)
			{
				logger.Error($"{ex}");
				return null;
			}
		}

		public T Create(T decorated)
		{
			object proxy = Create<T, PerformanceProxy<T>>();
			((PerformanceProxy<T>)proxy).SetParameters(decorated);
			return (T)proxy;
		}

		private void SetParameters(T decorated) => _decorated = decorated;
	}
}
