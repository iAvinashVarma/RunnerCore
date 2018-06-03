using AV.Middle.Pattern.Structural.FilterCriteria.Interface;
using AV.Middle.Pattern.Structural.FilterCriteria.Model;
using System.Collections.Generic;

namespace AV.Middle.Pattern.Structural.FilterCriteria.Concrete
{
	public class AndCriteria : ICriteria
	{
		private ICriteria _criteriaOne;
		private ICriteria _criteriaTwo;

		public AndCriteria(ICriteria criteriaOne, ICriteria criteriaTwo)
		{
			_criteriaOne = criteriaOne;
			_criteriaTwo = criteriaTwo;
		}

		public List<Person> MeetCriteria(List<Person> persons)
		{
			var criteriaPersons = _criteriaOne.MeetCriteria(persons);
			return _criteriaTwo.MeetCriteria(criteriaPersons);
		}
	}
}