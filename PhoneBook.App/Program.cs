//#define TEST

using System;
using PhoneBook.App;

namespace PhoneBook
{

    public class Program
    {
        static void PrintPhoneBook(List<PhoneBookItem> phoneBook)
        {
            foreach (var item in phoneBook)
            {
                PhoneBookConsole.Print(item);
                Console.WriteLine();
            }
            Console.WriteLine($"Колличество записей : {phoneBook.Count}");
        }

        static void Main(string[] args)
        {
            List<PhoneBookItem> phoneBook = new List<PhoneBookItem>();
            string key;
            string path = null;
            do
            {
                Console.Clear();
                Console.WriteLine("/tМеню:");
                Console.WriteLine("1. Заполнить телефонную книгу с консоли.");
                Console.WriteLine("2. Заполнить телефонную книгу случайными данными");
                Console.WriteLine("3. Считать телефонную книгу из файла");
                Console.WriteLine("4. Запись телефонной книги в файл");
                Console.WriteLine("5. Вывод книги на экран");
                Console.WriteLine("6. Вывод списка файлов телефонных книг");
                Console.WriteLine("0. Exit");
                key = Console.ReadLine();
                string yesNo;
                switch (key)
                {
                    case "1":
                        phoneBook.Add(PhoneBookConsole.AddConsole());
                        break;
                    case "2":
                        for (int i = 0; i < 10; i++)
                        {
                            PhoneBookItem phoneBookItem1 = new PhoneBookItem();
                            PhoneBookActions.AddRand(phoneBookItem1, i + 1);
                            phoneBook.Add(phoneBookItem1);
                        }
                        break;
                    case "3":
                        if (path != null)
                        {
                            Console.WriteLine("Желаете сохранить открытый файл? y - да");
                            yesNo = Console.ReadLine();
                            if (yesNo == "y")
                            {
                                PhoneBookFile.WritePhoneBookToFile(phoneBook, $"{path}.dat");
                            }
                        }
                        Console.WriteLine("Введите имя файла:");
                        path = Console.ReadLine();
                        try
                        {
                            phoneBook = PhoneBookFile.ReadFileToPhoneBook($"{path}.dat");
                        }
                        catch (FileNotFoundException)
                        {
                            Console.WriteLine("FileNotFoundException");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Введите имя файла:");
                        path = Console.ReadLine();
                        PhoneBookFile.WritePhoneBookToFile(phoneBook, $"{path}.dat");
                        break;
                    case "5":
                        PrintPhoneBook(phoneBook);
                        Console.ReadKey();
                        break;
                    case "6":
                        DirectoryInfo di = new DirectoryInfo(@"C:\Users\olegs\source\repos\PhoneBook_1\PhoneBook.App\bin\Debug\net6.0");
                        foreach (var fi in di.GetFiles("*.txt"))
                        {
                            Console.WriteLine(fi.Name);
                        }
                        Console.ReadKey();
                        break;
                    case "0":
                        Console.WriteLine("Желаете сохранить открытый файл? y - да");
                        yesNo = Console.ReadLine();
                        if (yesNo == "y")
                        {

                            if (path == null)
                            {
                                Console.WriteLine("Введите имя файла:");
                                path = Console.ReadLine();
                            }
                            PhoneBookFile.WritePhoneBookToFile(phoneBook, $"{path}.dat");

                        }
                        break;
                    default:
                        break;
                }

            } while (key != "0");



#if TEST
            List<PhoneBookItem> phoneBook = new List<PhoneBookItem>();
            for (int i = 0; i < 10; i++)
            {
                PhoneBookItem phoneBookItem1 = new PhoneBookItem();
                PhoneBookActions.AddRand(phoneBookItem1,i + 1);
                phoneBook.Add(phoneBookItem1);
            }
           
            phoneBook.Add(PhoneBookConsole.AddConsole());

            Console.WriteLine("\n==============================================================================\n");
            foreach (var item in phoneBook)
            {
                PhoneBookConsole.Print(item);
                Console.WriteLine();
            }
            Console.WriteLine(phoneBook.Count);
            PhoneBookActions.SortPhoneBook(ref phoneBook, PhoneBookElementType.FirstName);
            Console.WriteLine("\n==============================================================================\n");

            foreach (var item in phoneBook)
            {
                PhoneBookConsole.Print(item);
                Console.WriteLine();
            }
            Console.WriteLine(phoneBook.Count);
            PhoneBookActions.Remove(phoneBook, "FirstName1", PhoneBookElementType.FirstName);
            Console.WriteLine("\n==============================================================================\n");

            foreach (var item in phoneBook)
            {
                PhoneBookConsole.Print(item);
                Console.WriteLine();

            }
            PhoneBookFile.WritePhoneBookToFile(phoneBook, "book1.txt");
            List<PhoneBookItem> phoneBook2 = new List<PhoneBookItem>();

            try
            {
                phoneBook2 = PhoneBookFile.ReadFileToPhoneBook("book2.txt");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("FileNotFoundException");
            }

            Console.WriteLine("========phone book2==============");
            foreach (var item in phoneBook2)
            {
                PhoneBookConsole.Print(item);
                Console.WriteLine();

            }
#endif
        }
    }
}
