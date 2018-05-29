using AV.Middle.Pattern.ShapePrototype.Abstract;
using log4net;
using System.Reflection;

namespace AV.Middle.Pattern.ShapePrototype.Concrete
{
	public class Circle : Shape
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public Circle()
		{
			Type = "Circle";
		}

		public override void Draw()
		{
			logger.Info("Inside Circle => Draw()");
		}
	}
}