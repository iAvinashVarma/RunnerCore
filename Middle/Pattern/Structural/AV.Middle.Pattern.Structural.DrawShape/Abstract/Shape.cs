using AV.Middle.Pattern.Structural.DrawShape.Interface;

namespace AV.Middle.Pattern.Structural.DrawShape.Abstract
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