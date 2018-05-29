using AV.Middle.Pattern.ShapeMaker.Maker;
using AV.Middle.Reflector.IService;
using System.Collections;

namespace AV.Middle.Pattern.ShapeMaker
{
	/// <summary>
	/// Structural Design Pattern: Facade pattern hides the complexities of the system and provides an interface to the client using which the client can access the system. This type of design pattern comes under structural pattern as this adds an interface to existing system to hide its complexities.
	/// </summary>
	public class FacadeProcess : IProcess
	{
		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			var shapeMaker = new Shape();
			shapeMaker.DrawCircle();
			shapeMaker.DrawRectangle();
			shapeMaker.DrawSquare();
		}

		public bool Validate()
		{
			return true;
		}
	}
}