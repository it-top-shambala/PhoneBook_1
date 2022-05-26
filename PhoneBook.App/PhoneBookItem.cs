namespace PhoneBook.App;

public class PhoneBookItem
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Patronymic { get; set; }
    public List<Phone> Phones { get; set; }
    public List<Address> Addresses { get; set; }
    public List<string> Groups { get; set; }

    public PhoneBookItem()
    {
        Phones = new List<Phone>();
        Addresses = new List<Address>();
        Groups = new List<string>();
    }
}
