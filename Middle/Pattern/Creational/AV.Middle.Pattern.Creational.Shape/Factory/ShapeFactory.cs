using AV.Middle.Pattern.Creational.Shape.Concrete;
using AV.Middle.Pattern.Creational.Shape.Interface;

namespace AV.Middle.Pattern.Creational.Shape.Factory
{
	public class ShapeFactory
	{
		public IShape GetShape(ShapeType shapeType)
		{
			IShape shape = null;
			switch (shapeType)
			{
				case ShapeType.Circle:
					shape = new Circle();
					break;

				case ShapeType.Rectangle:
					shape = new Rectangle();
					break;

				case ShapeType.Square:
					shape = new Square();
					break;
			}
			return shape;
		}
	}

	public enum ShapeType
	{
		Circle,
		Rectangle,
		Square
	}
}