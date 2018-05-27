using AV.Middle.Pattern.Shape.Interface;
using log4net;
using System.Reflection;

namespace AV.Middle.Pattern.Shape.Concrete
{
	public class Square : IShape
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public void Draw()
		{
			logger.Info("Inside Square.");
		}
	}
}