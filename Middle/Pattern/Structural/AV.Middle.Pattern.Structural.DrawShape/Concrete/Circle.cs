﻿using AV.Middle.Pattern.Structural.DrawShape.Abstract;
using AV.Middle.Pattern.Structural.DrawShape.Interface;
using log4net;
using System.Reflection;

namespace AV.Middle.Pattern.Structural.DrawShape.Concrete
{
	public class Circle : Shape
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		private int x, y, radius;

		public Circle(int _x, int _y, int _radius, IDrawAPI drawAPI) : base(drawAPI)
		{
			x = _x;
			y = _y;
			radius = _radius;
		}

		public override void Draw()
		{
			drawAPI.DrawCircle(radius, x, y);
		}
	}
}