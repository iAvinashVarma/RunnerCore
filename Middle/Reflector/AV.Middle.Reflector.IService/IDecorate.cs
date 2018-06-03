using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Reflector.IService
{
    public interface IDecorate<T>
    {
		void Run(T entity);
    }
}
