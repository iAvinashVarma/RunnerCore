using AV.Middle.Aspect.OrientedProcess.Interface;
using log4net;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AV.Middle.Aspect.OrientedProcess.Concrete
{
	public class LoggerRepository<T> : IRepository<T>
	{
		private readonly IRepository<T> _decorated;
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public LoggerRepository(IRepository<T> decorated) => _decorated = decorated;

		public void Add(T entity)
		{
			Log("In decorator - Before Adding {0}", entity);
			_decorated.Add(entity);
			Log("In decorator - After Adding {0}", entity);
		}

		public void Delete(T entity)
		{
			Log("In decorator - Before Deleting {0}", entity);
			_decorated.Delete(entity);
			Log("In decorator - After Deleting {0}", entity);
		}

		public IEnumerable<T> GetAll()
		{
			Log("In decorator - Before Getting Entities");
			var result = _decorated.GetAll();
			Log("In decorator - After Getting Entities");
			return result;
		}

		public T GetById(int id)
		{
			Log("In decorator - Before Getting Entity {0}", id);
			var result = _decorated.GetById(id);
			Log("In decorator - After Getting Entity {0}", id);
			return result;
		}

		public void Update(T entity)
		{
			Log("In decorator - Before Updating {0}", entity);
			_decorated.Update(entity);
			Log("In decorator - After Updating {0}", entity);
		}

		private void Log(string msg, object arg = null)
		{
			logger.InfoFormat(msg, arg);
		}
	}
}
