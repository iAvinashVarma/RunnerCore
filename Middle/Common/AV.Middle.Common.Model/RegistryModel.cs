namespace AV.Middle.Common.Model
{
	public class RegistryModel
	{
		private string subKey;

		public string SubKey
		{
			get { return subKey; }
			set { subKey = value; }
		}

		private string key;

		public string Key
		{
			get { return key; }
			set { key = value; }
		}

		private string vValue;

		public string Value
		{
			get { return vValue; }
			set { vValue = value; }
		}
	}
}