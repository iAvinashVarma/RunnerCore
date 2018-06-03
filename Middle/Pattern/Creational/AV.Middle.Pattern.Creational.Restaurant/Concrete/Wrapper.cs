using AV.Middle.Pattern.Creational.Restaurant.Interface;

namespace AV.Middle.Pattern.Creational.Restaurant.Concrete
{
	public class Wrapper : IPackage
	{
		public string Type()
		{
			return "Wrapper";
		}
	}
}