using AV.Middle.Common.Machine.SystemConfiguration;
using AV.Middle.Reflector.IService;
using log4net;
using System.Collections;
using System.Reflection;

namespace AV.Middle.Reflector.MachineController
{
	public class SystemProcess : IProcess
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public Hashtable Hashtable { get; set; }

		public bool Validate()
		{
			return true;
		}

		public void Start()
		{
			var information = new Information();
			foreach (var key in information.MainSystemInformationKeys)
			{
				logger.Info(information.GetSystemInformation(key));
			}
		}
	}
}