using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectVersion2
{
    public partial class LoginForm : Form
    {
        private string username = "admin";
        private string password = "12345";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usernameInput, passwordInput;
            usernameInput = txtUsername.Text;
            passwordInput = txtPassword.Text;
            if (usernameInput != username || passwordInput != password)
            {
                MessageBox.Show("Username or Password is incorrect. Please try again.");
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
            else
            {
                txtUsername.Text = "";
                txtPassword.Text = "";
                InventoryForm inventorySystem = new InventoryForm();
                inventorySystem.Show();
                btnLogin.Enabled = false;
            } 
        }
    }
}
