using AV.Middle.Pattern.Creational.Restaurant.Builder;
using AV.Middle.Reflector.IService;
using log4net;
using System.Collections;
using System.Reflection;

namespace AV.Middle.Pattern.Creational.Restaurant
{
	/// <summary>
	/// Creational Desgin Pattern: Builder pattern builds a complex object using simple objects and using a step by step approach. This type of design pattern comes under creational pattern as this pattern provides one of the best ways to create an object.
	/// </summary>
	public class BuilderProcess : IProcess
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			var mealBuilder = new MealBuilder();
			var vegMeal = mealBuilder.PrepareVegMeal();
			logger.Info($"Veg Meal: ");
			vegMeal.ShowItems();

			var nonVegMeal = mealBuilder.PrepareNonVegMeal();
			logger.Info($"Non Veg Meal: ");
			nonVegMeal.ShowItems();
		}

		public bool Validate()
		{
			return true;
		}
	}
}