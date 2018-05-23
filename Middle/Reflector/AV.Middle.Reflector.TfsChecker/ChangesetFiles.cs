using AV.Middle.Common.Logger.Validator;
using AV.Middle.Common.VersionControl;
using AV.Middle.Reflector.IService;
using System;
using System.Collections;

namespace AV.Middle.Reflector.TfsChecker
{
	public class ChangesetFiles : IProcess
	{
		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			var workingDirectory = EnhanceLog.Set(Hashtable, "WorkingDirectory");
			var changeset = EnhanceLog.Set(Hashtable, "Changeset");
			var tfs = TfsCmdFactory.GetChangesetService(workingDirectory, changeset);
			var executeModel = tfs.ExecuteCommand();
		}

		public bool Validate()
		{
			return true;
		}
	}
}
