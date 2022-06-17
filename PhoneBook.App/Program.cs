namespace PhoneBook.App
{
    internal static class Program
    {
        private static void Main()
        {
            List<PhoneBookItem> phoneBook = new List<PhoneBookItem>()
            {
            new PhoneBookItem("волков", "дмитрий", "николаевич", "89660620230"),
            new PhoneBookItem("аликов", "сергей ", "сергеевич", "89660620231"),
            new PhoneBookItem("куликов", "никита","александрович", "89660620232"),
            };

            Console.WriteLine("Введите фамилию, имя, отчество и номер телефона в этом же порядке: ");
            string firstname = Console.ReadLine();
            string lastname = Console.ReadLine();
            string patronymic = Console.ReadLine();
            string phone_number = Console.ReadLine();
            PhoneBookItem items = new PhoneBookItem(firstname, lastname, patronymic, phone_number);
            items.Print();
            phoneBook.Add(items);

            foreach (PhoneBookItem item in phoneBook)
            {
                item.Print();
            }

            Console.WriteLine();

            foreach (PhoneBookItem item in phoneBook)
            {
                if (item.SearchElem("сергеевич"))
                {
                    item.Print();
                }
            }

            Console.WriteLine();


            for (int i = 0; i < phoneBook.Count; i++)
            {
                if (phoneBook[i].SearchElem("волков", "дмитрий"))
                {
                    phoneBook.RemoveAt(i);
                }
            }

            foreach (PhoneBookItem item in phoneBook)
            {
                item.Print();
            }
        }
    }
}
