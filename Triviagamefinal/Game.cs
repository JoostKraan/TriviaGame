using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Triviagamefinal;
namespace TriviaGame
{
    public class Game
    {
        Program Program = new Program();
        Program user = new Program();
        Question question = new Question();
        CatagoryQuestions geoQuest = new CatagoryQuestions();
        int lives = 3;
        int score = 0;
        List<Question> vragenLijst = new List<Question>();
        public void resetConsole()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public void Start()
        {
            Console.Clear();
            Console.SetCursorPosition(85, 0);
            Console.WriteLine("- Welcome to my Trivia game! -");
            Console.SetCursorPosition(85, 2);
            Console.WriteLine("- You can choose between 3 categories and one mixed category -");
            Console.SetCursorPosition(85, 4);
            Console.WriteLine("1) Geography"); 
            Console.SetCursorPosition(85, 6);
            Console.WriteLine("2) C# Questions");
            Console.SetCursorPosition(85, 8);
            Console.WriteLine("3) Gaming related Questions");
            Console.SetCursorPosition(85, 10);
            Console.WriteLine("4) Mix");
            Console.SetCursorPosition(85, 12);
            Console.WriteLine("5) Go back to main menu...");
            int bTomain = int.Parse(Console.ReadLine());
            if (bTomain == 1)
            {
                Console.Clear();
                Play();
                Console.ReadLine();
            }
            else if (bTomain == 2)
            {
                geoQuest.GetgeoQuestions();
            }
            else if (bTomain == 3)
            {
                //getGameQuestions();
            }
            void Play()
            {
                vragenLijst = geoQuest.GetgeoQuestions();
                lives = 3;
                askGeoQuestions();
            }
            void askGeoQuestions()
            {
                vragenLijst = geoQuest.GetgeoQuestions();
                Random rnd = new Random();
                int questCount = vragenLijst.Count;
                for (int i = 0; i < questCount; i++)
                {
                    int questionIndex = rnd.Next(0, vragenLijst.Count);
                    Question currentQuestion = vragenLijst[questionIndex];
                    Console.WriteLine(currentQuestion.Name);
                    vragenLijst.Remove(currentQuestion);
                    foreach (Answers antwoord in currentQuestion.Answers)
                    {
                        Console.WriteLine($"- {antwoord.Title}");
                    }
                    string answer = Console.ReadLine();
                    foreach (Answers antwoord in currentQuestion.Answers)
                    {
                        if (answer == antwoord.Title)
                        {
                            if (antwoord.isCorrect == false)
                            {
                                lives--;
                                Console.Clear();
                                Console.SetCursorPosition(85, 0);
                                Console.WriteLine("Antwoord is fout");
                                Console.SetCursorPosition(85, 5);
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.Clear();
                                score++;
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.SetCursorPosition(85, 0);
                                Console.WriteLine("Antwoord is goed");
                                Console.SetCursorPosition(85, 5);
                                Console.WriteLine($"Je Score is nu : {score}");
                                Console.SetCursorPosition(85, 10);
                                Console.ReadLine();
                            }
                        }
                    }
                }
            }
        }
    }
}
