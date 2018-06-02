using AV.Middle.Aspect.OrientedProcess.Concrete;
using AV.Middle.Aspect.OrientedProcess.Factory;
using AV.Middle.Aspect.OrientedProcess.Interface;
using AV.Middle.Aspect.OrientedProcess.Model;
using AV.Middle.Reflector.IService;
using log4net;
using System;
using System.Collections;
using System.Reflection;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using static AV.Middle.Aspect.OrientedProcess.Factory.RepositoryFactory;

namespace AV.Middle.Aspect.OrientedProcess
{
	public class AOPProcess : IProcess
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		public const string Star = "*****";
		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			logger.Info($"{Star} Begin Program {Star}");
			var customer = new Customer
			{
				Id = 1,
				Name = "Avinash",
				Address = "Hyderabad"
			};
			Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity("Administrator"),
				new[] { "Avi" });
			var customerRepository = new RepositoryFactory().Create<Customer>(CreateType.PerformanceProxy);
			customerRepository.Add(customer);
			customerRepository.Delete(customer);
			customerRepository.Update(customer);
			logger.Info($"{Star} End Program {Star}");
		}

		public bool Validate()
		{
			return true;
		}
	}
}
