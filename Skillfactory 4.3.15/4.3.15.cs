using System;
using System.Globalization;

class MainClass
{
    public static void Main(string[] args)
    {
        var arr = new int[] { -6, 19, -1000, 28, -15, 33, 4 };
        int kolich = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                kolich++;
            }
        }
        Console.WriteLine("Kolichestvo polozhitelnih chisel = {0}", kolich);
    }
}