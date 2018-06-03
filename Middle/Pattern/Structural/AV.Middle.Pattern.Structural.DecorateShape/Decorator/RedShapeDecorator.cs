using AV.Middle.Pattern.Structural.DecorateShape.Abstract;
using AV.Middle.Pattern.Structural.DecorateShape.Interface;
using log4net;
using System.Reflection;

namespace AV.Middle.Pattern.Structural.DecorateShape.Decorator
{
	public class RedShapeDecorator : ShapeDecorator
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public RedShapeDecorator(IShape shape) : base(shape)
		{
		}

		public override void Draw()
		{
			base.Draw();
			SetRedBorder(_shape);
		}

		private void SetRedBorder(IShape decoratedShape)
		{
			logger.Info("Border Color: Red.");
		}
	}
}