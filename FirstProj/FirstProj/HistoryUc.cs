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
    public partial class HistoryUc : UserControl
    {
        public HistoryUc()
        {
            InitializeComponent();
        }

        private void DasbaordLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var parent6 = this.Parent as Form1;
            var DashPan = parent6.dashboard1;
            var AccountPan = parent6.accountuc1;
            var CartPan = parent6.cartUc1;
            var HistoryPan = parent6.historyUc1;

            CartPan.Hide();
            DashPan.Show();
            AccountPan.Hide();
            HistoryPan.Hide();
        }

        private void CartLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var parent6 = this.Parent as Form1;
            var DashPan = parent6.dashboard1;
            var AccountPan = parent6.accountuc1;
            var CartPan = parent6.cartUc1;
            var HistoryPan = parent6.historyUc1;

            CartPan.Show();
            DashPan.Hide();
            AccountPan.Hide();
            HistoryPan.Hide();
        }

        private void HistoryLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void AccountLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var parent6 = this.Parent as Form1;
            var DashPan = parent6.dashboard1;
            var AccountPan = parent6.accountuc1;
            var CartPan = parent6.cartUc1;
            var HistoryPan = parent6.historyUc1;

            CartPan.Hide();
            DashPan.Hide();
            AccountPan.Show();
            HistoryPan.Hide();
        }
    }
}
