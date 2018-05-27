using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Geometry.Factory
{
    public class ProduceFactory
    {
		public GeometryFactory GetFactory(GeometryType geometryType)
		{
			GeometryFactory geometryFactory = null;
			switch(geometryType)
			{
				case GeometryType.Shape:
					geometryFactory = new ShapeFactory();
					break;
				case GeometryType.Color:
					geometryFactory = new ColorFactory();
					break;
			}
			return geometryFactory;
		}

		public enum GeometryType
		{
			Shape,
			Color
		}
    }
}
