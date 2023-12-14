using System;
using System.Text.RegularExpressions;

interface IFilter
{
    string Execute(string textLine);
}

class DigitFilter : IFilter
{
    public string Execute(string textLine)
    {
        return Regex.Replace(textLine, "[0-9]", "");
    }
}

class LetterFilter : IFilter
{
    public string Execute(string textLine)
    {
        return Regex.Replace(textLine, "[a-zA-Z]", "");
    }
}

class practice5_zadanie3
{
    static void Main()
    {
        DigitFilter digitFilter = new DigitFilter();
        LetterFilter letterFilter = new LetterFilter();

        string input = "a1b2c3d4e5f6";

        Console.WriteLine("Original: " + input);
        Console.WriteLine("Filtered Digits: " + digitFilter.Execute(input));
        Console.WriteLine("Filtered Letters: " + letterFilter.Execute(input));

        Console.ReadKey(true);
    }
}