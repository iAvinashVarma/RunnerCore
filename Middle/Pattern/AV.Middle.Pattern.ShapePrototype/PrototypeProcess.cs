using AV.Middle.Reflector.IService;
using log4net;
using System.Collections;
using System.Reflection;

namespace AV.Middle.Pattern.ShapePrototype
{
	/// <summary>
	/// Creational Design Pattern: Prototype pattern refers to creating duplicate object while keeping performance in mind. This type of design pattern comes under creational pattern as this pattern provides one of the best ways to create an object.
	/// </summary>
	public class PrototypeProcess : IProcess
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			ShapeCache.LoadCache();
			var clonedCircleShape = ShapeCache.GetShape("1");
			logger.Info($"Shape: {clonedCircleShape.Type}");

			var clonedSquareShape = ShapeCache.GetShape("2");
			logger.Info($"Shape: {clonedSquareShape.Type}");

			var clonedRectangleShape = ShapeCache.GetShape("3");
			logger.Info($"Shape: {clonedRectangleShape.Type}");
		}

		public bool Validate()
		{
			return true;
		}
	}
}