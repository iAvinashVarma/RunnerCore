using log4net;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace AV.Middle.Common.Logger.Validator
{
    public static class EnhanceLog
    {
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public static string Set(Hashtable Hashtable, string key, bool isPath = false)
		{
			var hash = Hashtable[key];
			var value = string.Empty;
			if (hash != null)
			{
				value = isPath ? Path.GetFullPath(hash.ToString()) : hash.ToString();
				logger.InfoFormat("Given {0}: {1}", key, value);
			}
			else
				throw new Exception(string.Format("Invalid {0} information.", key));
			return value;
		}
	}
}
