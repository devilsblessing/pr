using System;

interface IShape
{
    void Draw(int size);
}

class VerticalLine : IShape
{
    public void Draw(int size)
    {
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("|");
        }
    }
}

class HorizontalLine : IShape
{
    public void Draw(int size)
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
    }
}

class Square : IShape
{
    public void Draw(int size)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}

class practice5_zadanie4
{
    static void Main()
    {
        VerticalLine verticalLine = new VerticalLine();
        HorizontalLine horizontalLine = new HorizontalLine();
        Square square = new Square();

        Console.WriteLine("Vertical Line:");
        verticalLine.Draw(5);

        Console.WriteLine("\nHorizontal Line:");
        horizontalLine.Draw(10);

        Console.WriteLine("\nSquare:");
        square.Draw(6);

        Console.ReadKey(true);
    }
}