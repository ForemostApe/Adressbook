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

        public Person Name { get; set; }
        public Person Street { get; set; }

        public Person PostalCode { get; set; }
        public Person City { get; set; }

        public Person PhoneNumber { get; set; }

        public Person Emailadress { get; set; }

        public FileManager()
        {

        }


        public void WriteToFile()
        {
            using (StreamWriter _writer = new StreamWriter(_filePath)) ;



        }

        public void ReadFromFile()
        {

        }
    }
}

