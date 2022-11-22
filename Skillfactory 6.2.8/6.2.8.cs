using System;


static void Main(string[] args)
{

    Rectangle rect = new Rectangle();
    rect.Square();

    rect = new Rectangle(2);
    rect.Square();

    rect = new Rectangle(9, 4);
    rect.Square();

    Console.ReadKey();
}
class Rectangle
{  

    public int a;
    public int b;

    public int Square()
    {
        return a * b;
    }

    public Rectangle()
    {
        a = 6;
        b = 4;
    }

    public Rectangle(int first, int second)
    {
        a = first;
        b = second;
    }

    public Rectangle(int side)
    {
        a = side;
        b = side;
    }
}