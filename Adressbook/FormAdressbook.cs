using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }
    }
}
