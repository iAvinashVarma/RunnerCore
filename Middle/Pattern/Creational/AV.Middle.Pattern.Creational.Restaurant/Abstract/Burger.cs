using AV.Middle.Pattern.Creational.Restaurant.Concrete;
using AV.Middle.Pattern.Creational.Restaurant.Interface;

namespace AV.Middle.Pattern.Creational.Restaurant.Abstract
{
	public abstract class Burger : IItem
	{
		public abstract string Name();

		public IPackage Package()
		{
			return new Wrapper();
		}

		public abstract double Price();
	}
}