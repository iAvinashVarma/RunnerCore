using AV.Middle.Pattern.DrawShape.Abstract;
using AV.Middle.Pattern.DrawShape.Concrete;
using AV.Middle.Reflector.IService;
using log4net;
using System.Collections;
using System.Reflection;

namespace AV.Middle.Pattern.DrawShape
{
	/// <summary>
	/// Structural Design Pattern: Bridge is used when we need to decouple an abstraction from its implementation so that the two can vary independently. This type of design pattern comes under structural pattern as this pattern decouples implementation class and abstract class by providing a bridge structure between them.
	/// </summary>
	public class BridgeProcess : IProcess
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			DrawHelper(new Circle(100, 100, 10, new RedCircle()));
			DrawHelper(new Circle(100, 100, 10, new GreenCircle()));
		}

		public bool Validate()
		{
			return true;
		}

		private void DrawHelper(Shape shape)
		{
			shape.Draw();
		}
	}
}