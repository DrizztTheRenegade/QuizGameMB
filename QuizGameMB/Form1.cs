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
    public partial class ExaQuiz: Form
    {
        public ExaQuiz()
        {
            InitializeComponent();
        }

        private void welcome_Click(object sender, EventArgs e)
        {

        }

        private void userlogin_Click(object sender, EventArgs e)
        {
            userLoginForm userLoginForm = new userLoginForm();
            userLoginForm.ShowDialog();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();

        }

        private void adminlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminlogin adminLoginForm = new adminlogin();
            adminLoginForm.ShowDialog();
        }

        private void panelmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void help_Click(object sender, EventArgs e)
        {
            helpForm helpForm = new helpForm();
            helpForm.ShowDialog();
        }

        private void ExaQuiz_Load(object sender, EventArgs e)
        {

        }
    }
}
