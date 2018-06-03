using AV.Middle.Pattern.Creational.ShapePrototype.Abstract;
using log4net;
using System.Reflection;

namespace AV.Middle.Pattern.Creational.ShapePrototype.Concrete
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