using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PhoneBook.App
{
    internal static class PhoneBookFile
    {
        public static void WritePhoneBookToFile(List<PhoneBookItem> phoneBook, string path)
        {
            using (var stream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                JsonSerializer.Serialize(stream, phoneBook);
            }
        }
        public static List<PhoneBookItem> ReadFileToPhoneBook(string path)
        {
            if (!File.Exists(path)) throw new FileNotFoundException();
            using(var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                var phoneBook = JsonSerializer.Deserialize<List<PhoneBookItem>>(stream);
                return phoneBook;
            }
           
        }
    }
}
