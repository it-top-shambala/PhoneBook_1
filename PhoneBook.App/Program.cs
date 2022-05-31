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

            PrintPhoneBook(phoneBook);
        }
        public static void PrintPhoneBook(List<PhoneBookItem> phoneBook)
        {

            for(int i = 0; i < phoneBook.Count; i++)
            {
                phoneBook[i].PrintPhoneBookItem();
            }
        }
    }
}
