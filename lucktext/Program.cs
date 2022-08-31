string name = "";
string language = "";
string day = "";

EnterName:
Console.WriteLine("Please enter your name:");
name = Console.ReadLine();
if (name == "")
{
    goto EnterName;
}

EnterLanguage:
Console.WriteLine($"hello, {name}.\nWhat's your favourite programming language?");
language = Console.ReadLine();
if (language == "")
{
    goto EnterLanguage;
}

EnterDay:
Console.WriteLine("What day is it?");
day = Console.ReadLine();
if (day == "")
{
    goto EnterDay;
}

Console.WriteLine($"On {day}, {name} said that their favourite programming language is {language}.");
Console.WriteLine("\nPress Enter to end program");
Console.ReadLine();