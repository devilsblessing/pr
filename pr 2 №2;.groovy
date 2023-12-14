using System;

class NumberManager
{
    private int n;

    public bool SetNumber(int number)
    {
        if (number == n + 1)
        {
            n = number;
            return true;
        }
        else
        {
            n = 0;
            return false;
        }
    }

    public int GetExpectedNumber()
    {
        return n + 1;
    }
}

class pr2_zadanie2
{
    static void Main(string[] args)
    {
        NumberManager numberManager = new NumberManager();

        while (true)
        {
            Console.WriteLine($"Введите число {numberManager.GetExpectedNumber()}:");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            if (numberManager.SetNumber(inputNumber))
            {
                Console.WriteLine("Правильно!");
            }
            else
            {
                Console.WriteLine("Неправильное число. Попробуйте еще раз.");
            }
        }
    }
}