using Domen;
using Registration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prijavljivanje
{
    public partial class Form1 : Form
    {
        Controler.Controler controler;
        public Form1()
        {
            InitializeComponent();
             controler = new Controler.Controler();
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
           

            User newUser = controler.IsValid(username, password);
            if(newUser == null)
            {
                MessageBox.Show("Nevalidni parametri");
            }
            else
            {
                Calculator.Form1 newForm = new Calculator.Form1(newUser);
                newForm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationForm rf = new RegistrationForm();
            rf.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminPanel.Form1 form = new AdminPanel.Form1();
            form.ShowDialog();
        }
    }
}
