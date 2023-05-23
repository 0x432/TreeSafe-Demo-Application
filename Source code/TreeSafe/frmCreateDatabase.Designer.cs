namespace TreeSafe
{
    partial class frmCreateDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateDatabase));
            this.ToLoginButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.DBnameInput = new System.Windows.Forms.TextBox();
            this.DBnameLabel = new System.Windows.Forms.Label();
            this.DBpasswordLabel = new System.Windows.Forms.Label();
            this.DBpasswordInput = new System.Windows.Forms.TextBox();
            this.DBpasswordConfirmLabel = new System.Windows.Forms.Label();
            this.ConfirmDBpasswordInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ToLoginButton
            // 
            this.ToLoginButton.Location = new System.Drawing.Point(211, 128);
            this.ToLoginButton.Name = "ToLoginButton";
            this.ToLoginButton.Size = new System.Drawing.Size(176, 23);
            this.ToLoginButton.TabIndex = 11;
            this.ToLoginButton.Text = "Back";
            this.ToLoginButton.UseVisualStyleBackColor = true;
            this.ToLoginButton.Click += new System.EventHandler(this.ToLoginButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(12, 129);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(176, 23);
            this.CreateButton.TabIndex = 10;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // DBnameInput
            // 
            this.DBnameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DBnameInput.Location = new System.Drawing.Point(124, 20);
            this.DBnameInput.Name = "DBnameInput";
            this.DBnameInput.Size = new System.Drawing.Size(263, 16);
            this.DBnameInput.TabIndex = 7;
            // 
            // DBnameLabel
            // 
            this.DBnameLabel.AutoSize = true;
            this.DBnameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DBnameLabel.Location = new System.Drawing.Point(12, 17);
            this.DBnameLabel.Name = "DBnameLabel";
            this.DBnameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DBnameLabel.Size = new System.Drawing.Size(106, 19);
            this.DBnameLabel.TabIndex = 6;
            this.DBnameLabel.Text = "Database Name";
            // 
            // DBpasswordLabel
            // 
            this.DBpasswordLabel.AutoSize = true;
            this.DBpasswordLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DBpasswordLabel.Location = new System.Drawing.Point(12, 53);
            this.DBpasswordLabel.Name = "DBpasswordLabel";
            this.DBpasswordLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DBpasswordLabel.Size = new System.Drawing.Size(111, 19);
            this.DBpasswordLabel.TabIndex = 12;
            this.DBpasswordLabel.Text = "Create Password";
            // 
            // DBpasswordInput
            // 
            this.DBpasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DBpasswordInput.Location = new System.Drawing.Point(124, 55);
            this.DBpasswordInput.Name = "DBpasswordInput";
            this.DBpasswordInput.Size = new System.Drawing.Size(263, 16);
            this.DBpasswordInput.TabIndex = 13;
            this.DBpasswordInput.UseSystemPasswordChar = true;
            this.DBpasswordInput.TextChanged += new System.EventHandler(this.CreatePasswordInput_TextChanged);
            // 
            // DBpasswordConfirmLabel
            // 
            this.DBpasswordConfirmLabel.AutoSize = true;
            this.DBpasswordConfirmLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DBpasswordConfirmLabel.Location = new System.Drawing.Point(12, 88);
            this.DBpasswordConfirmLabel.Name = "DBpasswordConfirmLabel";
            this.DBpasswordConfirmLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DBpasswordConfirmLabel.Size = new System.Drawing.Size(120, 19);
            this.DBpasswordConfirmLabel.TabIndex = 14;
            this.DBpasswordConfirmLabel.Text = "Confirm Password";
            this.DBpasswordConfirmLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // ConfirmDBpasswordInput
            // 
            this.ConfirmDBpasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmDBpasswordInput.Location = new System.Drawing.Point(138, 90);
            this.ConfirmDBpasswordInput.Name = "ConfirmDBpasswordInput";
            this.ConfirmDBpasswordInput.Size = new System.Drawing.Size(249, 16);
            this.ConfirmDBpasswordInput.TabIndex = 15;
            this.ConfirmDBpasswordInput.UseSystemPasswordChar = true;
            // 
            // frmCreateDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 160);
            this.Controls.Add(this.ConfirmDBpasswordInput);
            this.Controls.Add(this.DBpasswordConfirmLabel);
            this.Controls.Add(this.DBpasswordInput);
            this.Controls.Add(this.DBpasswordLabel);
            this.Controls.Add(this.ToLoginButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.DBnameInput);
            this.Controls.Add(this.DBnameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCreateDatabase";
            this.Text = "Create Database - TreeSafe";
            this.Load += new System.EventHandler(this.frmCreateDatabase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ToLoginButton;
        private Button CreateButton;
        private TextBox DBnameInput;
        private Label DBnameLabel;
        private Label DBpasswordLabel;
        private TextBox DBpasswordInput;
        private Label DBpasswordConfirmLabel;
        private TextBox ConfirmDBpasswordInput;
    }
}