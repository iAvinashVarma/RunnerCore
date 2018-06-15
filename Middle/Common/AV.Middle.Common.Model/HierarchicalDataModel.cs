using AV.Middle.Common.Logger.Observer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AV.Middle.Common.Model
{
    public class HierarchicalDataModel
    {
		public FileModel FileModel
		{
			get; set;
		}

		public HierarchicalDataModel(FileModel fileModel) => FileModel = fileModel;

		private string fileText;

		public string FileText
		{
			get { return fileText; }
			set { fileText = value; }
		}

		private string fileIndented;

		public string FileIndented
		{
			get { return fileIndented; }
			set { fileIndented = value; }
		}

		private string currentFilePath;

		public string CurrentFilePath
		{
			get { return $"{Path.Combine(FileModel.DirectoryFullPath, FileModel.FileNameWithoutExtension)}.{CurrentFileExtension}"; }
		}

		private string currentFileExtension;

		public string CurrentFileExtension
		{
			get
			{
				return string.IsNullOrEmpty(currentFileExtension) ? "LOG" : currentFileExtension;
			}
			set { currentFileExtension = value; }
		}

		private HashSet<ILogger> loggers;

		public HashSet<ILogger> Loggers
		{
			get { return loggers; }
			set { loggers = value; }
		}

	}
}
