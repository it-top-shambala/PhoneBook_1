using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.App
{
    public class PhoneBook
    {
        public List<PhoneBookItem> PhoneBooksItem { get; set; }

        public PhoneBook()
        {
            PhoneBooksItem = new List<PhoneBookItem>();
        }

        public void Add(PhoneBookItem item)
        {
            PhoneBooksItem.Add(item);
        }

        public void Remove(PhoneBookItem item)
        {
            PhoneBooksItem.Remove(item);
        }

        public override string ToString()
        {
            return string.Join("\n", PhoneBooksItem);
        }
    }
    
}

