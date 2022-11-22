using System;
using System.Drawing;
using System.Globalization;

class MainClass
{
    public static void Main(string[] args)
    {
        (string Name, string[] Dishes) User;
        {
            Console.WriteLine("Введите своё имя");
            User.Name = Console.ReadLine();
            User.Dishes = new string[5];
            Console.WriteLine("Введите пять ваших любимых блюд");
            for (int i = 0; i < User.Dishes.Length; i++)
            {
                User.Dishes[i] = Console.ReadLine();
            }
        }
    }
}