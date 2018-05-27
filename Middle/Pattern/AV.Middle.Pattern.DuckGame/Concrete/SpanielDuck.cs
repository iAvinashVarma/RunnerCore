using AV.Middle.Pattern.DuckGame.Behavior;
using AV.Middle.Pattern.DuckGame.Context;

namespace AV.Middle.Pattern.DuckGame.Concrete
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