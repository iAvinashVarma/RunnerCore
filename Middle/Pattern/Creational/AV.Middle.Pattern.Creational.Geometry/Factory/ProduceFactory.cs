namespace AV.Middle.Pattern.Creational.Geometry.Factory
{
	public class ProduceFactory
	{
		public GeometryFactory GetFactory(GeometryType geometryType)
		{
			GeometryFactory geometryFactory = null;
			switch (geometryType)
			{
				case GeometryType.Shape:
					geometryFactory = new ShapeFactory();
					break;

				case GeometryType.Color:
					geometryFactory = new ColorFactory();
					break;
			}
			return geometryFactory;
		}

		public enum GeometryType
		{
			Shape,
			Color
		}
	}
}