using AV.Middle.Pattern.Behavioral.CheckCustomer.Abstract;
using AV.Middle.Pattern.Behavioral.CheckCustomer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Behavioral.CheckCustomer.Factory
{
    public class CustomerFactory
    {
		private readonly string[] names = { "Avinash", "Pruthvi", "Lakshmi" };

		public AbstractCustomer GetCustomer(string name)
		{
			for (int i = 0; i < names.Length; i++)
			{
				if(name[i].ToString().Equals(name, StringComparison.OrdinalIgnoreCase))
				{
					return new RealCustomer(name);
				}
			}
			return new NullCustomer();
		}
    }
}
