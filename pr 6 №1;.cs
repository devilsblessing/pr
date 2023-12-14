using System;
using System.IO;

class Phone
{
    public string Model { get; set; }
    public string Number { get; set; }

    public Phone(string model, string number)
    {
        Model = model;
        Number = number;
    }

    public void Call(string number)
    {
        Console.WriteLine($"Вызов по номеру {number}");
        WriteToLog($"Вызов {number}");
    }

    protected void WriteToLog(string text)
    {
        File.AppendAllText("log.txt", $"{Model}, {DateTime.Now}: {text}\n");
    }
}

class Smartphone : Phone
{
    public double CameraResolution { get; set; }

    public Smartphone(string model, string number, double cameraResolution) : base(model, number)
    {
        CameraResolution = cameraResolution;
    }

    public void Shoot()
    {
        Console.WriteLine("Снимок сделан");
        WriteToLog("Снимок сделан");
    }
}

class practice6_zadanie1
{
    static void Main()
    {
        Phone myHomePhone = new Phone("Nokia 3110", "88001234576");
        myHomePhone.Call("85672537414");

        Smartphone myWorkPhone = new Smartphone("iPhone 13", "8800553535", 80.5);
        myWorkPhone.Call("112");
        myWorkPhone.Shoot();

        Console.ReadKey(true);
    }
}