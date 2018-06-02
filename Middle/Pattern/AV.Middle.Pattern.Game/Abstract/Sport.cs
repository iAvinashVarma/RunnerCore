namespace AV.Middle.Pattern.Game.Abstract
{
	public interface ISport
	{
		void Initialize();

		void StartPlay();

		void EndPlay();
	}

	public abstract class Sport : ISport
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