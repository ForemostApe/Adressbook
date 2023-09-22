using Adressbook.Classes;

namespace Adressbook
{
    public partial class FormAdressbook : Form
    {
        List<AdressEntry> adressbook = new List<AdressEntry>();


        public FormAdressbook()
        {
            InitializeComponent();
        }

        private void listAdressViewPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            adressbook.Add(new AdressEntry(textName.Text));
            adressbook.Add(new AdressEntry(textStreet.Text));
            adressbook.Add(new AdressEntry(textPostalCode.Text));
            adressbook.Add(new AdressEntry(textCity.Text));
            adressbook.Add(new AdressEntry(textPhoneNumber.Text));
            adressbook.Add(new AdressEntry(textEmailAdress.Text));

            MessageBox.Show(AdressEntry adressbook);
            
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
    }
}
