using AV.Middle.Pattern.Behavioral.Game.Abstract;
using log4net;
using System.Reflection;

namespace AV.Middle.Pattern.Behavioral.Game.Concrete
{
	public class Cricket : Sport
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public override void EndPlay()
		{
			logger.Info("Cricket Game Finished!");
		}

		public override void Initialize()
		{
			logger.Info("Cricket Game Initialized! Start Playing!");
		}

		public override void StartPlay()
		{
			logger.Info("Cricket Game Started! Enjoy the game!");
		}
	}
}