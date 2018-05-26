using AV.Middle.Common.Model;
using AV.Middle.Common.Terminal;

namespace AV.Middle.Common.VersionControl
{
	public class TfsCmd : CommandService
	{
		private string Arguments;

		private string WorkingDirectory;

		public TfsCmd(string arguments, string workingDirectory)
		{
			Arguments = arguments;
			WorkingDirectory = workingDirectory;
		}

		public override ExecuteModel ExecuteCommand()
		{
			return base.ExecuteCommand("tf", Arguments, WorkingDirectory);
		}
	}
}