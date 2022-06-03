namespace PhoneBook.App;

public static class ConsoleWrite
{
    /// <summary>
    /// Method which take list and print all the elements included lists!
    /// </summary>
    /// <param name="list"></param>
    public static void PrintToConsoleList(List<PhoneBookItem> list)
    {
        foreach (var obj in list)
        {
            Console.WriteLine(obj);
            obj.Phones.ForEach((s) => Console.WriteLine(s));
            obj.Addresses.ForEach(i => Console.WriteLine(i));
            obj.Groups.ForEach(k => Console.WriteLine(k));
        }    
    }
    public static void PrintToConsolePhoneItem(PhoneBookItem phoneBookItem)
    {
        Console.WriteLine(phoneBookItem);
        phoneBookItem.Phones.ForEach((s) => Console.WriteLine(s));
        phoneBookItem.Addresses.ForEach(i => Console.WriteLine(i));
        phoneBookItem.Groups.ForEach(k => Console.WriteLine(k));
    }
}
