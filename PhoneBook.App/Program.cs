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

            phoneBook.Add(new PhoneBookItem());

            PrintPhoneBook(ref phoneBook);

            //DateDeletion(ref phoneBook);

            //PrintPhoneBook(ref phoneBook);

            SearchBuField(ref phoneBook);

        }

        /// <summary>
        /// Вывод списка на экран
        /// </summary>
        /// <param name="phoneBook">Телефонная книга</param>
        public static void PrintPhoneBook(ref List<PhoneBookItem> phoneBook)
        {

            for(int i = 0; i < phoneBook.Count; i++)
            {
                PhoneBookConsole.PrintPhoneBookItem(phoneBook[i]);
            }
        }

        /// <summary>
        /// Удаление данных по выбору
        /// </summary>
        /// <param name="phoneBook">Телефонная книга</param>
        public static void DateDeletion(ref List<PhoneBookItem> phoneBook)
        {
            Console.WriteLine("Что удалить?");
            Console.WriteLine("данные о пользователе - 1");
            Console.WriteLine("Номер телефона - 2");
            Console.WriteLine("Адрес - 3");

            int remove;
            int.TryParse(Console.ReadLine(), out remove);

            switch(remove)
            {
                case 1:
                    Console.Write("Фамилия: ");
                    string? firstName = Console.ReadLine();

                    if(firstName == null)
                    {
                        Console.WriteLine("Фамилия не введена");
                        return;
                    }

                    Console.Write("Имя: ");
                    string? lastName = Console.ReadLine();

                    if(lastName == null)
                    {
                        Console.WriteLine("Имя не введено");
                        return;
                    }

                    Console.Write("Отчество: ");
                    string? patronymic = Console.ReadLine();

                    if(patronymic == null)
                    {
                        Console.WriteLine("Отчество не введено");
                        return;
                    }

                    for(int i = 0; i < phoneBook.Count(); ++i)
                    {
                        if
                            (
                            phoneBook[i].FirstName == firstName &&
                            phoneBook[i].LastName == lastName &&
                            phoneBook[i].Patronymic == patronymic
                            )
                        {
                            phoneBook.RemoveAt(i);
                        }
                    }
                    break;
                case 2:
                    Console.Write("Номер телефона: ");
                    string? phoneNumber = Console.ReadLine();

                    if(phoneNumber == null)
                    {
                        Console.WriteLine("Номер телефона не был введен");
                        return;
                    }

                    for(int i = 0; i < phoneBook.Count(); ++i)
                    {
                        for(int j = 0; j <phoneBook[i]._phones.Count(); j++)
                        {
                            if(phoneNumber == phoneBook[i]._phones[j]._number)
                            {
                               phoneBook[i]._phones.RemoveAt(j);
                            }
                        }
                    }
                    break;
                case 3:
                    Console.Write("Адрес: ");
                    string? address = Console.ReadLine();

                    if(address == null)
                    {
                        Console.WriteLine("Адрес не был введен");
                        return;
                    }

                    for(int i = 0; i < phoneBook.Count(); ++i)
                    {
                        for(int j = 0; j < phoneBook[i]._addresses.Count(); ++j)
                        {
                            if(address == phoneBook[i]._addresses[j]._addressBody)
                            {
                                phoneBook[i]._addresses.RemoveAt(j);
                            }
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Неправельный ввод");
                    break;
                    
            }
        }

        /// <summary>
        /// Поиск по выбранному значению
        /// </summary>
        /// <param name="phoneBook">Телефонная книга</param>
        public static void SearchBuField(ref List<PhoneBookItem> phoneBook)
        {
            Console.WriteLine("Выберете по какому значению будет осуществлятся поиск");
            Console.WriteLine("1 - Фамилия");
            Console.WriteLine("2 - Имя");
            Console.WriteLine("3 - Отчество");
            Console.WriteLine("4 - номер телефона");
            Console.WriteLine("5 - Адрес");

            int search;
            int.TryParse(Console.ReadLine(), out search);

            switch(search)
            {
                case 1:
                    Console.Write("Фамилия: ");
                    string? firstName = Console.ReadLine();

                    if(firstName == null)
                    {
                        Console.WriteLine("Фамилия не введена");
                        return;
                    }

                    for(int i = 0; i < phoneBook.Count(); ++i)
                    {
                        if(firstName == phoneBook[i].FirstName)
                        {
                            PhoneBookConsole.PrintPhoneBookItem(phoneBook[i]);
                        }
                    }
                    break;
                case 2:
                    Console.Write("Имя: ");
                    string? lastName = Console.ReadLine();

                    if (lastName == null)
                    {
                        Console.WriteLine("Имя не введено");
                        return;
                    }

                    for (int i = 0; i < phoneBook.Count(); ++i)
                    {
                        if (lastName == phoneBook[i].LastName)
                        {
                            PhoneBookConsole.PrintPhoneBookItem(phoneBook[i]);
                        }
                    }
                    break;
                case 3:
                    Console.Write("Отчество: ");
                    string? patronymic = Console.ReadLine();

                    if (patronymic == null)
                    {
                        Console.WriteLine("Отчество не введено");
                        return;
                    }

                    for (int i = 0; i < phoneBook.Count(); ++i)
                    {
                        if (patronymic == phoneBook[i].Patronymic)
                        {
                            PhoneBookConsole.PrintPhoneBookItem(phoneBook[i]);
                        }
                    }
                    break;
                case 4:
                    Console.Write("Номер телефона: ");
                    string? phoneNumber = Console.ReadLine();

                    if (phoneNumber == null)
                    {
                        Console.WriteLine("Номер телефона не введен");
                        return;
                    }

                    for (int i = 0; i < phoneBook.Count(); ++i)
                    {
                       for(int j = 0; j < phoneBook[i]._phones.Count(); ++j)
                        {
                            if (phoneNumber == phoneBook[i]._phones[j]._number)
                            {
                                PhoneBookConsole.PrintPhoneBookItem(phoneBook[i]);
                            }
                        }
                    }
                    break;
                case 5:
                    Console.Write("Адрес:");
                    string? address = Console.ReadLine();

                    if (address == null)
                    {
                        Console.WriteLine("Адрес не введен");
                        return;
                    }

                    for (int i = 0; i < phoneBook.Count(); ++i)
                    {
                        for (int j = 0; j < phoneBook[i]._addresses.Count(); ++j)
                        {
                            if (address == phoneBook[i]._addresses[j]._addressBody)
                            {
                                PhoneBookConsole.PrintPhoneBookItem(phoneBook[i]);
                            }
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Неправельный выбор");
                    break;
            }
        }
        
        
        
    }
}
