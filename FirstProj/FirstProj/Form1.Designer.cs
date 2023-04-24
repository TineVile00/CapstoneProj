namespace FirstProj
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            signinLabel = new LinkLabel();
            label4 = new Label();
            googleBtn = new Button();
            facebookBtn = new Button();
            registerBtn = new Button();
            passwordTxtBox = new TextBox();
            usernameTxtBox = new TextBox();
            emailTxtBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            CaLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(signinLabel);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(googleBtn);
            panel1.Controls.Add(facebookBtn);
            panel1.Controls.Add(registerBtn);
            panel1.Controls.Add(passwordTxtBox);
            panel1.Controls.Add(usernameTxtBox);
            panel1.Controls.Add(emailTxtBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(CaLabel);
            panel1.Location = new Point(124, 25);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(280, 456);
            panel1.TabIndex = 1;
            // 
            // signinLabel
            // 
            signinLabel.AutoSize = true;
            signinLabel.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            signinLabel.LinkColor = Color.DodgerBlue;
            signinLabel.Location = new Point(166, 427);
            signinLabel.Name = "signinLabel";
            signinLabel.Size = new Size(30, 11);
            signinLabel.TabIndex = 12;
            signinLabel.TabStop = true;
            signinLabel.Text = "Sign in";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(71, 428);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(98, 11);
            label4.TabIndex = 10;
            label4.Text = "Already have an account?";
            // 
            // googleBtn
            // 
            googleBtn.Location = new Point(26, 366);
            googleBtn.Name = "googleBtn";
            googleBtn.RightToLeft = RightToLeft.Yes;
            googleBtn.Size = new Size(226, 29);
            googleBtn.TabIndex = 9;
            googleBtn.Text = "Continue with Google";
            googleBtn.UseVisualStyleBackColor = true;
            // 
            // facebookBtn
            // 
            facebookBtn.Location = new Point(26, 331);
            facebookBtn.Name = "facebookBtn";
            facebookBtn.RightToLeft = RightToLeft.Yes;
            facebookBtn.Size = new Size(226, 29);
            facebookBtn.TabIndex = 8;
            facebookBtn.Text = "Continue with Facebook ";
            facebookBtn.UseVisualStyleBackColor = true;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.LimeGreen;
            registerBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registerBtn.Location = new Point(26, 273);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(226, 29);
            registerBtn.TabIndex = 7;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = false;
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.ForeColor = SystemColors.WindowFrame;
            passwordTxtBox.Location = new Point(26, 224);
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.RightToLeft = RightToLeft.No;
            passwordTxtBox.Size = new Size(226, 23);
            passwordTxtBox.TabIndex = 6;
            passwordTxtBox.Text = "Enter Password";
            // 
            // usernameTxtBox
            // 
            usernameTxtBox.ForeColor = SystemColors.WindowFrame;
            usernameTxtBox.Location = new Point(26, 176);
            usernameTxtBox.Name = "usernameTxtBox";
            usernameTxtBox.RightToLeft = RightToLeft.No;
            usernameTxtBox.Size = new Size(226, 23);
            usernameTxtBox.TabIndex = 5;
            usernameTxtBox.Text = "Enter Username";
            // 
            // emailTxtBox
            // 
            emailTxtBox.ForeColor = SystemColors.WindowFrame;
            emailTxtBox.Location = new Point(26, 128);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.RightToLeft = RightToLeft.No;
            emailTxtBox.Size = new Size(226, 23);
            emailTxtBox.TabIndex = 4;
            emailTxtBox.Text = "Enter Email Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 206);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 158);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 110);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // CaLabel
            // 
            CaLabel.AutoSize = true;
            CaLabel.Font = new Font("Bell MT", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CaLabel.Location = new Point(72, 64);
            CaLabel.Name = "CaLabel";
            CaLabel.Size = new Size(138, 23);
            CaLabel.TabIndex = 0;
            CaLabel.Text = "Create Account";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 9, 64);
            ClientSize = new Size(546, 521);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label CaLabel;
        private TextBox passwordTxtBox;
        private TextBox usernameTxtBox;
        private TextBox emailTxtBox;
        private Label label3;
        private Button registerBtn;
        private Label label4;
        private Button googleBtn;
        private Button facebookBtn;
        private LinkLabel signinLabel;
    }
}