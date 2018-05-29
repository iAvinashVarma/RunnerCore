using AV.Middle.Pattern.DrawShape.Interface;

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