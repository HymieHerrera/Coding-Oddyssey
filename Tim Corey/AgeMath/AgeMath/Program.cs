using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeMath
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your age?\n");
            string ageText = Console.ReadLine();

            int.TryParse(ageText, out int age);

            int futureAge = (age + 25);
            int pastAge = (age - 25);

            Console.WriteLine($"Your age in 25 years will be {futureAge} years old.");
            Console.WriteLine($"Your age 25 years ago was {pastAge} years old.");
        }
    }
}
