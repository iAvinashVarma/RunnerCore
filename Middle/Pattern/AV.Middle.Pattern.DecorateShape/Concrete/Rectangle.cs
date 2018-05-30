﻿using AV.Middle.Pattern.DecorateShape.Interface;
using log4net;
using System.Reflection;

namespace AV.Middle.Pattern.DecorateShape.Concrete
{
	public class Rectangle : IShape
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public void Draw()
		{
			logger.Info("Rectangle => Draw.");
		}
	}
}