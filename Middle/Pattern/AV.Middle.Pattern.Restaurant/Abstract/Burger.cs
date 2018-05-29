using AV.Middle.Pattern.Restaurant.Concrete;
using AV.Middle.Pattern.Restaurant.Interface;

namespace AV.Middle.Pattern.Restaurant.Abstract
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