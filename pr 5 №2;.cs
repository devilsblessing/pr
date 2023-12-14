using System;
using System.Collections.Generic;

interface IHello
{
    void SayHello();
}

class EnglishHello : IHello
{
    public void SayHello()
    {
        Console.WriteLine("Hello!");
    }
}

class FrenchHello : IHello
{
    public void SayHello()
    {
        Console.WriteLine("Bonjour!");
    }
}

class GermanHello : IHello
{
    public void SayHello()
    {
        Console.WriteLine("Hallo!");
    }
}

class practice5_zadanie2
{
    static void Main()
    {
        List<IHello> greetings = new List<IHello>
        {
            new EnglishHello(),
            new FrenchHello(),
            new GermanHello()
        };

        foreach (IHello greeting in greetings)
        {
            greeting.SayHello();
        }

        Console.ReadKey(true);
    }
}