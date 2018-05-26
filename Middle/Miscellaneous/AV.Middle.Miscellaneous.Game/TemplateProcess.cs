using AV.Middle.Miscellaneous.Game.Concrete;
using AV.Middle.Reflector.IService;
using log4net;
using System;
using System.Collections;
using System.Reflection;

namespace AV.Middle.Miscellaneous.Game
{
	/// <summary>
	/// In Template pattern, an abstract class exposes defined way(s)/template(s) to execute its methods. Its subclasses can override the method implementation as per need but the invocation is to be in the same way as defined by an abstract class. This pattern comes under behavior pattern category.
	/// </summary>
	public class TemplateProcess : IProcess
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			logger.Info("Cricket Game: ");
			var cricket = new Cricket();
			cricket.Play();

			logger.Info("Football Game: ");
			var football = new Football();
			football.Play();
		}

		public bool Validate()
		{
			return true;
		}
	}
}
