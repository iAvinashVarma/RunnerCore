using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.IteratorPattern.Interface
{
	public interface IIterator
	{
		string FirstItem { get; }
		string NextItem { get; }
		string CurrentItem { get; }
		bool IsDone { get; }
	}
}
