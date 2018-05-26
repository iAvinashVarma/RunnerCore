﻿using AV.Middle.Miscellaneous.DuckGame.Interface;
using log4net;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AV.Middle.Miscellaneous.DuckGame.Behavior
{
    public class FlyHigh : IFlyBehavior
    {
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public void Fly()
		{
			logger.Info("WHOOOOOOSH!");
		}
	}
}
