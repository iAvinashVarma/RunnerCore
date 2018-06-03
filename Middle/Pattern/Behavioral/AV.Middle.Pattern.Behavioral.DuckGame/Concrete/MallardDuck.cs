using AV.Middle.Pattern.Behavioral.DuckGame.Behavior;
using AV.Middle.Pattern.Behavioral.DuckGame.Context;

namespace AV.Middle.Pattern.Behavioral.DuckGame.Concrete
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