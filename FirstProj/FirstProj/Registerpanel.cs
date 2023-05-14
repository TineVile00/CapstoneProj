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
    public partial class Registerpanel : UserControl
    {
        public Registerpanel()
        {
            InitializeComponent();
        }

        private void Registerpanel_Load(object sender, EventArgs e)
        {

        }

        private void signinLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var parent2 = this.Parent as Form1;
            var RegisterPan = parent2.registerpanel1;
            var LogInPan = parent2.logInpanel1;


            RegisterPan.Hide();
            LogInPan.Show();

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            var parent2 = this.Parent as Form1;
            var RegisterPan = parent2.registerpanel1;
            var LogInPan = parent2.logInpanel1;


            RegisterPan.Hide();
            LogInPan.Show();
        }
    }
}
