using AV.Middle.Pattern.Behavioral.Arithmetic.Interface;
using AV.Middle.Pattern.Behavioral.Arithmetic.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Behavioral.Arithmetic.Concrete.Operation
{
	public class Multiply : IStrategy
	{
		public int DoOperation(Number number) => number.NumberOne * number.NumberTwo;
	}
}
