using System;
using System.Collections.Generic;

class MyIntList
{
    private List<int> list = new List<int>();

    public int Count
    {
        get { return list.Count; }
    }

    public void Add(int value)
    {
        list.Add(value);
    }

    public int this[int index]
    {
        get { return list[index]; }
        set { list[index] = value; }
    }
}

class practice3_zadanie4
{
    static void Main(string[] args)
    {
        MyIntList myList = new MyIntList();
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);

        Console.WriteLine("Количество элементов в списке: " + myList.Count);

        for (int i = 0; i < myList.Count; i++)
        {
            Console.WriteLine("Элемент " + i + ": " + myList[i]);
        }
    }
}