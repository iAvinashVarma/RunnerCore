using AV.Middle.Pattern.Restaurant.Abstract;

namespace AV.Middle.Pattern.Restaurant.Concrete
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