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

           ;
            ConsoleKeyInfo input;
            do 
            {
               input = Console.ReadKey();
    
            }
            while (input.Key != ConsoleKey.Escape);

            //while(true)
            //{ 
            //    input = Console.ReadKey().Key;
            //    switch(input)
            //    {
            //        case ConsoleKey.D1:
            //            foreach (PhoneBookItem item in phoneBook)
            //            {
            //                item.Print();
            //            }
            //            break;
            //        case ConsoleKey.D2:
            //            break;




            //    }

            //}


            PhoneBookItem items = new PhoneBookItem(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            items.Print();
            phoneBook.Add(items);

            foreach (PhoneBookItem item in phoneBook)
            {
                item.Print();
            }

            Console.WriteLine();

           foreach(PhoneBookItem item in phoneBook)
           {
                if(item.SearchElem("сергеевич"))
                {
                    item.Print();
                }    
           }




        }
    }
}
