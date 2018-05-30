using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.ExpressionInterpreter.Interface
{
    public interface IExpression
    {
		bool Interpret(string context);
    }
}
