﻿using AV.Middle.Pattern.Geometry.Concrete.Color;
using AV.Middle.Pattern.Geometry.Interface;

namespace AV.Middle.Pattern.Geometry.Factory
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