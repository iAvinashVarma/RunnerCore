using AV.Middle.Aspect.OrientedProcess.Concrete;
using AV.Middle.Aspect.OrientedProcess.Factory;
using AV.Middle.Aspect.OrientedProcess.Interface;
using AV.Middle.Aspect.OrientedProcess.Model;
using AV.Middle.Reflector.IService;
using log4net;
using System;
using System.Collections;
using System.Reflection;
using System.Threading.Tasks;
using static AV.Middle.Aspect.OrientedProcess.Factory.RepositoryFactory;

namespace AV.Middle.Aspect.OrientedProcess
{
    public class AOPProcess : IProcess
    {
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			logger.Info($"{Environment.NewLine} Begin Program - No Logging. {Environment.NewLine}");
			var customer = new Customer
			{
				Id = 1,
				Name = "Avinash",
				Address = "Hyderabad"
			};
			var customerRepository = new RepositoryFactory().Create<Customer>(CreateType.DispatchProxy);
			customerRepository.Add(customer);
			customerRepository.Delete(customer);
			customerRepository.Update(customer);

			//var number = new Number
			//{
			//	NumberOne = 18,
			//	NumberTwo = 9
			//};
			//var calculatorRepository = new CalculatorFactory().Create<Number>(CreateType.DispatchProxy);
			//calculatorRepository.Add(number);
			//calculatorRepository.Substract(number);

			logger.Info($"{Environment.NewLine} End Program - No Logging. {Environment.NewLine}");
		}

		public bool Validate()
		{
			return true;
		}
	}
}
