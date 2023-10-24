// Plan and build a Console application that asks the user for their name and age.  If their name is Bob or Sue, address them as professor. If the person is under 21 years old, reccomend they wait x years to start this class.

//Const
const int AGE_TRESHOLD = 21;

//Initialize variables
string firstName = "";
int age = 0;

//Get variable values from input
Console.WriteLine("What is your first name?");
firstName = Console.ReadLine();


Console.WriteLine("What is your age?");
string agetext = Console.ReadLine();
int.TryParse(agetext, out age);


//Conditional that outputs depending on name and age.
if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
{
    Console.WriteLine("Welcome, professor!");
}
else
{
    Console.WriteLine($"Welcome, {firstName}!");
}

if (age < AGE_TRESHOLD)
    Console.WriteLine($"You're not old enough to take this class.  Please wait " + (AGE_TRESHOLD - age) + " years before taking this class");
else
    Console.WriteLine("Welcome to the class");


