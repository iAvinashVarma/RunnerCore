using AV.Middle.Pattern.Creational.ShapePrototype.Abstract;
using AV.Middle.Pattern.Creational.ShapePrototype.Concrete;
using System.Collections.Generic;

namespace AV.Middle.Pattern.Creational.ShapePrototype
{
	public class ShapeCache
	{
		private static Dictionary<string, Shape> shapeMap = new Dictionary<string, Shape>();

		public static Shape GetShape(string shapeId)
		{
			var shapeCache = shapeMap[shapeId];
			return (Shape)shapeCache.Clone();
		}

		public static void LoadCache()
		{
			var circle = new Circle
			{
				Id = "1"
			};
			shapeMap.Add(circle.Id, circle);

			var square = new Square
			{
				Id = "2"
			};
			shapeMap.Add(square.Id, square);

			var rectangle = new Rectangle
			{
				Id = "3"
			};
			shapeMap.Add(rectangle.Id, rectangle);
		}
	}
}