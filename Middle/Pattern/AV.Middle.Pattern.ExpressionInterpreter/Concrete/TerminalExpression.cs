using AV.Middle.Pattern.ExpressionInterpreter.Interface;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AV.Middle.Pattern.ExpressionInterpreter.Concrete
{
	public class TerminalExpression : IExpression
	{
		private string _data;

		public TerminalExpression(string data) => _data = data;

		public bool Interpret(string context)
		{
			return CultureInfo.CurrentCulture.CompareInfo.IndexOf(context, _data, CompareOptions.IgnoreCase) >= 0;
		}
	}
}
