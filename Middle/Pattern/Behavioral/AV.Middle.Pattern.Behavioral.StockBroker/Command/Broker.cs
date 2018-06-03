using AV.Middle.Pattern.Behavioral.StockBroker.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Behavioral.StockBroker.Command
{
    public class Broker
    {
		private List<IOrder> orders = new List<IOrder>();

		public void TakeOrder(IOrder order)
		{
			orders.Add(order);
		}

		public void PlaceOrder()
		{
			foreach (var order in orders)
			{
				order.Execute();
			}
			orders.Clear();
		}
    }
}
