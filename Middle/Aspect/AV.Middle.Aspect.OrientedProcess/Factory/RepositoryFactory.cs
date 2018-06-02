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

		public IRepository<T> Create<T>(CreateType createType = CreateType.DispatchProxy)
		{
			IRepository<T> repository = null;
			switch (createType)
			{
				case CreateType.DispatchProxy:
					repository = new LoggerAdvice<IRepository<T>>().Create(new Repository<T>(),
						s => logger.Info($"{s}"),
						e => logger.Error($"{e}"),
						o => o?.ToString(),
						TaskScheduler.Current);
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
		DispatchProxy = 1,
		LoggerRepository = 2
	}
}
