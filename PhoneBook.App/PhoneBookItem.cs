using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.App
{
    internal class PhoneBookItem
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public List<Phone> Phones { get; set; }
        public List<Addres> Addresses { get; set; }
        public List<string> Groups { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public PhoneBookItem()
        {
            Phones = new List<Phone>();
            Addresses = new List<Addres>();
            Groups = new List<string>();
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="patronymic"></param>
        /// <param name="phones"></param>
        /// <param name="addresses"></param>
        /// <param name="groups"></param>
        public PhoneBookItem(string firstName, string lastName, string patronymic, List<Phone> phones, List<Addres> addresses, List<string> groups)
        {
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            Phones = phones;
            Addresses = addresses;
            Groups = groups;
        }
        /// <summary>
        /// Добовление членов класса с консоли
        /// </summary>
        public void AddConsole()
        {
            Console.Write("Введите имя абонента : ");
            this.FirstName = Console.ReadLine();
            Console.Write("Введите фамилию абонента : ");
            this.LastName = Console.ReadLine();
            Console.Write("Введите отчество абонента : ");
            this.Patronymic = Console.ReadLine();
            ConsoleKeyInfo key;
            do
            {
                Console.WriteLine("Введите телефон абонента : ");
                Console.Write("Type : ");
                string type = Console.ReadLine();
                Console.Write("Phone : ");
                string Phone = Console.ReadLine();
                this.Phones.Add(new Phone(type, Phone));

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
                this.Addresses.Add(new Addres(type, adres));

                Console.WriteLine("Добавить еще один адресс? y/n");
                key = Console.ReadKey();
                Console.WriteLine();
            } while (key.Key == ConsoleKey.Y);
            do
            {
                Console.WriteLine("Введите группу : ");
                this.Groups.Add(Console.ReadLine());
                Console.WriteLine("Добавить еще одину группу? y/n");
                key = Console.ReadKey();
                Console.WriteLine();
            } while (key.Key == ConsoleKey.Y);
        }

        /// <summary>
        /// Автоматическое заполнение класса
        /// </summary>
        /// <param name="size">Номер в записи колекции</param>
        public void AddRand(int size)
        {

            this.FirstName = $"FirstName{size}";
            this.LastName = $"LastName{size}";
            this.Patronymic = $"Patronymic{size}";
            this.Phones.Add(new Phone($"Type{size}", $"Phone{size}"));
            this.Phones.Add(new Phone($"Type{size}+1", $"Phone{size}+1"));
            this.Addresses.Add(new Addres($"type{size}", $"adres{size}"));
            this.Addresses.Add(new Addres($"type{size}+1", $"adres{size}+1"));
            this.Groups.Add($"Group{size}");
            this.Groups.Add($"Group{size}+1");

        }
        /// <summary>
        /// Печать обекта класса
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"Фамилия {this.FirstName}\t" +
                $"Имя {this.LastName}\t" +
                $"Отчество {this.Patronymic}");
            Console.WriteLine("Телефоны : ");
            foreach (var item in this.Phones)
            {
                Console.WriteLine($"Type {item.Type}\t" + $"Number {item.Number}");
            }
            Console.WriteLine("Адрес : ");
            foreach (var item in this.Addresses)
            {
                Console.WriteLine($"Type {item.Type}\t" + $"Number {item.AddresBody}");
            }
            Console.WriteLine("Группы : ");
            foreach (var item in this.Groups)
            {
                Console.WriteLine($"Groups {item}");
            }
        }
    }
}
