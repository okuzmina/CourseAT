using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first row: ");
            string row1 = Console.ReadLine();

            Console.Write("\r\nEnter second row: ");
            string row2 = Console.ReadLine();

            Console.Write("\r\nEnter character: ");
            char ch = Console.ReadKey().KeyChar;

            while (Char.IsControl(ch))
            {
                Console.Write("Symbol is required! Try again: ");
                ch = Console.ReadKey().KeyChar;
            }

            string conc = row1 + row2;
            int lastIndex = conc.LastIndexOf(ch);

            Console.WriteLine();
            if (lastIndex < 0)
                Console.WriteLine("\nSymbol " + ch + " is not found in " + conc);
            else
                Console.WriteLine("\nIndex of " + ch + " in " + conc + ": " + lastIndex);
            Console.ReadKey();
        }
    }
}
