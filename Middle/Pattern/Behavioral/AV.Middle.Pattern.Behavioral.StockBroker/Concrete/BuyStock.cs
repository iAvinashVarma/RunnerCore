using AV.Middle.Pattern.Behavioral.StockBroker.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Behavioral.StockBroker.Concrete
{
    public class BuyStock : IOrder
    {
		private Stock _stock;

		public BuyStock(Stock stock)
		{
			_stock = stock;
		}

		public void Execute()
		{
			_stock.Buy();
		}
    }
}
