using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Behavioral.ComputerParts.Interface
{
    public interface IComputerPart
    {
		void Accept(IComputerPartVisitor computerPartVisitor);
    }
}
