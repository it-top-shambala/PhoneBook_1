using System;
using System.Collections.Generic;

namespace PhoneBook.App
{
    class Program
    {
        static void Main()
        {
            bool inCreation = true;

            List<PhoneBookItem> phoneBook = new List<PhoneBookItem>();
            
            //Пока почти никакой фильтрации входящих данных, кроме самой простейшей. Все остальное на чистой совести пользователя.
            while(inCreation)
            {
                string tempFirstName, tempSecondName, tempPatronymic;
                List<Phone> tempPhones = new List<Phone>();
                List<Address> tempAddresses = new List<Address>();
                List<string> tempGroups = new List<string>();

                Console.WriteLine("Добавление в телефонную книгу:\nВведите имя: ");
                tempFirstName = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Добавление в телефонную книгу:\nВведите фамилию: ");
                tempSecondName = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Добавление в телефонную книгу:\nВведите отчество: ");
                tempPatronymic = Console.ReadLine();
                Console.Clear();

                bool addingPhones = true;
                while(addingPhones)
                {
                    Phone tempPhone = new Phone();
                    string choose;

                    Console.WriteLine("Добавление в телефонную книгу:\nВведите код региона: ");
                    tempPhone.Type = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Добавление в телефонную книгу:\nВведите телефон: ");
                    tempPhone.Number = Console.ReadLine();
                    Console.Clear();
                    if (!tempPhones.Contains(tempPhone))
                        tempPhones.Add(tempPhone);
                    else
                        Console.WriteLine("Такой телефон уже есть");

                    Console.WriteLine("Хотите добавить еще один номер?\n(n\\N для выхода)");
                    choose = Console.ReadLine();
                    if (choose == "n" || choose == "N")
                        addingPhones = false;
                    Console.Clear();
                }
                bool addingAddresses = true;
                while (addingAddresses)
                {
                    Address tempAddress = new Address();
                    string choose;

                    Console.WriteLine("Добавление в телефонную книгу:\nВведите тип адреса: "); //что бы это ни было
                    tempAddress.Type = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Добавление в телефонную книгу:\nВведите адрес: ");
                    tempAddress.AddressBody = Console.ReadLine();
                    Console.Clear();
                    if (!tempAddresses.Contains(tempAddress))
                        tempAddresses.Add(tempAddress);
                    else
                        Console.WriteLine("Такой адрес уже есть");

                    Console.WriteLine("Хотите добавить еще один адрес?\n(n\\N для выхода):");
                    choose = Console.ReadLine();
                    if (choose == "n" || choose == "N")
                        addingAddresses = false;
                    Console.Clear();
                }

                string groupChoose;
                Console.WriteLine("Хотите добавить пользователя в какую-нибудь группу?\n(Y\\y для подтверждения):");
                groupChoose = Console.ReadLine();
                Console.Clear();
                if (groupChoose == "y" || groupChoose == "Y")
                {
                    bool addingGroups = true;
                    while (addingGroups)
                    {
                        string tempGroup;
                        string choose;

                        Console.WriteLine("Добавление в телефонную книгу:\nВведите группу: "); //что бы это ни было
                        tempGroup = Console.ReadLine();
                        Console.Clear();
                        if (!tempGroups.Contains(tempGroup))
                            tempGroups.Add(tempGroup);
                        else
                            Console.WriteLine("Такая группа уже присвоена");

                        Console.WriteLine("Хотите добавить еще одну грппу?\n(n\\N для выхода):");
                        choose = Console.ReadLine();
                        if (choose == "n" || choose == "N")
                            addingGroups = false;
                        Console.Clear();
                    }
                }
                //Наконец добавляем новую запись в телефонную книгу
                phoneBook.Add(new PhoneBookItem(tempFirstName, tempSecondName, tempPatronymic, tempPhones, tempAddresses, tempGroups));

                string recordingContinue;
                Console.WriteLine("В телефонную книгу успешно добавлена новая запись.\nХотите добавить еще одну?\n(n\\N для выхода):");
                recordingContinue = Console.ReadLine();
                if (recordingContinue == "n" || recordingContinue == "N")
                    inCreation = false;
                Console.Clear();
            }

            Console.WriteLine($"Ваша телефонная книга выглядит так и состоит из {phoneBook.Count} записей:");
            foreach (PhoneBookItem item in phoneBook)
                item.print();


            //List уже содержит все методы для работы с PhoneBookItem (удаление, фильтрация, добавление данных). Для нее нужно писать разве что интерфейс и реализацию в WPF
            //Потому я просто приведу в пример пару операций тут.
            string filterGroup;
            Console.WriteLine("Давайте произведем поиск по группам.\nВведите группу, по которой вы хотите отфильтровать список:");
            filterGroup = Console.ReadLine();

            Console.Clear();
            foreach (PhoneBookItem item in phoneBook)  
            {
                foreach (string stringItem in item.Groups)
                {
                    if (stringItem == filterGroup)
                        item.print();
                }
            }

            string recordLastName; //объявляю отдельно, потому что будет использоваться в еще одном примере.

            string deleteGroup;
            Console.WriteLine("Давайте удалим какую-нибудь группу.\nВведите фамилию пользователя, у которого хотели бы удалить:");
            recordLastName = Console.ReadLine();
            Console.WriteLine("\nВведите группу, которую хотели бы удалить:");
            deleteGroup = Console.ReadLine();
            Console.Clear();
            foreach (PhoneBookItem item in phoneBook)
            {
                if (item.LastName == recordLastName)
                    item.Groups.Remove(deleteGroup); //точно так же можно добавить/удалить запись из списка телефонов, адресов и даже из самой телефонной книги.
            }

            Console.WriteLine($"Ваша телефонная книга выглядит так и состоит из {phoneBook.Count} записей:");
            foreach (PhoneBookItem item in phoneBook)
                item.print();

        }
        private static void PrintPhoneBook(List<PhoneBookItem> phoneBook)
        {

        }
    }
}
