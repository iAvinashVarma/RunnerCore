using log4net;
using log4net.Config;
using log4net.Repository.Hierarchy;
using System;
using System.IO;
using System.Reflection;
using System.Xml;

namespace AV.Middle.Common.Configure
{
	public class Log
	{
		private static volatile Log instance = null;
		private static readonly object mutex = new Object();

		private Log()
		{
		}

		public static Log Instance
		{
			get
			{
				if (instance == null)
				{
					lock (mutex)
					{
						if (instance == null)
						{
							instance = new Log();
						}
					}
				}
				return instance;
			}
		}

		public void Configure(string configuration)
		{
			var log4netConfig = new XmlDocument();
			log4netConfig.Load(File.OpenRead(configuration));
			var loggerRepository = LogManager.CreateRepository(Assembly.GetEntryAssembly(), typeof(Hierarchy));
			XmlConfigurator.Configure(loggerRepository, log4netConfig["log4net"]);
		}
	}
}