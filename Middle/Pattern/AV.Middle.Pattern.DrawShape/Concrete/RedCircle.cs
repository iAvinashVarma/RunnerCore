using AV.Middle.Pattern.DrawShape.Interface;
using log4net;
using System.Reflection;

namespace AV.Middle.Pattern.DrawShape.Concrete
{
	public class RedCircle : IDrawAPI
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public void DrawCircle(int radius, int x, int y)
		{
			logger.Info($"Draw Circle => Color Red => Radius: {radius}, X: {x}, Y: {y}."); ;
		}
	}
}