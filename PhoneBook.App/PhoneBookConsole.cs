using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.App
{
    internal class PhoneBookConsole
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
            Console.WriteLine($"{address._addressBodyType}:  {address._addressBody}");
        }

        public static void DataAddition(ref PhoneBookItem phoneBookItem)
        {
            Console.Write("Фамилия: ");
            phoneBookItem.FirstName = Console.ReadLine();

            Console.Write("Имя: ");
            phoneBookItem.LastName = Console.ReadLine();

            Console.Write("Отчество: ");
            phoneBookItem.Patronymic = Console.ReadLine();

            ConsoleKeyInfo key;

            do
            {

                Console.Write("Номер телефона: ");
                string? phone = Console.ReadLine();
                

                Console.Write("Тип телефона:");
                string? type = Console.ReadLine();
                
                phoneBookItem._phones.Add(new Phone(ref type, ref phone));

                Console.WriteLine("Добавить ещё один номер телефона? Y/N");
                key = Console.ReadKey();

                Console.WriteLine();
            } while (key.Key == ConsoleKey.Y);

            do
            {

                Console.Write("Введите адрес: ");
                string? address = Console.ReadLine();


                Console.Write("Тип адреса:");
                string? type = Console.ReadLine();

                phoneBookItem._addresses.Add(new Address(ref type, ref address));

                Console.WriteLine("Добавить ещё один адрес? Y/N");
                key = Console.ReadKey();

                Console.WriteLine();
            } while (key.Key == ConsoleKey.Y);

            do
            {
                Console.WriteLine("Введите группу : ");
                phoneBookItem._groups.Add(Console.ReadLine());
                Console.WriteLine("Добавить еще одину группу? Y/N");
                key = Console.ReadKey();
                Console.WriteLine();
            } while (key.Key == ConsoleKey.Y);

        }

        public static void AddPhoneNumber(ref Phone phone)
        {
            Console.Write("Номер телефона: ");
            phone._number = Console.ReadLine();

            Console.Write("Тип телефона: ");
            phone._phoneType = Console.ReadLine();
        }
    }
}
