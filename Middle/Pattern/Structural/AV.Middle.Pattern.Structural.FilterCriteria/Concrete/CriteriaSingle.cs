using AV.Middle.Pattern.Structural.FilterCriteria.Interface;
using AV.Middle.Pattern.Structural.FilterCriteria.Model;
using System;
using System.Collections.Generic;

namespace AV.Middle.Pattern.Structural.FilterCriteria.Concrete
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