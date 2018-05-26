using log4net;
using System;
using System.Collections;
using System.IO;
using System.Reflection;

namespace AV.Middle.Extension.GenericLog
{
	public static class CommonLog
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public static string Validate(this Hashtable Hashtable, string key, bool isPath = false, string defaultValue = "")
		{
			var hash = Hashtable[key];
			var value = string.Empty;
			if (hash != null)
			{
				value = isPath ? Path.GetFullPath(hash.ToString()) : hash.ToString();
				logger.InfoFormat("Given {0}: {1}", key, value);
			}
			else if (!string.IsNullOrEmpty(defaultValue))
			{
				value = defaultValue;
			}
			else
			{
				throw new Exception(string.Format("Invalid {0} information.", key));
			}
			return value;
		}
	}
}