using AV.Middle.Miscellaneous.Geometry.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Miscellaneous.Geometry.Factory
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
