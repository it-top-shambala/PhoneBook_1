namespace PhoneBook.App;

public class Phone
{
    //public string Type { get; set; }
    public string? _number;
    public PhoneType? _phoneType = null;

    public enum PhoneType
    {
        home,
        cell
    }

    public Phone()
    {
        this._number = Console.ReadLine();
        
        if(_number != null)
        if(_number[0] == '+' || _number[0] == '8')
        {
            this._phoneType = PhoneType.cell;
        }
        else
        {
            this._phoneType = PhoneType.home;
        }
    }

    public void PrintPhone()
    {
        Console.WriteLine($"{_phoneType}:  {_number}");
    }
}
