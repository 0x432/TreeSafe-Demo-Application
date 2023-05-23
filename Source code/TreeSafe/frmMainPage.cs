using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace TreeSafe
{
    public partial class frmMainPage : Form
    {
        public frmMainPage()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddEntryButton_Click(object sender, EventArgs e)
        {
            frmAddEntry frmAddEntry = new frmAddEntry();
            frmAddEntry.Tag = this;
            frmAddEntry.Show(this);
        }

        private void frmMainPage_Load(object sender, EventArgs e)
        {
            Text = "TreeSafe - " + UserLogic.EncryptedFilePath;
            AccountTable.UserDeletingRow += dataGridView1_UserDeletingRow;
            AddRow();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var cellValues = new object[e.Row.Cells.Count];
            for (int i = 0; i < e.Row.Cells.Count; i++)
            {
                cellValues[i] = e.Row.Cells[i].Value;
            }

            string rowDataString = string.Join("|", cellValues);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                string filePath = UserLogic.FilePath;
                HashSet<string> lines = new HashSet<string>(File.ReadAllLines(filePath));
                string matchingLine = lines.FirstOrDefault(line => line.Contains(rowDataString));
                if (matchingLine != null)
                {
                    lines.Remove(matchingLine);
                    File.WriteAllLines(filePath, lines);
                }
            }


        }

        private void LoignButton_Click(object sender, EventArgs e)
        {
            AddRow();
        }

        void AddRow()
        {
            AccountTable.Rows.Clear();

            StringBuilder sb = new StringBuilder();
            using (StreamReader reader = new StreamReader(UserLogic.FilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    sb.AppendLine(line);
                }
            }

            string[] rows = sb.ToString().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            AccountTable.SuspendLayout();
            AccountTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            foreach (string row in rows)
            {
                string[] data_array = row.Split('|');
                if (data_array.Length >= 4)
                {
                    AccountTable.Rows.Add(data_array);
                }
            }

            AccountTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AccountTable.ResumeLayout();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

       



    }
}
