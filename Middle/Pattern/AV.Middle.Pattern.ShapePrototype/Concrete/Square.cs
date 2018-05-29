using AV.Middle.Pattern.ShapePrototype.Abstract;
using log4net;
using System.Reflection;

namespace AV.Middle.Pattern.ShapePrototype.Concrete
{
	public class Square : Shape
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public Square()
		{
			Type = "Square";
		}

		public override void Draw()
		{
			logger.Info("Inside Square => Draw()");
		}
	}
}