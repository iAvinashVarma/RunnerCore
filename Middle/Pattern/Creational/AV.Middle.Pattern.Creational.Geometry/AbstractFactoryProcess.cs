using AV.Middle.Pattern.Creational.Geometry.Factory;
using AV.Middle.Reflector.IService;
using log4net;
using System.Collections;
using System.Reflection;

namespace AV.Middle.Pattern.Creational.Geometry
{
	/// <summary>
	/// Creational Design Pattern: Abstract Factory patterns work around a super-factory which creates other factories. This factory is also called as factory of factories. This type of design pattern comes under creational pattern as this pattern provides one of the best ways to create an object.
	/// </summary>
	public class AbstractFactoryProcess : IProcess
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			#region Shape Factory

			// Get Shape Factory
			var shapeFactory = new ProduceFactory().GetFactory(ProduceFactory.GeometryType.Shape);
			// Get an object of Shape Circle.
			var circle = shapeFactory.GetShape(ShapeType.Circle);
			// Draw Circle.
			circle.Draw();
			// Get an object of Shape Rectangle.
			var rectangle = shapeFactory.GetShape(ShapeType.Rectangle);
			// Draw Rectangle.
			rectangle.Draw();
			// Get an object of Shape Square.
			var square = shapeFactory.GetShape(ShapeType.Square);
			// Draw Square.
			square.Draw();

			#endregion Shape Factory

			#region Color Factory

			// Get Color Factory
			var colorFactory = new ProduceFactory().GetFactory(ProduceFactory.GeometryType.Color);
			// Get an object of Blue Color.
			var blue = shapeFactory.GetColor(ColorType.Blue);
			// Fill Blue Color.
			blue.Fill();
			// Get an object of Green Color.
			var green = shapeFactory.GetColor(ColorType.Green);
			// Fill Green Color.
			green.Fill();
			// Get an object of Red Color.
			var red = shapeFactory.GetColor(ColorType.Red);
			// Fill Red Color.
			red.Fill();

			#endregion Color Factory
		}

		public bool Validate()
		{
			return true;
		}
	}
}