using System;
using System.Collections.Generic;

namespace PhoneBook.App
{
   internal static class Program
   {
        private static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();
            
            PhoneBookItem sidorov = new PhoneBookItem("Сидоров",
            "Семен", "Сидорович");

            Phone phone1 = new Phone("Сотовый телефон", "+89356784343");
            Phone phone2 = new Phone("Домашний телефон", "+123456");
            sidorov.Phones.Add(phone1);
            sidorov.Phones.Add(phone2);

            Address address1 = new Address("Домашниий адрес","г.Самара  ул.Лесная д.2 кв.87");
            Address address2 = new Address("Рабочий адрес", "г.Самара ул. Набережная 18");
            sidorov.Addresses.Add(address1);
            sidorov.Addresses.Add(address2);

            string group1 = "Коллеги";
            string group2 = "Друзья";
            sidorov.Groups.Add(group1);
            sidorov.Groups.Add(group2);

            phoneBook.Add(sidorov);

            Console.WriteLine(phoneBook);

            phoneBook.Remove(sidorov);

            Console.WriteLine(phoneBook);    
        }
    }
}
