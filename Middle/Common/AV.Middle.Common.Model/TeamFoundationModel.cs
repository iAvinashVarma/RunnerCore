using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Common.Model
{
    public class TeamFoundationModel
    {
		private string workingDirectory;

		public string WorkingDirectory
		{
			get { return workingDirectory; }
			set { workingDirectory = value; }
		}

		private string changeset;

		public string Changeset
		{
			get { return changeset; }
			set { changeset = value; }
		}

		private string shelveset;

		public string Shelveset
		{
			get { return shelveset; }
			set { shelveset = value; }
		}

	}
}
