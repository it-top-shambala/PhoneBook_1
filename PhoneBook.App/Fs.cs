using System.Text.Json;
using System.Xml.XPath;

namespace PhoneBook.App;

public static class Fs
{
    public static void SaveToFile(string path, IEnumerable<PhoneBookItem> phoneBookItems)
    {
        using FileStream fileStream = new FileStream(path, FileMode.Create);
        JsonSerializer.Serialize(fileStream, phoneBookItems);
    }

    public static List<PhoneBookItem>? ReadFromFile(string path)
    {
        if (!File.Exists(path))
        {
            throw new FileNotFoundException();
        }
        using FileStream fileStream = new FileStream(path, FileMode.Open,FileAccess.Read);
        return JsonSerializer.Deserialize<List<PhoneBookItem>>(fileStream);
    }
    
}
