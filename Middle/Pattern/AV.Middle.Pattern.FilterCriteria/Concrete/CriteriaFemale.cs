using AV.Middle.Pattern.FilterCriteria.Interface;
using AV.Middle.Pattern.FilterCriteria.Model;
using System;
using System.Collections.Generic;

namespace AV.Middle.Pattern.FilterCriteria.Concrete
{
	public class CriteriaFemale : ICriteria
	{
		public List<Person> MeetCriteria(List<Person> persons)
		{
			var females = new List<Person>();
			foreach (var person in persons)
			{
				if (person.Gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
					females.Add(person);
			}
			return females;
		}
	}
}