using System;
using System.Globalization;

class MainClass
{
    static string ShowColor(string name)
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
        return (color);

    }
    public static void Main(string[] args)
    {
        {
            var (name, age) = ("Сергей", 28);
            Console.WriteLine("Моё имя - {0}", name);
            Console.WriteLine("Мой возраст - {0}", age);

            Console.WriteLine("Введите своё имя");
            name = Console.ReadLine();
            Console.WriteLine("Введите свой возраст цифрами");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваше имя - {0}", name);
            Console.WriteLine("Ваш возраст - {0}", age);

            Console.WriteLine("Введите три своих любимых цвета.");
            var favcolors = new string[3];
            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor(name);
            }

            Console.WriteLine("{0} Ваши любимые цвета", name);

            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
        }
    }
}