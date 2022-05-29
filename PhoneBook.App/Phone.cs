﻿namespace PhoneBook.App;

public class Phone
{

    public string Type { get; set; }
    public string Number { get; set; }

    public Phone(){}
    public Phone(string type, string number)
    {
        Type = type;
        Number = number;
    }

    public void Print()
    {
        Console.WriteLine($"Type: {Type + Environment.NewLine}  Number: {Number + Environment.NewLine}");
    }
}
