using System;
using System.IO;

namespace UsernameParser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gather input from the user and set variables
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your github username?");
            string username = Console.ReadLine();

            // Logging the details to a file named "userlog.csv" in the same directory as the executable.(Logging is not currently working will revisit Saturday)
            string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss},{name},{age},{username}";
            File.AppendAllText("userlog.csv", logEntry + Environment.NewLine);

            // Output the details to the console
            Console.WriteLine($"Your name is {name}, you are {age} years old, and your github username is {username}.");
        }
    }
}
