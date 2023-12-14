using System;
using System.Collections.Generic;
using System.Linq;

class RandomNumberGenerator
{
    private List<int> numbers = new List<int>();
    private Random random = new Random();

    public List<int> GetNumbers()
    {
        return numbers;
    }

    public void GenerateNumbers(int length, int min, int max)
    {
        numbers.Clear();
        for (int i = 0; i < length; i++)
        {
            numbers.Add(random.Next(min, max + 1));
        }
    }

    public double CalculateMean()
    {
        return numbers.Count > 0 ? numbers.Average() : 0;
    }

    public double CalculateVariance()
    {
        return numbers.Count > 1 ? numbers.Select(x => Math.Pow(x - CalculateMean(), 2)).Average() : 0;
    }

    public double CalculateStandardDeviation()
    {
        return Math.Sqrt(CalculateVariance());
    }

    public int CalculateMedian()
    {
        List<int> sortedNumbers = new List<int>(numbers);
        sortedNumbers.Sort();
        int middle = sortedNumbers.Count / 2;

        if (sortedNumbers.Count % 2 == 0)
        {
            return (sortedNumbers[middle - 1] + sortedNumbers[middle]) / 2;
        }
        else
        {
            return sortedNumbers[middle];
        }
    }
}

class practice3_zadanie6
{
    static void Main(string[] args)
    {
        RandomNumberGenerator generator = new RandomNumberGenerator();
        generator.GenerateNumbers(15, 5, 500);

        Console.WriteLine("Сгенерированные числа: " + string.Join(", ", generator.GetNumbers()));
        Console.WriteLine("Среднее значение: " + generator.CalculateMean());
        Console.WriteLine("Дисперсия: " + generator.CalculateVariance());
        Console.WriteLine("Среднеквадратическое отклонение: " + generator.CalculateStandardDeviation());
        Console.WriteLine("Медиана: " + generator.CalculateMedian());
    }
}