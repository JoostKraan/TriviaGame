using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Triviagamefinal;
namespace TriviaGame
{
    public class Game
    {
        GameQuestions gamequestions = new GameQuestions();  
        Program Program = new Program();
        Question question = new Question();
        CatagoryQuestions geoQuest = new CatagoryQuestions();
        int lives = 3;
        int score = 0;
        List<Question> questionList = new List<Question>();
        public void resetConsole()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.SetCursorPosition(85, 0);
            Console.WriteLine("- Welcome to my Trivia game! -");
            Console.SetCursorPosition(80, 2);
            Console.WriteLine("- You can choose between 3 categories and one mixed category -");
            Console.SetCursorPosition(85, 6);
            Console.WriteLine("1) Geography");
            Console.SetCursorPosition(85, 10);
            Console.WriteLine("2) Games");
            Console.SetCursorPosition(85, 14);
            Console.WriteLine("3) History");
            Console.SetCursorPosition(85, 18);
            Console.WriteLine("4) Go back to main menu...");
            int bTomain = int.Parse(Console.ReadLine());
            if (bTomain == 1)
            {
                lives = 3;
                score = 0;
                Console.Clear();
                askGeoQuestions();
                result(score,lives);
            }
            else if (bTomain == 2)
            {
                lives = 3;
                score = 0;
                Console.Clear();
                askgameQuestions();
                result(score, lives);
            }
            else if (bTomain == 3)
            {
                lives = 3;
                score = 0;
                Console.Clear();
                askHistoryQuestions();
                result(score,lives);
            }
            else if (bTomain == 4)
            {
                Program.Menu();
            }
        }
        void askGeoQuestions()
        {
            questionList = geoQuest.GetgeoQuestions();
            Random rnd = new Random();
            int questCount = questionList.Count;
            for (int i = 0; i < questCount; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                int questionIndex = rnd.Next(0, questionList.Count);
                Question currentQuestion = questionList[questionIndex];
                Console.WriteLine(currentQuestion.Name);
                questionList.Remove(currentQuestion);
                foreach (Answers antwoord in currentQuestion.Answers)
                {
                    Console.ForegroundColor = ConsoleColor.White;
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
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(85, 0);
                            Console.WriteLine("Answer is Wrong");
                            Console.SetCursorPosition(85, 5);
                            Console.WriteLine($"Your score is now : {score}");
                            Console.SetCursorPosition(85, 10);
                            Console.WriteLine($"You have {lives} Lives Left!");
                            Console.ReadLine();
                            Console.Clear();

                            if (lives == 0)
                            {
                                Console.WriteLine("You don't seem to have any lives left...");
                                return;
                            }
                            if (score == 10)
                            {
                                return;
                            }
                        }
                        else
                        {
                            score++;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(85, 0);
                            Console.WriteLine("Answer is Correct");
                            Console.SetCursorPosition(85, 5);
                            Console.WriteLine($"Your score is now : {score}");
                            Console.SetCursorPosition(85, 10);
                            Console.WriteLine($"You have {lives} lives Left!");
                            Console.SetCursorPosition(85, 15);
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid");
                        Console.Clear();
                    }
                }
            }
        }
        void askgameQuestions()
        {
            questionList = gamequestions.getGameQuestions();
            Random rnd = new Random();
            int questCount = questionList.Count;
            for (int i = 0; i < questCount; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                int questionIndex = rnd.Next(0, questionList.Count);
                Question currentQuestion = questionList[questionIndex];
                Console.WriteLine(currentQuestion.Name);
                questionList.Remove(currentQuestion);
                foreach (Answers antwoord in currentQuestion.Answers)
                {
                    Console.ForegroundColor = ConsoleColor.White;
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
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(85, 0);
                            Console.WriteLine("Answer is Wrong");
                            Console.SetCursorPosition(85, 5);
                            Console.WriteLine($"Your score is now : {score}");
                            Console.SetCursorPosition(85, 10);
                            Console.WriteLine($"You have {lives} Lives Left!");
                            Console.ReadLine();
                            Console.Clear();
                            if (lives == 0)
                            {
                                Console.WriteLine("Seems like you have no lives left.");
                                return;
                            }
                            else if (score == 10)
                            {
                                return;
                            }
                        }
                        else
                        {
                            score++;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(85, 0);
                            Console.WriteLine("Answer is Correct");
                            Console.SetCursorPosition(85, 5);
                            Console.WriteLine($"Your score is now : {score}");
                            Console.SetCursorPosition(85, 10);
                            Console.WriteLine($"You have {lives} lives Left!");
                            Console.SetCursorPosition(85, 15);
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid");
                        Console.Clear();
                    }
                }
            }
        }
        void askHistoryQuestions()
        {
            questionList = geoQuest.GetgeoQuestions();
            Random rnd = new Random();
            int questCount = questionList.Count;
            for (int i = 0; i < questCount; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                int questionIndex = rnd.Next(0, questionList.Count);
                Question currentQuestion = questionList[questionIndex];
                Console.WriteLine(currentQuestion.Name);
                questionList.Remove(currentQuestion);
                foreach (Answers antwoord in currentQuestion.Answers)
                {
                    Console.ForegroundColor = ConsoleColor.White;
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
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(85, 0);
                            Console.WriteLine("Answer is Wrong");
                            Console.SetCursorPosition(85, 5);
                            Console.WriteLine($"Your score is now : {score}");
                            Console.SetCursorPosition(85, 10);
                            Console.WriteLine($"You have {lives} Lives Left!");
                            Console.ReadLine();
                            Console.Clear();
                            if (lives == 0)
                            {
                                Console.WriteLine("You don't seem to have any lives left...");
                                return;
                            }
                            else if (score == 10)
                            {
                                return;
                            }
                        }
                        else
                        {
                            score++;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(85, 0);
                            Console.WriteLine("Answer is Correct");
                            Console.SetCursorPosition(85, 5);
                            Console.WriteLine($"Your score is now : {score}");
                            Console.SetCursorPosition(85, 10);
                            Console.WriteLine($"You have {lives} lives Left!");
                            Console.SetCursorPosition(85, 15);
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid");
                        Console.Clear();
                    }
                }
            }
        }
        public void result(int score,int lives)
        {
            Console.Clear();
            Console.SetCursorPosition(85, 0);
            Console.WriteLine("Results");
            Console.SetCursorPosition(70, 5);
            Console.WriteLine($"Score : {score}");
            Console.SetCursorPosition(70, 7);
            Console.WriteLine($"Lives : {lives}");
            Console.SetCursorPosition(85, 12);
            if (score == 10)
            {
                Console.WriteLine("Perfect Score!");
            }
            else if (score < 10)
            {
                Console.WriteLine($"You don't seem to have any lives left so here are your results.");
            }
            Console.SetCursorPosition(85, 14);
            Console.ReadLine();
            Start();
        }
    }
}

