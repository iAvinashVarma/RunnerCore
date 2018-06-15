using AV.Middle.Common.HierarchicalData;
using AV.Middle.Common.Logger.Observer;
using AV.Middle.Common.Model;
using AV.Middle.Extension.GenericLog;
using AV.Middle.Reflector.IService;
using log4net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;

namespace AV.Middle.Reflector.FileController
{
	public class FileConverter : IProcess
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		private Logger log = Logger.Instance;
		private DataFactory dataFactory = null;

		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			var dataProcess = dataFactory.GetDataProcess();
			var hierarchicalData = dataProcess.GetHierarchicalDataModel();
			log.RegisterObservers(hierarchicalData.Loggers);
			log.LogMessage(hierarchicalData.FileIndented);
			logger.Info($"Converted file is placed at {hierarchicalData.CurrentFilePath}");
		}

		public bool Validate()
		{
			bool status = false;
			try
			{
				dataFactory = new DataFactory(Hashtable.Validate("FilePath", true));
				status = true;
			}
			catch (Exception ex)
			{
				logger.Error(ex);
			}
			return status;
		}

		private string BeautifyXml(XmlDocument xmlDocument)
		{
			var sb = new StringBuilder();
			var settings = new XmlWriterSettings
			{
				Indent = true,
				IndentChars = "  ",
				NewLineChars = "\r\n",
				NewLineHandling = NewLineHandling.Replace
			};
			using (var writer = XmlWriter.Create(sb, settings))
			{
				xmlDocument.Save(writer);
			}
			return sb.ToString();
		}
	}
}