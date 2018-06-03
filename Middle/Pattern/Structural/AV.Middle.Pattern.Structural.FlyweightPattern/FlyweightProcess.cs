using AV.Middle.Pattern.Structural.FlyweightPattern.Concrete;
using AV.Middle.Pattern.Structural.FlyweightPattern.Factory;
using AV.Middle.Reflector.IService;
using log4net;
using System;
using System.Collections;
using System.Reflection;

namespace AV.Middle.Pattern.Structural.FlyweightPattern
{
	/// <summary>
	/// Structural design pattern: Flyweight pattern is primarily used to reduce the number of objects created and to decrease memory footprint and increase performance. This type of design pattern comes under structural pattern as this pattern provides ways to decrease object count thus improving the object structure of application.
	/// </summary>
	public class FlyweightProcess : IProcess
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		private static string[] colors = { "Red", "Green", "Blue", "White", "Black" };
		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			for (int i = 0; i < 20; i++)
			{
				var circle = (Circle)ShapeFactory.GetCircle(colors[(int)new Random().Next(colors.Length - 1)]);
				circle.SetX((int)new Random().Next(100));
				circle.SetY((int)new Random().Next(100));
				circle.SetRadius(100);
				circle.Draw();
			}
		}

		public bool Validate()
		{
			return true;
		}
	}
}