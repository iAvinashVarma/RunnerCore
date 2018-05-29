using AV.Middle.Pattern.Restaurant.Abstract;

namespace AV.Middle.Pattern.Restaurant.Concrete
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