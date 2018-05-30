using AV.Middle.Pattern.StockBroker.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.StockBroker.Concrete
{
	public class SellStock : IOrder
	{
		private Stock _stock;

		public SellStock(Stock stock)
		{
			_stock = stock;
		}

		public void Execute()
		{
			_stock.Sell();
		}
	}
}
