using System;
using System.Globalization;

class MainClass
{
    public static void Main(string[] args)
    {
        var arr = new int[,] { { 8, -90, 167, 0, 776 }, { -6, 19, -1000, 28, -15 } };
        int temp = 0;
        for (int i = 0; i <= arr.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= arr.GetUpperBound(1); j++)
                for (int k = j+1; k <= arr.GetUpperBound(1); k++)
                if (arr[i, j] > arr[i, k])
                    {
                        temp = arr[i, k];
                        arr[i, k] = arr[i,j];
                        arr[i, j] = temp;
                        Console.Write(arr[i, j] + "");
                    }
            Console.WriteLine();
        }
    }
}