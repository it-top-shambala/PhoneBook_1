using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.App
{
   
    internal class Addres
    {
        public string Type { get; set; }
        public string AddresBody { get; set; }

        public Addres()
        {
        }
        
        public Addres(string type, string addresBody)
        {
            Type = type;
            AddresBody = addresBody;
        }

    }
}
