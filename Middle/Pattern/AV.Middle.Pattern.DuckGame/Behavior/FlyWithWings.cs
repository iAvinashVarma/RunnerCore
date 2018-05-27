using AV.Middle.Pattern.DuckGame.Interface;
using log4net;
using System.Reflection;

namespace AV.Middle.Pattern.DuckGame.Behavior
{
	public class FlyWithWings : IFlyBehavior
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public void Fly()
		{
			logger.Info("Fly with wings.");
		}
	}
}