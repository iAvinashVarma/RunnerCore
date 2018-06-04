using AV.Middle.Pattern.Behavioral.Arithmetic.Interface;
using AV.Middle.Pattern.Behavioral.Arithmetic.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Behavioral.Arithmetic.Concrete
{
    public class Context
    {
		private IStrategy _strategy;

		public Context(IStrategy strategy) => _strategy = strategy;

		public virtual int ExecuteStrategy(Number number) => _strategy.DoOperation(number);
    }
}
