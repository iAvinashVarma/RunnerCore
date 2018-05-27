﻿using AV.Middle.Miscellaneous.Restaurant.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Miscellaneous.Restaurant.Concrete
{
	public class VegBurger : Burger
	{
		public override string Name()
		{
			return "Veg Burger";
		}

		public override double Price()
		{
			return 25.0;
		}
	}
}
