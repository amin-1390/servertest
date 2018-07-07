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
    public partial class frm_sendmsg : Form
    {
        public frm_sendmsg()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            login.message = txt_message.Text;
            this.Close();
        }
    }
}
