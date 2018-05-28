using AV.Middle.Pattern.DrawShape.Interface;
using log4net;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AV.Middle.Pattern.DrawShape.Concrete
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
