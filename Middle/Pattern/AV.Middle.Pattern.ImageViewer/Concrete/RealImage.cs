using AV.Middle.Pattern.ImageViewer.Interface;
using log4net;
using System.Reflection;

namespace AV.Middle.Pattern.ImageViewer.Concrete
{
	public class RealImage : IImage
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		private string _fileName;

		public RealImage(string fileName)
		{
			_fileName = fileName;
			LoadFromDisk(fileName);
		}

		public void Display()
		{
			logger.Info($"Displaying {_fileName}.");
		}

		private void LoadFromDisk(string fileName)
		{
			logger.Info($"Loading {fileName}.");
		}
	}
}