using System;
using System.Drawing;
using System.Globalization;

class MainClass
{
    public static void Main(string[] args)
    {
        (string name, string lastname, string login, int loglength, bool pet,int age, string [] colors) User;
        for (int k = 0; k < 3; k++)
        {
            Console.WriteLine("Введите своё имя");
            User.name = Console.ReadLine();
            Console.WriteLine("Введите свою фамилию");
            User.lastname = Console.ReadLine();
            Console.WriteLine("Введите свой логин");
            User.login = Console.ReadLine();
            User.loglength = User.login.Length;
            Console.WriteLine("Есть ли у вас домашнее животное? Да или Нет");
            var result = Console.ReadLine();
            if (result == "Да")
                User.pet = true;
            else
                User.pet = false;
            Console.WriteLine("Введите ваш возраст");
            User.age = Convert.ToInt32(Console.ReadLine());
            User.colors = new string[3];
            Console.WriteLine("Введите три ваших любимых цвета");
            for (int i = 0; i < User.colors.Length; i++)
            {
                User.colors[i] = Console.ReadLine();
            }
        }
    }
}