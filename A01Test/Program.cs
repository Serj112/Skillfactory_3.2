
/*

Console.WriteLine(Calculator.Sum(1, 2));
Console.WriteLine(Calculator.Minus(1, 2));
Console.WriteLine(Calculator.Умножить(1, 2));
Console.WriteLine(Calculator.Разделить(1, 2));
Console.WriteLine(Calculator.Умножить(1, "2"));
Console.WriteLine(Calculator.Умножить(1, "asfsfdgdfghdfgdfg"));

*/
var t = new List<int>();
foreach (var m in Enumerable.Range(0, 25))
    if (m == 2 || m == 5 || (m > 7 && m < 11) || m == 20) t.Add(m);
PrintArr(t.ToArray(), Enumerable.Range(1, 15).ToArray());


foreach (var m in Enumerable.Range(0, 5))
{
    var n = double.TryParse(Console.ReadLine(), out var kkk) ? kkk : double.MaxValue;
    Console.WriteLine(n);
}

void PrintArr(int[] xx, int[] yy)
{
    foreach (var y in yy)
    {
        foreach (var x in xx)
            Console.Write(y * x + " ");

        Console.WriteLine();
    }
}




//for (int i = 0; i < 5; i++)





public static class Calculator
{
    public static double Sum(double a, double b)
    {
        return a + b;
    }

    public static double Minus(double a, double b)
    {
        return a - b;
    }

    public static double Умножить(double a, double b)
    {
        return a * b;
    }
    public static double Умножить(double a, string b)
    {
        return a * (double.TryParse(b, out var b1) ? b1 : 0);
    }
    public static double Разделить(double a, double b)
    {
        return a / b;
    }


}



