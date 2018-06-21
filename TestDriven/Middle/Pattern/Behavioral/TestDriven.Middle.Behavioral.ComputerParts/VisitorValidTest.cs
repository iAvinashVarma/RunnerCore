using AV.Middle.Pattern.Behavioral.ComputerParts.Concrete;
using AV.Middle.Pattern.Behavioral.ComputerParts.Interface;
using NUnit.Framework;

namespace TestDriven.Middle.Behavioral.ComputerParts
{
    [TestFixture]
    public class VisitorValidTest
    {
        [Test]
        public void KeyboardInterfaceTest()
        {
			var keyboard = new Keyboard();
			Assert.IsNotNull(keyboard);
			Assert.IsInstanceOf<IComputerPart>(keyboard);
		}

		[Test]
		public void MonitorInterfaceTest()
		{
			var monitor = new Monitor();
			Assert.IsNotNull(monitor);
			Assert.IsInstanceOf<IComputerPart>(monitor);
		}

		[Test]
		public void MouseInterfaceTest()
		{
			var mouse = new Mouse();
			Assert.IsNotNull(mouse);
			Assert.IsInstanceOf<IComputerPart>(mouse);
		}

		[Test]
		public void ComputerInterfaceTest()
		{
			var computer = new Computer();
			Assert.IsNotNull(computer);
			Assert.IsInstanceOf<IComputerPart>(computer);
		}
	}
}
