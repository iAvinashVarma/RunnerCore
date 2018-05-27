using AV.Middle.Pattern.Shape.Factory;
using AV.Middle.Reflector.IService;
using System.Collections;

namespace AV.Middle.Pattern.Shape
{
	/// <summary>
	/// Creational Design Pattern: Factory pattern is one of the most used design patterns. This type of design pattern comes under creational pattern as this pattern provides one of the best ways to create an object.
	/// </summary>
	public class FactoryProcess : IProcess
	{
		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			var shapeFactory = new ShapeFactory();
			var circle = shapeFactory.GetShape(ShapeType.Circle);
			circle.Draw();
			var rectangle = shapeFactory.GetShape(ShapeType.Rectangle);
			rectangle.Draw();
			var square = shapeFactory.GetShape(ShapeType.Square);
			square.Draw();
		}

		public bool Validate()
		{
			return true;
		}
	}
}