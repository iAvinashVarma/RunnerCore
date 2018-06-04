using AV.Middle.Pattern.Behavioral.ComputerParts.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Behavioral.ComputerParts.Concrete
{
	public class Mouse : IComputerPart
	{
		public void Accept(IComputerPartVisitor computerPartVisitor) => computerPartVisitor.Visit(this);
	}
}
