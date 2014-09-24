using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame
{
    class Program
    {
        static List<Trivia> QuestionList;
        static void Main(string[] args)
        {
            //The logic for your trivia game happens here
            QuestionList = GetTriviaList();
            List<Trivia> AllQuestions = GetTriviaList();
            Console.WriteLine("Hello, welcome to SeedPaths Trivia Game!  What is your name?");
            string input = Console.ReadLine();
            Console.WriteLine("Hello, " + input + " lets play!");
            Console.WriteLine("You will be asked random trivia questions and depending on your answer, you will be told if you are right or wrong.");

            int turnsLeft = 5;
            int questionsRight = 0;

            while (questionsRight <= 5000 || turnsLeft >= 0)
            {
                int score = 0;
                Random newTrivia = new Random();
                int number = newTrivia.Next(0, QuestionList.Count());
                Trivia output = QuestionList[number];
                Console.WriteLine(newTrivia.Tell());
                Console.WriteLine("Enter your answer");
                string answer = Console.ReadLine().ToLower();
                if (answer == newTrivia.Tell())
                {

                    Console.WriteLine("You have answered: " + score + "correctly, and you still have: " + turnsLeft + " turns left.");
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {

                    Console.WriteLine("You have answered: " + score + "correctly, and you still have: " + turnsLeft + " turns left.");

                    Console.WriteLine("The correct answer is: " + newTrivia.Tell());
                    turnsLeft--;
                    if (turnsLeft == 4)
                    {
                        Console.WriteLine("You have only used one turn. you still have 4 left!");
                    }
                    else if (turnsLeft == 3)
                    {
                        Console.WriteLine("You still have three turns left!");
                    }
                    else if (turnsLeft == 2)
                    {
                        Console.WriteLine("Two turns left!");
                    }
                    else if (turnsLeft == 1)
                    {
                        Console.WriteLine("Only one turn left!");
                    }
                }
            }
        }


        //This functions gets the full list of trivia questions from the Trivia.txt document
        static List<Trivia> GetTriviaList()
        {
            //Get Contents from the file.  Remove the special char "\r".  Split on each line.  Convert to a list.
            List<string> contents = File.ReadAllText("trivia.txt").Replace("\r", "").Split('\n').ToList();

            //Each item in list "contents" is now one line of the Trivia.txt document.
            
            //make a new list to return all trivia questions
            List<Trivia> returnList = new List<Trivia>();
            // TODO: go through each line in contents of the trivia file and make a trivia object.
            //       add it to our return list.
            // Example: Trivia newTrivia = new Trivia("what is my name?*question");
            //Return the full list of trivia questions
            return returnList;
        }
         }
        static void AddHighScore(int playerscore)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            ForrestEntities db = new ForrestEntities();

            HighScore newHighScore = new HighScore();
            newHighScore.Name = playername;
            newHighScore.Date = DateTime.Now;
            newHighScore.Game = "Trivia";
            newHighScore.Score = playerscore;

            db.HighScores.Add(newHighScore);

            db.Save();
        }
        static void DisplayHighScore()
    {
            Console.WriteLine("High Scores");
            Console.WriteLine("---------------------------------");
            Console.WriteLine();

            ForrestEntities db = new ForrestEntities();
            List<HighScore> HighScoreList = db.HighScores.Where(x => x.Game == "Trivia").OrderBy(x => x.Score).Take(10).ToList();

            foreach (HighScore highscore in HighScoreList)
	{
		    Console.WriteLine("{0}, {1} Took {2} tries to win! {3}", HighScoreList.IndexOf(highscore) + 1, highscore.Score, highscore.Date.Value.ToShortDateString());
	}
    }
}
    }
}
