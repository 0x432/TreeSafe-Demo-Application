using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.LinkLabel;

namespace TreeSafe
{
    public partial class frmAddEntry : Form
    {

        private const char Separator = '|';
        private readonly string FilePath = UserLogic.filePath;

        public frmAddEntry()
        {
            InitializeComponent();
        }

        private void AddEntryButton_Click(object sender, EventArgs e)
        {
            string title = TitleInput.Text.Trim();
            string username = UsernameInput.Text.Trim();
            string email = EmailInput.Text.Trim();
            string password = PasswordInput.Text;

            if (string.IsNullOrWhiteSpace(title) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter valid data for all fields.");
                return;
            }

            if (!UserLogic.IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            if (!UserLogic.IsPasswordValid(password))
            {
                MessageBox.Show("Please enter a stronger password.");
                return;
            }

            StringBuilder data = new StringBuilder();
            data.Append(title).Append(Separator)
                .Append(username).Append(Separator)
                .Append(email).Append(Separator)
                .Append(password);

            try
            {
                using (StreamWriter writer = File.AppendText(FilePath))
                {
                    writer.WriteLine(data);
                    int number = UserLogic.GetRandomNumber(UserLogic.currentSize, UserLogic.currentSize + 125);
                    UserLogic.currentSize = number;
                    string encryptedString = UserLogic.GenerateString(number, false);
                    string str = "\n" + encryptedString;
                    File.WriteAllText(UserLogic.encryptedFilePath, encryptedString + "\n");
                    MessageBox.Show($"Data saved, press refresh to update database");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding entry: {ex.Message}");
            }

        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }


        private void UsernameTabel_Click(object sender, EventArgs e)
        {

        }

        private void EmailLabel_Click(object sender, EventArgs e)
        {

        }


        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmPasswordGenerator frmPasswordGenerator = new frmPasswordGenerator();
            frmPasswordGenerator.Tag = this;
            frmPasswordGenerator.Show(this);
        }

        private void frmAddEntry_Load(object sender, EventArgs e)
        {

        }
    }
}
