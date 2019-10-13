using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controler;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(User u)
        {
            InitializeComponent();
            lblDobrodoslica.Text = "Dobrodosao/la ";
            lblDobrodoslica.Text += u.Name;
        }

        private void btnZbir_Click(object sender, EventArgs e)
        {
            Controler.Controler c = new Controler.Controler();
            if (c.SumNumber(txtPrviBroj.Text, txtDrugBroj.Text) != Int32.MaxValue)
            {
                txtRezultat.Text = c.SumNumber(txtPrviBroj.Text, txtDrugBroj.Text).ToString();
            }
            else
            {
                MessageBox.Show("Uneti neadekvatni brojevi!");
            }
        }

        private void btnRazlika_Click(object sender, EventArgs e)
        {
            Controler.Controler c = new Controler.Controler();
            if (c.DifferenceBettwen(txtPrviBroj.Text,txtDrugBroj.Text) != Int32.MaxValue)
            {
                txtRezultat.Text = c.DifferenceBettwen(txtPrviBroj.Text, txtDrugBroj.Text).ToString();
            }
            else
            {
                MessageBox.Show("Uneti neadekvatni brojevi!");
            }
        }
    }
}
