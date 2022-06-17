using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.App
{
    public class Address
    {
        public string Type { get; set; }
        public string AddressType { get; set; }
         public Address(string type, string addressType)

         {
              Type = type;
              AddressType = addressType;
         }
        public override string ToString()
        {
            return $"\t{Type}: {AddressType}";
        }
    }
       

}
