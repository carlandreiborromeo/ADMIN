using System;

namespace LoginProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string correctUsername = "Admin";
            string correctPassword = "Admin1234!";
            int attemptsLeft = 3;

            while (attemptsLeft > 0)
            {
                Console.Write("Enter your username: ");
                string username = Console.ReadLine();

                Console.Write("Enter your password: ");
                string password = Console.ReadLine();

                if (username == correctUsername && password == correctPassword)
                {
                    Console.WriteLine("Login successful!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect username or password. Please try again.");
                    attemptsLeft--;
                    Console.WriteLine($"Attempts left: {attemptsLeft}");
                }
            }

            if (attemptsLeft == 0)
            {
                Console.WriteLine("You have exceeded the maximum number of attempts. Please try again later.");
            }

            Console.ReadLine(); 
        }
    }
}
