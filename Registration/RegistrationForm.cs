using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrujSe_Click(object sender, EventArgs e)
        {
            Controler.Controler c = new Controler.Controler();
            if(c.CreateNewUser(txtImePrezime.Text, txtEmail.Text, txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Uspesno kreiran korisnik.");
            }
            else
            {
                MessageBox.Show("Neuspesno kreiran korisnik.");
            }
        }
    }
}
