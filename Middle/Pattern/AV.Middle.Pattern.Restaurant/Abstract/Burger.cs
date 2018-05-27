using AV.Middle.Pattern.Restaurant.Concrete;
using AV.Middle.Pattern.Restaurant.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Restaurant.Abstract
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
