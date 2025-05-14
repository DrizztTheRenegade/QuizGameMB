using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGameMB
{
    public partial class adminlogin : Form
    {
        public string InputPassword { get; private set; } 
        public adminlogin()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            InputPassword = textBox1.Text;
            this.DialogResult = DialogResult.OK; // Set the dialog result to OK
            this.Close(); // Close the form
        }
    }
}
