using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.App
{
    internal static class PhoneBookConsole
    {

        public static void AddConsole(PhoneBookItem phoneBook)
        {
            Console.Write("Введите имя абонента : ");
            phoneBook.FirstName = Console.ReadLine();
            Console.Write("Введите фамилию абонента : ");
            phoneBook.LastName = Console.ReadLine();
            Console.Write("Введите отчество абонента : ");
            phoneBook.Patronymic = Console.ReadLine();
            ConsoleKeyInfo key;
            do
            {
                Console.WriteLine("Введите телефон абонента : ");
                Console.Write("Type : ");
                string type = Console.ReadLine();
                Console.Write("Phone : ");
                string Phone = Console.ReadLine();
                phoneBook.Phones.Add(new Phone(type, Phone));

                Console.WriteLine("Добавить еще один телефон? y/n");
                key = Console.ReadKey();
                Console.WriteLine();
            } while (key.Key == ConsoleKey.Y);
            do
            {
                Console.WriteLine("Введите адресс абонента : ");
                Console.Write("Type : ");
                string type = Console.ReadLine();
                Console.Write("Addres : ");
                string adres = Console.ReadLine();
                phoneBook.Addresses.Add(new Addres(type, adres));

                Console.WriteLine("Добавить еще один адресс? y/n");
                key = Console.ReadKey();
                Console.WriteLine();
            } while (key.Key == ConsoleKey.Y);
            do
            {
                Console.WriteLine("Введите группу : ");
                phoneBook.Groups.Add(Console.ReadLine());
                Console.WriteLine("Добавить еще одину группу? y/n");
                key = Console.ReadKey();
                Console.WriteLine();
            } while (key.Key == ConsoleKey.Y);
        }
        /// <summary>
        /// Автоматическое заполнение класса
        /// </summary>
        /// <param name="size">Номер в записи колекции</param>
        public static void AddRand(PhoneBookItem phoneBook, int size)
        {

            phoneBook.FirstName = $"FirstName{size}";
            phoneBook.LastName = $"LastName{size}";
            phoneBook.Patronymic = $"Patronymic{size}";
            phoneBook.Phones.Add(new Phone($"Type{size}", $"Phone{size}"));
            phoneBook.Phones.Add(new Phone($"Type{size}+1", $"Phone{size}+1"));
            phoneBook.Addresses.Add(new Addres($"type{size}", $"adres{size}"));
            phoneBook.Addresses.Add(new Addres($"type{size}+1", $"adres{size}+1"));
            phoneBook.Groups.Add($"Group{size}");
            phoneBook.Groups.Add($"Group{size}+1");

        }
        /// <summary>
        /// Печать обекта класса
        /// </summary>
        public static void Print(PhoneBookItem phoneBook)
        {
            Console.WriteLine($"Фамилия {phoneBook.FirstName}\t" +
                $"Имя {phoneBook.LastName}\t" +
                $"Отчество {phoneBook.Patronymic}");
            Console.WriteLine("Телефоны : ");
            foreach (var item in phoneBook.Phones)
            {
                Console.WriteLine($"Type {item.Type}\t" + $"Number {item.Number}");
            }
            Console.WriteLine("Адрес : ");
            foreach (var item in phoneBook.Addresses)
            {
                Console.WriteLine($"Type {item.Type}\t" + $"Number {item.AddresBody}");
            }
            Console.WriteLine("Группы : ");
            foreach (var item in phoneBook.Groups)
            {
                Console.WriteLine($"Groups {item}");
            }
        }

    }
}
