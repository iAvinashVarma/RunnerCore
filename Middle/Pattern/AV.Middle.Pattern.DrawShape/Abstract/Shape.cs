using AV.Middle.Pattern.DrawShape.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.DrawShape.Abstract
{
    public abstract class Shape
    {
		protected IDrawAPI drawAPI;

		protected Shape(IDrawAPI draw)
		{
			drawAPI = draw;
		}

		public abstract void Draw();
    }
}
