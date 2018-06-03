using AV.Middle.Pattern.Creational.Geometry.Interface;
using log4net;
using System.Reflection;

namespace AV.Middle.Pattern.Creational.Geometry.Concrete.Shape
{
	public class Circle : IShape
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public void Draw()
		{
			logger.Info("Inside Circle => Draw().");
		}
	}
}