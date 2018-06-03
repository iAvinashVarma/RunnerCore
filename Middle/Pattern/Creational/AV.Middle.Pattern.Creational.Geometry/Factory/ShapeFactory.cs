using AV.Middle.Pattern.Creational.Geometry.Concrete.Color;
using AV.Middle.Pattern.Creational.Geometry.Interface;

namespace AV.Middle.Pattern.Creational.Geometry.Factory
{
	public class ShapeFactory : GeometryFactory
	{
		public override IColor GetColor(ColorType colorType)
		{
			IColor color = null;
			switch (colorType)
			{
				case ColorType.Blue:
					color = new Blue();
					break;

				case ColorType.Green:
					color = new Green();
					break;

				case ColorType.Red:
					color = new Red();
					break;
			}
			return color;
		}

		public override IShape GetShape(ShapeType shapeType)
		{
			return null;
		}
	}
}