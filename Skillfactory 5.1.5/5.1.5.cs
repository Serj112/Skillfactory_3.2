using System;
using System.Drawing;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

class MainClass
{
    static string ShowColor()
    {
        var color = Console.ReadLine();
        switch (color)
        {
            case ("red"):
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Your color is red!");
                break;

            case ("green"):
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Your color is green!");
                break;

            case ("cyan"):
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Your color is cyan!");
                break;

            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your color is yellow!");
                break;
        }
        return(color);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

        var favcolors = new string[3];
        for (int i = 0; i < favcolors.Length; i++)
        {
            favcolors[i] = ShowColor();
        }

        Console.WriteLine("Ваши любимые цвета");

        foreach (var color in favcolors)
        {
            Console.WriteLine(color);
        }

        Console.ReadLine();
    }
}