using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Policy;

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
        public Person(string aName, string aStreet, string aZipCode, string aCity, string aPhoneNumber, string aEmailAdress)
        
        {
            Name = aName;
            Street = aStreet;
            ZipCode = aZipCode;
            City = aCity;
            PhoneNumber = aPhoneNumber;
            EmailAdress = aEmailAdress;

            PassEntryToFileMgr();
        }

        public void PassEntryToFileMgr()
        {
            Person person = new Person();
            person.Name = Name;
            person.Street = Street;
            person.ZipCode = ZipCode;
            person.City = City;
            person.PhoneNumber = PhoneNumber;
            person.EmailAdress = EmailAdress;

            FileManager fileManager = new FileManager(person);
        }
        
    }
}
    
