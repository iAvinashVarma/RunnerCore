using AV.Middle.Reflector.IService;
using log4net;
using System.Collections;
using System.Reflection;

namespace AV.Middle.Reflector.MultiReplacer
{
	public class PreRunProcess : IPreProcess
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public Hashtable Hashtable { get; set; }

		public void PreStart()
		{
		}

		public bool PreValidate()
		{
			return true;
		}
	}
}