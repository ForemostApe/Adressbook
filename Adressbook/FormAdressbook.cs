using Adressbook.Classes;

namespace Adressbook
{
    public partial class FormAdressbook : Form
    {
        //Lista där alla Person-objekts sparar. Denna fil styr även vad som visas i ListView och vad som sparas till textfilen.
        List<Person> adressBook = new List<Person>();

        public FormAdressbook()
        {
            InitializeComponent();
        }

        private void FormAdressbook_Load(object sender, EventArgs e)
        {
            //Initierar FileManager och anropar 'ReadFromFile()'-metoden som läser in informationen i filen och senare returnerar en lista som kommer utgöra 'adressBook'.
            FileManager fileManager = new FileManager();
            adressBook = fileManager.ReadFromFile();

            //Loopar igenom person-objekten i adressboken och anropar 'PopulateListView()'-metoden för att skjuta in värdena i ListView-boxen.
            foreach (Person person in adressBook) PopulateListView(person);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Initierar ett nytt objekt och skickar värdena från textboxarna till constructorn i AdressEntry-klassen, lägger sen till objektet i 'adressBook'-listan.
            Person person = new Person(textName.Text, textStreet.Text, textZipCode.Text, textCity.Text, textPhoneNumber.Text, textEmailAdress.Text);

            adressBook.Add(person);
            FileManager fileManager = new FileManager(adressBook);
            PopulateListView(person);

            //Anropar metoden 'ClearTextFields()' som tömmer textfälten.
            ClearTextFields();
        }

        private void listAdressEntries_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listAdressEntries.Items.Clear();

            //Tar emot sökkriteriet.
            string searchCondition = textSearchBox.Text;

            //Loopar igenom varje person-objekt i adressBook-listan.
            foreach (Person entry in adressBook)
            {
                //Kontrollerar om man fyllt i något i Sök-fältet.
                if (searchCondition.Length > 0)
                {
                    //Söker på sökkriteriet man fyllt i Sök-fältet och visar träffar.
                    if (entry.Name.ToString().ToLower().Contains(searchCondition.ToLower().Trim()) || entry.City.ToString().ToLower().Contains(searchCondition.ToLower().Trim()))
                    {
                        PopulateListView(entry);
                    }
                }

                //Om man trycker på Sök-knappen utan att ha fyllt i något visas samtliga poster i listan.
                else
                {
                    listAdressEntries.Items.Clear();

                    foreach (Person entries in adressBook)
                    {
                        PopulateListView(entries);
                    }
                }
            }
            ClearTextFields();

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

                //Ändrar vilken knapp som är synlig, Spara eller Ändra. Ändra visas eftersom en post ska modifieras.
                buttonSave.Visible = false;
                buttonModify.Visible = true;
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Kontrollerar så att listan har entries, resulterar annars i ett exception-error.
            if (listAdressEntries.SelectedItems.Count > 0)
            {
                //Tar bort den valda raden ur adressBook-listan och listviewboxen samt skriver den nya adressbook-litan till fil.
                int selectedIndex = listAdressEntries.SelectedItems[0].Index;
                adressBook.RemoveAt(selectedIndex);
                listAdressEntries.Items.RemoveAt(selectedIndex);
                FileManager fileManager = new FileManager(adressBook);
            }

            buttonSave.Text = "Spara";

            ClearTextFields();
        }
        private void buttonModify_Click(object sender, EventArgs e)
        {
            Person person = new Person(textName.Text, textStreet.Text, textZipCode.Text, textCity.Text, textPhoneNumber.Text, textEmailAdress.Text);

            int selectedIndex = listAdressEntries.SelectedItems[0].Index;
            adressBook.RemoveAt(selectedIndex);
            adressBook.Insert(selectedIndex, person);
            listAdressEntries.Items.RemoveAt(selectedIndex);

            //Borde gå att fixa till en metod som tar emot ett index och ett ListViewItem, istället för att ha detta både i Modify-knappen OCH PopulateListView-metoden.

            ListViewItem list = new ListViewItem(person.Name); //Initierar ett nytt ListViewItem-objekt med namnet 'list' och hämtar item plus subitems från adressEntry-klassen.
            list.SubItems.Add(person.Street);
            list.SubItems.Add(person.ZipCode);
            list.SubItems.Add(person.City);
            list.SubItems.Add(person.PhoneNumber);
            list.SubItems.Add(person.EmailAdress);
            listAdressEntries.Items.Insert(selectedIndex, list); //Lägger till alla items i 'list'-objektet i det visuella fönstret.

            FileManager fileManager = new FileManager(adressBook);

            ClearTextFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearTextFields();
        }

        private void PopulateListView(Person x)
        {
            ListViewItem list = new ListViewItem(x.Name);
            list.SubItems.Add(x.Street);
            list.SubItems.Add(x.ZipCode);
            list.SubItems.Add(x.City);
            list.SubItems.Add(x.PhoneNumber);
            list.SubItems.Add(x.EmailAdress);
            listAdressEntries.Items.Add(list);

        }

        private void ClearTextFields()
        {
            //Tömmer alla textfält för personuppgifter. Går det inte att göra genom någon form av loop?!
            textName.Clear();
            textStreet.Clear();
            textZipCode.Clear();
            textCity.Clear();
            textPhoneNumber.Clear();
            textEmailAdress.Clear();

            //Eftersom alla fält är tömda kommer det som fylls i bli en ny post, därav visas Save-knappen och Ändra är dold.
            buttonSave.Visible = true;
            buttonModify.Visible = false;
        }
    }
}