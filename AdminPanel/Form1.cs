using StorageUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StorageUsers;
using Domen;

namespace AdminPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StorageUsers.StorageDatabase storageDatabase = new StorageDatabase();
            List<User> users = storageDatabase.AllUsers();
            lstViewUsers.Items.Add("Name\tUsername\tPassword\tEmail");
            foreach(User u in users)
            {
                string row = $"{u.Name}\t{u.Username}\t{u.Password}\t{u.Email}";
                lstViewUsers.Items.Add(row);
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
