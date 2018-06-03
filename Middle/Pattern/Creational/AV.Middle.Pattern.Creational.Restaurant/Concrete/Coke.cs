using AV.Middle.Pattern.Creational.Restaurant.Abstract;

namespace AV.Middle.Pattern.Creational.Restaurant.Concrete
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