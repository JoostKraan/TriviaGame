using System;
using TriviaGame;

namespace TriviaGame
{
    public class Program
    {
        public static string username;
        public static string age;
        public static Game game = new Game();


        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.Title = "Trivia Game";
            UserInput();
            Menu();
        }

        static void UserInput()
        {
            Console.SetCursorPosition(85, 0);
            Console.WriteLine("Welcome to my trivia game");
            Console.SetCursorPosition(85, 5);
            Console.WriteLine("Enter your name");
            Console.SetCursorPosition(85, 10);
            username = Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(85, 0);
            Console.WriteLine("Welcome to my trivia game");
            Console.SetCursorPosition(85, 5);
            Console.WriteLine($"Username = {username}");
            Console.Clear();
            Console.SetCursorPosition(85, 0);
            Console.WriteLine("Enter Age");
            Console.SetCursorPosition(85, 5);
            Console.WriteLine($"Username = {username}");
            Console.SetCursorPosition(85, 10);
            age = Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(85, 0);
            Console.WriteLine($"Username = {username}");
            Console.SetCursorPosition(85, 5);
            Console.WriteLine($"Age = { age}");
            Console.SetCursorPosition(85, 10);
            Console.WriteLine("Press any key to continue....");
            Console.SetCursorPosition(85, 15);
            Console.ReadLine();
        }
        public static void Menu()
        {
            Console.Clear();
            Console.SetCursorPosition(85, 0);
            Console.WriteLine("Username : " + username);
            Console.SetCursorPosition(85, 5);
            Console.WriteLine("Age : " + age);
            Console.SetCursorPosition(85, 7);
            Console.WriteLine("(1: Start");
            Console.SetCursorPosition(85, 9);
            Console.WriteLine("(2: Options");
            Console.SetCursorPosition(85, 11);
            Console.WriteLine("(3: How to play");
            Console.SetCursorPosition(85, 13);
            Console.WriteLine(" (4: Exit");
            Console.SetCursorPosition(85, 15);
            Console.WriteLine("(5: Change username and age");
            Console.SetCursorPosition(85, 17);
            Console.WriteLine("Select an option...");

            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                Console.Clear();
                Console.SetCursorPosition(85, 0);
                Console.WriteLine("Start");
                Console.SetCursorPosition(85, 5);
                Console.WriteLine("(1: Begin");
                Console.SetCursorPosition(85, 10);
                Console.WriteLine("(0: Back");
                Console.SetCursorPosition(85, 15);
                int startopt = int.Parse(Console.ReadLine());
                if (startopt == 0)
                {
                    Console.Clear();
                    Menu();
                    Console.Beep(300, 180);
                }
                else if (startopt == 1)
                {
                    Console.Clear();
                    game.Start();
                    Console.Beep(300, 180);
                }
            }
            else if (option == 2)
            {
                Console.Clear();
                Console.SetCursorPosition(85, 0);
                Console.WriteLine("Options");
                Console.SetCursorPosition(85, 5);
                Console.WriteLine("(1: Change Background Color");
                Console.SetCursorPosition(85, 10);
                Console.WriteLine("(2: Change Text Color");
                Console.SetCursorPosition(85, 15);
                Console.WriteLine("(b: Back...");
                Console.SetCursorPosition(85, 20);
                int option2b = char.Parse(Console.ReadLine());
                if (option2b == 'b')
                {
                    Menu();
                    Console.Beep(300, 180);
                }
                int optiontab = int.Parse(Console.ReadLine());
                if (optiontab == 1)
                {
                    Console.Clear();
                    Console.SetCursorPosition(85, 2);
                    Console.WriteLine("0  | Green");
                    Console.SetCursorPosition(85, 4);
                    Console.WriteLine("1  | Magenta");
                    Console.SetCursorPosition(85, 6);
                    Console.WriteLine("2  | Red");
                    Console.SetCursorPosition(85, 8);
                    Console.WriteLine("3  | Gray");
                    Console.SetCursorPosition(85, 10);
                    Console.WriteLine("4  | Cyan");
                    Console.SetCursorPosition(85, 12);
                    Console.WriteLine("5  | Black");
                    Console.SetCursorPosition(85, 14);
                    Console.WriteLine("6  | Blue");
                    Console.SetCursorPosition(85, 16);
                    Console.WriteLine("7  | Yellow");
                    Console.SetCursorPosition(85, 18);
                    Console.WriteLine("8  | DarkGreen");
                    Console.SetCursorPosition(85, 20);
                    Console.WriteLine("9  | DarkMagenta");
                    Console.SetCursorPosition(85, 22);
                    Console.WriteLine("10 | DarkRed");
                    Console.SetCursorPosition(85, 24);
                    Console.WriteLine("11 | DarkGray");
                    Console.SetCursorPosition(85, 26);
                    Console.WriteLine("12 | DarkCyan");
                    Console.SetCursorPosition(85,28 );
                    Console.WriteLine("13 | DarkBlue");
                    Console.SetCursorPosition(85, 30);
                    Console.WriteLine("14 | DarkYellow");
                    Console.SetCursorPosition(85, 32);
                    int optiontab2 = int.Parse(Console.ReadLine());

                    switch (optiontab2)
                    {
                        case (int)Colors.Green:
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Clear();
                            Console.Beep(380, 280);
                            Menu();
                            break;
                        case (int)Colors.Magenta:
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Magenta;
                            Console.Clear();
                            Console.Beep(380, 280);
                            Menu();
                            break;
                        case (int)Colors.Red:
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Clear();
                            Console.Beep(380, 280);
                            Menu();
                            break;
                        case (int)Colors.Gray:
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.Clear();
                            Console.Beep(380, 280);
                            Menu();
                            break;
                        case (int)Colors.Cyan:
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            Console.Clear();
                            Console.Beep(380, 280);
                            Menu();
                            break;
                        case (int)Colors.Black:
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.Beep(380, 280);
                            Menu();
                            break;
                        case (int)Colors.Blue:
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Clear();
                            Console.Beep(380, 280);
                            Menu();
                            break;
                        case (int)Colors.Yellow:
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.Clear();
                            Console.Beep(380, 280);
                            Menu();
                            break;
                        case (int)Colors.DarkGreen:
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.Clear();
                            Console.Beep(380, 280);
                            Menu();
                            break;
                        case (int)Colors.DarkMagenta:
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                            Console.Clear();
                            Console.Beep(380, 280);
                            Menu();
                            break;
                        case (int)Colors.DarkRed:
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.Clear();
                            Console.Beep(380, 280);
                            Menu();
                            break;
                        case (int)Colors.DarkGray:
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Console.Clear();
                            Console.Beep(380, 280);
                            Menu();
                            break;
                        case (int)Colors.DarkCyan:
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkCyan;
                            Console.Clear();
                            Console.Beep(380, 280);
                            Menu();
                            break;
                        case (int)Colors.DarkBlue:
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.Clear();
                            Console.Beep(380, 280);
                            Menu();
                            break;
                        case (int)Colors.DarkYellow:
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.Clear();
                            Console.Beep(380, 280);
                            Menu();
                            break;

                        default:
                            Console.Beep(590, 750);
                            break;
                    }
                }
                else if (optiontab == 2)
                {
                    Console.Clear();
                    Console.SetCursorPosition(85, 0);
                    Console.WriteLine("0  | Green");
                    Console.SetCursorPosition(85, 2);
                    Console.WriteLine("1  | Magenta");
                    Console.SetCursorPosition(85, 4);
                    Console.WriteLine("2  | Red");
                    Console.SetCursorPosition(85, 6);
                    Console.WriteLine("3  | Gray");
                    Console.SetCursorPosition(85, 8);
                    Console.WriteLine("4  | Cyan");
                    Console.SetCursorPosition(85, 10);
                    Console.WriteLine("5  | Black");
                    Console.SetCursorPosition(85, 12);
                    Console.WriteLine("6  | Blue");
                    Console.SetCursorPosition(85, 14);
                    Console.WriteLine("7  | Yellow");
                    Console.SetCursorPosition(85, 16);
                    Console.WriteLine("8  | DarkGreen");
                    Console.SetCursorPosition(85, 18);
                    Console.WriteLine("9  | DarkMagenta");
                    Console.SetCursorPosition(85, 20);
                    Console.WriteLine("10 | DarkRed");
                    Console.SetCursorPosition(85, 22);
                    Console.WriteLine("11 | DarkGray");
                    Console.SetCursorPosition(85, 24);
                    Console.WriteLine("12 | DarkCyan");
                    Console.SetCursorPosition(85, 26);
                    Console.WriteLine("13 | DarkBlue");
                    Console.SetCursorPosition(85, 28);
                    Console.WriteLine("14 | DarkYellow");
                    Console.SetCursorPosition(85, 30);
                    Console.WriteLine("b: Back...");
                    Console.SetCursorPosition(85, 32);
                    int optiontab3 = int.Parse(Console.ReadLine());

                    switch (optiontab3)
                    {
                        case (int)Colors.Green:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Clear();
                            Console.Beep(380, 280);
                            Menu();
                            break;
                        case (int)Colors.Magenta:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Clear();
                            Console.Beep(380, 280);
                            Menu();
                            break;
                        case (int)Colors.Red:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            Console.Beep(380, 280);
                            Menu();
                            break;
                        case (int)Colors.Gray:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Clear();
                            Console.Beep(380, 280);
                            Menu();
                            break;
                        case (int)Colors.Cyan:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Clear();
                            Console.Beep(380, 280);
                            Menu();
                            break;
                        case (int)Colors.Black:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.Beep(380, 280);
                            Menu();
                            break;
                        case (int)Colors.Blue:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Clear();
                            Console.Beep(380, 280);
                            Menu();
                            break;
                        case (int)Colors.DarkGreen:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Clear();
                            Console.Beep(380, 280);
                            Menu();
                            break;
                        case (int)Colors.DarkMagenta:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.Clear();
                            Console.Beep(380, 280);
                            Menu();
                            break;
                        case (int)Colors.DarkRed:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Clear();
                            Console.Beep(380, 280);
                            Menu();
                            break;
                        case (int)Colors.DarkGray:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Clear();
                            Console.Beep(380, 280);
                            Menu();
                            break;
                        case (int)Colors.DarkCyan:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Clear();
                            Console.Beep(380, 280);
                            Menu();
                            break;
                        case (int)Colors.DarkBlue:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.Clear();
                            Console.Beep(380, 280);
                            Menu();
                            break;
                        case (int)Colors.DarkYellow:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Clear();
                            Console.Beep(380, 280);
                            Menu();
                            break;

                        default:
                            Console.SetCursorPosition(85, 65);
                            Console.WriteLine("There is no color associated with that number");
                            Console.Beep(590, 750);
                            break;
                    }
                    int coloropt2 = char.Parse(Console.ReadLine());
                    if (coloropt2 == 'b')
                    {
                        Menu();
                        Console.Beep(300, 180);
                    }
                }
            }
            if (option == 3)
            {
                Console.Clear();
                Console.SetCursorPosition(85, 0);
                Console.WriteLine("How to play");
                Console.SetCursorPosition(85, 5);
                Console.WriteLine("Work in Progress...");
                Console.SetCursorPosition(85, 10);
                Console.WriteLine("(b: Back...");
                Console.SetCursorPosition(85, 12);
                Console.Beep(300, 180);
                int opt3b = char.Parse(Console.ReadLine());
                if (opt3b == 'b')
                {
                    Console.Clear();
                    Menu();
                }
            }

            else if (option == 4)
            {
                Console.Clear();
                Environment.Exit(0);

            }
            if (option == 5)
            {
                Console.Clear();
                UserInput();
                Menu();
            }
        }

    }
}





