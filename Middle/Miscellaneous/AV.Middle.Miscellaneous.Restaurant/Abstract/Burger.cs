using AV.Middle.Miscellaneous.Restaurant.Concrete;
using AV.Middle.Miscellaneous.Restaurant.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Miscellaneous.Restaurant.Abstract
{
	public abstract class Burger : IItem
	{
		public abstract string Name();

		public IPackage Package()
		{
			return new Wrapper();
		}

		public abstract double Price();
	}
}
