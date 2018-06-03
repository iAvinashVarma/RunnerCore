namespace AV.Middle.Pattern.Creational.Restaurant.Interface
{
	public interface IItem
	{
		string Name();

		IPackage Package();

		double Price();
	}
}