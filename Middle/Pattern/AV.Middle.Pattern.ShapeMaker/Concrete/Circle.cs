﻿using AV.Middle.Pattern.ShapeMaker.Interface;
using log4net;
using System.Reflection;

namespace AV.Middle.Pattern.ShapeMaker.Concrete
{
	public class Circle : IShape
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public void Draw()
		{
			logger.Info("Inside Circle.");
		}
	}
}