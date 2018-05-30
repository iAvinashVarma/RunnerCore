using AV.Middle.Pattern.ExpressionInterpreter.Concrete;
using AV.Middle.Pattern.ExpressionInterpreter.Interface;
using AV.Middle.Reflector.IService;
using log4net;
using System;
using System.Collections;
using System.Reflection;

namespace AV.Middle.Pattern.ExpressionInterpreter
{
	/// <summary>
	/// Behavioral Design pattern: Interpreter pattern provides a way to evaluate language grammar or expression. This type of pattern comes under behavioral pattern. This pattern involves implementing an expression interface which tells to interpret a particular context. This pattern is used in SQL parsing, symbol processing engine etc.
	/// </summary>
	public class InterpreterProcess : IProcess
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			var isMale = GetExpression<OrExpression>("Robert", "John");
			var isMariedWoman = GetExpression<AndExpression>("Julie", "Married");

			logger.Info($"John is male? {isMale.Interpret("John")}.");
			logger.Info($"Julie is a married woman? {isMariedWoman.Interpret("Married Julie")}.");
		}

		public bool Validate()
		{
			return true;
		}

		private IExpression GetExpression<T>(string expressionOne, string expressionTwo)
		{
			IExpression expression = null;
			var eOne = new TerminalExpression(expressionOne);
			var eTwo = new TerminalExpression(expressionTwo);
			if(typeof(T) == typeof(AndExpression))
			{
				expression = new AndExpression(eOne, eTwo);
			}
			else if(typeof(T) == typeof(OrExpression))
			{
				expression = new OrExpression(eOne, eTwo);
			}
			return expression;
		}
	}
}
