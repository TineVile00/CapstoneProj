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
            dashboard1 = new Dashboard();
            cartUc1 = new CartUc();
            historyUc1 = new HistoryUc();
            accountuc1 = new Accountuc();
            registerpanel1 = new Registerpanel();
            logInpanel1 = new LogInpanel();
            SuspendLayout();
            // 
            // dashboard1
            // 
            dashboard1.BackColor = Color.White;
            dashboard1.Location = new Point(-1, -1);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(836, 524);
            dashboard1.TabIndex = 2;
            // 
            // cartUc1
            // 
            cartUc1.BackColor = Color.White;
            cartUc1.Location = new Point(-1, -1);
            cartUc1.Name = "cartUc1";
            cartUc1.Size = new Size(836, 527);
            cartUc1.TabIndex = 3;
            // 
            // historyUc1
            // 
            historyUc1.BackColor = Color.White;
            historyUc1.Location = new Point(-1, -1);
            historyUc1.Name = "historyUc1";
            historyUc1.Size = new Size(836, 524);
            historyUc1.TabIndex = 4;
            // 
            // accountuc1
            // 
            accountuc1.BackColor = Color.White;
            accountuc1.Location = new Point(-1, -1);
            accountuc1.Name = "accountuc1";
            accountuc1.Size = new Size(836, 524);
            accountuc1.TabIndex = 5;
            // 
            // registerpanel1
            // 
            registerpanel1.BackColor = Color.LightGray;
            registerpanel1.Location = new Point(295, 87);
            registerpanel1.Name = "registerpanel1";
            registerpanel1.Size = new Size(280, 359);
            registerpanel1.TabIndex = 6;
            // 
            // logInpanel1
            // 
            logInpanel1.BackColor = Color.LightGray;
            logInpanel1.Location = new Point(295, 87);
            logInpanel1.Name = "logInpanel1";
            logInpanel1.Size = new Size(280, 359);
            logInpanel1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 9, 64);
            ClientSize = new Size(834, 521);
            Controls.Add(logInpanel1);
            Controls.Add(registerpanel1);
            Controls.Add(dashboard1);
            Controls.Add(cartUc1);
            Controls.Add(historyUc1);
            Controls.Add(accountuc1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        internal Dashboard dashboard1;
        internal CartUc cartUc1;
        internal HistoryUc historyUc1;
        internal Accountuc accountuc1;
        internal Registerpanel registerpanel1;
        internal LogInpanel logInpanel1;
    }
}