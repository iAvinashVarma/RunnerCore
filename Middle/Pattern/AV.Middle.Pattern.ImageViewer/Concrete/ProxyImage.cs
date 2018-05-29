using AV.Middle.Pattern.ImageViewer.Interface;

namespace AV.Middle.Pattern.ImageViewer.Concrete
{
	public class ProxyImage : IImage
	{
		private RealImage realImage;
		private string _fileName;

		public ProxyImage(string fileName)
		{
			_fileName = fileName;
		}

		public void Display()
		{
			if (realImage == null)
			{
				realImage = new RealImage(_fileName);
			}
			realImage.Display();
		}
	}
}