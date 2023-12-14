using System;
using System.Collections.Generic;

interface IAnimal
{
    void Voice();
}

class Dog : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Гав!");
    }
}

class Cat : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Мяу!");
    }
}

class Parrot : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Кар-кар!");
    }
}

class Elephant : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Ууууу!");
    }
}

class Snake : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Шшшш!");
    }
}

class practice5_zadanie1
{
    static void PetAnimal(IAnimal animal)
    {
        Console.WriteLine("Мы гладим зверюшку, а она нам говорит:");
        animal.Voice();
    }

    static void Main()
    {
        List<IAnimal> myAnimals = new List<IAnimal>();
        myAnimals.Add(new Dog());
        myAnimals.Add(new Cat());
        myAnimals.Add(new Parrot());
        myAnimals.Add(new Elephant());
        myAnimals.Add(new Snake());

        foreach (IAnimal animal in myAnimals)
        {
            PetAnimal(animal);
        }

        Console.ReadKey(true);
    }
}