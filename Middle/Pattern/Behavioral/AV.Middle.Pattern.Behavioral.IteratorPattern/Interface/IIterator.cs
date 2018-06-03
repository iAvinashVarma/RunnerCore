using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Behavioral.IteratorPattern.Interface
{
	public interface IIterator
	{
		string FirstItem { get; }
		string NextItem { get; }
		string CurrentItem { get; }
		bool IsDone { get; }
	}
}
