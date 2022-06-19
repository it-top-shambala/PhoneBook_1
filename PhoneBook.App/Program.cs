namespace PhoneBook.App
{
    //TODO Add unit testing to project and seperate project to different projects 
    internal static class Program
    {
        public static readonly string FileName = "test.log";
        private static void Main()
        {
            List<PhoneBookItem> phoneBook = new List<PhoneBookItem>();
            string operation;
            int count_updated = 0;
            CLI.PrintColord("The end of program file will be saved automatically",ConsoleColor.Blue);
            Console.WriteLine("Enter operation Add-Remove-Find-Update-Read-Print-Exit");
            operation = Console.ReadLine();
            while (true)
            {
                if (operation == "exit") break;
                switch (operation)
                {
                    case "Add":
                    case "add":
                    {
                        PhoneBookItem phoneBookItem = CLI.InitalizeItem();
                        phoneBook.Add(phoneBookItem);
                        count_updated++;
                    }break;
                    case "Remove":
                    case "remove":
                    {
                        string? id = Console.ReadLine();
                        bool isDone = phoneBook.Remove(new PhoneBookItem(id));
                        if (isDone)
                        {
                            Console.WriteLine("Item succesfully removed!!");
                        }
                        else
                        {
                            Console.WriteLine($"There is not item which is id : {id}");
                        }
                    }break;
                    case "Find":
                    case "find":
                    {
                        Console.WriteLine("Enter value to find object");
                        string? ValueToFind = Console.ReadLine();
                        PhoneBookItem findingItem = phoneBook.Find(x => x.IsContain(AttributeEnum.Firstname, ValueToFind));
                        CLI.PrintToConsolePhoneItem(findingItem);
                    }break;
                    case "Update":
                    case "update":
                    {
                        Fs.SaveToFile(FileName,phoneBook);
                        count_updated = 0;
                        Console.WriteLine("Updated done!!!");
                    }break;
                    case "Read":
                    case "read":
                    {
                        Console.WriteLine("Enter path to read file: ");
                        string? path = Console.ReadLine();
                        try
                        {
                            if (phoneBook.Count > 0)
                            {
                                var list_from_file = Fs.ReadFromFile(path);
                                phoneBook.AddRange(list_from_file);
                                count_updated += list_from_file.Count;
                            }
                            else
                            {
                                phoneBook = Fs.ReadFromFile(path);
                                count_updated += phoneBook.Count;
                            }
                            CLI.PrintColord("Read success",ConsoleColor.Green);
                        }
                        catch (FileNotFoundException f)
                        {
                            Console.WriteLine($"{f.Message} : {f.FileName}");
                        }
                    }break; 
                    case "Print":
                    case "print":
                    {
                        CLI.PrintToConsoleList(phoneBook);
                    }break;
                    default: break;
                }
                if (count_updated > 0)
                {
                    CLI.PrintColord($"There is {count_updated} update you can update it now Write ---Update--- to console!!",ConsoleColor.Red);
                }
                Console.WriteLine("Enter operation again: ");
                operation = Console.ReadLine();
            }
            Fs.SaveToFile(FileName,phoneBook);
        }
    }
}
