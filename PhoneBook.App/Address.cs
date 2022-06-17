namespace PhoneBook.App;

public class Address
{
    //public string Type;
    public string? _addressBody { get; set; }
    public string? _addressBodyType;

    public Address()
    {
        this._addressBodyType = null;
        this._addressBody = null;
    }

    public Address(ref string addressBodyType, ref string addressBody)
    {
        this._addressBodyType = addressBodyType;
        this._addressBody = addressBody;
    }

}
