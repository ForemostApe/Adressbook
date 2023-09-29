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
        public FileManager()
        {
            
        }
        public FileManager(List<string> entriesToSave)
        {
            //Ska man göra det här till en private method istället?
            using (StreamWriter _writer = new StreamWriter(_filePath))
            {
                foreach (string entry in entriesToSave)
                {
                    _writer.WriteLine(entry);
                }
            }
        }
        public void ReadFromFile()
        {
            using (StreamReader _reader = new StreamReader(_filePath))
            {

                //Läs in filen.
                //lägg in varje rad som en entry in adressbook-listan
                //Visa varje rad i listviewboxen.
                if (_reader.ReadLine() != null) 
                {
                    _reader.ReadLine();
                }
            }
        }
    }
}
 

