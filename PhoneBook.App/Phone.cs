using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.App
{
    class Phone
    {
        public string Type { get; set; }
        public string Number { get; set; }

        public void print()
        {
            Console.Write($"+{Type}-{Number}, ");
        }

        public static bool operator !=(Phone left, Phone right)
        {
            if (left.Type != right.Type || left.Number != right.Number)
                return true;
            else
                return false;
        }
        public static bool operator ==(Phone left, Phone right)
        {
            if (left.Type == right.Type || left.Number == right.Number)
                return true;
            else
                return false;
        }
    }
}
