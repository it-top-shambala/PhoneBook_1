using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.App
{
    internal static class PhoneBookConsole
    {
        public static void PrintPhoneBookItem(PhoneBookItem phoneBook)
        {
            Console.WriteLine($"{phoneBook.FirstName} {phoneBook.LastName} {phoneBook.Patronymic}");

            for (int i = 0; i < phoneBook._phones.Count; i++)
            {
                PrintPhone(phoneBook._phones[i]);
                Console.WriteLine();

                PrintAddress(phoneBook._addresses[i]);
                Console.WriteLine();

                Console.WriteLine($"{phoneBook._groups[i]} ");
            }

        }

        public static void PrintPhone(Phone phone)
        {
            Console.WriteLine($"{phone._phoneType}:  {phone._number}");
        }

        public static void PrintAddress(Address address)
        {
            Console.WriteLine($"{address._addressBodyTape}:  {address._addressBody}");
        }

    }
}
