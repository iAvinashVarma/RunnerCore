using AV.Middle.Pattern.DuckGame.Behavior;
using AV.Middle.Pattern.DuckGame.Context;

namespace AV.Middle.Pattern.DuckGame.Concrete
{
	internal class MallardDuck : DuckContext
	{
		public MallardDuck()
		{
			SetFly(new FlyWithWings());
			SetQuack(new QuackLikeMallard());
		}
	}
}