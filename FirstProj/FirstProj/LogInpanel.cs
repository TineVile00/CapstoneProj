using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProj
{
    public partial class LogInpanel : UserControl
    {
        public LogInpanel()
        {
            InitializeComponent();
        }

        private void CaLabel_Click(object sender, EventArgs e)
        {

        }

        private void LogInbtn_Click(object sender, EventArgs e)
        {
            var parent1 = this.Parent as Form1;
            var RegisterPan = parent1.registerpanel1;
            var DashPan = parent1.dashboard1;
            var LogInPan = parent1.logInpanel1;
            var AccountPan = parent1.accountuc1;

            LogInPan.Hide();
            RegisterPan.Hide();
            DashPan.Show();
            AccountPan.Hide();
        }

        private void ContGoogleBtn_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SignUplabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var parent1 = this.Parent as Form1;
            var RegisterPan = parent1.registerpanel1;
            var DashPan = parent1.dashboard1;
            var LogInPan = parent1.logInpanel1;
            var AccountPan = parent1.accountuc1;
            var CartPan = parent1.cartUc1;
            var HistoryPan = parent1.historyUc1;

            LogInPan.Hide();
            CartPan.Hide();
            RegisterPan.Show();
            DashPan.Hide();
            AccountPan.Hide();
            HistoryPan.Hide();


        }

        private void LogInpanel_Load(object sender, EventArgs e)
        {

        }

        private void ContFbBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
