using AV.Middle.Pattern.Geometry.Interface;

namespace AV.Middle.Pattern.Geometry.Factory
{
	public abstract class GeometryFactory
	{
		public abstract IColor GetColor(ColorType colorType);

		public abstract IShape GetShape(ShapeType shapeType);
	}

	public enum ColorType
	{
		Blue,
		Green,
		Red
	}

	public enum ShapeType
	{
		Circle,
		Rectangle,
		Square
	}
}