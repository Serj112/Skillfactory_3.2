using System;
using System.Globalization;

class MainClass
{
    public static void Main(string[] args)
    {
        var arr = new int[,] { {8, -90, 167, 0, 776 }, { -6, 19, -1000, 28, -15} };
        int kolich = 0;
        for (int i = 0; i <= arr.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= arr.GetUpperBound(1); j++)
                if (arr[i,j] > 0)
                    kolich++;
        }
        Console.WriteLine("Kolichestvo polozhitelnih chisel = {0}", kolich);
    }
}