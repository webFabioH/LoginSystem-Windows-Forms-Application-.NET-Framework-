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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            
            while (UserRegister.UserLogged == null)
            {
                Visible = false;
                formLogin.ShowDialog();

                if (FormLogin.Cancel)
                {
                    Application.Exit();
                    return;
                }
            }

            label_Welcome.Text = "Bem Vindo(a) \n" + UserRegister.UserLogged.Name;
            Visible = true;
        }
    }
}
