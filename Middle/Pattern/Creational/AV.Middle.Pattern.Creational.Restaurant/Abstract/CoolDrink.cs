using AV.Middle.Pattern.Creational.Restaurant.Concrete;
using AV.Middle.Pattern.Creational.Restaurant.Interface;

namespace AV.Middle.Pattern.Creational.Restaurant.Abstract
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