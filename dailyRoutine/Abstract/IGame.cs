using System;
namespace dailyRoutine.Abstract
{
	public interface IGame
	{
		IPlayer Player { get; }
		int Level { get; }
		double GetScore(string habit);
	}
}

