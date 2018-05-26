using AV.Middle.Miscellaneous.DuckGame.Interface;
using log4net;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AV.Middle.Miscellaneous.DuckGame.Context
{
    public class DuckContext
    {
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		IFlyBehavior flyer;
		IQuackBehavior quacker;

		public virtual void SetFly(IFlyBehavior flyBehavior)
		{
			flyer = flyBehavior;
		}

		public virtual void SetQuack(IQuackBehavior quackBehavior)
		{
			quacker = quackBehavior;
		}

		public virtual void DoFly()
		{
			flyer.Fly();
		}

		public virtual void DoQuack()
		{
			quacker.Quack();
		}

		public virtual void DoSwim()
		{
			logger.Info("Swim..");
		}
    }
}
