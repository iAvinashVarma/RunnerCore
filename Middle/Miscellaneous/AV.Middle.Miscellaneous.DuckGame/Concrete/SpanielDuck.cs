using AV.Middle.Miscellaneous.DuckGame.Behavior;
using AV.Middle.Miscellaneous.DuckGame.Context;

namespace AV.Middle.Miscellaneous.DuckGame.Concrete
{
	internal class SpanielDuck : DuckContext
	{
		public SpanielDuck()
		{
			SetFly(new FlyHigh());
			SetQuack(new QuackLikeSpaniel());
		}
	}
}