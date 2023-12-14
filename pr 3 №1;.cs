using System;

class Color
{
    public int Red { get; set; }
    public int Green { get; set; }
    public int Blue { get; set; }

    public Color(int red, int green, int blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }

    public void PrintColor()
    {
        Console.WriteLine($"RGB({Red}, {Green}, {Blue})");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Color myColor = new Color(255, 0, 0);
        myColor.PrintColor();
    }
}