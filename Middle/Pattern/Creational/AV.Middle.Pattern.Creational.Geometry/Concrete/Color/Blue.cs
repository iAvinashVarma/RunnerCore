﻿using AV.Middle.Pattern.Creational.Geometry.Interface;
using log4net;
using System.Reflection;

namespace AV.Middle.Pattern.Creational.Geometry.Concrete.Color
{
	public class Blue : IColor
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public void Fill()
		{
			logger.Info("Inside Blue => Fill().");
		}
	}
}