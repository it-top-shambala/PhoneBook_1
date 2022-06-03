using System;
namespace PhoneBook.App;

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
    public override string ToString()
    {
        return $"{Environment.NewLine} " +
               $"Type: {Type + Environment.NewLine}" +
               $"Number: {Number + Environment.NewLine}";
    }
}
