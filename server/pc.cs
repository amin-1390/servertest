using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using server.code;
using System.Net.Sockets;
using System.Net;

namespace server
{
    public partial class pc : UserControl
    {

        private string _name, _uname;
 
        private string _ipaddress;
        private int _port;
    
        private int  _count;
  
        private Boolean _mo, _connect, _busy, _disable;
      

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }

        }
        public string uname
        {
            get
            {
                return _uname;
            }
            set
            {
                _uname = value;
            }

        }
        public string IPADDRESS
        {
            get
            {
                return _ipaddress;
            }
            set
            {
                _ipaddress = value;
            }

        }

        public int port
        {
            get
            {
                return _port;
            }
            set
            {
                _port = value;
            }

        }
      
        public int count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }

        }
      
      
       
        public Boolean mo
        {
            get
            {
                return _mo;
            }
            set
            {
                _mo = value;

            }
        }
        public Boolean disable
        {
            get
            {
                return _disable;
            }
            set
            {
                _disable = value;

            }
        }
        public Boolean busy
        {
            get
            {
                return _busy;
            }
            set
            {
                _busy = value;

            }
        }
        public Boolean connect
        {
            get
            {
                return _connect;
            }
            set
            {
                _connect = value;

            }
        }
       
        public pc()
        {
            InitializeComponent();

        }

        private void pc_Load(object sender, EventArgs e)
        {

            pcs p = new pcs();
            string detial = "";
            detial += "ip: " + _ipaddress + "\n";
            detial += "port: " + _port + "\n";
            detial += "نام کاربر: " + _uname + "\n";
           
            detial += "شماره :" + _count + "\n";
            toolTip1.SetToolTip(pcimg, detial);
            label1.Text = _uname.ToString();


        }

        public void disconect()
        {
            if (!_busy)
            {
                toolTip1.SetToolTip(pcimg, "");
                pcimg.ImageLocation = Application.StartupPath + "\\img\\" + "1.png";
            }
            else
            {
                pcimg.Image = server.Properties.Resources._2;
            }

        }
        private void clr()
        {
            _name = "";
            _uname = "";
        }
     
        public void ready()
        {
            pcimg.Image = server.Properties.Resources._2;
            busy = false;
        }
       

        private void pcimg_MouseEnter(object sender, EventArgs e)
        {
            this.Focus();
        }



        protected override void OnGotFocus(EventArgs e)
        {
            _mo = true;

            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            _mo = false;
          
            base.OnLostFocus(e);

        }

        private void pcimg_Click(object sender, EventArgs e)
        {
            this.Focus();
        }
      
        private void mn_shdesktop_Click(object sender, EventArgs e)
        {
          
        }

       





    }
}
