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
        this.FirstName = Console.ReadLine();
        this.LastName = Console.ReadLine();
        this.Patronymic = Console.ReadLine();
        _phones = new List<Phone>();
        _addresses = new List<Address>();
        _groups = new List<string>();

        _phones.Add(new Phone());

        Console.WriteLine(" 1 - Legal 2 - physical");

        int number = int.Parse(Console.ReadLine());

        switch(number)
        {
            case 1:
                _addresses.Add(new Address(Address.AddressBodyType.legal));
                break;
            case 2:
                _addresses.Add(new Address(Address.AddressBodyType.physical));
                break;
        }

        _groups.Add(Console.ReadLine());
    }



   public void PrintPhoneBookItem()
    {
        Console.WriteLine($"{FirstName} {LastName} {Patronymic}");

        for(int i = 0; i < _phones.Count; i++)
        {
            _phones[i].PrintPhone();
            Console.WriteLine();

            _addresses[i].PrintAddress();
            Console.WriteLine();

            Console.WriteLine($"{_groups[i]} ");
        }
      
    }
}
