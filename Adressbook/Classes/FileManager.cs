using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressbook.Classes
{
    public class FileManager

    {
        private string _filePath = @"C:\temp\Adressbook.txt";

        public string Name { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAdress { get; set; }

        public FileManager()
        {
            
        }

        //Constructorn tar emot värden som sen skjuts in i getters:setters för enhetlig namnsättning.
        public FileManager(string aName, string aStreet, string aZipCode, string aCity, string aPhoneNumber, string aEmailAdress)
        {
            Name = aName;
            Street = aStreet;
            ZipCode = aZipCode;
            City = aCity;
            PhoneNumber = aPhoneNumber;
            EmailAdress = aEmailAdress;

            //StreamWriter initieras och objektet _writer skapas. Sökvägen för filen som ska skrivas till hämtas från stringen '_filePath' och är inställd på att lägga till istället för att skriva över eftersom append = true.
            using (StreamWriter _writer = new StreamWriter(_filePath, true))
            {
                {
                    //Skriver instansvariablerna till den angivna filen.
                    _writer.WriteLine($"{Name}, {Street}, {ZipCode}, {City}, {PhoneNumber}, {EmailAdress}");
                }
            }
        }
        
        public string[] ReadFromFile()
        {
            string row = string.Empty;

            using (StreamReader _reader = new StreamReader(_filePath))
            {
                row = _reader.ReadToEnd();
            }

            string[] separatedFile = row.Split(',');



            return separatedFile;
        }


    }
}
 

