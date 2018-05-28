using AV.Middle.Pattern.FilterCriteria.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.FilterCriteria.Interface
{
    public interface ICriteria
    {
		List<Person> MeetCriteria(List<Person> persons);
    }
}
