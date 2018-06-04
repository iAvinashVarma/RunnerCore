using AV.Middle.Pattern.Behavioral.ComputerParts.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Behavioral.ComputerParts.Concrete
{
	public class Computer : IComputerPart
	{
		private IComputerPart[] _computerParts;

		public Computer() => _computerParts = new IComputerPart[] { new Mouse(), new Monitor(), new Keyboard() };

		public void Accept(IComputerPartVisitor computerPartVisitor)
		{
			for (int i = 0; i < _computerParts.Length; i++)
			{
				_computerParts[i].Accept(computerPartVisitor);
			}
			computerPartVisitor.Visit(this);
		}
	}
}
