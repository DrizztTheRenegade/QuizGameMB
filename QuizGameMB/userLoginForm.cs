using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace QuizGameMB
{
    public partial class userLoginForm : Form
    {
        private string usersFilePath = "users.xml";

        public userLoginForm()
        {
            InitializeComponent();
        }

      

        private UserList LoadUsers()
        {
            if (!File.Exists(usersFilePath))
                return new UserList();

            try
            {
                using (FileStream fs = new FileStream(usersFilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(UserList));
                    return (UserList)serializer.Deserialize(fs);
                }
            }
            catch
            {
                return new UserList();
            }
        }

        private void SaveUsers(UserList userList)
        {
            using (FileStream fs = new FileStream(usersFilePath, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(UserList));
                serializer.Serialize(fs, userList);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void userLoginBtn_Click(object sender, EventArgs e)
        {
            string userNameValue = userName.Text.Trim();
            if (string.IsNullOrEmpty(userNameValue))
            {
                MessageBox.Show("Please enter your name.");
                return;
            }

            UserList userList = LoadUsers();
            userList.Users.Add(new User { Name = userNameValue });
            SaveUsers(userList);

            // Open QuizForm
            QuizForm quizForm = new QuizForm();
            quizForm.Show();
            this.Hide();
        }
    }
}
