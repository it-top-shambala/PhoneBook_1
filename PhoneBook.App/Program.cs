using System;
using PhoneBook.App;

namespace PhoneBook.App
{

    internal class Program
    {

        /// <summary>
        /// Сортировка телефонной книги 
        /// </summary>
        /// <param name="phoneBook"></param>
        /// <param name="id"> Параметр сортировки по какому полю : 
        /// 0 - по FirstName; 
        /// 1 - по LastName; 
        /// 2 - по Patronymic: </param>
        public static void SortPhoneBook(ref List<PhoneBookItem> phoneBook, int id)
        {
            PhoneBookItem tempPhoneBookItem = new PhoneBookItem();

            for (int i = 0; i < phoneBook.Count; i++)
            {
                for (int j = i; j < phoneBook.Count; j++)
                {
                    if ((String.Compare(phoneBook[i].FirstName, phoneBook[j].FirstName, true) > 0 && id == 0) ||
                        (String.Compare(phoneBook[i].LastName, phoneBook[j].LastName, true) > 0 && id == 1) ||
                        (String.Compare(phoneBook[i].Patronymic, phoneBook[j].Patronymic, true) > 0 && id == 2))
                    {
                        tempPhoneBookItem = (PhoneBookItem)phoneBook[i];
                        phoneBook[i] = phoneBook[j];
                        phoneBook[j] = tempPhoneBookItem;

                    }
                }
            }

        }
        /// <summary>
        /// Поиск элемента в Телефонной книге
        /// </summary>
        /// <param name="phoneBook"></param>
        /// <param name="element"></param>
        /// <param name="id">= 0 - </param>
        /// <returns>Возвращает индекс элемента, если элемента нет -1</returns>
        public static int ElementSearch(List<PhoneBookItem> phoneBook, string element, PhoneBookElementType id)
        {

            switch (id.GetHashCode())
            {
                case 0:
                    for (int i = 0; i < phoneBook.Count; i++) if (element.Equals(phoneBook[i].FirstName)) return i;
                    break;
                case 1:
                    for (int i = 0; i < phoneBook.Count; i++) if (element.Equals(phoneBook[i].LastName)) return i;
                    break;
                case 2:
                    for (int i = 0; i < phoneBook.Count; i++) if (element.Equals(phoneBook[i].Patronymic)) return i;
                    break;
                case 3:
                    for (int i = 0; i < phoneBook.Count; i++)
                        for (int j = 0; i < phoneBook[i].Phones.Count; j++)
                            if (element.Equals(phoneBook[i].Phones[j].Number)) return i;
                    break;
                case 4:
                    for (int i = 0; i < phoneBook.Count; i++)
                        for (int j = 0; i < phoneBook[i].Phones.Count; j++)
                            if (element.Equals(phoneBook[i].Phones[j].Type)) return i;
                    break;
                case 5:
                    for (int i = 0; i < phoneBook.Count; i++)
                        for (int j = 0; i < phoneBook[i].Addresses.Count; j++)
                            if (element.Equals(phoneBook[i].Addresses[j].Type)) return i;
                    break;
                case 6:
                    for (int i = 0; i < phoneBook.Count; i++)
                        for (int j = 0; i < phoneBook[i].Addresses.Count; j++)
                            if (element.Equals(phoneBook[i].Addresses[j].AddresBody)) return i;
                    break;
                case 7:
                    for (int i = 0; i < phoneBook.Count; i++)
                        for (int j = 0; i < phoneBook[i].Groups.Count; j++)
                            if (element.Equals(phoneBook[i].Groups[j])) return i;
                    break;
            }
            return -1;
        }
        /// <summary>
        /// Удаление элемента телефонной книги
        /// </summary>
        /// <param name="phoneBook"></param>
        /// <param name="element"></param>
        /// <param name="id"></param>
        public static void Remove(List<PhoneBookItem> phoneBook, string element, PhoneBookElementType id)
        {
            int i = ElementSearch(phoneBook, element, id);
            if (i!=-1) phoneBook.RemoveAt(i);
                       
        }

        static void Main(string[] args)
        {

            List<PhoneBookItem> phoneBook = new List<PhoneBookItem>();


            for (int i = 0; i < 10; i++)
            {
                PhoneBookItem phoneBookItem1 = new PhoneBookItem();
                PhoneBookConsole.AddRand(phoneBookItem1,i + 1);
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
            SortPhoneBook(ref phoneBook, 0);
            Console.WriteLine("\n==============================================================================\n");

            foreach (var item in phoneBook)
            {
                PhoneBookConsole.Print(item);
                Console.WriteLine();
            }
            Console.WriteLine(phoneBook.Count);
            Remove(phoneBook, "FirstName1", PhoneBookElementType.FirstName);
            Console.WriteLine("\n==============================================================================\n");

            foreach (var item in phoneBook)
            {
                PhoneBookConsole.Print(item);
                Console.WriteLine();
            }
        }
    }
}
