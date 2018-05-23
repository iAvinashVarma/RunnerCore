using AV.Middle.Common.Terminal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AV.Middle.Common.VersionControl
{
	public class TfsCmdFactory
    {
		private static readonly TaskCompletionSource<string> workingDirectory = new TaskCompletionSource<string>();
		private static ICommandService commandService;

		public static ICommandService GetChangesetService(string wDirectory, string changeset)
		{
			if(workingDirectory.TrySetResult(wDirectory))
			{
				commandService = new TfsCmd($"changeset {changeset} /noprompt", wDirectory);
			}
			else if (workingDirectory.Task.Result != wDirectory)
			{
				throw new InvalidOperationException("Working directory redefinition.");
			}
			return commandService;
		}
    }
}
