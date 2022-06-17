using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.App
{
   public class Phone
    {
        public string Type { get; set; }
        public string Number { get; set; }
        public Phone(string type,string number)
        {
            Type = type;
            Number = number;
        }
        public override string ToString()
        {
            return $"\t{Type}: {Number}";
        }

    }
}
