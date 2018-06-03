using AV.Middle.Pattern.Structural.MediaPlayer.Concrete;
using AV.Middle.Reflector.IService;
using log4net;
using System.Collections;
using System.Reflection;

namespace AV.Middle.Pattern.Structural.MediaPlayer
{
	/// <summary>
	/// Structural Design Pattern: Adapter pattern works as a bridge between two incompatible interfaces. This type of design pattern comes under structural pattern as this pattern combines the capability of two independent interfaces.
	/// </summary>
	public class AdapterProcess : IProcess
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			var audioPlayer = new AudioPlayer();
			audioPlayer.Play("mp3", "beyond the horizon.mp3");
			audioPlayer.Play("mp4", "alone.mp4");
			audioPlayer.Play("vlc", "far far away.vlc");
			audioPlayer.Play("avi", "mind me.avi");
		}

		public bool Validate()
		{
			return true;
		}
	}
}