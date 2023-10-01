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

        public FileManager(Person person)
        {
            Name = person.Name;
            Street = person.Street;
            ZipCode = person.ZipCode;
            City = person.City;
            PhoneNumber = person.PhoneNumber;
            EmailAdress = person.EmailAdress;

            //StreamWriter initieras och objektet _writer skapas. Sökvägen för filen som ska skrivas till hämtas från stringen '_filePath' och är inställd på att lägga till istället för att skriva över eftersom append = true.
            using (StreamWriter _writer = new StreamWriter(_filePath, true))
            {
                {
                    //Skriver instansvariablerna till den angivna filen.
                    _writer.WriteLine($"{Name},{Street},{ZipCode},{City},{PhoneNumber},{EmailAdress}");
                }
            }
        }
        
        public Person ReadFromFile()
        {
            string row = string.Empty;

            //using (StreamReader _reader = new StreamReader(_filePath))
            //{
            //    row = _reader.ReadToEnd();
            //}

            using (StreamReader _reader = new StreamReader(_filePath))
            {
                Person person = new Person();

                if (_reader.ReadLine() != null)
                {
                    row = _reader.ReadLine();
                    string[] separatedFile = row.Split(',');
                    
                    person.Name = separatedFile[0];
                    person.Street = separatedFile[1];
                    person.ZipCode = separatedFile[2];
                    person.City = separatedFile[3];
                    person.PhoneNumber = separatedFile[4];
                    person.EmailAdress = separatedFile[5];
                }
                return person;
            }


            //string[] separatedFile = row.Split(',');

            //Person person = new Person();
            //person.Name = separatedFile[0];
            //person.Street = separatedFile[1];
            //person.ZipCode = separatedFile[2];
            //person.City = separatedFile[3];
            //person.PhoneNumber = separatedFile[4];
            //person.EmailAdress = separatedFile[5];

            //return person;
        }


        //public void DeleteFromFile(int rowIndex)
        //{
        //    int rowToDelete = rowIndex;
        //    int rowIndex = listAdressEntries.SelectedItems.Count;
        //}

    }
}
 

