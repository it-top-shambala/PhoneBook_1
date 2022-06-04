namespace PhoneBook.App;

public class PhoneBookItem
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Patronymic { get; set; }
    public List<Phone> _phones;
    public List<Address> _addresses;
    public List<string> _groups;

    public PhoneBookItem()
    {
        FirstName = null;
        LastName = null;
        Patronymic = null;
        _phones = new List<Phone>();
        _addresses = new List<Address>();
        _groups = new List<string>();  
    }




}
