using AV.Middle.Pattern.Behavioral.Arithmetic.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Behavioral.Arithmetic.Interface
{
    public interface IStrategy
    {
		int DoOperation(Number number);
    }
}
