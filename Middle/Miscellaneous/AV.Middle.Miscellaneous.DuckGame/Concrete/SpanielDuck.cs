using AV.Middle.Miscellaneous.DuckGame.Behavior;
using AV.Middle.Miscellaneous.DuckGame.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Miscellaneous.DuckGame.Concrete
{
    class SpanielDuck : DuckContext
    {
		public SpanielDuck()
		{
			SetFly(new FlyHigh());
			SetQuack(new QuackLikeSpaniel());
		}
    }
}
