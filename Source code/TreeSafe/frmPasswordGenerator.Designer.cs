namespace TreeSafe
{
    partial class frmPasswordGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPasswordGenerator));
            this.IncludeSpecialCharsCheckBox = new System.Windows.Forms.CheckBox();
            this.PasswordLengthTrackBar = new System.Windows.Forms.TrackBar();
            this.LengthCounterLabel = new System.Windows.Forms.Label();
            this.DisplayPasswordOutput = new System.Windows.Forms.TextBox();
            this.GenerateNewPasswordButton = new System.Windows.Forms.Button();
            this.CopyPasswordButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLengthTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // IncludeSpecialCharsCheckBox
            // 
            this.IncludeSpecialCharsCheckBox.AutoSize = true;
            this.IncludeSpecialCharsCheckBox.Location = new System.Drawing.Point(12, 12);
            this.IncludeSpecialCharsCheckBox.Name = "IncludeSpecialCharsCheckBox";
            this.IncludeSpecialCharsCheckBox.Size = new System.Drawing.Size(164, 19);
            this.IncludeSpecialCharsCheckBox.TabIndex = 0;
            this.IncludeSpecialCharsCheckBox.Text = "Include Special Characters";
            this.IncludeSpecialCharsCheckBox.UseVisualStyleBackColor = true;
            // 
            // PasswordLengthTrackBar
            // 
            this.PasswordLengthTrackBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordLengthTrackBar.Location = new System.Drawing.Point(56, 37);
            this.PasswordLengthTrackBar.Maximum = 100;
            this.PasswordLengthTrackBar.Minimum = 1;
            this.PasswordLengthTrackBar.Name = "PasswordLengthTrackBar";
            this.PasswordLengthTrackBar.Size = new System.Drawing.Size(283, 45);
            this.PasswordLengthTrackBar.TabIndex = 1;
            this.PasswordLengthTrackBar.Value = 1;
            this.PasswordLengthTrackBar.Scroll += new System.EventHandler(this.PasswordLengthTrackBar_Scroll);
            // 
            // LengthCounterLabel
            // 
            this.LengthCounterLabel.AutoSize = true;
            this.LengthCounterLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LengthCounterLabel.Location = new System.Drawing.Point(122, 67);
            this.LengthCounterLabel.Name = "LengthCounterLabel";
            this.LengthCounterLabel.Size = new System.Drawing.Size(142, 19);
            this.LengthCounterLabel.TabIndex = 2;
            this.LengthCounterLabel.Text = "1 Character Password";
            this.LengthCounterLabel.Click += new System.EventHandler(this.LengthCounterLabel_Click);
            // 
            // DisplayPasswordOutput
            // 
            this.DisplayPasswordOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DisplayPasswordOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DisplayPasswordOutput.Location = new System.Drawing.Point(41, 92);
            this.DisplayPasswordOutput.Name = "DisplayPasswordOutput";
            this.DisplayPasswordOutput.ReadOnly = true;
            this.DisplayPasswordOutput.Size = new System.Drawing.Size(298, 16);
            this.DisplayPasswordOutput.TabIndex = 3;
            this.DisplayPasswordOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GenerateNewPasswordButton
            // 
            this.GenerateNewPasswordButton.Location = new System.Drawing.Point(12, 119);
            this.GenerateNewPasswordButton.Name = "GenerateNewPasswordButton";
            this.GenerateNewPasswordButton.Size = new System.Drawing.Size(176, 23);
            this.GenerateNewPasswordButton.TabIndex = 5;
            this.GenerateNewPasswordButton.Text = "Generate";
            this.GenerateNewPasswordButton.UseVisualStyleBackColor = true;
            this.GenerateNewPasswordButton.Click += new System.EventHandler(this.GenerateNewPasswordButton_Click);
            // 
            // CopyPasswordButton
            // 
            this.CopyPasswordButton.Location = new System.Drawing.Point(211, 119);
            this.CopyPasswordButton.Name = "CopyPasswordButton";
            this.CopyPasswordButton.Size = new System.Drawing.Size(176, 23);
            this.CopyPasswordButton.TabIndex = 6;
            this.CopyPasswordButton.Text = "Copy Password";
            this.CopyPasswordButton.UseVisualStyleBackColor = true;
            this.CopyPasswordButton.Click += new System.EventHandler(this.CopyPasswordButton_Click);
            // 
            // frmPasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 154);
            this.Controls.Add(this.CopyPasswordButton);
            this.Controls.Add(this.GenerateNewPasswordButton);
            this.Controls.Add(this.DisplayPasswordOutput);
            this.Controls.Add(this.LengthCounterLabel);
            this.Controls.Add(this.PasswordLengthTrackBar);
            this.Controls.Add(this.IncludeSpecialCharsCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPasswordGenerator";
            this.Text = "Password Generator - TreeSafe";
            this.Load += new System.EventHandler(this.frmPasswordGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLengthTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox IncludeSpecialCharsCheckBox;
        private TrackBar PasswordLengthTrackBar;
        private Label LengthCounterLabel;
        private TextBox DisplayPasswordOutput;
        private Button GenerateNewPasswordButton;
        private Button CopyPasswordButton;
    }
}