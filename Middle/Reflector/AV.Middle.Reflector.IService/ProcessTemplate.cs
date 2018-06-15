using log4net;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AV.Middle.Reflector.IService
{
	public abstract class ProcessTemplate<T> : IDecorate<T>
	{
		private IProcess _process;
		private Hashtable _hashtable;

		public ProcessTemplate(Hashtable hashtable) => _hashtable = hashtable;

		public virtual void Run(T entity)
		{
			_process = (IProcess)entity;
			if (_hashtable == null) return;
			_process.Hashtable = _hashtable;
			if (_process.Validate())
			{
				_process.Start();
			}
		}
	}
}
