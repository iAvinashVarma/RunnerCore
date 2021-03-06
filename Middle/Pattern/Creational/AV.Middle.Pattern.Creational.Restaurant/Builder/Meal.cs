﻿using AV.Middle.Pattern.Creational.Restaurant.Interface;
using log4net;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace AV.Middle.Pattern.Creational.Restaurant.Builder
{
	public class Meal
	{
		private List<IItem> items = new List<IItem>();
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public void AddItem(IItem item)
		{
			items.Add(item);
		}

		public double GetCost()
		{
			var cost = 0.0;
			foreach (var item in items)
			{
				cost += item.Price();
			}
			return cost;
		}

		public void ShowItems()
		{
			foreach (var item in items)
			{
				logger.Info($"Item: {item.Name()} | Packing: {item.Package().Type()} | Price: {item.Price()}{Environment.NewLine}");
			}
		}
	}
}