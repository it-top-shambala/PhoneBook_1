using System;
using System.Collections.Generic;
/*
Написать программу для реализации "абстрактной" телефонной книги.

    Программа должна уметь:

добавлять данные с клавиатуры
выводить весь список данных
удалять данные
искать по разным полям
*/
namespace PhoneBook.App
{
    
    internal static class Program
    {
        private static void Main()
        {
            List<PhoneBookItem> phoneBook = new List<PhoneBookItem>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter firstname: ");
                string? firstname = Console.ReadLine();
                Console.WriteLine("Enter lastname: ");
                string? lastname = Console.ReadLine();
                Console.WriteLine("Enter Patronymic: ");
                string? patronymic = Console.ReadLine();
                Console.WriteLine("Enter phone Type: ");
                string? phoneType = Console.ReadLine();
                Console.WriteLine("Enter phone Number: ");
                string? phoneNumber = Console.ReadLine();
                Phone phone = new Phone() { Type = phoneType, Number = phoneNumber };
                Console.WriteLine("Enter adress information: ");
                Address address = new Address() { Type = Console.ReadLine(), AddressBody = Console.ReadLine() };
                Console.WriteLine("Enter groups: ");
                string? groups = Console.ReadLine();
                phoneBook.Add(
                    new PhoneBookItem(
                        firstname,
                        lastname,
                        patronymic,
                        phone,
                        address,
                        groups
                    )
                );
            }
            Console.WriteLine();
            ConsoleWrite.PrintToConsoleList(phoneBook);
            Console.WriteLine("Enter id to remove: ");
            string? id = Console.ReadLine();
            //will be invoked method Equals!
            phoneBook.Remove(new PhoneBookItem(id));
 
            Console.WriteLine("New one: ");
            ConsoleWrite.PrintToConsoleList(phoneBook);
            Console.WriteLine("Enter value to find object");
            string? ValueToFind = Console.ReadLine();
            PhoneBookItem findingItem = phoneBook.Find(x => x.IsContain(AttributeEnum.Firstname, ValueToFind));
            Console.WriteLine("Finding item: ");
            ConsoleWrite.PrintToConsolePhoneItem(findingItem);
        }
    }
}
