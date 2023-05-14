namespace FirstProj
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            AccountLabel = new LinkLabel();
            HistoryLabel = new LinkLabel();
            CartLabel = new LinkLabel();
            DasbaordLabel = new LinkLabel();
            panel2 = new Panel();
            SubflowerBtn = new Button();
            ButterflyBtn = new Button();
            BlueCakeBtn = new Button();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 9, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(AccountLabel);
            panel1.Controls.Add(HistoryLabel);
            panel1.Controls.Add(CartLabel);
            panel1.Controls.Add(DasbaordLabel);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 560);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(38, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 90);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
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
            AccountLabel.TabIndex = 3;
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
            HistoryLabel.TabIndex = 2;
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
            CartLabel.TabIndex = 1;
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
            DasbaordLabel.TabIndex = 0;
            DasbaordLabel.TabStop = true;
            DasbaordLabel.Text = "Dashboard";
            DasbaordLabel.VisitedLinkColor = Color.Purple;
            DasbaordLabel.LinkClicked += DasbaordLabel_LinkClicked;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(SubflowerBtn);
            panel2.Controls.Add(ButterflyBtn);
            panel2.Controls.Add(BlueCakeBtn);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(202, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(591, 466);
            panel2.TabIndex = 1;
            // 
            // SubflowerBtn
            // 
            SubflowerBtn.BackColor = Color.FromArgb(103, 194, 200);
            SubflowerBtn.Location = new Point(393, 165);
            SubflowerBtn.Name = "SubflowerBtn";
            SubflowerBtn.Size = new Size(150, 30);
            SubflowerBtn.TabIndex = 5;
            SubflowerBtn.Text = "SUNFLOWER CAKE";
            SubflowerBtn.UseVisualStyleBackColor = false;
            SubflowerBtn.Click += SubflowerBtn_Click;
            // 
            // ButterflyBtn
            // 
            ButterflyBtn.BackColor = Color.FromArgb(103, 194, 200);
            ButterflyBtn.Location = new Point(221, 161);
            ButterflyBtn.Name = "ButterflyBtn";
            ButterflyBtn.Size = new Size(150, 34);
            ButterflyBtn.TabIndex = 4;
            ButterflyBtn.Text = "BUTTERFLY CAKE";
            ButterflyBtn.UseVisualStyleBackColor = false;
            ButterflyBtn.Click += ButterflyBtn_Click;
            // 
            // BlueCakeBtn
            // 
            BlueCakeBtn.BackColor = Color.FromArgb(103, 194, 200);
            BlueCakeBtn.Location = new Point(47, 161);
            BlueCakeBtn.Name = "BlueCakeBtn";
            BlueCakeBtn.Size = new Size(150, 34);
            BlueCakeBtn.TabIndex = 3;
            BlueCakeBtn.Text = "BLUE CAKE";
            BlueCakeBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(394, 30);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(147, 136);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(224, 30);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(143, 136);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(54, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(137, 136);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara Light", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(246, 20);
            label1.Name = "label1";
            label1.Size = new Size(92, 40);
            label1.TabIndex = 2;
            label1.Text = "CAKE";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            Size = new Size(850, 560);
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private LinkLabel CartLabel;
        private LinkLabel DasbaordLabel;
        private LinkLabel AccountLabel;
        private LinkLabel HistoryLabel;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button ButterflyBtn;
        internal Button BlueCakeBtn;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label1;
        private Button SubflowerBtn;
    }
}
