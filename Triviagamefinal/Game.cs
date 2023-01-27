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
        public Game newGame = new Game();
        public Program user = new Program();
        public static void resetConsole()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public void Start()
        {

            Console.Clear();
            Console.WriteLine("                                                             - Welcome to my Trivia game! -");
            Console.WriteLine("                                                     - You can choose between 3 categories and one mixed category -");
            Console.WriteLine("");
            Console.WriteLine("                                                     1) C# Questions");
            Console.WriteLine("");
            Console.WriteLine("                                                     2) Geography and History");
            Console.WriteLine("");
            Console.WriteLine("                                                     3) Gaming related Questions");
            Console.WriteLine("");
            Console.WriteLine("                                                     4) Mix");
            Console.WriteLine();
            Console.WriteLine("                                                     5) Go back to main menu...");

            int bTomain = int.Parse(Console.ReadLine());

            switch (bTomain)
            {
                case 1:
                    Console.Clear();
                    
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Put Data Here");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Put Data Here");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Put Data Here");
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