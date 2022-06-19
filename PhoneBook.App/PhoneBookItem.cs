using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.App
{
    internal class PhoneBookItem
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public List<Phone> Phones { get; set; }
        public List<Addres> Addresses { get; set; }
        public List<string> Groups { get; set; }
        
        public PhoneBookItem()
        {
            Phones = new List<Phone>();
            Addresses = new List<Addres>();
            Groups = new List<string>();
        }
        
        public PhoneBookItem(string firstName, string lastName, string patronymic, List<Phone> phones, List<Addres> addresses, List<string> groups)
        {
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            Phones = phones;
            Addresses = addresses;
            Groups = groups;
        }
        

    }
}
