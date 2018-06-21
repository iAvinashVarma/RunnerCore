using AV.Middle.Common.Model;
using NUnit.Framework;

namespace TestDriven.Middle.Common.Model
{
	[TestFixture]
	public class FileModelValidTest
	{
		private readonly FileModel fileModel;

		public FileModelValidTest()
		{
			fileModel = new FileModel(@"C:\Temp\Avi\Filter.xml");
		}

		[Test]
		public void CheckIfFileExists()
		{
			Assert.AreEqual(true, fileModel.IsFileExists);
		}
	}
}
