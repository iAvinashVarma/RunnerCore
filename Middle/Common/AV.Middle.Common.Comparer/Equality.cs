using System.Collections;
using System.Globalization;

namespace AV.Middle.Common.Comparer
{
	public class Equality
	{
		public class InsensitiveComparer : IEqualityComparer
		{
			private CaseInsensitiveComparer comparer;

			public InsensitiveComparer() => comparer = new CaseInsensitiveComparer();

			public InsensitiveComparer(CultureInfo cultureInfo) => comparer = new CaseInsensitiveComparer(cultureInfo);

			public new bool Equals(object x, object y) => comparer.Compare(x, y) == 0;

			public int GetHashCode(object obj) => obj.ToString().ToLowerInvariant().GetHashCode();
		}
	}
}