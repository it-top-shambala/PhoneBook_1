namespace PhoneBook.App;

public static class CLI
{
    /// <summary>
    /// Method for initalization PhoneBookItem!
    /// </summary>
    /// <returns>PhoneBookItem</returns>
    public static PhoneBookItem InitalizeItem()
    {
        Console.WriteLine("Enter firstname: ");
        string? firstname = Console.ReadLine();
        Console.WriteLine("Enter lastname: ");
        string? lastname = Console.ReadLine();
        Console.WriteLine("Enter Patronymic: ");
        string? patronymic = Console.ReadLine();
        Console.WriteLine("Enter phone Type: ");
        string? phoneType = Console.ReadLine();
        Console.WriteLine("Enter phone Number: ");
        string? phoneNumber = Console.ReadLine();
        Phone phone = new Phone() { Type = phoneType, Number = phoneNumber };
        Console.WriteLine("Enter adress information: ");
        Console.WriteLine("Enter adress type: ");
        string? adress_type = Console.ReadLine();
        Console.WriteLine("Enter adress body: ");
        string? adress_body = Console.ReadLine();
        Address address = new Address() { Type = adress_type, AddressBody = adress_body };
        Console.WriteLine("Enter groups: ");
        string? groups = Console.ReadLine();
        return new PhoneBookItem(firstname, lastname, patronymic, phone, address, groups);
    }

    public static void PrintColord(string value,ConsoleColor consoleColor)
    {
        Console.ForegroundColor = consoleColor;
        Console.WriteLine(value);
        Console.ResetColor();
    }
    /// <summary>
    /// Method which take list and print all the elements included lists!
    /// </summary>
    /// <param name="list"></param>
    public static void PrintToConsoleList(List<PhoneBookItem> list)
    {
        foreach (var obj in list)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(obj);
            obj.Phones.ForEach((s) => Console.WriteLine(s));
            obj.Addresses.ForEach(i => Console.WriteLine(i));
            obj.Groups.ForEach(k => Console.WriteLine(k));
            Console.ResetColor();
        }    
    }
    public static void PrintToConsolePhoneItem(PhoneBookItem phoneBookItem)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine(phoneBookItem);
        phoneBookItem.Phones.ForEach((s) => Console.WriteLine(s));
        phoneBookItem.Addresses.ForEach(i => Console.WriteLine(i));
        phoneBookItem.Groups.ForEach(k => Console.WriteLine(k));
        Console.ResetColor();
    }
}
