using System;

class Orc
{
    private static int totalGoldCarriedByAllOrcs = 0;
    private static int numberOfOrcs = 0;
    private int goldCarried;

    public int GoldCarried
    {
        get { return goldCarried; }
        set { goldCarried = value; }
    }

    public Orc()
    {
        numberOfOrcs++;
        if (numberOfOrcs <= 5)
        {
            totalGoldCarriedByAllOrcs += 2;
            goldCarried = totalGoldCarriedByAllOrcs;
        }
        else
        {
            goldCarried = totalGoldCarriedByAllOrcs - (numberOfOrcs - 5) * 2;
            totalGoldCarriedByAllOrcs -= 2;
        }
    }
}

class practice4_zadanie3
{
    static void Main()
    {
        Orc orc1 = new Orc();
        Orc orc2 = new Orc();
        Orc orc3 = new Orc();
        Orc orc4 = new Orc();
        Orc orc5 = new Orc();
        Orc orc6 = new Orc();
        Orc orc7 = new Orc();

        Console.WriteLine($"Золото, переносимое первыми пятью орками: {orc1.GoldCarried}");
        Console.WriteLine($"Золото, переносимое оставшимися орками: {orc6.GoldCarried}");

        Console.ReadKey(true);
    }
}