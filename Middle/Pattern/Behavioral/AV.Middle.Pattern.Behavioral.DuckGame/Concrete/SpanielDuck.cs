using AV.Middle.Pattern.Behavioral.DuckGame.Behavior;
using AV.Middle.Pattern.Behavioral.DuckGame.Context;

namespace AV.Middle.Pattern.Behavioral.DuckGame.Concrete
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