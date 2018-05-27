using AV.Middle.Miscellaneous.DuckGame.Behavior;
using AV.Middle.Miscellaneous.DuckGame.Context;

namespace AV.Middle.Miscellaneous.DuckGame.Concrete
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