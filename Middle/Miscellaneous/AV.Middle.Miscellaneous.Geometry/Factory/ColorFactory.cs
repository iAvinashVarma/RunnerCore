﻿using System;
using System.Collections.Generic;
using System.Text;
using AV.Middle.Miscellaneous.Geometry.Concrete.Shape;
using AV.Middle.Miscellaneous.Geometry.Interface;

namespace AV.Middle.Miscellaneous.Geometry.Factory
{
	public class ColorFactory : GeometryFactory
	{
		public override IColor GetColor(ColorType colorType)
		{
			return null;
		}

		public override IShape GetShape(ShapeType shapeType)
		{
			IShape shape = null;
			switch(shapeType)
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
}
