using System;
using System.Collections.Generic;

namespace AV.Middle.Extension.Generic
{
	public static class Enumerables
	{
		public static void ForEach<T>(this IEnumerable<T> @enumeration, Action<T> action)
		{
			foreach (T item in @enumeration)
				action(item);
		}

		public static T DoAction<T>(this T @this, Action<string> action)
		{
			action.Invoke(null);
			return @this;
		}
	}
}