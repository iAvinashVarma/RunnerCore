﻿using AV.Middle.Pattern.ShapeMaker.Concrete;
using AV.Middle.Pattern.ShapeMaker.Interface;

namespace AV.Middle.Pattern.ShapeMaker.Maker
{
	public class Shape
	{
		private IShape circle;
		private IShape rectangle;
		private IShape square;

		public Shape()
		{
			circle = new Circle();
			rectangle = new Rectangle();
			square = new Square();
		}

		public void DrawCircle()
		{
			circle.Draw();
		}

		public void DrawRectangle()
		{
			rectangle.Draw();
		}

		public void DrawSquare()
		{
			square.Draw();
		}
	}
}