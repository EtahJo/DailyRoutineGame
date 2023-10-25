using System;
namespace dailyRoutine.Abstract
{
	public interface IPlayer
	{
		public bool Dance { get; }
        public bool Sing { get;  }
        public bool Journaling { get;  }
		public int Sleeping { get;  }
		public FoodType FoodType { get;  }
		public bool Meditation { get; }
		public int Working { get;  }
		public bool Exercise { get; }
		public bool SocialMedia { get;  }
		public bool Praying { get;  }
		public bool PlayingGames { get; }
       
		
	}
}

