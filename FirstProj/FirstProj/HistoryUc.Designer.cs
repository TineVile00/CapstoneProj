namespace FirstProj
{
    partial class HistoryUc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryUc));
            panel1 = new Panel();
            AccountLabel = new LinkLabel();
            HistoryLabel = new LinkLabel();
            CartLabel = new LinkLabel();
            DasbaordLabel = new LinkLabel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 9, 64);
            panel1.Controls.Add(AccountLabel);
            panel1.Controls.Add(HistoryLabel);
            panel1.Controls.Add(CartLabel);
            panel1.Controls.Add(DasbaordLabel);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 560);
            panel1.TabIndex = 0;
            // 
            // AccountLabel
            // 
            AccountLabel.ActiveLinkColor = Color.FromArgb(0, 192, 192);
            AccountLabel.AutoSize = true;
            AccountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            AccountLabel.LinkColor = Color.White;
            AccountLabel.Location = new Point(23, 330);
            AccountLabel.Name = "AccountLabel";
            AccountLabel.Size = new Size(86, 25);
            AccountLabel.TabIndex = 11;
            AccountLabel.TabStop = true;
            AccountLabel.Text = "Account ";
            AccountLabel.LinkClicked += AccountLabel_LinkClicked;
            // 
            // HistoryLabel
            // 
            HistoryLabel.ActiveLinkColor = Color.FromArgb(0, 192, 192);
            HistoryLabel.AutoSize = true;
            HistoryLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            HistoryLabel.LinkColor = Color.White;
            HistoryLabel.Location = new Point(23, 274);
            HistoryLabel.Name = "HistoryLabel";
            HistoryLabel.Size = new Size(71, 25);
            HistoryLabel.TabIndex = 10;
            HistoryLabel.TabStop = true;
            HistoryLabel.Text = "History";
            HistoryLabel.LinkClicked += HistoryLabel_LinkClicked;
            // 
            // CartLabel
            // 
            CartLabel.ActiveLinkColor = Color.FromArgb(0, 192, 192);
            CartLabel.AutoSize = true;
            CartLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            CartLabel.LinkColor = Color.White;
            CartLabel.Location = new Point(23, 221);
            CartLabel.Name = "CartLabel";
            CartLabel.Size = new Size(47, 25);
            CartLabel.TabIndex = 9;
            CartLabel.TabStop = true;
            CartLabel.Text = "Cart";
            CartLabel.LinkClicked += CartLabel_LinkClicked;
            // 
            // DasbaordLabel
            // 
            DasbaordLabel.ActiveLinkColor = Color.FromArgb(0, 192, 192);
            DasbaordLabel.AutoSize = true;
            DasbaordLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            DasbaordLabel.LinkColor = Color.White;
            DasbaordLabel.Location = new Point(23, 168);
            DasbaordLabel.Name = "DasbaordLabel";
            DasbaordLabel.Size = new Size(104, 25);
            DasbaordLabel.TabIndex = 8;
            DasbaordLabel.TabStop = true;
            DasbaordLabel.Text = "Dashboard";
            DasbaordLabel.VisitedLinkColor = Color.Purple;
            DasbaordLabel.LinkClicked += DasbaordLabel_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(38, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 90);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Location = new Point(202, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(591, 466);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara Light", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(246, 20);
            label1.Name = "label1";
            label1.Size = new Size(140, 40);
            label1.TabIndex = 3;
            label1.Text = "HISTORY";
            // 
            // HistoryUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "HistoryUc";
            Size = new Size(850, 560);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private LinkLabel AccountLabel;
        private LinkLabel HistoryLabel;
        private LinkLabel CartLabel;
        private LinkLabel DasbaordLabel;
        private Panel panel2;
        private Label label1;
    }
}
