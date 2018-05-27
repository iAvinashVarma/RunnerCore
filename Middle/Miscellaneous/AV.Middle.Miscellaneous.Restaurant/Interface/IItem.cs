using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Miscellaneous.Restaurant.Interface
{
    public interface IItem
    {
		string Name();

		IPackage Package();

		double Price();
    }
}
