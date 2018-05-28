using AV.Middle.Pattern.FilterCriteria.Interface;
using AV.Middle.Pattern.FilterCriteria.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.FilterCriteria.Concrete
{
	public class CriteriaSingle : ICriteria
	{
		public List<Person> MeetCriteria(List<Person> persons)
		{
			var singles = new List<Person>();
			foreach (var person in persons)
			{
				if (person.MaritalStatus.Equals("Single", StringComparison.OrdinalIgnoreCase))
					singles.Add(person);
			}
			return singles;
		}
	}
}
