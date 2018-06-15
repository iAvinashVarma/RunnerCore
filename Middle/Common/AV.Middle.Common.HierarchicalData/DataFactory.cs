using System;
using System.Collections.Generic;
using System.Text;
using AV.Middle.Common.HierarchicalData.Concrete;
using AV.Middle.Common.HierarchicalData.Interface;
using AV.Middle.Common.Model;

namespace AV.Middle.Common.HierarchicalData
{
	public class DataFactory
	{
		private string _filePath;

		public DataFactory(string filePath) => _filePath = filePath;

		public IDataProcess GetDataProcess()
		{
			IDataProcess dataProcess = null;
			if (PredicateType()("XML"))
				dataProcess = GetDataProcess(DataProcessType.Xml);
			else if(PredicateType()("JSON"))
				dataProcess = GetDataProcess(DataProcessType.Json);
			return dataProcess;
		}

		private IDataProcess GetDataProcess(DataProcessType dataProcessType)
		{
			IDataProcess dataProcess = null;
			switch(dataProcessType)
			{
				case DataProcessType.Xml:
					dataProcess = new DataProcess(new XmlProcess(_filePath, "json"));
					break;
				case DataProcessType.Json:
					dataProcess = new DataProcess(new JsonProcess(_filePath, "xml"));
					break;
			}
			return dataProcess;
		}

		private Predicate<string> PredicateType()
		{
			bool predicate(string p) => new FileModel(_filePath).FileExtension.Equals($".{p}", StringComparison.OrdinalIgnoreCase);
			return predicate;
		}
	}
}
