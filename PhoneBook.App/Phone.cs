namespace PhoneBook.App;

public class Phone
{
    //public string Type { get; set; }
    public string? _number;
    public PhoneType? _phoneType;

    public enum PhoneType
    {
        home,
        cell
    }

    public Phone()
    {
        this._number = null;
        this._phoneType = null;
    }

}
