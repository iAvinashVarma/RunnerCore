using AV.Middle.Pattern.Behavioral.ComputerParts.Concrete;
using AV.Middle.Pattern.Behavioral.ComputerParts.Interface;
using log4net;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AV.Middle.Pattern.Behavioral.ComputerParts.Visitor
{
	public class ComputerPartDisplayVisitor : IComputerPartVisitor
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public void Visit(Keyboard keyboard) => logger.Info("Displaying Keyboard.");

		public void Visit(Monitor monitor) => logger.Info("Displaying Monitor.");

		public void Visit(Mouse mouse) => logger.Info("Displaying Mouse.");

		public void Visit(Computer computer) => logger.Info("Displaying Computer.");
	}
}
