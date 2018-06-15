using AV.Middle.Common.HierarchicalData.Interface;
using AV.Middle.Common.Logger.Observer;
using AV.Middle.Common.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace AV.Middle.Common.HierarchicalData.Concrete
{
	public class XmlProcess : IDataProcess
	{
		public FileModel FileModel { get; set; }

		public string CurrentFileExtension { get; set; }

		public string CurrentFilePath { get; set; }

		public XmlProcess(string filePath, string currentFileExtension = "")
		{
			FileModel = new FileModel(filePath);
			CurrentFileExtension = currentFileExtension;
			CurrentFilePath = $"{Path.Combine(FileModel.DirectoryFullPath, FileModel.FileNameWithoutExtension)}.{CurrentFileExtension}";
		}

		public HierarchicalDataModel GetHierarchicalDataModel()
		{
			var xmlDocument = new XmlDocument();
			xmlDocument.Load(FileModel.FileFullPath);
			var fileText = JsonConvert.SerializeXmlNode(xmlDocument);
			return new HierarchicalDataModel(FileModel)
			{
				FileText = fileText,
				FileIndented = JToken.Parse(fileText).ToString(Newtonsoft.Json.Formatting.Indented),
				CurrentFileExtension = CurrentFileExtension,
				Loggers = new HashSet<ILogger>
				{
					new FileLogger(CurrentFilePath)
				}
			};
		}
	}
}
