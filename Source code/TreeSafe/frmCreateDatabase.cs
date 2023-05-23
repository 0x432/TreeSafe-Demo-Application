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

namespace TreeSafe
{
    public partial class frmCreateDatabase : Form
    {
        public frmCreateDatabase()
        {
            InitializeComponent();
        }

        private void CreatePasswordInput_TextChanged(object sender, EventArgs e)
        {

        }


        public void CreateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DBnameInput.Text))
            {
                MessageBox.Show("Please enter a database name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(DBpasswordInput.Text))
            {
                MessageBox.Show("Please enter a password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!UserLogic.IsPasswordValid(DBpasswordInput.Text))
            {
                MessageBox.Show("Please enter a password that is at least 6 characters long and includes a special character", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DBpasswordInput.Text != ConfirmDBpasswordInput.Text)
            {
                MessageBox.Show("Your passwords do not match please try again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string filePath = Path.Combine(appDataPath, "readfromdatabase.txt");

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(DBpasswordInput.Text);
                    writer.WriteLine("");
                }

                SaveFileDialog saveFileDialog = UserLogic.CreateSaveFileDialog(DBnameInput.Text);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
  
                    int number = UserLogic.GetRandomNumber(180,256);
                    UserLogic.CurrentSize = number;
                    string encryptedString = UserLogic.GenerateString(number, false);
                    File.WriteAllText(saveFileDialog.FileName, encryptedString + "\n");
                }

                MessageBox.Show("Success: Database created");
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
                this.Hide();
            }
        }

        private void ToLoginButton_Click(object sender, EventArgs e)
        {
            if (Tag is frmLogin frmLogin)
            {
                frmLogin.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Error: parent form not found.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmCreateDatabase_Load(object sender, EventArgs e)
        {

        }
    }
}
