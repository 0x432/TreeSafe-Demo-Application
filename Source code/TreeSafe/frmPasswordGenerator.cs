using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeSafe
{
    public partial class frmPasswordGenerator : Form
    {
        public frmPasswordGenerator()
        {
            InitializeComponent();
        }

        private void frmPasswordGenerator_Load(object sender, EventArgs e)
        {

        }

        private void PasswordLengthTrackBar_Scroll(object sender, EventArgs e)
        {
            LengthCounterLabel.Text = PasswordLengthTrackBar.Value.ToString() + " Character Password";
        }

        private void LengthCounterLabel_Click(object sender, EventArgs e)
        {

        }

        private void GenerateNewPasswordButton_Click(object sender, EventArgs e)
        {
            int length = PasswordLengthTrackBar.Value;
            bool includeSpecials = IncludeSpecialCharsCheckBox.Checked;

            string password = UserLogic.GenerateString(length, includeSpecials);

            DisplayPasswordOutput.Text = password;
            CopyPasswordButton.Enabled = !string.IsNullOrEmpty(password);
        }


        private void CopyPasswordButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DisplayPasswordOutput.Text))
            {
                CopyPasswordButton.Enabled = false;
            }
            else
            {
                System.Windows.Forms.Clipboard.SetText(DisplayPasswordOutput.Text);
            }
        }

    }
}
