namespace PhoneBook.App;

public class Address
{
    public string Type { get; set; }
    public string AddressBody { get; set; }
    
    public Address(){}
    public Address(string type, string addressBody)
    {
        Type = type;
        AddressBody = addressBody;
    }
    public void Print()
    {
        Console.WriteLine($"Type: {Type + Environment.NewLine}  AddressBody: {AddressBody + Environment.NewLine}");
    }
}
