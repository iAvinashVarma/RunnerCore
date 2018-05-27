using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Restaurant.Interface
{
    public interface IItem
    {
		string Name();

		IPackage Package();

		double Price();
    }
}
