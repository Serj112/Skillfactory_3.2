using System;
using System.Drawing;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

class MainClass
{ 
    static string ShowColor()
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