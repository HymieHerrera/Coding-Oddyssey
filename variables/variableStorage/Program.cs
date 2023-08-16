

string firstName = string.Empty;
string lastName = string.Empty;
var fullName = firstName + lastName;
int? age = null;
bool isAlive = true;

Console.WriteLine("What is your first name?");
firstName = Console.ReadLine();
Console.WriteLine("What is your surname?");
lastName = Console.ReadLine();
Console.WriteLine(fullName);

Console.WriteLine();
Console.WriteLine($"Pleasure to meet you {fullName}");
Console.WriteLine("What is your age?");
age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Oh so you are {age} years old");

Console.WriteLine(isAlive);