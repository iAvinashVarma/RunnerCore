using AV.Middle.Pattern.Structural.FilterCriteria.Interface;
using AV.Middle.Pattern.Structural.FilterCriteria.Model;
using System.Collections.Generic;

namespace AV.Middle.Pattern.Structural.FilterCriteria.Concrete
{
	public class OrCriteria : ICriteria
	{
		private ICriteria _criteriaOne;
		private ICriteria _criteriaTwo;

		public OrCriteria(ICriteria criteriaOne, ICriteria criteriaTwo)
		{
			_criteriaOne = criteriaOne;
			_criteriaTwo = criteriaTwo;
		}

		public List<Person> MeetCriteria(List<Person> persons)
		{
			var criteriaItemsOne = _criteriaOne.MeetCriteria(persons);
			var criteriaItemsTwo = _criteriaTwo.MeetCriteria(persons);

			foreach (var person in criteriaItemsTwo)
			{
				if (!criteriaItemsOne.Contains(person))
					criteriaItemsOne.Add(person);
			}

			return criteriaItemsOne;
		}
	}
}