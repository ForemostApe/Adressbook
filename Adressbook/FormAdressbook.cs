using Adressbook.Classes;

namespace Adressbook
{
    public partial class FormAdressbook : Form
    {
        List<Person> adressBook = new List<Person>();

        public FormAdressbook()
        {
            InitializeComponent();
        }

        private void FormAdressbook_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Initierar ett nytt objekt och skickar värdena från textboxarna till constructorn i AdressEntry-klassen.
            Person adressEntry = new Person(textName.Text, textStreet.Text, textZipCode.Text, textCity.Text, textPhoneNumber.Text, textEmailAdress.Text);

            //Initierar ett nytt ListViewItem-objekt med namnet 'list' och hämtar item plus subitems från adressEntry-klassen.
            ListViewItem list = new ListViewItem(adressEntry.Name);
            list.SubItems.Add(adressEntry.Street);
            list.SubItems.Add(adressEntry.ZipCode);
            list.SubItems.Add(adressEntry.City);
            list.SubItems.Add(adressEntry.PhoneNumber);
            list.SubItems.Add(adressEntry.EmailAdress);
            listAdressEntries.Items.Add(list); //Lägger till alla items i 'list'-objektet i det visuella fönstret. 

            //Lägger till textboxvärdena i en lista. Måste finnas ett bättre sätt att göra allt det här på.
            //Funkar inte efter att jag ändrade 'adressBook' till att ta emot Person-objekt.
            //adressBook.Add(adressEntry.Name);
            //adressBook.Add(adressEntry.Street);
            //adressBook.Add(adressEntry.ZipCode);
            //adressBook.Add(adressEntry.City);
            //adressBook.Add(adressEntry.PhoneNumber);
            //adressBook.Add(adressEntry.EmailAdress);


            adressBook.Add(adressEntry);
     

            //Initierar ett nytt fileManager-objekt från FileManager-klassen och skickar textbox-värdena till constructorn.
            FileManager fileManager = new FileManager(textName.Text, textStreet.Text, textZipCode.Text, textCity.Text, textPhoneNumber.Text, textEmailAdress.Text);

            buttonSave.Text = "Spara";

            //Anropar en metod för att tömma textfälten efter att man sparat värdena.
            ClearTextFields();
        }

        private void ClearTextFields()
        {
            textName.Clear();
            textStreet.Clear();
            textZipCode.Clear();
            textCity.Clear();
            textPhoneNumber.Clear();
            textEmailAdress.Clear();
        }

        private void listAdressEntries_SelectedIndexChanged(object sender, EventArgs e)
        {

                
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listAdressEntries.Items.Clear();

            string searchString = textSearchBox.Text;

            listAdressEntries.FindItemWithText(searchString);

            //Funkar inte eftersom värdena är sparade individuellt istället för som en lång string med allt i ett.
            //Funkar inte efter att jag ändrade 'adressBook' till att ta emot objekt.
            //foreach (string entry in adressBook)
            //{

            //    if (entry.ToLower().Equals(searchString.ToLower()))
            //    {
            //        {
            //            listAdressEntries.Items.Add(entry);
            //        }
            //    }
            //}
        }

        private void listAdressEntries_Click(object sender, EventArgs e)
        {
            //Kollar så att det finns entries i listan, så man inte får ett out-of-range-error vid knapptryck.
            if (listAdressEntries.SelectedItems.Count > 0)
            {
                textName.Text = listAdressEntries.SelectedItems[0].SubItems[0].Text;
                textStreet.Text = listAdressEntries.SelectedItems[0].SubItems[1].Text;
                textZipCode.Text = listAdressEntries.SelectedItems[0].SubItems[2].Text;
                textCity.Text = listAdressEntries.SelectedItems[0].SubItems[3].Text;
                textPhoneNumber.Text = listAdressEntries.SelectedItems[0].SubItems[4].Text;
                textEmailAdress.Text = listAdressEntries.SelectedItems[0].SubItems[5].Text;

                buttonSave.Text = "Ändra";
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listAdressEntries.SelectedItems.Count > 0)
            {
                listAdressEntries.Items.Remove(listAdressEntries.SelectedItems[0]);
            }

            //int rowIndex = listAdressEntries.Selected; KOLLA HÄR!!!!
        }
    }
}