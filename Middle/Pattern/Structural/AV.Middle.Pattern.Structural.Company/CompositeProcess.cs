using AV.Middle.Pattern.Structural.Company.Model;
using AV.Middle.Reflector.IService;
using log4net;
using System.Collections;
using System.Reflection;

namespace AV.Middle.Pattern.Structural.Company
{
	/// <summary>
	/// Structural Design Pattern: Composite pattern is used where we need to treat a group of objects in similar way as a single object. Composite pattern composes objects in term of a tree structure to represent part as well as whole hierarchy. This type of design pattern comes under structural pattern as this pattern creates a tree structure of group of objects.
	/// </summary>
	public class CompositeProcess : IProcess
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			var ceo = new Employee("Avinash", "CEO", 30000);
			var headSales = new Employee("Robert", "Head Sales", 20000);
			var headMarketing = new Employee("Michel", "Head Marketing", 20000);
			var clerkOne = new Employee("Laura", "Marketing", 10000);
			var clerkTwo = new Employee("Bob", "Marketing", 10000);
			var salesExecutiveOne = new Employee("Richard", "Sales", 10000);
			var salesExecutiveTwo = new Employee("Rob", "Sales", 10000);

			ceo.Add(headSales);
			ceo.Add(headMarketing);

			headSales.Add(salesExecutiveOne);
			headSales.Add(salesExecutiveTwo);

			headMarketing.Add(clerkOne);
			headMarketing.Add(clerkTwo);

			logger.Info($"CEO: {ceo}.");
			ceo.Employees.ForEach(x =>
			{
				logger.Info(x);
				x.Employees.ForEach(e =>
				{
					logger.Info(e);
				});
			});
		}

		public bool Validate()
		{
			return true;
		}
	}
}