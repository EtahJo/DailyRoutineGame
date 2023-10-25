global using dailyRoutine.Enums;
global using dailyRoutine.Abstract;
using dailyRoutine.GameClasses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dailyRoutine
{
    class Program
    {
        static void Main()
        {
            List<string> goals = new List<string>();
            Dictionary<int, string> habitsDictionary = new Dictionary<int, string>() { {1,"dance" },{2,"sing" },{3,"journal" },{4,"sleep" },{5,"eat" },{6,"meditate" },{7,"work" },{8,"exercise" },{9,"social Media" },{10,"Pray" },{11,"games" }
        };
            Console.WriteLine("What is your name ?");
            var player = new Player(Console.ReadLine());

            var levelOne = new LevelOne(player);

            Console.WriteLine("Hi {0}", player.Name);
            Console.WriteLine("List 5 goals you have - hit enter after each goal");
           
            while (goals.Count < 5)
            {
                goals.Add(Console.ReadLine());
                
            }
            Console.WriteLine("Play level one to help you achieve {0}", goals[0]);

           


            Console.WriteLine("Let's begin");
            Console.WriteLine("_________________");
            Console.WriteLine("Write the numbers of the habits you do,please enter after each number and type - done, when you are done selecting");
            bool selectingHabits = true;
            while (selectingHabits)
            {
                foreach (var item in habitsDictionary)
                {
                    Console.WriteLine("{0} - {1}", item.Key, item.Value);
                }
                var selectedNumber = Console.ReadLine();
                if (selectedNumber == "done")
                {
                    selectingHabits = false;
                }
                else
                {
                    var habit = habitsDictionary[int.Parse(selectedNumber)];
                    player.SetHabitToTrue(habit);
                    levelOne.GetScore(habit);
                }
            }

            levelOne.DisplayResults();
          
          

            Console.ReadKey();
           
        }
    }
}