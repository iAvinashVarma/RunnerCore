﻿using AV.Middle.Pattern.Creational.Restaurant.Abstract;

namespace AV.Middle.Pattern.Creational.Restaurant.Concrete
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