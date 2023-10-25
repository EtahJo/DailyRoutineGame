using System;
using System.Collections.Generic;
namespace dailyRoutine.GameClasses
{
	public class LevelOne:IGame
	{
		
		private Dictionary<string, double> _scoreDictionary;
        public int Level { get { return 1; } }

        public IPlayer Player { get; set; }

        public LevelOne( IPlayer player)
		{
			
			Player = player;
			_scoreDictionary = new Dictionary<string, double>();
		}
		
		static double ScoreAlgorithm( int portion)
		{
			return (0.025 * portion) * 100;
		}
		private void  AddScoreToDictionary(string habit,double score)
		{
			_scoreDictionary.Add(habit, score);
		}
		public double GetScore(string habit)
		{
			double score=0;
			
                switch (habit)
                {
                    case "dance":
						score=Player.Dance?
							ScoreAlgorithm(2):0;
                        break;
                    case "sing":
						score=Player.Sing?ScoreAlgorithm(2):0;
                        break;
					case "journal":
						score = Player.Journaling?ScoreAlgorithm(3):0;
						break;
					case "sleep":
						 score =Player.Sleeping <=8 ||Player.Sleeping>=7? ScoreAlgorithm(4):0; 
                        
						break;
					case "eat":
                        score = Player.FoodType== FoodType.Healthy?
						ScoreAlgorithm(4):0;
                        break;
					case "meditate":
                        score =Player.Meditation? ScoreAlgorithm(5):0;
                        break;
					case "work":
					{
						if (Player.Working >= 8)
						{
							score = ScoreAlgorithm(7);
						}
						else if (Player.Working >= 5 && Player.Working <= 8)
						{
							score = ScoreAlgorithm(5);
						}
						else score = 0;
                    }

                    break;
					case "exercise":
                        score = Player.Exercise?ScoreAlgorithm(4):0;
                        break;
					case "social Media":
                        score = !Player.SocialMedia?ScoreAlgorithm(3):0;
                        break;
					case "Pray":
                        score = Player.Praying?ScoreAlgorithm(4):0;
                        break;
					case "games":
                        score = !Player.PlayingGames?ScoreAlgorithm(2):0;
                        break;

                
            }
			AddScoreToDictionary(habit, score);
			return score;
			
		}
		public void DisplayResults()
		{
			Console.WriteLine("________________");
			Console.WriteLine("This are your detail results");
            foreach (var item in _scoreDictionary)
            {
				Console.WriteLine("{0} - {1}", item.Key,item.Value);
            }

        }
		
		public double GetResults()
		{
			double result=0;
			foreach(var item in _scoreDictionary.Values)
			{
				result += item;
			}
			Console.WriteLine("Maintaining these habits gives you a {0} chance of achieving your goal",result);
			return result;
		}
		
	}
}

