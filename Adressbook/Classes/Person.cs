using System.Net.Mail;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace Adressbook.Classes
{
    public class Person
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAdress { get; set; }

        public Person()
        {
        }


        //Constructorn tar emot 6st strings som sen sätts som publika.
        public Person(string name, string street, string zipCode, string city, string phoneNumber, string emailAdress)
        
        {
            Name = name;
            Street = street;
            ZipCode = zipCode;
            City = city;
            PhoneNumber = phoneNumber;
            EmailAdress = emailAdress;
        }
    }
}
    
