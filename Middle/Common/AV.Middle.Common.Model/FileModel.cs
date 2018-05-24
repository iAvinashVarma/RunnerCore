using System.IO;

namespace AV.Middle.Common.Model
{
	public class FileModel
	{
		public FileModel(string fileFullPath)
		{
			FileFullPath = fileFullPath;
		}

		public string FileFullPath
		{
			get; set;
		}

		public string DirectoryFullPath
		{
			get { return Path.GetDirectoryName(FileFullPath); }
		}

		public string FileNameWithoutExtension
		{
			get { return Path.GetFileNameWithoutExtension(FileFullPath); }
		}

		public string FileExtension
		{
			get { return Path.GetExtension(FileFullPath); }
		}
	}
}