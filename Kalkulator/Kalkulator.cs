﻿using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulatorr
{
    public partial class Kalkulator : Form
    {
        public Kalkulator()
        {
            InitializeComponent();
        }

        public Kalkulator(User k)
        {
            InitializeComponent();
            lblDobrodoslica.Text = "Dobrodosao/la ";
            lblDobrodoslica.Text += k.Name;
        }

        private void btnZbir_Click(object sender, EventArgs e)
        {

        }
    }
}
