using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Aspect.OrientedProcess.Interface
{
    public interface ICalculator<T>
    {
		int Add(T entity);
		int Substract(T entity);
    }
}
