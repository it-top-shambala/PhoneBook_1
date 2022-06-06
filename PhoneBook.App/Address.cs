using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.App
{
    class Address
    {
        public string Type { get; set; }
        public string AddressBody { get; set; }
        public void print()
        {
            Console.Write($"{Type}:{AddressBody}, ");
        }
        public static bool operator !=(Address left, Address right)
        {
            if (left.Type != right.Type || left.AddressBody != right.AddressBody)
                return true;
            else
                return false;
        }
        public static bool operator ==(Address left, Address right)
        {
            if (left.Type == right.Type || left.AddressBody == right.AddressBody)
                return true;
            else
                return false;
        }
    }
}
