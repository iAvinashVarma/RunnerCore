namespace AV.Middle.Common.Model
{
	public class ReplaceModel
	{
		private string directoryPath;

		public string DirectoryPath
		{
			get { return directoryPath; }
			set { directoryPath = value; }
		}

		private string matchValue;

		public string MatchValue
		{
			get { return matchValue; }
			set { matchValue = value; }
		}

		private string replaceValue;

		public string ReplaceValue
		{
			get { return replaceValue; }
			set { replaceValue = value; }
		}

		private string pattern;

		public string Pattern
		{
			get { return pattern; }
			set { pattern = value; }
		}

		private string contains;

		public string Contains
		{
			get { return contains; }
			set { contains = value; }
		}

		private bool isOther;

		public bool IsOther
		{
			get { return isOther; }
			set { isOther = value; }
		}
	}
}