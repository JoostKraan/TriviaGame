﻿using System;
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
        Program Program = new Program();
        Program user = new Program();
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
                askGeoQuestions(score, lives);

                Console.ReadLine();
            }
            else if (bTomain == 2)
            {

            }
            else if (bTomain == 3)
            {

            }

            void Failed()
            {
                Console.SetCursorPosition(85, 0);
                Console.WriteLine("Seems like you dont have any lives left...");
                Console.SetCursorPosition(85, 2);
                Console.WriteLine("The cause of you failing will mostly have to do with you having a skill issue.");
                Console.SetCursorPosition(85, 4);
                Console.ReadLine();

            }
            void Results()
            {
                Console.SetCursorPosition(85, 0);
                Console.WriteLine("Here we have the Results for your previous game you played.");
                Console.SetCursorPosition(85, 2);
                Console.WriteLine($"score : {score}");
                Console.SetCursorPosition(85, 4);
                Console.WriteLine($"Lives you had left : {lives}");
                if (score < 0)
                {

                    Console.SetCursorPosition(85, 6);
                    Console.WriteLine("You didn't get any points that game....");
                    Console.SetCursorPosition(85, 8);
                    Console.WriteLine("Impressive?");
                    Console.SetCursorPosition(85, 10);
                }
                else if (score == 5)
                {
                    Console.SetCursorPosition(85, 6);
                    Console.WriteLine("You got halfway there!");
                    Console.SetCursorPosition(85, 8);
                    Console.WriteLine("Thats great but you can do better.");
                    Console.SetCursorPosition(85, 10);
                }
                else if (score == 10)
                {
                    Console.SetCursorPosition(85, 6);
                    Console.WriteLine("That was a perfect game 10/10");
                    Console.SetCursorPosition(85, 8);
                    Console.WriteLine("You seem to be Extremely intelligent for answering these very difficult questions.");
                    Console.SetCursorPosition(85, 10);
                }
            }
            void askGeoQuestions(int lives, int score)
            {
                lives = 3;
                score = 0;
                questionList = geoQuest.GetgeoQuestions();
                Random rnd = new Random();
                int questCount = questionList.Count;
                for (int i = 0; i < questCount; i++)
                {
                    int questionIndex = rnd.Next(0, questionList.Count);
                    Question currentQuestion = questionList[questionIndex];
                    Console.WriteLine(currentQuestion.Name);
                    questionList.Remove(currentQuestion);
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
                                Console.WriteLine("Answer is Wrong");
                                Console.SetCursorPosition(85, 5);
                                Console.WriteLine($"Your score is now : {score}");
                                Console.SetCursorPosition(85, 10);
                                Console.WriteLine($"You have {lives} Lives Left!");
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else
                            {
                                score++;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Blue;
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
                    }
                }
            }
        }
    }
}
