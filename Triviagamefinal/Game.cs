using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame
{

    public class Game
    {
        public  Program Program = new Program();
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
            Console.SetCursorPosition(85, 5);
            Console.WriteLine("- You can choose between 3 categories and one mixed category -");
            Console.SetCursorPosition(85, 10);
            Console.WriteLine("1) C# Questions");
            Console.SetCursorPosition(85, 12);
            Console.WriteLine("2) Geography and History");
            Console.SetCursorPosition(85, 14);
            Console.WriteLine("3) Gaming related Questions");
            Console.SetCursorPosition(85, 18);
            Console.WriteLine("4) Mix");
            Console.SetCursorPosition(85, 20);
            Console.WriteLine("5) Go back to main menu...");
            Console.SetCursorPosition(85, 22);
            int bTomain = int.Parse(Console.ReadLine());
            switch (bTomain)
            {
                case 1:
                    Console.Clear();
                    
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Clear();
                    Console.SetCursorPosition(85, 65);
                    Console.WriteLine("Put Data Here");
                    Console.SetCursorPosition(85, 70);
                    Console.ReadLine();
                    break;
                case 3:
                    Console.Clear();
                    Console.SetCursorPosition(85, 65);
                    Console.WriteLine("Put Data Here");
                    Console.SetCursorPosition(85, 70);
                    Console.ReadLine();
                    break;
                case 4:
                    Console.Clear();
                    Console.SetCursorPosition(85, 65);
                    Console.WriteLine("Put Data Here");
                    Console.SetCursorPosition(85, 70);
                    Console.ReadLine();
                    break;
                case 5:
                    Console.Clear();
                    Program.Menu();
                    break;
            }
        }
    }
}