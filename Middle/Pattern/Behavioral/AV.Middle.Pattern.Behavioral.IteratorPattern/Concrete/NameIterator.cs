using AV.Middle.Pattern.Behavioral.IteratorPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Behavioral.IteratorPattern.Concrete
{
    public class NameIterator : IIterator
    {
		IAggregator _aggregator = null;
		int _currentIndex = 0;

		public NameIterator(IAggregator aggregator) => _aggregator = aggregator;

		#region IIterator Members

		public string FirstItem
		{
			get
			{
				_currentIndex = 0;
				return _aggregator[_currentIndex];
			}
		}

		public string NextItem
		{
			get
			{
				_currentIndex += 1;
				return !IsDone ? _aggregator[_currentIndex] : string.Empty;
			}
		}

		public string CurrentItem => _aggregator[_currentIndex];

		public bool IsDone => !(_currentIndex < _aggregator.Count);

		#endregion
	}
}
