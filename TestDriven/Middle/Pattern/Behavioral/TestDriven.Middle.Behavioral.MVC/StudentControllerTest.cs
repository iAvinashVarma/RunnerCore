using AV.Middle.Pattern.Behavioral.MVC.Controller;
using AV.Middle.Pattern.Behavioral.MVC.Model;
using AV.Middle.Pattern.Behavioral.MVC.View;
using NUnit.Framework;

namespace TestDriven.Middle.Behavioral.MVC
{
    [TestFixture]
    public class StudentControllerTest
    {
        [Test]
        public void TestStudentView()
        {
			var model = new StudentModel
			{
				Name = "Avinash",
				RollNumber = "1209"
			};
			var controller = new StudentController(model, new StudentView());
			controller.SetStudentName("Avinash");
			controller.SetRollNumber("1209");
			Assert.AreEqual(model.Name, controller.GetStudentName());
			Assert.AreEqual(model.RollNumber, controller.GetRollNumber());
        }
    }
}
