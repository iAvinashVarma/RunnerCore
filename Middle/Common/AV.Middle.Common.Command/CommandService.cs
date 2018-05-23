using AV.Middle.Common.Model;
using System.Diagnostics;
using System.IO;

namespace AV.Middle.Common.Terminal
{
	public abstract class CommandService : ICommandService
	{
		public virtual ExecuteModel ExecuteCommand()
		{
			return ExecuteCommand();
		}

		public virtual ExecuteModel ExecuteCommand(string fileName = "cmd", string arguments = "/?", string workingDirectory = "")
		{
			var output = string.Empty;
			var error = string.Empty;
			var message = string.Empty;
			var processStartInfo = new ProcessStartInfo(fileName, arguments)
			{
				UseShellExecute = false,
				CreateNoWindow = true,
				WindowStyle = ProcessWindowStyle.Hidden,
				RedirectStandardOutput = true,
				RedirectStandardError = true
			};
			if (!string.IsNullOrEmpty(workingDirectory) && Directory.Exists(workingDirectory)) processStartInfo.WorkingDirectory = workingDirectory;
			var processCommand = new Process
			{
				StartInfo = processStartInfo
			};
			processCommand.Start();
			processCommand.WaitForExit();
			var executeModel = new ExecuteModel
			{
				Output = processCommand.StandardOutput.ReadToEnd(),
				Error = processCommand.StandardError.ReadToEnd(),
				ExitCode = processCommand.ExitCode
			};
			return executeModel;
		}
	}
}