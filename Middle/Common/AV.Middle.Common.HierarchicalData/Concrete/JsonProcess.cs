using AV.Middle.Common.HierarchicalData.Interface;
using AV.Middle.Common.Logger.Observer;
using AV.Middle.Common.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace AV.Middle.Common.HierarchicalData.Concrete
{
	public class JsonProcess : IDataProcess
	{
		public FileModel FileModel { get; set; }

		public string CurrentFileExtension { get; set; }

		public string CurrentFilePath { get; set; }

		public JsonProcess(string filePath, string currentFileExtension = "")
		{
			FileModel = new FileModel(filePath);
			CurrentFileExtension = currentFileExtension;
			CurrentFilePath = $"{Path.Combine(FileModel.DirectoryFullPath, FileModel.FileNameWithoutExtension)}.{CurrentFileExtension}";
		}

		public HierarchicalDataModel GetHierarchicalDataModel()
		{
			var fileNameWOE = FileModel.FileNameWithoutExtension;
			var rootElement = fileNameWOE.EndsWith("s") ? fileNameWOE : $"{fileNameWOE}s";
			var childElement = fileNameWOE.EndsWith("s") ? fileNameWOE.Remove(fileNameWOE.Length - 1) : fileNameWOE;
			var xmlDocument = JsonConvert.DeserializeXmlNode("{\"" + childElement + "\":" + FileModel.FileData + "}", rootElement);
			return new HierarchicalDataModel(FileModel)
			{
				FileText = xmlDocument.OuterXml,
				FileIndented = BeautifyXml(xmlDocument),
				CurrentFileExtension = CurrentFileExtension,
				Loggers = new HashSet<ILogger>
				{
					new XmlLogger(CurrentFilePath)
				}
			};
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
