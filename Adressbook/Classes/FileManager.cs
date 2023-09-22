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

        public AdressEntry Name { get; set; }
        public AdressEntry Street { get; set; }

        public AdressEntry PostalCode { get; set; }
        public AdressEntry City { get; set; }

        public AdressEntry PhoneNumber { get; set; }

        public AdressEntry Emailadress { get; set; }

        public FileManager()
        {

        }


        public void WriteToFile()
        {
            using (StreamWriter _writer = new StreamWriter(_filePath))
            {

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
 

