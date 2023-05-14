﻿using System;
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
    public partial class CartUc : UserControl
    {
        public CartUc()
        {
            InitializeComponent();
        }

        private void AccountLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var parent5 = this.Parent as Form1;
            var DashPan = parent5.dashboard1;
            var AccountPan = parent5.accountuc1;
            var CartPan = parent5.cartUc1;

            CartPan.Hide();
            DashPan.Hide();
            //AccountPan.BringToFront();
            AccountPan.Show();

        }

        private void DasbaordLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var parent5 = this.Parent as Form1;
            var DashPan = parent5.dashboard1;
            var AccountPan = parent5.accountuc1;
            var CartPan = parent5.cartUc1;

            CartPan.Hide();
            DashPan.Show();
           // DashPan.BringToFront();
            AccountPan.Hide();
        }

        private void HistoryLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var parent5 = this.Parent as Form1;
            var DashPan = parent5.dashboard1;
            var AccountPan = parent5.accountuc1;
            var CartPan = parent5.cartUc1;
            var HistoryPan = parent5.historyUc1;

            CartPan.Hide();
            DashPan.Hide();
            AccountPan.Hide();
            HistoryPan.Show();
        }
    }
}
