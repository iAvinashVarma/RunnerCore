using AV.Middle.Pattern.Restaurant.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Restaurant.Concrete
{
	public class Coke : CoolDrink
	{
		public override string Name()
		{
			return "Coke";
		}

		public override double Price()
		{
			return 30.0;
		}
	}
}
