namespace PhoneBook.App;

public class PhoneBookItem
{
    public string FirstName
    {
        get;
        set;
    }
    public string LastName { get; set; }
    public string Patronymic { get; set; }
    public string Phones { get; set; }


    public PhoneBookItem(string FirstName, string LastName, string Patronymic, string Phones)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Patronymic = Patronymic;
        this.Phones = Phones;
    }
    public void Print()
    {
        Console.WriteLine($"{FirstName}, {LastName}, {Patronymic} : {Phones}");
    }

    public bool SearchElem(string info)
    {
        if (info == FirstName || info == LastName || info == Patronymic)
            return true;
        return false;
    }

    public bool SearchElem(string FirstName, string LastName)
    {
        if (this.FirstName == FirstName || this.LastName == LastName)
            return true;
        return false;
    }

}
