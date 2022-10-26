using System;

class MainClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter your age:");
        byte age = checked((byte)int.Parse(Console.ReadLine()));
        Console.WriteLine("Your name is {0} and age is {1} \n What is your favorite day of week?", name, age);
        DayOfWeek day = (DayOfWeek) int.Parse(Console.ReadLine());
        Console.WriteLine("Your favorite day is {0} \nEnter your birthdate:", day);
        var birthdate = Console.ReadLine();
        Console.WriteLine("Your birthdate is {0}", birthdate);
    }

}