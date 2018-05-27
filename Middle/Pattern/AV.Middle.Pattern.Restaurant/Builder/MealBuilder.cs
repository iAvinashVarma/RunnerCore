using AV.Middle.Pattern.Restaurant.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Restaurant.Builder
{
    public class MealBuilder
    {
		public Meal PrepareVegMeal()
		{
			var meal = new Meal();
			meal.AddItem(new Coke());
			meal.AddItem(new VegBurger());
			return meal;
		}

		public Meal PrepareNonVegMeal()
		{
			var meal = new Meal();
			meal.AddItem(new Pepsi());
			meal.AddItem(new ChickenBurger());
			return meal;
		}
    }
}
