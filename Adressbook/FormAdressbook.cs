using Adressbook.Classes;

namespace Adressbook
{
    public partial class FormAdressbook : Form
    {

        List<string> addressBook = new List<string>();
        

        public FormAdressbook()
        {
            InitializeComponent();
        }

        private void listAdressViewPort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            Person.Name = textName.Text;

        }

        private void ClearTextFields()
        {
            textName.Clear();
        }

        
    }
}
