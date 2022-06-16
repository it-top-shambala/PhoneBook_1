using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.App
{
    internal static class PhoneBookActions
    {
        
        public static void AddRand(PhoneBookItem phoneBook, int size)
        {

            phoneBook.FirstName = $"FirstName{size}";
            phoneBook.LastName = $"LastName{size}";
            phoneBook.Patronymic = $"Patronymic{size}";
            phoneBook.Phones.Add(new Phone($"Type{size}", $"Phone{size}"));
            phoneBook.Phones.Add(new Phone($"Type{size}+1", $"Phone{size}+1"));
            phoneBook.Addresses.Add(new Addres($"type{size}", $"adres{size}"));
            phoneBook.Addresses.Add(new Addres($"type{size}+1", $"adres{size}+1"));
            phoneBook.Groups.Add($"Group{size}");
            phoneBook.Groups.Add($"Group{size}+1");

        }
        
        public static void SortPhoneBook(ref List<PhoneBookItem> phoneBook, int id)
        {
            PhoneBookItem tempPhoneBookItem = new PhoneBookItem();

            for (int i = 0; i < phoneBook.Count; i++)
            {
                for (int j = i; j < phoneBook.Count; j++)
                {
                    if ((String.Compare(phoneBook[i].FirstName, phoneBook[j].FirstName, true) > 0 && id == 0) ||
                        (String.Compare(phoneBook[i].LastName, phoneBook[j].LastName, true) > 0 && id == 1) ||
                        (String.Compare(phoneBook[i].Patronymic, phoneBook[j].Patronymic, true) > 0 && id == 2))
                    {
                        tempPhoneBookItem = (PhoneBookItem)phoneBook[i];
                        phoneBook[i] = phoneBook[j];
                        phoneBook[j] = tempPhoneBookItem;

                    }
                }
            }
        }

        public static int ElementSearch(List<PhoneBookItem> phoneBook, string element, PhoneBookElementType id)
        {
            return id.GetHashCode() switch
            {
                0 => SearchFirstName(phoneBook, element),
                1 => SearchLastName(phoneBook, element),
                2 => SearchPatronymic(phoneBook, element),
                3 => SearchPhonesNumber(phoneBook, element),
                4 => SearchPhonesType(phoneBook, element),
                5 => SearchAddressesType(phoneBook, element),
                6 => SearchAddressesAddresBody(phoneBook, element),
                7 => SearchGroups(phoneBook, element),
                
            };         
        }
        private static int SearchFirstName(List<PhoneBookItem> phoneBook, string element)
        {
            for (int i = 0; i < phoneBook.Count; i++) if (element.Equals(phoneBook[i].FirstName)) return i;
            return -1;
        }
        private static int SearchLastName(List<PhoneBookItem> phoneBook, string element)
        {
            for (int i = 0; i < phoneBook.Count; i++) if (element.Equals(phoneBook[i].LastName)) return i;
            return -1;
        }
        private static int SearchPatronymic(List<PhoneBookItem> phoneBook, string element)
        {
            for (int i = 0; i < phoneBook.Count; i++) if (element.Equals(phoneBook[i].Patronymic)) return i;
            return -1;
        }
        private static int SearchPhonesNumber(List<PhoneBookItem> phoneBook, string element)
        {
            for (int i = 0; i < phoneBook.Count; i++)
                for (int j = 0; i < phoneBook[i].Phones.Count; j++)
                    if (element.Equals(phoneBook[i].Phones[j].Number)) return i;
            return -1;
        }
        
        private static int SearchPhonesType(List<PhoneBookItem> phoneBook, string element)
        {
            for (int i = 0; i < phoneBook.Count; i++)
                for (int j = 0; i < phoneBook[i].Phones.Count; j++)
                    if (element.Equals(phoneBook[i].Phones[j].Type)) return i;
            return -1;
        }
        private static int SearchAddressesType(List<PhoneBookItem> phoneBook, string element)
        {
            for (int i = 0; i < phoneBook.Count; i++)
                for (int j = 0; i < phoneBook[i].Addresses.Count; j++)
                    if (element.Equals(phoneBook[i].Addresses[j].Type)) return i;
            return -1;
        }
        private static int SearchAddressesAddresBody(List<PhoneBookItem> phoneBook, string element)
        {
            for (int i = 0; i < phoneBook.Count; i++)
                for (int j = 0; i < phoneBook[i].Addresses.Count; j++)
                    if (element.Equals(phoneBook[i].Addresses[j].AddresBody)) return i;
            return -1;
        }
        private static int SearchGroups(List<PhoneBookItem> phoneBook, string element)
        {
            for (int i = 0; i < phoneBook.Count; i++)
                for (int j = 0; i < phoneBook[i].Groups.Count; j++)
                    if (element.Equals(phoneBook[i].Groups[j])) return i;
            return -1;
        }
        
        public static void Remove(List<PhoneBookItem> phoneBook, string element, PhoneBookElementType id)
        {
            int i = ElementSearch(phoneBook, element, id);
            if (i != -1) phoneBook.RemoveAt(i);
        }
















    }
}
