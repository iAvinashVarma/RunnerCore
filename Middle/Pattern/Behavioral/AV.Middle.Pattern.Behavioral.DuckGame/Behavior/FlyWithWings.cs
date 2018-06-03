using AV.Middle.Pattern.Behavioral.DuckGame.Interface;
using log4net;
using System.Reflection;

namespace AV.Middle.Pattern.Behavioral.DuckGame.Behavior
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