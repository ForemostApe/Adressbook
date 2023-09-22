using Adressbook.Classes;

namespace Adressbook
{
    public partial class FormAdressbook : Form
    {
        List<string> adressbook = new List<string>();


        public FormAdressbook()
        {
            InitializeComponent();
        }

        private void FormAdressbook_Load(object sender, EventArgs e)
        {
            LoadFileToList();
        }

        private void listAdressViewPort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            adressbook.Add(textName.Text);
            adressbook.Add(textStreet.Text);
            adressbook.Add(textPostalCode.Text);
            adressbook.Add(textCity.Text);
            adressbook.Add(textPhoneNumber.Text);
            adressbook.Add(textEmailAdress.Text);

            ClearTextFields();
        }

        private void ClearTextFields()
        {
            textName.Clear();
            textStreet.Clear();
            textPostalCode.Clear();
            textCity.Clear();
            textPhoneNumber.Clear();
            textEmailAdress.Clear();
        }

        private void LoadFileToList()
        {
            FileManager fileManager = new FileManager();

            foreach (string entry in fileManager.ReadFromFile())
            {
                adressbook.Add(entry.ToString());
            }

            ListView listView = new ListView();

            ListViewItem listEntry = new ListViewItem(adressbook[0]);

            for (int i = 0; i < adressbook.Count; i++)
            {
                listEntry.SubItems.Add(adressbook[i]);
            }

            //ListViewItem listEntry = new ListViewItem(adressbook[0]);
            //listEntry.SubItems.Add(adressbook[1]);
            //listEntry.SubItems.Add(adressbook[2]);
            //listEntry.SubItems.Add(adressbook[3]);
            //listEntry.SubItems.Add(adressbook[4]);
            //listEntry.SubItems.Add(adressbook[5]);
            //listEntry.SubItems.Add(adressbook[6]);



            listAdressViewPort.Items.AddRange(new ListViewItem[] { listEntry });


        }
    }

}


