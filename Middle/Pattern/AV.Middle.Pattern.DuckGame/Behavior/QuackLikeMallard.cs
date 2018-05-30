﻿using AV.Middle.Pattern.DuckGame.Interface;
using log4net;
using System.Reflection;

namespace AV.Middle.Pattern.DuckGame.Behavior
{
	public class QuackLikeMallard : IQuackBehavior
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public void Quack()
		{
			logger.Info("Quack!");
		}
	}
}