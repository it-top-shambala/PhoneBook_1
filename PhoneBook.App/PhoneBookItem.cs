using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.App
{

    public class PhoneBookItem
    {
         public string FirstName { get; set; }        
         public string LastName { get; set; }        
         public string Patronymic { get; set; }
         public List<Phone> Phones { get; set; }
         public List<Address> Addresses { get; set; }
         public List<string> Groups { get; set; }

      public PhoneBookItem(string firstName,string lastName,string patranamic)
      {
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patranamic;
            Addresses = new List<Address>();
            Phones = new List<Phone>();
            Groups = new List<string>();

      }
       
        public override string ToString()      
        {
            var fio = $"ФИО: {FirstName} { LastName} { Patronymic}";
            var addrs = $"Адреса:\n" + string.Join('\n', Addresses);          
            var phone = $"Телефоны:\n" + string.Join('\n', Phones);          
            var grp = $"Группы: " + string.Join(',', Groups);
            
            return $"{fio}\n{addrs}\n{phone}\n{grp}";     
        }
    }
}

