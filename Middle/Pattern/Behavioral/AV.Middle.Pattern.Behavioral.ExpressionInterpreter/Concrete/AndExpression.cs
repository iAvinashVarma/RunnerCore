using AV.Middle.Pattern.Behavioral.ExpressionInterpreter.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Behavioral.ExpressionInterpreter.Concrete
{
	public class AndExpression : IExpression
	{
		private IExpression _expressionOne = null;
		private IExpression _expressionTwo = null;

		public AndExpression(IExpression expressionOne, IExpression expressionTwo)
		{
			_expressionOne = expressionOne;
			_expressionTwo = expressionTwo;
		}

		public bool Interpret(string context)
		{
			return _expressionOne.Interpret(context) && _expressionTwo.Interpret(context);
		}
	}
}
