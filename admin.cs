using System;

namespace hayup
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
                Console.WriteLine("Enter username:");
                string usernameInput = Console.ReadLine();

                Console.WriteLine("Enter password:");
                string passwordInput = Console.ReadLine();

                if (usernameInput == correctUsername && passwordInput == correctPassword)
                {
                    Console.WriteLine("Login successful");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect username or password. Please try again.");
                    attemptsLeft--;
                    Console.WriteLine($"Attempts left: {attemptsLeft}");
                }

                if (attemptsLeft == 0)
                {
                    Console.WriteLine("Out of attempts. Please try again later.");
                }
            }
        }
    }
}

