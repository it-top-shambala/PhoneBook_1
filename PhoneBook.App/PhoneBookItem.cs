﻿using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;

namespace PhoneBook.App;

public enum AttributeStruct
{
    Guid,
    Firstname,
    Lastname,
    Patronymic,
    Phone,
    Adress,
    Groups
}

public class PhoneBookItem
{
    private string GuId { get; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Patronymic { get; set; }
    public  List<Phone> Phones { get; set; } 
    public List<Address> Addresses { get; set; }
    public List<string> Groups { get; set; }
    
    public PhoneBookItem()
    {
        GuId = Guid.NewGuid().ToString("N");
        Phones = new List<Phone>();
        Addresses = new List<Address>();
        Groups = new List<string>();
    }
    public PhoneBookItem(string Id,string firstName, string lastName, string patronymic, Phone phones, Address addresses, string groups)
    {
        GuId = Id;
        FirstName = firstName;
        LastName = lastName;
        Patronymic = patronymic;
        Phones = new List<Phone>() { phones };
        Addresses = new List<Address>() { addresses };
        Groups = new List<string>() { groups };
    }

    //construtor for the finde removing element => Equals will be compare id
    public PhoneBookItem(string id)
    {
        GuId = id;
        Phones = new List<Phone>();
        Addresses = new List<Address>();
        Groups = new List<string>();
    }
    
    public void Print()
    {
        Console.WriteLine($"Id: {GuId + Environment.NewLine}Firstname: {FirstName + Environment.NewLine} Lastname: {LastName + Environment.NewLine} Patronymic {Patronymic + Environment.NewLine}");
        Phones.ForEach((s) => s.Print());
        Addresses.ForEach((s) => s.Print());
        Groups.ForEach(s => Console.WriteLine($"Group {s}"));
    }
    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        PhoneBookItem asBookItem = obj as PhoneBookItem;
        if (asBookItem == null) return false;
        else return Equals(asBookItem);
    }
    public bool Equals(PhoneBookItem obj)
    {
        if (obj == null) return false;
        return this.GuId.Equals(obj.GuId);
    }

    public bool IsContain(AttributeStruct attributeStruct,string element)
    {
        switch (attributeStruct)
        {
            case AttributeStruct.Guid:
                if (GuId == element) return true; 
                break; 
            case AttributeStruct.Firstname:
            { 
                if (element == this.FirstName) return true;
            }break;
            case AttributeStruct.Lastname:
            {
                if (element == this.LastName) return true;
            }break;
            case AttributeStruct.Patronymic:
            {
                if (element == this.Patronymic) return true;
            }break;
            case AttributeStruct.Phone:
            {
                return Phones.Any(i => i.Number == element);
            }break;
            case AttributeStruct.Adress:
            {
                return Addresses.Any(i => i.AddressBody == element);
            }break;
            case AttributeStruct.Groups:
            {
                return Groups.Any(i => i == element);
            }break;
        }
        return false;
    }
}
