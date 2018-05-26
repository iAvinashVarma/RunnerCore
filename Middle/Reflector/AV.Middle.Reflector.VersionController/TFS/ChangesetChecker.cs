using AV.Middle.Common.Logger.Observer;
using AV.Middle.Common.Model;
using AV.Middle.Common.VersionControl;
using AV.Middle.Extension.GenericLog;
using AV.Middle.Reflector.IService;
using log4net;
using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Reflection;

namespace AV.Middle.Reflector.VersionController.TFS
{
	public class ChangesetChecker : IProcess
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		private Logger csvLogger = Logger.Instance;
		private TeamFoundationModel teamFoundationModel;
		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			var tfs = TfsCmdFactory.GetChangesetService(string.Empty, teamFoundationModel.Changeset);
			var executeModel = tfs.ExecuteCommand();
			if (executeModel.ExitCode == 0)
			{
				if (!string.IsNullOrEmpty(teamFoundationModel.Section))
					SectionChecker(executeModel, teamFoundationModel.Section);
				logger.Info(executeModel.Output);
			}
		}

		public bool Validate()
		{
			bool status = false;
			try
			{
				teamFoundationModel = new TeamFoundationModel
				{
					WorkingDirectory = Hashtable.Validate("WorkingDirectory"),
					Changeset = Hashtable.Validate("Changeset"),
					Section = Hashtable.Validate("Section")
				};
				status = true;
			}
			catch (Exception ex)
			{
				logger.Warn(ex);
			}
			return status;
		}

		private void SectionChecker(ExecuteModel executeModel, string section)
		{
			csvLogger.RegisterObservers(new FileLogger(Path.Combine($"{teamFoundationModel.WorkingDirectory}, {teamFoundationModel.Changeset}.LOG")));
			var findSection = executeModel.Output.IndexOf($"{section}:", StringComparison.OrdinalIgnoreCase);
			var output = executeModel.Output.Substring(findSection).Split('\n').Skip(1).Select(x => x.Trim()).Where(x => x.IndexOf("$/", StringComparison.OrdinalIgnoreCase) != -1).Select((x, i) => new
			{
				Trim = x,
				Change = x.Substring(0, x.IndexOf('$')).Trim(),
				Path = x.Substring(x.IndexOf('$')),
				Index = i + 1
			});
		}
	}
}