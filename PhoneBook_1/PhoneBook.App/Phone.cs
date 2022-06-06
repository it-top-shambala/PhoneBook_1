namespace PhoneBook.App
{

    public class Phone
    {
        public Type typeNumber;
        public string number { get; set; }

        public enum Type
        {
            city,
            mobile
        }
        public Phone(Type typeNumber, string number)
        {
                number = number;

                typeNumber=typeNumber;

                if (number[0] == '8' || number[1] == '9')
                {
                typeNumber = Type.mobile;
                }
                else
                {
                    typeNumber = Type.city;
                }

            
        }
        
    }
}
