using AV.Middle.Pattern.Behavioral.StatePattern.Interface;
using log4net;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AV.Middle.Pattern.Behavioral.StatePattern.Concrete
{
	public class StartState : IState
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public void DoAction(Context context)
		{
			logger.Info("Player is in start state");
			context.State = this;
		}

		public override string ToString() => "Start State";
	}
}
