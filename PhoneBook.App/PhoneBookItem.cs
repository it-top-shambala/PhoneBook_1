using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.App
{
    class PhoneBookItem
    {
        public string FirstName { get; set;} //авто свойства не могут быть приватными. при компиляции создается private свойство, к которому будут применены эти геттеры и сеттеры
        //хоть к публичным свойствам и можно обратиться без геттеров/сеттеров, без них мы не сможем сделать сериализацию этого свойства.
        //Сериализация - это когда мы берем экземпляр класса и его состояние записываем в файлик какого-то формата, например xml
        //(По сути, сохранение текущего состояния экземпляра класса в какой-то текстовый вид с возможностью последующего восстановления)
        public string LastName { get; set;}
        public string Patronymic { get; set;} //отчество
        public List<Phone> Phones { get; set; }
        public List<Address> Addresses { get; set; }
        public List<string> Groups { get; set; }

        public PhoneBookItem()
        {
            Phones = new List<Phone>(); //списки, словари и прочие контейнеры лучше инициализировать в конструкторе пустыми, ибо без инициализации их использовать нельзя
            Addresses = new List<Address>();
            Groups = new List<string>();
        }
        public PhoneBookItem(string FirstName, string LastName, string Patronymic, List<Phone> Phones, List<Address> Addresses, List<string> Groups = default)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Patronymic = Patronymic;
            this.Phones = Phones;
            this.Addresses = Addresses;
            this.Groups = Groups;
        }

        //public void addGroup(string Group)
        //{
        //    Groups.Add(Group);
        //}
        //public void removeGroup(string Group) //Не совсем уверен, нужно ли это, когда мы можем просто обратиться к объекту  этого класса: obj.Groups.remove(someString);
        //{
        //    if (Groups.Count == 0)
        //        return;
        //    if (Groups.Contains(Group))
        //        Groups.Remove(Group);
        //}

        //public void removePhone(Phone phone)
        //{
        //    if (Phones.Count == 0)
        //        return;
        //    if (Phones.Contains(phone))
        //        Phones.Remove(phone);
        //} 
        public void print()
        {
            Console.Write($"\n{LastName} {FirstName} {Patronymic}:\nPh. Number(s):\t");
            foreach (Phone item in Phones)
                item.print();
            Console.Write("\nAddress(es):\t");
            foreach (Address item in Addresses)
                item.print();
            Console.Write("\nGroup(s):\t");
            if (Groups.Count != 0)
            {
                foreach (string item in Groups)
                    Console.Write($"{item}, ");
            }
            else
            {
                Console.Write ("none.");
            }
            Console.Write('\n');
        }

    }
}
