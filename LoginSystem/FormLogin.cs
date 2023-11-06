using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginSystem.Entities;

namespace LoginSystem
{
    public partial class FormLogin : Form
    {
        public static bool Cancel = false;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            string name = txtUser.Text;
            string password = txtPassword.Text;

            if (UserRegister.Login(name, password))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Acesso Negado!");
                txtUser.Text = "";
                txtPassword.Text = "";
                txtUser.Focus();
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {   
            Cancel = true;
            Close(); 
        }
    }
}
