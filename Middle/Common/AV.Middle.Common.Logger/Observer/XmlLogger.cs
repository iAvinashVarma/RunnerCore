using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace AV.Middle.Common.Logger.Observer
{
	public class XmlLogger : ILogger
	{
		private string filePath;

		public XmlLogger(string fileName) => filePath = fileName;

		public void LogMessage(string message)
		{
			var xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(message);
			File.WriteAllText(filePath, BeautifyXml(xmlDocument));
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
