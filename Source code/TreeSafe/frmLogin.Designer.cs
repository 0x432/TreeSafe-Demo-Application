namespace TreeSafe
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.CreateDatabaseButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SelectDatabaseURL = new System.Windows.Forms.Button();
            this.DatabaseInputTextBox = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.PasswordLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateDatabaseButton
            // 
            this.CreateDatabaseButton.Location = new System.Drawing.Point(145, 73);
            this.CreateDatabaseButton.Name = "CreateDatabaseButton";
            this.CreateDatabaseButton.Size = new System.Drawing.Size(124, 23);
            this.CreateDatabaseButton.TabIndex = 11;
            this.CreateDatabaseButton.Text = "Create Database";
            this.CreateDatabaseButton.UseVisualStyleBackColor = true;
            this.CreateDatabaseButton.Click += new System.EventHandler(this.CreateDatabaseButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(10, 73);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(124, 23);
            this.LoginButton.TabIndex = 10;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // SelectDatabaseURL
            // 
            this.SelectDatabaseURL.Location = new System.Drawing.Point(194, 31);
            this.SelectDatabaseURL.Name = "SelectDatabaseURL";
            this.SelectDatabaseURL.Size = new System.Drawing.Size(75, 23);
            this.SelectDatabaseURL.TabIndex = 9;
            this.SelectDatabaseURL.Text = "Select";
            this.SelectDatabaseURL.UseVisualStyleBackColor = true;
            this.SelectDatabaseURL.Click += new System.EventHandler(this.SelectDatabaseURL_Click);
            // 
            // DatabaseInputTextBox
            // 
            this.DatabaseInputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatabaseInputTextBox.Location = new System.Drawing.Point(10, 35);
            this.DatabaseInputTextBox.Name = "DatabaseInputTextBox";
            this.DatabaseInputTextBox.PlaceholderText = "Select Database";
            this.DatabaseInputTextBox.ReadOnly = true;
            this.DatabaseInputTextBox.Size = new System.Drawing.Size(178, 16);
            this.DatabaseInputTextBox.TabIndex = 8;
            // 
            // PasswordInput
            // 
            this.PasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordInput.Location = new System.Drawing.Point(73, 8);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(196, 16);
            this.PasswordInput.TabIndex = 7;
            this.PasswordInput.UseSystemPasswordChar = true;
            // 
            // PasswordLable
            // 
            this.PasswordLable.AutoSize = true;
            this.PasswordLable.Location = new System.Drawing.Point(10, 8);
            this.PasswordLable.Name = "PasswordLable";
            this.PasswordLable.Size = new System.Drawing.Size(57, 15);
            this.PasswordLable.TabIndex = 6;
            this.PasswordLable.Text = "Password";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 105);
            this.Controls.Add(this.CreateDatabaseButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.SelectDatabaseURL);
            this.Controls.Add(this.DatabaseInputTextBox);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.PasswordLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.Text = "Login - TreeSafe";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CreateDatabaseButton;
        private Button LoginButton;
        private Button SelectDatabaseURL;
        private TextBox DatabaseInputTextBox;
        private TextBox PasswordInput;
        private Label PasswordLable;
    }
}