using System;

class MainClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число, которое желаете возвести степень");
        int chislo = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите степень");
        byte stepen = byte.Parse(Console.ReadLine());

        Console.WriteLine(PowerUp(chislo, stepen));
        
    }


    private static int PowerUp(int N, byte pow)
    {
        if (pow == 0)
            return 1;
        else if (pow == 1)
            return N;
        else
        {
            int i = Convert.ToInt32(Math.Pow(N, pow));
            return i;
        }
    }
}