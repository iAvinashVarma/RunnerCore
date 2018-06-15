using System;
using System.Collections.Generic;
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
			xmlDocument.Save(filePath);
		}
	}
}
