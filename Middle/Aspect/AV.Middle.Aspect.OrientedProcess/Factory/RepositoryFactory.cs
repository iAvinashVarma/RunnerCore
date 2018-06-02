using AV.Middle.Aspect.OrientedProcess.Concrete;
using AV.Middle.Aspect.OrientedProcess.Interface;
using AV.Middle.Aspect.OrientedProcess.Model;
using log4net;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AV.Middle.Aspect.OrientedProcess.Factory
{
	public class RepositoryFactory
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public IRepository<T> Create<T>(CreateType createType = CreateType.DynamicProxy)
		{
			IRepository<T> repository = null;
			switch (createType)
			{
				case CreateType.DynamicProxy:
					repository = new DynamicProxy<IRepository<T>>().Create(new Repository<T>(),
						s => logger.Info($"{s}"),
						e => logger.Error($"{e}"),
						o => o?.ToString(),
						TaskScheduler.Current);
					break;
				case CreateType.AuthenticationProxy:
					repository = new AuthenticationProxy<IRepository<T>>().Create(Create<T>(CreateType.DynamicProxy), TaskScheduler.Current);
					break;
				case CreateType.PerformanceProxy:
					repository = new PerformanceProxy<IRepository<T>>().Create(Create<T>(CreateType.AuthenticationProxy));
					break;
				case CreateType.LoggerRepository:
					repository = new LoggerRepository<T>(new Repository<T>());
					break;
			}
			return repository;
		}
	}

	public enum CreateType
	{
		DynamicProxy = 1,
		AuthenticationProxy = 2,
		PerformanceProxy = 3,
		LoggerRepository = 4
	}
}
