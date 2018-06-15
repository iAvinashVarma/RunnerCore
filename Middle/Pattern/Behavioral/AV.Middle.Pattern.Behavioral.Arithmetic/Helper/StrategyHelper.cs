using AV.Middle.Pattern.Behavioral.Arithmetic.Concrete;
using AV.Middle.Pattern.Behavioral.Arithmetic.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Behavioral.Arithmetic.Helper
{
    public class StrategyHelper
    {
		public int DoStrategy(Context context, Number number) => context.ExecuteStrategy(number);
	}
}
