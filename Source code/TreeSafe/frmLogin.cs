using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace TreeSafe
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void CreateDatabaseButton_Click(object sender, EventArgs e)
        {
            frmCreateDatabase frmCreateDatabase = new frmCreateDatabase();
            frmCreateDatabase.Tag = this;
            frmCreateDatabase.Show(this);
            Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "C:\\Users\\Admin\\AppData\\Roaming\\readfromdatabase.txt";
                string encryptedFilepath = DatabaseInputTextBox.Text;
                if (string.IsNullOrEmpty(filePath))
                {
                    throw new ArgumentException("Please select a database file.");
                }

                string[] lines = File.ReadLines(filePath).ToArray();

                if (lines.Length == 0)
                {
                    throw new ArgumentException("The database file is empty.");
                }

                string DBpassword = lines[0];

                if (DBpassword == PasswordInput.Text)
                {
                    UserLogic.Password = PasswordInput.Text;
                    UserLogic.FilePath = filePath;
                    UserLogic.EncryptedFilePath = encryptedFilepath;
                    frmMainPage mainForm = new frmMainPage();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect password. Please try again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelectDatabaseURL_Click(object sender, EventArgs e)
        {
            DatabaseInputTextBox.Text = UserLogic.GetSelectedFilePath();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
