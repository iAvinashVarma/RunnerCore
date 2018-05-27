using AV.Middle.Miscellaneous.Restaurant.Abstract;
using AV.Middle.Miscellaneous.Restaurant.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Miscellaneous.Restaurant.Concrete
{
	public class ChickenBurger : Burger
	{
		public override string Name()
		{
			return "Chicken Burger";
		}

		public override double Price()
		{
			return 50.5;
		}
	}
}
