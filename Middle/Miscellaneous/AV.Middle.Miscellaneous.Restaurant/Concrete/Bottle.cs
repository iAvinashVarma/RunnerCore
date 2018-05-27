using AV.Middle.Miscellaneous.Restaurant.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Miscellaneous.Restaurant.Concrete
{
	public class Bottle : IPackage
	{
		public string Type()
		{
			return "Bottle";
		}
	}
}
