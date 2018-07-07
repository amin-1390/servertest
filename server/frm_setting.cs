using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace server
{
    public partial class frm_setting : Form
    {
        public frm_setting()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            login.setconfig(txtserverip.Text, txtsendport.Text, txtrecport.Text);
        }
    }
}
