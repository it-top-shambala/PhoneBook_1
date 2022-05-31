namespace PhoneBook.App;

public class Address
{
    //public string Type;
    public string? _addressBody { get; set; }
    public AddressBodyType? _addressBodyTape = null;

    public enum AddressBodyType
    {
        legal,
        physical
    }

    public Address(AddressBodyType addressBodyType)
    {
        this._addressBodyTape = addressBodyType;
        this._addressBody = Console.ReadLine();
    }

     public void PrintAddress()
    {
        Console.WriteLine($"{_addressBodyTape}:  {_addressBody}");
    }
}
