using AV.Middle.Pattern.Restaurant.Concrete;
using AV.Middle.Pattern.Restaurant.Interface;

namespace AV.Middle.Pattern.Restaurant.Abstract
{
	public abstract class CoolDrink : IItem
	{
		public abstract string Name();

		public IPackage Package()
		{
			return new Bottle();
		}

		public abstract double Price();
	}
}