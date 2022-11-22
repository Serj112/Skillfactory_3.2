using System;

class Pen
{
    public string color;
    public int cost;

    public void vivod()
    {
        Console.WriteLine("Цвет ручки - {0}, стоимость ручки - {1}", color, cost);
    }

    public Pen()
    {
        color = "Черный";
        cost = 100;
    }

    public Pen(string penColor, int penCost)
    {
        color = penColor;
        cost = penCost;
    }

    static void Main(string[] args)
    {
        Pen pen = new Pen();
        pen.vivod();

        pen = new Pen("Желтый", 500);
        pen.vivod();
    }

}