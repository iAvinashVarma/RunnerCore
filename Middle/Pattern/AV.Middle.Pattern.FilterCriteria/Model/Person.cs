namespace AV.Middle.Pattern.FilterCriteria.Model
{
	public class Person
	{
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string gender;

		public string Gender
		{
			get { return gender; }
			set { gender = value; }
		}

		private string maritalStatus;

		public string MaritalStatus
		{
			get { return maritalStatus; }
			set { maritalStatus = value; }
		}

		public override string ToString()
		{
			return $"Person: [ Name: {name}, Gender: {gender}, Marital Status: {maritalStatus} ]";
		}
	}
}