namespace Adressbook.Classes
{
    public class AdressEntry
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAdress { get; set; }

        public AdressEntry(string x)
        {
            Name = x;
        }
     
        public void AddEntryToAdressbook()
        {
            Adressbook entry = new Adressbook();

        }
            
    }
}
    
