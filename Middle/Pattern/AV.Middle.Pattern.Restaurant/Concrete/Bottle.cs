using AV.Middle.Pattern.Restaurant.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Restaurant.Concrete
{
	public class Bottle : IPackage
	{
		public string Type()
		{
			return "Bottle";
		}
	}
}
