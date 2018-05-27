using AV.Middle.Miscellaneous.DuckGame.Interface;
using log4net;
using System.Reflection;

namespace AV.Middle.Miscellaneous.DuckGame.Behavior
{
	public class QuackLikeSpaniel : IQuackBehavior
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public void Quack()
		{
			logger.Info("Woof!");
		}
	}
}