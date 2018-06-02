using AV.Middle.Aspect.OrientedProcess.Interface;
using AV.Middle.Aspect.OrientedProcess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Aspect.OrientedProcess.Concrete
{
	public class Calculator<T> : ICalculator<T>
	{
		public int Add(T entity)
		{
			var number = entity as Number;
			return number.NumberOne + number.NumberTwo;
		}

		public int Substract(T entity)
		{
			var number = entity as Number;
			return number.NumberOne - number.NumberTwo;
		}
	}
}
