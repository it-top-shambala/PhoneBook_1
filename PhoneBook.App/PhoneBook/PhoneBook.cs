using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class PhoneBookItem

    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public List<Phone> Phones { get; set; }
        public List<Address> Addresses{ get; set; }
        public List<string> Groups { get; set; }

        public PhoneBookItem()
        {
            Phones = new List<Phone>();
            Addresses = new List<Address>();
            Groups = new List<string>();
        }
    }
}
