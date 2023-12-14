using System;

class SmsMessage
{
    private string messageText;
    private double price;
    private int maxLength;
    private double basePrice;
    private double pricePerChar;

    public string MessageText
    {
        get { return messageText; }
        set
        {
            if (value.Length > maxLength)
            {
                messageText = value.Substring(0, maxLength);
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

    public SmsMessage(string text, int maxLength = 250, double basePrice = 1.5, double pricePerChar = 0.5)
    {
        this.maxLength = maxLength;
        this.basePrice = basePrice;
        this.pricePerChar = pricePerChar;
        MessageText = text;
    }

    private void CalculatePrice()
    {
        int length = messageText.Length;
        if (length <= maxLength)
        {
            price = basePrice;
        }
        else
        {
            int extraCharacters = length - maxLength;
            price = basePrice + (extraCharacters * pricePerChar);
        }
    }
}

class practice3_zadanie5
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите текст сообщения:");
        string text = Console.ReadLine();

        SmsMessage sms = new SmsMessage(text);

        Console.WriteLine($"Стоимость сообщения: {sms.Price} рублей");
    }
}