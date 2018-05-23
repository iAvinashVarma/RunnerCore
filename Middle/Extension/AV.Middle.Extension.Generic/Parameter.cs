using System;
using System.Collections;
using System.Diagnostics;
using static AV.Middle.Common.Comparer.Equality;

namespace AV.Middle.Extension.Generic
{
	/// <summary>
	/// Represents parameter related functionality.
	/// </summary>
	public static class Parameter
	{
		/// <summary>
		/// Get the value of the parameter based on the name from the passed parameter list.
		/// </summary>
		/// <param name="additionalParameters">Parameters to pass.</param>
		/// <param name="parameterName">Parameter Name.</param>
		/// <returns>Parameter Value.</returns>
		public static string GetAdditionalParams(this string[] additionalParameters, string parameterName)
		{
			try
			{
				foreach (string param in additionalParameters.FilterArray(parameterName))
				{
					if ((param.Substring(0, 1).Equals("/") || param.Substring(0, 1).Equals("-")))
					{
						if (param.Contains("="))
							return param.Substring(1, param.IndexOf("=") - 1).Equals(parameterName, StringComparison.OrdinalIgnoreCase) ? param.Substring(param.IndexOf("=") + 1) : string.Empty;
						else
							return param.Substring(1).Equals(parameterName, StringComparison.OrdinalIgnoreCase) ? param.Substring(1) : string.Empty;
					}
				}
			}
			catch (Exception genericException)
			{
				Debug.WriteLine("{0}", genericException.Message);
			}

			return string.Empty;
		}

		public static Hashtable GetHashArguments(this string[] args)
		{
			var hashTable = new Hashtable(new InsensitiveComparer());
			foreach (var param in args)
			{
				try
				{
					if ((param.Substring(0, 1).Equals("/") || param.Substring(0, 1).Equals("-")))
					{
						if (param.Contains("="))
						{
							hashTable.Add(param.Substring(1, param.IndexOf("=") - 1), param.Substring(param.IndexOf("=") + 1));
						}
						else
						{
							hashTable.Add(param.Substring(1), true);
						}
					}
				}
				catch (Exception genericException)
				{
					Debug.WriteLine("{0}", genericException.Message);
				}
			}
			return hashTable;
		}

		/// <summary>
		/// Get the value of the parameter based on the occurence from the passed parameter list.
		/// </summary>
		/// <param name="additionalParameters">Parameters to pass.</param>
		/// <param name="occurrence">Parameter occurence.</param>
		/// <returns>Parameter Value.</returns>
		public static string GetAdditionalParams(this string[] additionalParameters, int occurrence)
		{
			try
			{
				if (occurrence <= additionalParameters.Length)
				{
					occurrence -= 1;
					string param = additionalParameters[occurrence];
					if (param.Substring(0, 1) == "/" || param.Substring(0, 1) == "-")
					{
						return param.Substring(1);
					}
				}
			}
			catch (Exception genericException)
			{
				Debug.WriteLine("{0}", genericException.InnerException);
			}
			return string.Empty;
		}
	}
}