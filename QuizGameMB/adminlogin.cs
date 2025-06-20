using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Xml.Serialization;
using System.Configuration;

namespace QuizGameMB
{
    public partial class adminlogin : Form
    {
        private string configPath = "app.config";
        public string InputPassword { get; private set; } 

        public adminlogin()
        {
            InitializeComponent();
        }

        private string GetAdminPassword()
        {
            return ConfigurationManager.AppSettings["adminPassword"];
        }

        private void welcome_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminlogin_Load(object sender, EventArgs e)
        {

        }

       
        private void btnLogin_click(object sender, EventArgs e)
        {
            string enteredPassword = txtPassword.Text;
            string adminPassword = GetAdminPassword();

            if (adminPassword == null)
                return;

            if (enteredPassword == adminPassword)
            {
                MessageBox.Show("Login successful!");
                // Proceed to admin panel
                this.DialogResult = DialogResult.OK;
                this.Close();
                adminlogin adminPanel = new adminlogin();
                adminPanel.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect password.");
            }
        }
    }
}
