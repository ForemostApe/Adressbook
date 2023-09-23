using System.Reflection.Metadata.Ecma335;
using System.Security.Policy;

namespace Adressbook.Classes
{
    public class AdressEntry
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAdress { get; set; }

        public AdressEntry()
        {

        }

        //Constructorn tar emot 6st strings som sen sätts som publika. Inga tester utförs utan allt är bara ren pass-through i nuläget.
        public AdressEntry(string aName, string aStreet, string aZipCode, string aCity, string aPhoneNumber, string aEmailAdress)
        
        {
            Name = aName;
            Street = aStreet;
            ZipCode = aZipCode;
            City = aCity;
            PhoneNumber = aPhoneNumber;
            EmailAdress = aEmailAdress;
        }

        
    }
}
    
