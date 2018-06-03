using AV.Middle.Pattern.Creational.Restaurant.Abstract;

namespace AV.Middle.Pattern.Creational.Restaurant.Concrete
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