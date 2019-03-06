using System;

namespace Calculator
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
            double operand1 = 0, operand2 = 0;

            Console.Write("Enter first operand: ");
            operand1 = Check();

            Console.Write("\r\nEnter second operand: ");
            operand2 = Check();

            Console.Write("\nEnter operation: ");
            char operation = Console.ReadKey().KeyChar;
            switch (operation)
            {
                case '+':
                    Console.WriteLine("\n{0} + {1} = {2}", operand1, operand2, operand1 + operand2);
                    break;
                case '-':
                    Console.WriteLine("\n{0} - {1} = {2}", operand1, operand2, operand1 - operand2);
                    break;
                case '/':
                    Console.WriteLine("\n{0} / {1} = {2}", operand1, operand2, operand1 / operand2);
                    break;
                case '*':
                    Console.WriteLine("\n{0} * {1} = {2}", operand1, operand2, operand1 * operand2);
                    break;
                case '^':
                    Console.WriteLine("\n{0} ^ {1} = {2}", operand1, operand2, Math.Pow(operand1, operand2));
                    break;
                default:
                    Console.WriteLine("\nEntered operation doesn't exist.");
                    break;
            }

            Console.ReadLine();
        }
    }
}