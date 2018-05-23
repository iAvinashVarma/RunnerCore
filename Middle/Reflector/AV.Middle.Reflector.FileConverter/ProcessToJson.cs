using AV.Middle.Common.Logger.Observer;
using AV.Middle.Common.Logger.Validator;
using AV.Middle.Common.Model;
using AV.Middle.Reflector.IService;
using log4net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Xml;

namespace AV.Middle.Reflector.FileConverter
{
	public class ProcessToJson : IProcess
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		private Logger log = Logger.Instance;
		private XmlDocument xmlDocument = null;
		private FileModel fileModel = null;

		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			var jsonText = JsonConvert.SerializeXmlNode(xmlDocument);
			var jsonIndented = JToken.Parse(jsonText).ToString(Newtonsoft.Json.Formatting.Indented);
			var jsonPath = $"{Path.Combine(fileModel.DirectoryFullPath, fileModel.FileNameWithoutExtension)}.json";
			var webPath = "http://localhost:180/Checkin/CR213Logger.ashx?data=";
			log.RegisterObservers(new FileLogger(jsonPath));
			log.RegisterObservers(new WebLogger(webPath));
			log.LogMessage(jsonIndented);
			logger.Info($"Converted file is placed at {jsonPath}");
		}

		public bool Validate()
		{
			bool status = false;
			try
			{
				var fileFullPath = Path.GetFullPath(EnhanceLog.Set(Hashtable, "FilePath", true));
				fileModel = new FileModel(fileFullPath);
				//if (Path.GetExtension(fileModel.FileFullPath).Equals(".XML", StringComparison.OrdinalIgnoreCase))
				{
					xmlDocument = new XmlDocument();
					xmlDocument.Load(fileModel.FileFullPath);
					status = true;
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex);
			}
			return status;
		}
	}
}