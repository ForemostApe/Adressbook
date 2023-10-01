using Adressbook.Classes;
using System;

namespace Adressbook
{
    public partial class FormAdressbook : Form
    {
        List<Person> adressBook = new List<Person>(); //Lista där alla Person-objekts sparar. Denna fil styr även vad som visas i ListView och vad som sparas till textfilen.

        public FormAdressbook()
        {
            InitializeComponent();
        }

        private void FormAdressbook_Load(object sender, EventArgs e)
        {
            FileManager fileManager = new FileManager();
            adressBook.Add(fileManager.ReadFromFile()); //Vet inte ens om den här gör något just nu.

        }  

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Initierar ett nytt objekt och skickar värdena från textboxarna till constructorn i AdressEntry-klassen, lägger sen till objektet i 'adressBook'-listan.
            Person person = new Person(textName.Text, textStreet.Text, textZipCode.Text, textCity.Text, textPhoneNumber.Text, textEmailAdress.Text);
            adressBook.Add(person);

            ListViewItem list = new ListViewItem(person.Name);
            list.SubItems.Add(person.Street); //Initierar ett nytt ListViewItem-objekt med namnet 'list' och hämtar item plus subitems från adressEntry-klassen.
            list.SubItems.Add(person.ZipCode);
            list.SubItems.Add(person.City);
            list.SubItems.Add(person.PhoneNumber);
            list.SubItems.Add(person.EmailAdress);
            listAdressEntries.Items.Add(list); //Lägger till alla items i 'list'-objektet i det visuella fönstret. 

            buttonSave.Text = "Spara";

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

        private void listAdressEntries_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listAdressEntries_Click(object sender, EventArgs e)
        {
            //Kollar så att det finns entries i listan, så man inte får ett out-of-range-error vid knapptryck.
            if (listAdressEntries.SelectedItems.Count > 0)
            {
                //Lägger till värdena från listan i textboxarna. SelectedItems kommer alltid vara noll eftersom det är radindexet man står på antar jag? Sen är SubItems värdena i kolumnerna.
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

            buttonSave.Text = "Spara";

            ClearTextFields();
        }
    }
}