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
		public void CheckIfFileExists() => Assert.AreEqual(true, fileModel.IsFileExists);

		[Test]
		public void CheckIfFileIsHavingData() => Assert.IsTrue(!string.IsNullOrEmpty(fileModel.FileData));

		[Test]
		public void CheckIfFileIsHavingExtension() => Assert.IsTrue(!string.IsNullOrEmpty(fileModel.FileExtension));

		[Test]
		public void CheckIfFileIsHavingFileNameWithoutExtension() => Assert.IsTrue(!string.IsNullOrEmpty(fileModel.FileNameWithoutExtension));

		[Test]
		public void CheckIfFileIsHavingDirectory() => Assert.IsTrue(!string.IsNullOrEmpty(fileModel.DirectoryFullPath));

		[Test]
		public void CheckIfFileIsHavingFileFullPath() => Assert.IsTrue(!string.IsNullOrEmpty(fileModel.FileFullPath));
	}
}
