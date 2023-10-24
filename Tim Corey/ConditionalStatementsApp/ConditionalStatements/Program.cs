// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

string firstName = "";
Console.WriteLine("What is your first name?");
firstName = Console.ReadLine();

if (firstName.ToLower() == "tim")
    Console.WriteLine("Hello, Professor");
else
    Console.WriteLine("Hello, Student");


