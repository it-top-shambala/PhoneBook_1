namespace PhoneBook.App;

public class Phone
{
    public string? _number;
    public string? _phoneType;

    public Phone()
    {
        this._number = null;
        this._phoneType = null;
    }

    public Phone(ref string type, ref string phoneNumber)
    {
        this._phoneType = type;
        this._number = phoneNumber;
    }

}
