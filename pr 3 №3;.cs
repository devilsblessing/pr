using System;

class SQLCommand
{
    private string commandText;

    public string CommandText
    {
        get { return commandText; }
        set { commandText = value.ToUpper(); }
    }

    public SQLCommand(string text)
    {
        CommandText = text;
    }
}

class Program
{
    static void Main(string[] args)
    {
        SQLCommand sqlCommand = new SQLCommand("select * from customers");

        Console.WriteLine("SQL Query: " + sqlCommand.CommandText);
    }
}