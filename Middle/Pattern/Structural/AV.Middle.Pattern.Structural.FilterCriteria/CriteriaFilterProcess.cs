using AV.Middle.Extension.Generic;
using AV.Middle.Pattern.Structural.FilterCriteria.Concrete;
using AV.Middle.Pattern.Structural.FilterCriteria.Model;
using AV.Middle.Reflector.IService;
using log4net;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace AV.Middle.Pattern.Structural.FilterCriteria
{
	/// <summary>
	/// Structural Design Pattern: Filter pattern or Criteria pattern is a design pattern that enables developers to filter a set of objects using different criteria and chaining them in a decoupled way through logical operations. This type of design pattern comes under structural pattern as this pattern combines multiple criteria to obtain single criteria.
	/// </summary>
	public class CriteriaFilterProcess : IProcess
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			var persons = new List<Person>()
			{
				new Person { Name = "Avinash", Gender = "Male", MaritalStatus = "Single"},
				new Person { Name = "Pruthvi", Gender = "Male", MaritalStatus = "Single"},
				new Person { Name = "Lakshmi", Gender = "Female", MaritalStatus = "Married"},
				new Person { Name = "Manoj", Gender = "Male", MaritalStatus = "Single"},
				new Person { Name = "Bharath", Gender = "", MaritalStatus = "Single"}
			};

			var male = new CriteriaMale();
			var female = new CriteriaFemale();
			var single = new CriteriaSingle();

			male.MeetCriteria(persons).DoAction(x => logger.Info("Males: ")).ForEach(m => logger.Info(m));
			female.MeetCriteria(persons).DoAction(x => logger.Info("Females: ")).ForEach(f => logger.Info(f));
			single.MeetCriteria(persons).DoAction(x => logger.Info("Single: ")).ForEach(s => logger.Info(s));
			(new AndCriteria(single, male)).MeetCriteria(persons).DoAction(x => logger.Info("And: ")).ForEach(a => logger.Info(a));
			(new OrCriteria(single, female)).MeetCriteria(persons).DoAction(x => logger.Info("Or: ")).ForEach(o => logger.Info(o));
		}

		public bool Validate()
		{
			return true;
		}
	}
}