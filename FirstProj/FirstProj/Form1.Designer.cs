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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signinLabel = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.googleBtn = new System.Windows.Forms.Button();
            this.facebookBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CaLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.signinLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.googleBtn);
            this.panel1.Controls.Add(this.facebookBtn);
            this.panel1.Controls.Add(this.registerBtn);
            this.panel1.Controls.Add(this.passwordTxtBox);
            this.panel1.Controls.Add(this.usernameTxtBox);
            this.panel1.Controls.Add(this.emailTxtBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CaLabel);
            this.panel1.Location = new System.Drawing.Point(124, 25);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(280, 456);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(28, 372);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 26);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(28, 336);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 26);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // signinLabel
            // 
            this.signinLabel.AutoSize = true;
            this.signinLabel.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signinLabel.LinkColor = System.Drawing.Color.DodgerBlue;
            this.signinLabel.Location = new System.Drawing.Point(166, 427);
            this.signinLabel.Name = "signinLabel";
            this.signinLabel.Size = new System.Drawing.Size(30, 11);
            this.signinLabel.TabIndex = 12;
            this.signinLabel.TabStop = true;
            this.signinLabel.Text = "Sign in";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(71, 428);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(98, 11);
            this.label4.TabIndex = 10;
            this.label4.Text = "Already have an account?";
            // 
            // googleBtn
            // 
            this.googleBtn.Location = new System.Drawing.Point(25, 368);
            this.googleBtn.Name = "googleBtn";
            this.googleBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.googleBtn.Size = new System.Drawing.Size(227, 34);
            this.googleBtn.TabIndex = 9;
            this.googleBtn.Text = "Continue with Google";
            this.googleBtn.UseVisualStyleBackColor = true;
            // 
            // facebookBtn
            // 
            this.facebookBtn.Location = new System.Drawing.Point(25, 332);
            this.facebookBtn.Name = "facebookBtn";
            this.facebookBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.facebookBtn.Size = new System.Drawing.Size(227, 34);
            this.facebookBtn.TabIndex = 8;
            this.facebookBtn.Text = "Continue with Facebook ";
            this.facebookBtn.UseVisualStyleBackColor = true;
            this.facebookBtn.Click += new System.EventHandler(this.facebookBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.registerBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerBtn.Location = new System.Drawing.Point(26, 273);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(226, 34);
            this.registerBtn.TabIndex = 7;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.passwordTxtBox.Location = new System.Drawing.Point(28, 224);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PlaceholderText = "Enter Password";
            this.passwordTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordTxtBox.Size = new System.Drawing.Size(224, 23);
            this.passwordTxtBox.TabIndex = 6;
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.usernameTxtBox.Location = new System.Drawing.Point(26, 176);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.PlaceholderText = "Enter Username";
            this.usernameTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usernameTxtBox.Size = new System.Drawing.Size(226, 23);
            this.usernameTxtBox.TabIndex = 5;
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.emailTxtBox.Location = new System.Drawing.Point(26, 128);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.PlaceholderText = "Enter Email Address";
            this.emailTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.emailTxtBox.Size = new System.Drawing.Size(226, 23);
            this.emailTxtBox.TabIndex = 4;
            this.emailTxtBox.TextChanged += new System.EventHandler(this.emailTxtBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // CaLabel
            // 
            this.CaLabel.AutoSize = true;
            this.CaLabel.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CaLabel.Location = new System.Drawing.Point(72, 64);
            this.CaLabel.Name = "CaLabel";
            this.CaLabel.Size = new System.Drawing.Size(138, 23);
            this.CaLabel.TabIndex = 0;
            this.CaLabel.Text = "Create Account";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(9)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(546, 521);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}