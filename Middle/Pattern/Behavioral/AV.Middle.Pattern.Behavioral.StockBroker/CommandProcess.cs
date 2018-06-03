using AV.Middle.Pattern.Behavioral.StockBroker.Command;
using AV.Middle.Pattern.Behavioral.StockBroker.Concrete;
using AV.Middle.Reflector.IService;
using System;
using System.Collections;

namespace AV.Middle.Pattern.Behavioral.StockBroker
{
	/// <summary>
	/// Behavioral Design pattern: Command pattern is a data driven design pattern and falls under behavioral pattern category. A request is wrapped under an object as command and passed to invoker object. Invoker object looks for the appropriate object which can handle this command and passes the command to the corresponding object which executes the command.
	/// </summary>
	public class CommandProcess : IProcess
	{
		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			var abcStock = new Stock("ABC", 10);
			var buyStock = new BuyStock(abcStock);
			var sellStock = new SellStock(abcStock);

			var broker = new Broker();
			broker.TakeOrder(buyStock);
			broker.TakeOrder(sellStock);

			broker.PlaceOrder();
		}

		public bool Validate()
		{
			return true;
		}
	}
}
