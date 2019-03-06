using System;

namespace Authentication
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "User1";
            string password = "qwe123";
            int counter = 3;

            while (counter > 0)
            {
                Console.Write("\rEnter login: ");
                string loginInput = Console.ReadLine();

                Console.Write("\rEnter password: ");
                string passwordInput = Console.ReadLine();

                if (login == loginInput && password == passwordInput)
                {
                    Console.WriteLine("\nYou have been successfully logged in");
                    break;
                }
                else
                {
                    Console.WriteLine("\rEntered login or password is invalid");
                    Console.WriteLine("\rAttempts remaining: {0}", --counter);
                    Console.WriteLine();
                    if (counter == 0)
                        Console.WriteLine("\rError: there are no more attempts left");
                }
            }

            Console.ReadKey();
        }
    }
}