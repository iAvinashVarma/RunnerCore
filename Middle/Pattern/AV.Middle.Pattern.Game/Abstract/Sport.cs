namespace AV.Middle.Pattern.Game.Abstract
{
	public abstract class Sport
	{
		public abstract void Initialize();

		public abstract void StartPlay();

		public abstract void EndPlay();

		/// <summary>
		/// Template Method.
		/// </summary>
		public void Play()
		{
			// Initialize the game.
			Initialize();
			// Start the game.
			StartPlay();
			// End the game.
			EndPlay();
		}
	}
}