using System;
class Автомобиль
{
    private string name;
    private int maxSpeed;
    public Автомобиль(string _name)
    {
        name = _name;
    }
    public void ShowInfo()
    {
        Console.WriteLine("Название автомобиля: " + name);
        Console.WriteLine("Максимальная скорость: " + maxSpeed);
    }
    public void SetMaxSpeed(int speed)
    {
        maxSpeed = speed;
    }
}
class practice1
{
    static void Main(string[] args)
    {
        Автомобиль Машина1 = new Автомобиль("Corvette");
        Автомобиль Машина2 = new Автомобиль("Bugatti");
        Автомобиль Машина3 = new Автомобиль("McLaren");
        Автомобиль Машина4 = new Автомобиль("Ferarri");
        Машина1.SetMaxSpeed(320);
        Машина2.SetMaxSpeed(400);
        Машина3.SetMaxSpeed(340);
        Машина4.SetMaxSpeed(350);
        Машина1.ShowInfo();
        Машина2.ShowInfo();
        Машина3.ShowInfo();
        Машина4.ShowInfo();
    }
}