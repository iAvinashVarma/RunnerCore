﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.StockObserver.Interface
{
    public interface ISubject
    {
		void Subscribe(IObserver observer);

		void Unsubscribe(IObserver observer);

		void Notify();
    }
}
