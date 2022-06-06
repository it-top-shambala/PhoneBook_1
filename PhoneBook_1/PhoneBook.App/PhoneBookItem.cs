
namespace PhoneBook.App;


public  class PhoneBookItem
{
    public static string FirstName { get; set; }
    public static string LastName { get; set; }
    public static string Patronymic { get; set; }
    public static List<Phone> Phones { get; set; }
    public static List<Address> Addresses { get; set; }
    public static List<string> Groups { get; set; }


    public PhoneBookItem()
    {
        Phones = new List<Phone>();
        Addresses = new List<Address>();
        Groups = new List<string>();
    }
    public PhoneBookItem(string lastName, string firstName,  string patronymic, List<Phone> phones,/*Type typeNumber,*/ List<Address> addresses, List<string> groups)
    {
        FirstName = firstName;
        LastName = lastName;
        Patronymic = patronymic;
        Phones = phones;
        //typeNumber = typeNumber;
        Addresses = addresses;
        Groups = groups;
    }
   
}
