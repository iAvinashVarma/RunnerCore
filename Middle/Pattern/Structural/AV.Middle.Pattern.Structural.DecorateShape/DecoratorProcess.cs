using AV.Middle.Pattern.Structural.DecorateShape.Concrete;
using AV.Middle.Pattern.Structural.DecorateShape.Decorator;
using AV.Middle.Reflector.IService;
using log4net;
using System.Collections;
using System.Reflection;

namespace AV.Middle.Pattern.Structural.DecorateShape
{
	/// <summary>
	/// Structural design pattern: Decorator pattern allows a user to add new functionality to an existing object without altering its structure. This type of design pattern comes under structural pattern as this pattern acts as a wrapper to existing class.
	/// </summary>
	public class DecoratorProcess : IProcess
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			var circle = new Circle();
			var redCircle = new RedShapeDecorator(circle);

			var redRectangle = new RedShapeDecorator(new Rectangle());
			logger.Info("Circle with normal border.");
			circle.Draw();

			logger.Info("Circle of red border.");
			redCircle.Draw();

			logger.Info("Rectangle of red border.");
			redRectangle.Draw();
		}

		public bool Validate()
		{
			return true;
		}
	}
}