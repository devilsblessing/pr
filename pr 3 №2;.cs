using System;

class SmsMessage
{
    private string messageText;
    private double price;

    public string MessageText
    {
        get { return messageText; }
        set
        {
            if (value.Length > 250)
            {
                messageText = value.Substring(0, 250);
            }
            else
            {
                messageText = value;
            }
            CalculatePrice();
        }
    }

    public double Price
    {
        get { return price; }
    }

    public SmsMessage(string text)
    {
        MessageText = text;
    }

    private void CalculatePrice()
    {
        int length = messageText.Length;
        if (length <= 65)
        {
            price = 1.5;
        }
        else
        {
            int extraCharacters = length - 65;
            price = 1.5 + (extraCharacters * 0.5);
        }
    }
}

class practice3_zadanie2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите текст сообщения:");
        string text = Console.ReadLine();

        SmsMessage sms = new SmsMessage(text);

        Console.WriteLine($"Стоимость сообщения: {sms.Price} рублей");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Color myColor = new Color(255, 0, 0);
        myColor.PrintColor();
    }
}