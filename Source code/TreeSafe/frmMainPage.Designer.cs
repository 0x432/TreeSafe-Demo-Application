namespace TreeSafe
{
    partial class frmMainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainPage));
            this.AccountTable = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddEntryButton = new System.Windows.Forms.Button();
            this.LoignButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AccountTable)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountTable
            // 
            this.AccountTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.AccountTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.AccountTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Username,
            this.Email,
            this.Password});
            this.AccountTable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AccountTable.GridColor = System.Drawing.SystemColors.Control;
            this.AccountTable.Location = new System.Drawing.Point(12, 12);
            this.AccountTable.Name = "AccountTable";
            this.AccountTable.RowHeadersWidth = 60;
            this.AccountTable.RowTemplate.Height = 25;
            this.AccountTable.Size = new System.Drawing.Size(610, 313);
            this.AccountTable.TabIndex = 0;
            this.AccountTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 124;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 124;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 150;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 150;
            // 
            // AddEntryButton
            // 
            this.AddEntryButton.Location = new System.Drawing.Point(12, 331);
            this.AddEntryButton.Name = "AddEntryButton";
            this.AddEntryButton.Size = new System.Drawing.Size(177, 23);
            this.AddEntryButton.TabIndex = 11;
            this.AddEntryButton.Text = "Add Entry";
            this.AddEntryButton.UseVisualStyleBackColor = true;
            this.AddEntryButton.Click += new System.EventHandler(this.AddEntryButton_Click);
            // 
            // LoignButton
            // 
            this.LoignButton.Location = new System.Drawing.Point(230, 331);
            this.LoignButton.Name = "LoignButton";
            this.LoignButton.Size = new System.Drawing.Size(177, 23);
            this.LoignButton.TabIndex = 12;
            this.LoignButton.Text = "refresh";
            this.LoignButton.UseVisualStyleBackColor = true;
            this.LoignButton.Click += new System.EventHandler(this.LoignButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(445, 331);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(177, 23);
            this.LogoutButton.TabIndex = 13;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.LoignButton);
            this.Controls.Add(this.AddEntryButton);
            this.Controls.Add(this.AccountTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMainPage";
            this.Text = "frmMainPage";
            this.Load += new System.EventHandler(this.frmMainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccountTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView AccountTable;
        private Button AddEntryButton;
        private Button LoignButton;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Password;
        private Button LogoutButton;
    }
}