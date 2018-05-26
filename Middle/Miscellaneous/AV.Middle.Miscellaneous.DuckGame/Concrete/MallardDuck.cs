using AV.Middle.Miscellaneous.DuckGame.Behavior;
using AV.Middle.Miscellaneous.DuckGame.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Miscellaneous.DuckGame.Concrete
{
    class MallardDuck : DuckContext
    {
		public MallardDuck()
		{
			SetFly(new FlyWithWings());
			SetQuack(new QuackLikeMallard());
		}
    }
}
