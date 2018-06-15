using AV.Middle.Pattern.Behavioral.ComputerParts.Concrete;
using AV.Middle.Pattern.Behavioral.ComputerParts.Interface;
using AV.Middle.Pattern.Behavioral.ComputerParts.Visitor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDriven.Middle.Behavioral.ComputerParts
{
    [TestClass]
    public class VisitorValidTest
    {
        [TestMethod]
        public void KeyboardInterfaceTest()
        {
			var keyboard = new Keyboard();
			Assert.IsNotNull(keyboard);
			Assert.IsInstanceOfType(keyboard, typeof(IComputerPart));
		}

		[TestMethod]
		public void MonitorInterfaceTest()
		{
			var monitor = new Monitor();
			Assert.IsNotNull(monitor);
			Assert.IsInstanceOfType(monitor, typeof(IComputerPart));
		}

		[TestMethod]
		public void MouseInterfaceTest()
		{
			var mouse = new Mouse();
			Assert.IsNotNull(mouse);
			Assert.IsInstanceOfType(mouse, typeof(IComputerPart));
		}

		[TestMethod]
		public void ComputerInterfaceTest()
		{
			var computer = new Computer();
			Assert.IsNotNull(computer);
			Assert.IsInstanceOfType(computer, typeof(IComputerPart));
		}
	}
}
