using AV.Middle.Miscellaneous.ShapePrototype.Abstract;
using log4net;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AV.Middle.Miscellaneous.ShapePrototype.Concrete
{
	public class Square : Shape
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public Square()
		{
			Type = "Square";
		}

		public override void Draw()
		{
			logger.Info("Inside Square => Draw()");
		}
	}
}
