namespace TreeSafe
{
    partial class frmAddEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEntry));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.UsernameTabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.AddEntryButton = new System.Windows.Forms.Button();
            this.NavigateToPasswordGenerator = new System.Windows.Forms.PictureBox();
            this.TitleInput = new System.Windows.Forms.TextBox();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NavigateToPasswordGenerator)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(17, 17);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TitleLabel.Size = new System.Drawing.Size(37, 19);
            this.TitleLabel.TabIndex = 7;
            this.TitleLabel.Text = "Title:";
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // UsernameTabel
            // 
            this.UsernameTabel.AutoSize = true;
            this.UsernameTabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameTabel.Location = new System.Drawing.Point(17, 45);
            this.UsernameTabel.Name = "UsernameTabel";
            this.UsernameTabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UsernameTabel.Size = new System.Drawing.Size(74, 19);
            this.UsernameTabel.TabIndex = 8;
            this.UsernameTabel.Text = "Username:";
            this.UsernameTabel.Click += new System.EventHandler(this.UsernameTabel_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.Location = new System.Drawing.Point(17, 75);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EmailLabel.Size = new System.Drawing.Size(44, 19);
            this.EmailLabel.TabIndex = 9;
            this.EmailLabel.Text = "Email:";
            this.EmailLabel.Click += new System.EventHandler(this.EmailLabel_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.Location = new System.Drawing.Point(17, 105);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PasswordLabel.Size = new System.Drawing.Size(70, 19);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "Password:";
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // AddEntryButton
            // 
            this.AddEntryButton.Location = new System.Drawing.Point(17, 140);
            this.AddEntryButton.Name = "AddEntryButton";
            this.AddEntryButton.Size = new System.Drawing.Size(359, 23);
            this.AddEntryButton.TabIndex = 15;
            this.AddEntryButton.Text = "Add Entry";
            this.AddEntryButton.UseVisualStyleBackColor = true;
            this.AddEntryButton.Click += new System.EventHandler(this.AddEntryButton_Click);
            // 
            // NavigateToPasswordGenerator
            // 
            this.NavigateToPasswordGenerator.BackColor = System.Drawing.SystemColors.Control;
            this.NavigateToPasswordGenerator.BackgroundImage = global::TreeSafe.Properties.Resources.key_icon_clipart_3618256832;
            this.NavigateToPasswordGenerator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NavigateToPasswordGenerator.InitialImage = null;
            this.NavigateToPasswordGenerator.Location = new System.Drawing.Point(380, 108);
            this.NavigateToPasswordGenerator.Name = "NavigateToPasswordGenerator";
            this.NavigateToPasswordGenerator.Size = new System.Drawing.Size(15, 16);
            this.NavigateToPasswordGenerator.TabIndex = 16;
            this.NavigateToPasswordGenerator.TabStop = false;
            this.NavigateToPasswordGenerator.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TitleInput
            // 
            this.TitleInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleInput.Location = new System.Drawing.Point(113, 19);
            this.TitleInput.Name = "TitleInput";
            this.TitleInput.Size = new System.Drawing.Size(263, 16);
            this.TitleInput.TabIndex = 17;
            // 
            // UsernameInput
            // 
            this.UsernameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameInput.Location = new System.Drawing.Point(113, 48);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(263, 16);
            this.UsernameInput.TabIndex = 18;
            // 
            // EmailInput
            // 
            this.EmailInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailInput.Location = new System.Drawing.Point(113, 78);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(263, 16);
            this.EmailInput.TabIndex = 19;
            // 
            // PasswordInput
            // 
            this.PasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordInput.Location = new System.Drawing.Point(113, 108);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(263, 16);
            this.PasswordInput.TabIndex = 20;
            // 
            // frmAddEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 171);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.TitleInput);
            this.Controls.Add(this.NavigateToPasswordGenerator);
            this.Controls.Add(this.AddEntryButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.UsernameTabel);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddEntry";
            this.Text = "Add Entry - TreeSafe";
            this.Load += new System.EventHandler(this.frmAddEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NavigateToPasswordGenerator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TitleLabel;
        private Label UsernameTabel;
        private Label EmailLabel;
        private Label PasswordLabel;
        private Button AddEntryButton;
        private PictureBox NavigateToPasswordGenerator;
        private TextBox TitleInput;
        private TextBox UsernameInput;
        private TextBox EmailInput;
        private TextBox PasswordInput;
    }
}