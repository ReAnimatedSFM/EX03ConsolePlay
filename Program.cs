using System;

namespace EX03ConsolePlay
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console layout
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WindowWidth = 120;
            Console.WindowHeight = 30;

            //Print
            Console.WriteLine();
            Console.WriteLine("Hvid, grøn");

            //Console color change
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;

            //Print
            Console.WriteLine();
            Console.WriteLine("Blå, gul");

            //beep
            Console.Beep(4000, 1000);
            Console.Beep(2000, 1500);
            
            Console.ReadKey();

        }
    }
}
