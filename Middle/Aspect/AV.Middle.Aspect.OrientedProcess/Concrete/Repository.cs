using AV.Middle.Aspect.OrientedProcess.Interface;
using log4net;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AV.Middle.Aspect.OrientedProcess.Concrete
{
	public class Repository<T> : IRepository<T>
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public void Add(T entity)
		{
			logger.Info($"Adding {entity}.");
		}

		public void Delete(T entity)
		{
			logger.Info($"Deleting {entity}.");
		}

		public IEnumerable<T> GetAll()
		{
			logger.Info($"Getting entities.");
			return null;
		}

		public T GetById(int id)
		{
			logger.Info($"Getting entity {id}.");
			return default(T);
		}

		public void Update(T entity)
		{
			logger.Info($"Adding {entity}.");
		}
	}
}
