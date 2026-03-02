
using System.ComponentModel;

namespace C__Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a triangle with "*"
            /*
             
            Console.Write("Please enter a number: ");
            int number  = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i < number; i++)
            {
                for(int  j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            */



            //------------------------------------------------------



            //Create a square
            /*
             
            Console.Write("Please enter a number: ");
            int length = Convert.ToInt32(Console.ReadLine());

            void lineFunc(int lenght)
            {
                for (int i = 0; i < length * 2; i++)
                {
                    Console.Write("-");
                }
            }


            lineFunc(length);
            Console.WriteLine();


            for (int j = 0; j < length; j++)
            {
                for (int i = 0; i < length; i++)
                {
                    if (i == 0)
                    {
                        Console.Write("|");
                    }

                    else if(i == length - 1)
                    {
                        Console.Write("|");
                        Console.WriteLine();
                    }

                    else
                    {
                        Console.Write("  ");
                    }
                }
            }

            lineFunc(length);

            */



            //---------------------------------------------------------------------



            //C# Game

            int x = 5;
            int y = 5;
            int rotX = 0;
            int rotY = 0;
            int oldX;
            int oldY;
            int objectX = 10;
            int objectY = 10;
            int point = 0;
            bool isContinue = true;
            bool isHaveObject = false;
            ConsoleKeyInfo key;

            Console.CursorVisible = false;

            do
            {
                Console.WriteLine("The arrows are movement buttons." +
                    "Pressing another button will change the transformation of the \"X\".");
                Console.WriteLine("Press \"Enter\" to play.");
                Console.WriteLine("Press \"Esc\" to exit after the game starts.");
                key = Console.ReadKey();
                Console.Clear();
            }
            while (key.Key != ConsoleKey.Enter);


            while (isContinue)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("O");

                if (!isHaveObject)
                {
                    objectX = new Random().Next(0, Console.WindowWidth);
                    objectY = new Random().Next(0, Console.WindowHeight);
                    Console.SetCursorPosition(objectX, objectY);
                    Console.Write("X");
                    isHaveObject = true;
                }

                if(objectX == x & objectY == y)
                {
                    point++;
                    isHaveObject = false;
                }

                if(Console.KeyAvailable)
                {
                    key = Console.ReadKey();

                    switch(key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            rotX = 0; rotY = -1;
                            break;

                        case ConsoleKey.DownArrow:
                            rotX = 0; rotY = 1;
                            break;

                        case ConsoleKey.LeftArrow:
                            rotX = -1; rotY = 0;
                            break;

                        case ConsoleKey.RightArrow:
                            rotX = 1; rotY = 0;
                            break;

                        case ConsoleKey.Escape:
                            Console.Clear();
                            Console.WriteLine("Quited the game.");
                            Console.WriteLine("Total points : " + point);
                            isContinue = false;
                            break;

                        default:
                            Console.Clear();
                            isHaveObject = false;
                            break;
                    }
                }

                oldX = x;
                oldY = y;

                x += rotX;
                y += rotY;

                x = Math.Clamp(x, 0, Console.WindowWidth - 1);
                y = Math.Clamp(y, 0, Console.WindowHeight - 1);
                Thread.Sleep(100);

                Console.SetCursorPosition(oldX, oldY);
                Console.Write(" ");

                Console.SetCursorPosition(110,0);
                Console.WriteLine("Points : " + point);
                
                for(int i = 0;i < 3;i++)
                {
                    Console.SetCursorPosition(109, i);
                    Console.WriteLine("|");
                }

                for (int i = 110; i < 120; i++)
                {
                    Console.SetCursorPosition(i, 2);
                    Console.WriteLine("_");
                }
            }









        }
    }
}
