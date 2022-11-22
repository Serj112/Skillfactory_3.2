using System;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

class Zadaniye
{
    static (string name, string secname, double age, int petnumber) EnterUser()
    {
        (string name, string secname, double age, int petnumber) user;



        Console.WriteLine("Введите имя");
        user.name = Console.ReadLine();

        Console.WriteLine("Введите фамилию");
        user.secname = Console.ReadLine();

        Console.WriteLine("Введите возраст цифрами");
        double.TryParse(Console.ReadLine(), out user.age);

        while (user.age <= 0)
        {
            Console.WriteLine("Неверный возраст. Введите верные данные");
            user.age = double.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("Введите количество питомцев");
        int.TryParse(Console.ReadLine(), out user.petnumber);

        while (user.petnumber < 0)
        {
            Console.WriteLine("Неверное количество питомцев. Введите верные данные");
            user.age = double.Parse(Console.ReadLine());
        }


        return user;
    }

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
                Console.ForegroundColor = ConsoleColor.Black;
                break;
        }
        return (color);

    }


    static string[] PetDetails(int numpet)
    {
        if(numpet<=0)
        {
            Console.WriteLine("У вас нет питомцев");
            return new string[] { };
        }

        Console.WriteLine("Введите клички питомцев");

        var klichka = new string[numpet];
        for (int i = 0; i < numpet; i++)
        {
            klichka[i] = Console.ReadLine();
        }
        return klichka;
    }

    /*static bool CheckNum(string number, out int corrnumber)
    {
        if (int.TryParse(number, out int intnum))
        {
            if (intnum > 0)
            {
                corrnumber = intnum;
                return false;
            }
        }
        {
            corrnumber = 0;
            return true;
        }
    }*/


    static void Main(string[] args)
    {
        var user = EnterUser();

        var klichkas = PetDetails(user.petnumber);


        Console.WriteLine("Введите количество любимых цветов");
        int favcolnumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите ваши любимые цвета.");
        var favcolors = new string[favcolnumber];
        for (int i = 0; i < favcolors.Length; i++)
        {
            favcolors[i] = ShowColor();
        }

        Console.WriteLine("Итак.\nВаше имя - {0}. \nВаша фамилия - {1}. \nВаш возраст - {2}. \nКоличество ваших питомцев - {3}", user.name, user.secname, user.age, user.petnumber);
        
        if (user.petnumber > 0)
        {
            Console.WriteLine("Клички ваших питомцев:");
            foreach (var klichka in klichkas)
            {
                Console.WriteLine(klichka);
            }

        }

        else
            Console.WriteLine("У вас нет питомцев");

        Console.WriteLine("Ваши любимые цвета");

        foreach (var color in favcolors)
        {
            Console.WriteLine(color);
        }
    }
}