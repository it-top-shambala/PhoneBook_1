namespace PhoneBook.App
{

    public class Address
    {
        public static string TypeAddress { get; set; }
        public static string AddressBody { get; set; }

        public Address(string typeAddress, string addressBody)
        {
            TypeAddress = typeAddress;
            AddressBody = addressBody;
           
        }
    }
}
