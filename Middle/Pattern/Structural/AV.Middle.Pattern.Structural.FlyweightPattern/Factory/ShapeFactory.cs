using AV.Middle.Pattern.Structural.FlyweightPattern.Concrete;
using AV.Middle.Pattern.Structural.FlyweightPattern.Interface;
using log4net;
using System.Collections.Generic;
using System.Reflection;

namespace AV.Middle.Pattern.Structural.FlyweightPattern.Factory
{
	public class ShapeFactory
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		private static Dictionary<string, Circle> circleMap = new Dictionary<string, Circle>();

		public static IShape GetCircle(string color)
		{
			if (!circleMap.TryGetValue(color, out Circle circle))
			{
				circle = new Circle(color);
				circleMap.Add(color, circle);
				logger.Info($"Creating circle of color: {color}.");
			}
			return circle;
		}
	}
}