using AV.Middle.Pattern.FilterCriteria.Model;
using System.Collections.Generic;

namespace AV.Middle.Pattern.FilterCriteria.Interface
{
	public interface ICriteria
	{
		List<Person> MeetCriteria(List<Person> persons);
	}
}