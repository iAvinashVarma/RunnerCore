using AV.Middle.Pattern.Structural.FlyweightPattern.Interface;
using log4net;
using System.Reflection;

namespace AV.Middle.Pattern.Structural.FlyweightPattern.Concrete
{
	public class Circle : IShape
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		private string _color;
		private int _x;
		private int _y;
		private int _radius;

		public Circle(string color)
		{
			_color = color;
		}

		public void SetX(int x)
		{
			_x = x;
		}

		public void SetY(int y)
		{
			_y = y;
		}

		public void SetRadius(int radius)
		{
			_radius = radius;
		}

		public void Draw()
		{
			logger.Info($"Circle => Draw() => [Color: {_color}, X: {_x}, Y: {_y}, Radius: {_radius}]");
		}
	}
}