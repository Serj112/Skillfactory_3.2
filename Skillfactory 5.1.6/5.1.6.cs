using System;

class MainClass
{
    public static void Main()
    {
        GetArrayFromConsole();
    }

    static int[] GetArrayFromConsole()
    {
        var result = new int[5];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }
        int a = 0;
        for (int i = 0; i < result.Length; i++)
            for (int j = i + 1; j < result.Length; j++)
                if (result[i] > result[j])
                {
                    a = result[i];
                    result[i] = result[j];
                    result[j] = a;
                }

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }

        return result;
    }
}
