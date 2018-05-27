using AV.Middle.Miscellaneous.Restaurant.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Miscellaneous.Restaurant.Concrete
{
	public class Pepsi : CoolDrink
	{
		public override string Name()
		{
			return "Pepsi";
		}

		public override double Price()
		{
			return 35.0;
		}
	}
}
