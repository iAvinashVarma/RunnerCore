using AV.Middle.Pattern.Behavioral.ComputerParts.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Behavioral.ComputerParts.Interface
{
    public interface IComputerPartVisitor
    {
		void Visit(Keyboard keyboard);
		void Visit(Monitor monitor);
		void Visit(Mouse mouse);
		void Visit(Computer computer);
    }
}
