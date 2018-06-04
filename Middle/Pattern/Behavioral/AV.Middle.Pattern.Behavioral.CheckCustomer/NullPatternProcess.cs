using AV.Middle.Pattern.Behavioral.CheckCustomer.Factory;
using AV.Middle.Reflector.IService;
using log4net;
using System;
using System.Collections;
using System.Reflection;

namespace AV.Middle.Pattern.Behavioral.CheckCustomer
{
	/// <summary>
	/// In Null Object pattern, a null object replaces check of NULL object instance. Instead of putting if check for a null value, Null Object reflects a do nothing relationship. Such Null object can also be used to provide default behaviour in case data is not available.
	/// </summary>
	public class NullPatternProcess : IProcess
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			var customerFactory = new CustomerFactory();
			var customerOne = customerFactory.GetCustomer("Avinash");
			var customerTwo = customerFactory.GetCustomer("Pruthvi");
			var customerThree = customerFactory.GetCustomer("India");
			var customerFour = customerFactory.GetCustomer("India");

			logger.Info("Customers:");
			logger.Info(customerOne.GetName());
			logger.Info(customerTwo.GetName());
			logger.Info(customerThree.GetName());
			logger.Info(customerFour.GetName());
		}

		public bool Validate() => true;
	}
}
