using AV.Middle.Miscellaneous.Restaurant.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Miscellaneous.Restaurant.Concrete
{
	public class Wrapper : IPackage
	{
		public string Type()
		{
			return "Wrapper";
		}
	}
}
