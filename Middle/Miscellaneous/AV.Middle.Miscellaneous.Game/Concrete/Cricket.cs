using AV.Middle.Miscellaneous.Game.Abstract;
using log4net;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AV.Middle.Miscellaneous.Game.Concrete
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
