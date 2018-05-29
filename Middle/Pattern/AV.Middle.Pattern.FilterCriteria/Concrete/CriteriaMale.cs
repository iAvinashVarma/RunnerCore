using AV.Middle.Pattern.FilterCriteria.Interface;
using AV.Middle.Pattern.FilterCriteria.Model;
using System;
using System.Collections.Generic;

namespace AV.Middle.Pattern.FilterCriteria.Concrete
{
	public class CriteriaMale : ICriteria
	{
		public List<Person> MeetCriteria(List<Person> persons)
		{
			var males = new List<Person>();
			foreach (var person in persons)
			{
				if (person.Gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
					males.Add(person);
			}
			return males;
		}
	}
}