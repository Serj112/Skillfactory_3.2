using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int age = 28;
        Console.WriteLine("Ваш возраст - {0}", age);
        ChangeAge(age);
        Console.WriteLine(age);
        Console.ReadLine();
    }
    static void ChangeAge(int age)
    {
        Console.WriteLine("Введите возраст");
        age = int.Parse(Console.ReadLine());
    }
}