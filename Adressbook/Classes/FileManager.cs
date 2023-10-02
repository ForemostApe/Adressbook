namespace Adressbook.Classes
{
    public class FileManager

    {
        private string _filePath = @"C:\temp\Adressbook.txt";

        public FileManager()
        {

        }

        //Constructorn tar emot en lista med personobjekt.
        public FileManager(List<Person> persons)
        {
            //Streamwritern initieras och hämtar sökvägen från '_filepath'-variabeln.
            using (StreamWriter _writer = new StreamWriter(_filePath))
            {
                //Varje personobjekt i listan loopas igenom och dess properties skrivs till filen.
                foreach (Person entry in persons)
                {
                    _writer.WriteLine($"{entry.Name},{entry.Street},{entry.ZipCode},{entry.City},{entry.PhoneNumber},{entry.EmailAdress}");
                }
            }
        }

        public List<Person> ReadFromFile()
        {
            using (StreamReader _reader = new StreamReader(_filePath))
            {
                //En ny lista med personobjekt initieras.
                List<Person> personList = new List<Person>();


                string row = string.Empty;

                //En while-loop som fortsätter rad för rad i filen tills den kommer till en tom rad. 'row' ges värdet av varje rad för sig.
                while ((row = _reader.ReadLine()) != null) //Borde kanske finnas en try-catch här?
                {
                    //För varje rad upprättas ett personobjekt.
                    Person person = new Person();

                    //Raden som lagras i 'row' delas upp i en array utifrån kommatering.
                    string[] separatedFile = row.Split(',');

                    //Dom separerade värdena som lagras i 'separatedFile' skjuts in i person-objektets properties och läggs sen till i 'personList'-listan.
                    person.Name = separatedFile[0];
                    person.Street = separatedFile[1];
                    person.ZipCode = separatedFile[2];
                    person.City = separatedFile[3];
                    person.PhoneNumber = separatedFile[4];
                    person.EmailAdress = separatedFile[5];
                    personList.Add(person);
                }
                return personList;
            }
        }
    }
}
 

