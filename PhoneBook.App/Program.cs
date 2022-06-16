using System;
using PhoneBook.App;

namespace PhoneBook.App
{

    internal class Program
    {
        static void Main(string[] args)
        {

            List<PhoneBookItem> phoneBook = new List<PhoneBookItem>();


            for (int i = 0; i < 10; i++)
            {
                PhoneBookItem phoneBookItem1 = new PhoneBookItem();
                PhoneBookActions.AddRand(phoneBookItem1,i + 1);
                phoneBook.Add(phoneBookItem1);
            }
            PhoneBookItem phoneBookItem = new PhoneBookItem();
            PhoneBookConsole.AddConsole(phoneBookItem);
            phoneBook.Add(phoneBookItem);

            Console.WriteLine("\n==============================================================================\n");
            foreach (var item in phoneBook)
            {
                PhoneBookConsole.Print(item);
                Console.WriteLine();
            }
            Console.WriteLine(phoneBook.Count);
            PhoneBookActions.SortPhoneBook(ref phoneBook, 0);
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
        }
    }
}
