using AV.Middle.Miscellaneous.Game.Abstract;
using log4net;
using System.Reflection;

namespace AV.Middle.Miscellaneous.Game.Concrete
{
	public class Football : Sport
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public override void EndPlay()
		{
			logger.Info("Football Game Finished!");
		}

		public override void Initialize()
		{
			logger.Info("Football Game Initialized! Start Playing!");
		}

		public override void StartPlay()
		{
			logger.Info("Football Game Started! Enjoy the game!");
		}
	}
}