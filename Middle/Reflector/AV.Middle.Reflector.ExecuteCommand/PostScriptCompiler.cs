using AV.Middle.Reflector.IService;
using log4net;
using System.Collections;
using System.Reflection;

namespace AV.Middle.Reflector.SqlServerCompiler
{
	public class PostScriptCompiler : IPostProcess
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public Hashtable Hashtable { get; set; }

		public bool PostValidate()
		{
			return true;
		}

		public void PostStart()
		{
		}
	}
}