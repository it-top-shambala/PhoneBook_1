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

    public Address()
    {
        this._addressBodyTape = null;
        this._addressBody = null;
    }

}
