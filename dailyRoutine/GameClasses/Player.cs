using System;

namespace dailyRoutine.GameClasses
{
	public class Player:IPlayer
	{
		
        public string Name { get; set; }
        public bool Dance { get; private set; }

        public bool Sing { get; private set; }

        public bool Journaling { get; private set; }

        public int Sleeping { get; private set; }

        public FoodType FoodType { get; private set; }

        public bool Meditation { get; private set; }

        public int Working { get; private set; }

        public bool Exercise { get; private set; }

        public bool SocialMedia { get; private set; }

        public bool Praying { get; private set; }

        public bool PlayingGames { get; private set; }
        public Player( string name)
        {
            Name = name;
        }
        public void SetHabitToTrue(string habit)
        {
            switch (habit)
            {
                case "dance":
                    Dance = true;
                    break;
                case "sing":
                    Sing = true;
                    break;
                case "journal":
                    Journaling = true;
                    break;
                case "meditate":
                    Meditation = true;
                    break;
                case "exercise":
                    Exercise = true;
                    break;
                case "social Media":
                    SocialMedia = true;
                    break;
                case "Pray":
                    Praying = true;
                    break;
                case "games":
                    PlayingGames = true;
                    break;



            }

        }
    }
}

