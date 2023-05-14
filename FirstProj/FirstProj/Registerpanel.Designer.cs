namespace FirstProj
{
    partial class Registerpanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            signinLabel = new LinkLabel();
            label4 = new Label();
            registerBtn = new Button();
            passwordTxtBox = new TextBox();
            usernameTxtBox = new TextBox();
            emailTxtBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            CaLabel = new Label();
            SuspendLayout();
            // 
            // signinLabel
            // 
            signinLabel.AutoSize = true;
            signinLabel.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            signinLabel.LinkColor = Color.DodgerBlue;
            signinLabel.Location = new Point(169, 328);
            signinLabel.Name = "signinLabel";
            signinLabel.Size = new Size(30, 11);
            signinLabel.TabIndex = 26;
            signinLabel.TabStop = true;
            signinLabel.Text = "Sign in";
            signinLabel.LinkClicked += signinLabel_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(75, 329);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(98, 11);
            label4.TabIndex = 25;
            label4.Text = "Already have an account?";
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.LimeGreen;
            registerBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registerBtn.Location = new Point(27, 266);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(226, 34);
            registerBtn.TabIndex = 22;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.ForeColor = SystemColors.WindowFrame;
            passwordTxtBox.Location = new Point(30, 223);
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.PlaceholderText = "Enter Password";
            passwordTxtBox.RightToLeft = RightToLeft.No;
            passwordTxtBox.Size = new Size(224, 23);
            passwordTxtBox.TabIndex = 21;
            // 
            // usernameTxtBox
            // 
            usernameTxtBox.ForeColor = SystemColors.WindowFrame;
            usernameTxtBox.Location = new Point(28, 175);
            usernameTxtBox.Name = "usernameTxtBox";
            usernameTxtBox.PlaceholderText = "Enter Username";
            usernameTxtBox.RightToLeft = RightToLeft.No;
            usernameTxtBox.Size = new Size(226, 23);
            usernameTxtBox.TabIndex = 20;
            // 
            // emailTxtBox
            // 
            emailTxtBox.ForeColor = SystemColors.WindowFrame;
            emailTxtBox.Location = new Point(28, 127);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.PlaceholderText = "Enter Email Address";
            emailTxtBox.RightToLeft = RightToLeft.No;
            emailTxtBox.Size = new Size(226, 23);
            emailTxtBox.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 205);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 18;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 157);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 17;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 109);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 16;
            label1.Text = "Email";
            // 
            // CaLabel
            // 
            CaLabel.AutoSize = true;
            CaLabel.Font = new Font("Bell MT", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CaLabel.Location = new Point(75, 65);
            CaLabel.Name = "CaLabel";
            CaLabel.Size = new Size(138, 23);
            CaLabel.TabIndex = 15;
            CaLabel.Text = "Create Account";
            // 
            // Registerpanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(signinLabel);
            Controls.Add(label4);
            Controls.Add(registerBtn);
            Controls.Add(passwordTxtBox);
            Controls.Add(usernameTxtBox);
            Controls.Add(emailTxtBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CaLabel);
            Name = "Registerpanel";
            Size = new Size(280, 359);
            Load += Registerpanel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel signinLabel;
        private Label label4;
        private Button registerBtn;
        private TextBox passwordTxtBox;
        private TextBox usernameTxtBox;
        private TextBox emailTxtBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label CaLabel;
    }
}
