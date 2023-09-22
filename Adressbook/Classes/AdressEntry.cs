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

        public AdressEntry(List<string> adressItems)
        {
            Name = adressItems[0];
            Street = adressItems[1];
            PostalCode = adressItems[2];
            City = adressItems[3];
            PhoneNumber = adressItems[4];
            EmailAdress = adressItems[5];
        }
     
        public void AddEntryToAdressbook()
        {
            

        }
            
    }
}
    
