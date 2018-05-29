using AV.Middle.Pattern.ImageViewer.Concrete;
using AV.Middle.Reflector.IService;
using log4net;
using System.Collections;
using System.Reflection;

namespace AV.Middle.Pattern.ImageViewer
{
	public class ProxyProcess : IProcess
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			var image = new ProxyImage(@"V:\Client\WPF\BuildProj\BuildProj\Resources\Images\AV.png");
			// Image will be loaded from disk.
			image.Display();
			// Image will not be loaded from disk.
			image.Display();
		}

		public bool Validate()
		{
			return true;
		}
	}
}