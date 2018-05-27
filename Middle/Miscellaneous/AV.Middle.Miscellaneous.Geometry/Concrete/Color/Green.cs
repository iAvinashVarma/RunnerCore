using AV.Middle.Miscellaneous.Geometry.Interface;
using log4net;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AV.Middle.Miscellaneous.Geometry.Concrete.Color
{
	public class Green : IColor
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public void Fill()
		{
			logger.Info("Inside Green => Fill().");
		}
	}
}
