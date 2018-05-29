using AV.Middle.Pattern.DecorateShape.Interface;

namespace AV.Middle.Pattern.DecorateShape.Abstract
{
	public abstract class ShapeDecorator : IShape
	{
		protected IShape _shape;

		public ShapeDecorator(IShape shape)
		{
			_shape = shape;
		}

		public virtual void Draw()
		{
			_shape.Draw();
		}
	}
}