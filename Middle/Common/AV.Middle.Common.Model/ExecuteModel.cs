namespace AV.Middle.Common.Model
{
	public class ExecuteModel
	{
		private string input;

		public string Input
		{
			get { return input; }
			set { input = value; }
		}

		private string output;

		public string Output
		{
			get { return output; }
			set { output = value; }
		}

		private string error;

		public string Error
		{
			get { return error; }
			set { error = value; }
		}

		public bool IsError
		{
			get { return !string.IsNullOrEmpty(error); }
		}

		public bool IsInput
		{
			get { return !string.IsNullOrEmpty(input); }
		}

		public bool IsOutput
		{
			get { return !string.IsNullOrEmpty(output); }
		}

		private int exitCode;

		public int ExitCode
		{
			get { return exitCode; }
			set { exitCode = value; }
		}
	}
}