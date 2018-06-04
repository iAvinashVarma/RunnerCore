using AV.Middle.Pattern.Behavioral.ComputerParts.Concrete;
using AV.Middle.Pattern.Behavioral.ComputerParts.Visitor;
using AV.Middle.Reflector.IService;
using System;
using System.Collections;

namespace AV.Middle.Pattern.Behavioral.ComputerParts
{
	public class VisitorProcess : IProcess
	{
		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			var computer = new Computer();
			computer.Accept(new ComputerPartDisplayVisitor());
		}

		public bool Validate() => true;
	}
}
