using AV.Middle.Pattern.Structural.FilterCriteria.Model;
using System.Collections.Generic;

namespace AV.Middle.Pattern.Structural.FilterCriteria.Interface
{
	public interface ICriteria
	{
		List<Person> MeetCriteria(List<Person> persons);
	}
}