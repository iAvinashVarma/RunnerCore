using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.IteratorPattern.Interface
{
    public interface IAggregator
    {
		IIterator GetIterator();
		string this[int itemIndex] { get; set; }
		int Count { get; }
    }
}
