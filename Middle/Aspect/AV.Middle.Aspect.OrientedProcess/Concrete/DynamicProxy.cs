using log4net;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AV.Middle.Aspect.OrientedProcess.Concrete
{
	public class DynamicProxy<T> : DispatchProxy
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		private readonly T _decorated;
		private Predicate<MethodInfo> filter;

		public DynamicProxy(T decorated)
		{
			_decorated = decorated;
			filter = m => true;
		}

		public Predicate<MethodInfo> Filter
		{
			get
			{
				return filter;
			}
			set
			{
				filter = value ?? (m => true);
			}
		}

		protected override object Invoke(MethodInfo targetMethod, object[] args)
		{
			try
			{
				var result = targetMethod.Invoke(_decorated, args);
				Log($"In Dynamic Proxy - After executing ${targetMethod.Name}.");
				return result;
			}
			catch (Exception ex) when (ex is TargetInvocationException)
			{
				Log($"In Dynamic Proxy - After executing ${targetMethod.Name}.");
				throw ex.InnerException ?? ex;
			}
		}

		private void Log(string msg, object arg = null) => logger.InfoFormat(msg, arg);
	}
}
