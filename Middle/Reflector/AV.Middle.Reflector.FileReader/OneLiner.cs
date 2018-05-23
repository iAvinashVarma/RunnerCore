using AV.Middle.Common.Logger.Observer;
using AV.Middle.Common.Logger.Validator;
using AV.Middle.Common.Model;
using AV.Middle.Reflector.IService;
using log4net;
using System;
using System.Collections;
using System.IO;
using System.Reflection;

namespace AV.Middle.Reflector.FileReader
{
	public class OneLiner : IProcess
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		private Logger log = Logger.Instance;
		public Hashtable Hashtable { get; set; }
		private FileModel fileModel = null;


		public void Start()
		{
			var readToOneLine = File.ReadAllText(fileModel.FileFullPath).Replace(Environment.NewLine, " ");
			var newFilePath = $"{Path.Combine(fileModel.DirectoryFullPath, fileModel.FileNameWithoutExtension)}-{Guid.NewGuid().ToString().ToUpper()}{fileModel.FileExtension}";
			log.RegisterObservers(new FileLogger(newFilePath));
			log.LogMessage(readToOneLine);
			logger.Info($"Converted file is placed at {newFilePath}");
		}

		public bool Validate()
		{
			bool status = false;
			try
			{
				var fileFullPath = Path.GetFullPath(EnhanceLog.Set(Hashtable, "FilePath", true));
				fileModel = new FileModel(fileFullPath);
				status = File.Exists(fileFullPath);
			}
			catch(Exception ex)
			{
				logger.Error(ex);
			}
			return status;
		}
	}
}
