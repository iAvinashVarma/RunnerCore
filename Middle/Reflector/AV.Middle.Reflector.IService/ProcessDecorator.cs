using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Reflector.IService
{
    public class ProcessDecorator<T> : ProcessTemplate<T>, IDecorate<T>
	{
		public ProcessDecorator(Hashtable hashtable) : base(hashtable)
		{
		}

		public override void Run(T entity)
		{
			base.Run(entity);
		}
    }
}
