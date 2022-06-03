
using System;
using System.Collections.Generic;
using System.Linq;
namespace PhoneBook.App;
public class PhoneBookItem
{
    private string GuId { get; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Patronymic { get; set; }
    public  List<Phone> Phones { get; set; } 
    public List<Address> Addresses { get; set; }
    public List<string> Groups { get; set; }
    
    public PhoneBookItem()
    {
        GuId = Guid.NewGuid().ToString("N");
        Phones = new List<Phone>();
        Addresses = new List<Address>();
        Groups = new List<string>();
    }
    /// <summary>
    /// Constructor which take Single item not List
    /// </summary>
    /// <param name="Id"></param>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    /// <param name="patronymic"></param>
    /// <param name="phones"></param>
    /// <param name="addresses"></param>
    /// <param name="groups"></param>
    public PhoneBookItem(string firstName, string lastName, string patronymic, Phone phones, Address addresses, string groups)
    {
        GuId = Guid.NewGuid().ToString("N");
        FirstName = firstName;
        LastName = lastName;
        Patronymic = patronymic;
        Phones = new List<Phone>() { phones };
        Addresses = new List<Address>() { addresses };
        Groups = new List<string>() { groups };
    }
    /// <summary>
    /// Constructor which take List as parametr
    /// </summary>
    /// <param name="guId"></param>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    /// <param name="patronymic"></param>
    /// <param name="phones"></param>
    /// <param name="addresses"></param>
    /// <param name="groups"></param>
    public PhoneBookItem(string firstName, string lastName, string patronymic, List<Phone> phones, List<Address> addresses, List<string> groups)
    {
        GuId = GuId = Guid.NewGuid().ToString("N");
        FirstName = firstName;
        LastName = lastName;
        Patronymic = patronymic;
        Phones = phones;
        Addresses = addresses;
        Groups = groups;
    }

    /// <summary>
    /// construtor for the find removing element => Equals will be compare id
    /// </summary>
    /// <param name="id"></param>
    public PhoneBookItem(string id)
    {
        GuId = id;
        Phones = new List<Phone>();
        Addresses = new List<Address>();
        Groups = new List<string>();
    }
    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        PhoneBookItem asBookItem = obj as PhoneBookItem;
        if (asBookItem == null) return false;
        else return Equals(asBookItem);
    }
    private bool Equals(PhoneBookItem obj)
    {
        if (obj == null) return false;
        return this.GuId.Equals(obj.GuId);
    }

    public override string ToString()
    {
        return $"{Environment.NewLine} " +
               $"Id: {GuId + Environment.NewLine}" +
               $" Firstname: {FirstName + Environment.NewLine}" +
               $" Lastname: {LastName + Environment.NewLine}" +
               $" Patronymic: {Patronymic + Environment.NewLine}";
    }

    /// <summary>
    /// Method for Find Element in different attribute
    /// </summary>
    /// <param name="attributeStruct">Struct for find needed attribute</param>
    /// <param name="element">element type string</param>
    /// <returns></returns>
    public bool IsContain(AttributeEnum attributeStruct,string element)
    {
        return attributeStruct switch
        {
            AttributeEnum.Guid => (GuId == element) ? true : false,
            AttributeEnum.Firstname => (FirstName == element) ? true : false,
            AttributeEnum.Lastname => (LastName == element) ? true : false,
            AttributeEnum.Patronymic => (Patronymic == element) ? true : false,
            AttributeEnum.Phone => Phones.Any(i => i.Number == element),
            AttributeEnum.Adress => Addresses.Any(i => i.AddressBody == element),
            AttributeEnum.Groups =>  Groups.Any(i => i == element),
        };
        return false;
    }
}
