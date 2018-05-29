using AV.Middle.Pattern.Geometry.Interface;
using log4net;
using System.Reflection;

namespace AV.Middle.Pattern.Geometry.Concrete.Shape
{
	public class Rectangle : IShape
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public void Draw()
		{
			logger.Info("Inside Rectangle => Draw().");
		}
	}
}