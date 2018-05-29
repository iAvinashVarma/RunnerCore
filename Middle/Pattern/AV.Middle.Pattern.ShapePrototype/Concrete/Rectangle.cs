using AV.Middle.Pattern.ShapePrototype.Abstract;
using log4net;
using System.Reflection;

namespace AV.Middle.Pattern.ShapePrototype.Concrete
{
	public class Rectangle : Shape
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public Rectangle()
		{
			Type = "Rectangle";
		}

		public override void Draw()
		{
			logger.Info("Inside Rectangle => Draw()");
		}
	}
}