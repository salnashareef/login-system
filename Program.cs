using System;
namespace LoginSystemMiniProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string correctUsername = "admin";
            string correctPassword = "1234";
            int attempts = 3;

            Console.WriteLine("==== LOGIN SYSTEM ====");
            while (attempts > 0)
            {
                Console.WriteLine("ENTER USERNAME: ");
                string username = Console.ReadLine();
                Console.WriteLine("ENTER PASSWORD:");
                string password = Console.ReadLine();
                if (username == correctUsername && password == correctPassword)
                {
                    Console.WriteLine("LOGIN SUCCESSFULL !!! WELCOME " + username);
                    break;
                }
                else
                {
                    attempts--;
                    Console.WriteLine($"LOGIN FAILED !!! ATTEMPTS LEFT : {attempts}");
                }
                if (attempts == 0)
                {
                    Console.WriteLine("ALL ATTEMPTS USED ...... EXITING PROGRAM");
                }


            }
            Console.WriteLine("PRESS ANY KEY TO EXIT .......");
            Console.ReadKey();
        }
    }
}