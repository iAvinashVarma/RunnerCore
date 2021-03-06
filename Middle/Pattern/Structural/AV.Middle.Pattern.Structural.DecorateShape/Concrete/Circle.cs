﻿using AV.Middle.Pattern.Structural.DecorateShape.Interface;
using log4net;
using System.Reflection;

namespace AV.Middle.Pattern.Structural.DecorateShape.Concrete
{
	public class Circle : IShape
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public void Draw()
		{
			logger.Info("Circle => Draw.");
		}
	}
}