using System;

namespace Task2
{
    class Program
    {
        static double Check()
        {
            int checkedInput = 0;
            string input = Console.ReadLine();

            while (!Int32.TryParse(input, out checkedInput))
            {
                Console.Write("Integer required! Try again: ");
                input = Console.ReadLine();
            }

            return checkedInput;
        }
        static void Main(string[] args)
        {
            double width = 0, height = 0, length = 0;

            Console.Write("Enter width: ");
            width = Check();

            Console.Write("\r\nEnter height: ");
            height = Check();

            Console.Write("\r\nEnter length: ");
            length = Check();

            var result = Math.Sqrt((Math.Pow(width,2) + Math.Pow(height,2) + Math.Pow(length,2)));

            Console.WriteLine();
            Console.Write("Parallelepiped diagonal length: " + result);
            Console.ReadKey();
        }
    }
}
