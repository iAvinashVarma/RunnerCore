using log4net;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AV.Middle.Pattern.StockBroker.Concrete
{
    public class Stock
    {
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		private string _name;
		private int _quantity;

		public Stock(string name, int quantity)
		{
			_name = name;
			_quantity = quantity;
		}

		public void Buy()
		{
			logger.Info($"Stock [ Name: {_name}, Quantity: {_quantity} ] bought");
		}

		public void Sell()
		{
			logger.Info($"Stock [ Name: {_name}, Quantity: {_quantity}] sold");
		}
    }
}
