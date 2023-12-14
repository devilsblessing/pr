using System;

class TransportVehicle
{
    public string Name { get; set; }
    public int MaxSpeed { get; set; }
}

class PolitechCar : TransportVehicle
{
    public void PlayBadMusicLoudly()
    {
        Console.WriteLine("Громко включаем плохую музыку!");
    }
}

class Airplane : TransportVehicle
{
    public void DustField()
    {
        Console.WriteLine("Опыляем поле!");
    }
}

class ConcreteMixer : TransportVehicle
{
    public void MixConcrete()
    {
        Console.WriteLine("Мешаем бетон!");
    }
}

class practice6_zadanie2
{
    static void Main()
    {
        PolitechCar car = new PolitechCar { Name = "Политех-машина", MaxSpeed = 200 };
        car.PlayBadMusicLoudly();

        Airplane plane = new Airplane { Name = "Самолёт", MaxSpeed = 1000 };
        plane.DustField();

        ConcreteMixer mixer = new ConcreteMixer { Name = "Бетономешалка", MaxSpeed = 50 };
        mixer.MixConcrete();

        Console.ReadKey(true);
    }
}