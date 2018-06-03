using AV.Middle.Pattern.Creational.Restaurant.Concrete;

namespace AV.Middle.Pattern.Creational.Restaurant.Builder
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