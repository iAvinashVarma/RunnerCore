using AV.Middle.Pattern.FilterCriteria.Concrete;
using AV.Middle.Pattern.FilterCriteria.Model;
using AV.Middle.Reflector.IService;
using log4net;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace AV.Middle.Pattern.FilterCriteria
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
			var and = new AndCriteria(single, male);
			var or = new OrCriteria(single, female);

			logger.Info($"Males: {male}.");
			logger.Info($"Females: {female}.");
			logger.Info($"Singles: {single}.");
			logger.Info($"Single Males: {and}.");
			logger.Info($"Single or Females: {or}.");
			or.ToString();
		}

		public bool Validate()
		{
			return true;
		}
	}
}
