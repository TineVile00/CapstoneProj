namespace FirstProj
{
    partial class LogInpanel
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
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            CaLabel = new Label();
            PasswordLogTxtBx = new TextBox();
            EmailUserLogTxtBx = new TextBox();
            LogInbtn = new Button();
            SignUplabel = new LinkLabel();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(72, 332);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(92, 11);
            label4.TabIndex = 29;
            label4.Text = "Don't have an account?";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 190);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 28;
            label3.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 130);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 27;
            label1.Text = "Email or Username";
            // 
            // CaLabel
            // 
            CaLabel.AutoSize = true;
            CaLabel.Font = new Font("Bell MT", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CaLabel.Location = new Point(38, 65);
            CaLabel.Name = "CaLabel";
            CaLabel.Size = new Size(203, 23);
            CaLabel.TabIndex = 26;
            CaLabel.Text = "Sign in to your account";
            CaLabel.Click += CaLabel_Click;
            // 
            // PasswordLogTxtBx
            // 
            PasswordLogTxtBx.Location = new Point(27, 209);
            PasswordLogTxtBx.Name = "PasswordLogTxtBx";
            PasswordLogTxtBx.PlaceholderText = "Enter Password";
            PasswordLogTxtBx.Size = new Size(227, 23);
            PasswordLogTxtBx.TabIndex = 31;
            // 
            // EmailUserLogTxtBx
            // 
            EmailUserLogTxtBx.Location = new Point(27, 153);
            EmailUserLogTxtBx.Name = "EmailUserLogTxtBx";
            EmailUserLogTxtBx.PlaceholderText = "Enter Email or Username";
            EmailUserLogTxtBx.Size = new Size(227, 23);
            EmailUserLogTxtBx.TabIndex = 32;
            // 
            // LogInbtn
            // 
            LogInbtn.BackColor = Color.LimeGreen;
            LogInbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LogInbtn.Location = new Point(27, 266);
            LogInbtn.Name = "LogInbtn";
            LogInbtn.Size = new Size(227, 34);
            LogInbtn.TabIndex = 33;
            LogInbtn.Text = "Log In";
            LogInbtn.UseVisualStyleBackColor = false;
            LogInbtn.Click += LogInbtn_Click;
            // 
            // SignUplabel
            // 
            SignUplabel.AutoSize = true;
            SignUplabel.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            SignUplabel.LinkColor = Color.DodgerBlue;
            SignUplabel.Location = new Point(161, 331);
            SignUplabel.Name = "SignUplabel";
            SignUplabel.Size = new Size(34, 11);
            SignUplabel.TabIndex = 36;
            SignUplabel.TabStop = true;
            SignUplabel.Text = "Sign Up";
            SignUplabel.LinkClicked += SignUplabel_LinkClicked;
            // 
            // LogInpanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(SignUplabel);
            Controls.Add(LogInbtn);
            Controls.Add(EmailUserLogTxtBx);
            Controls.Add(PasswordLogTxtBx);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(CaLabel);
            Name = "LogInpanel";
            Size = new Size(280, 359);
            Load += LogInpanel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label1;
        private Label CaLabel;
        private TextBox PasswordLogTxtBx;
        private TextBox EmailUserLogTxtBx;
        private Button LogInbtn;
        private LinkLabel SignUplabel;
    }
}
