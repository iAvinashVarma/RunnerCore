using AV.Middle.Common.Logger.Validator;
using AV.Middle.Common.Model;
using AV.Middle.Reflector.IService;
using log4net;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

namespace AV.Middle.Reflector.TotalCommander
{
	public class MultiLineChecker : IProcess
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		private ReplaceModel replaceModel = null;
		private List<ReplaceModel> replaceModels = null;

		public Hashtable Hashtable { get; set; }

		public bool Validate()
		{
			bool status = false;
			try
			{
				var xDoc = XDocument.Load(EnhanceLog.Set(Hashtable, "SubKeys", true));
				replaceModel = xDoc.Descendants("Replacer").Select(x => new ReplaceModel
				{
					DirectoryPath = x.Attribute("Directory").Value,
					Pattern = x.Attribute("Pattern").Value,
					Contains = x.Attribute("Contains").Value
				}).FirstOrDefault();
				replaceModels = xDoc.Element("Replacer").Elements("Line").Select(x => new ReplaceModel
				{
					DirectoryPath = x.Attribute("Directory") == null ? replaceModel.DirectoryPath : x.Attribute("Directory").Value,
					Pattern = x.Attribute("Pattern") == null ? replaceModel.DirectoryPath : x.Attribute("Pattern").Value,
					Contains = x.Attribute("Contains") == null ? replaceModel.DirectoryPath : x.Attribute("Contains").Value,
					MatchValue = x.Attribute("Match").Value,
					ReplaceValue = x.Attribute("Replace").Value
				}).ToList();
				status = true;
			}
			catch (Exception ex)
			{
				logger.Error(ex);
			}
			return status;
		}

		public void Start()
		{
			if (Directory.Exists(replaceModel.DirectoryPath))
			{
				var files = Directory.GetFiles(replaceModel.DirectoryPath, replaceModel.Pattern, SearchOption.AllDirectories);
				foreach (var file in files.Select((value, index) => new { value, index = index++ }))
				{
					//logger.DebugFormat($"{file.index + 1} - {file.value}.");
					foreach (var line in File.ReadAllLines(file.value).Select((v, i) => new { v, i }))
					{
						var replacableList = replaceModels.Where(x => line.v.IndexOf(x.MatchValue, StringComparison.OrdinalIgnoreCase) >= 0);
						if (replacableList.Any() && line.v.Contains(replaceModel.Contains))
						{
							var rModel = replacableList.FirstOrDefault();
							logger.WarnFormat("------------------------------------------");
							logger.WarnFormat("Replace: \"{0}\".", rModel.ReplaceValue);
							logger.WarnFormat("Match: \"{0}\".", rModel.MatchValue);
							logger.WarnFormat("FileName: \"{0}\"", file.value);
							logger.WarnFormat("Line Value: \"{0}\"", line.v);
							logger.WarnFormat("Line Number: \"{0}\"", line.i);
							logger.WarnFormat("------------------------------------------");
						}
					}
				}
			}
		}
	}
}