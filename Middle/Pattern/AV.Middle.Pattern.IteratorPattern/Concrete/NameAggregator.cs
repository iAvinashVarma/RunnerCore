using AV.Middle.Pattern.IteratorPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.IteratorPattern.Concrete
{
	public class NameAggregator : IAggregator
	{
		List<string> _values = null;

		public NameAggregator() => _values = new List<string>();

		#region IAggregate Members

		public string this[int itemIndex]
		{
			get => itemIndex < _values.Count ? _values[itemIndex] : string.Empty;
			set => _values.Add(value);
		}

		public int Count => _values.Count;

		public IIterator GetIterator() => new NameIterator(this);

		#endregion
	}
}
