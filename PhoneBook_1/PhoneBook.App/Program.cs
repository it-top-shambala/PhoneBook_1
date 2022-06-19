//Написать программу для реализации "абстрактной" телефонной книги.

//Программа должна уметь:

//добавлять данные с клавиатуры
//выводить весь список данных
//удалять данные
//искать по разным полям
using PhoneBook.App;

namespace PhoneBook.App
{
    internal static class Program
    {

        private static void Main()
        {
            List<PhoneBookItem> phoneBook = new List<PhoneBookItem>();
           // PrintPhoneBook(phoneBook);
            AddClient(phoneBook);
        }
        private static void PrintPhoneBook(List<PhoneBookItem> phoneBook)
        {
            Console.Write("Введите фамилию абонента : ");
            PhoneBookItem.LastName = Console.ReadLine();
            Console.Write("Введите имя абонента : ");
            PhoneBookItem.FirstName = Console.ReadLine();
            Console.Write("Введите отчество абонента : ");
            PhoneBookItem.Patronymic = Console.ReadLine();
            Console.WriteLine("Введите телефон абонента");
            string Phone = Console.ReadLine();
            //Console.Write($"Тип(городской/сотовый) : {Type}");
            Console.Write("Введите адрес абонента : ");
            string adres = Console.ReadLine();
            //Console.Write("Тип адреса(юридический/фактический) : ");
            // TypeAddress = Console.ReadLine();

        }
        public static void AddClient(List<PhoneBookItem> phoneBook)
        {
            ConsoleKeyInfo key;
            do
            {
                Console.Write("Введите фамилию абонента : ");
                PhoneBookItem.LastName = Console.ReadLine();
                Console.Write("Введите имя абонента : ");
                PhoneBookItem.FirstName = Console.ReadLine();
                Console.Write("Введите отчество абонента : ");
                PhoneBookItem.Patronymic = Console.ReadLine();
                Console.WriteLine("Введите телефон абонента");
                string Phone = Console.ReadLine();
                //Console.Write($"Тип(городской/сотовый) : {Type}");
                Console.Write("Введите адрес абонента : ");
                string adres = Console.ReadLine();
                //Console.Write("Тип адреса(юридический/фактический) : ");
                // TypeAddress = Console.ReadLine();


                Console.WriteLine("Добавить еще одного абонента? y/n");
                key = Console.ReadKey();
                Console.WriteLine();
            } while (key.Key == ConsoleKey.Y);





        }
    }
}
