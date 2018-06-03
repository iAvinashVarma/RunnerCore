using AV.Middle.Pattern.Structural.DrawShape.Interface;
using log4net;
using System.Reflection;

namespace AV.Middle.Pattern.Structural.DrawShape.Concrete
{
	public class GreenCircle : IDrawAPI
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public void DrawCircle(int radius, int x, int y)
		{
			logger.Info($"Draw Circle => Color Green => Radius: {radius}, X: {x}, Y: {y}."); ;
		}
	}
}