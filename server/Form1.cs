using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using server.code;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace server
{
    public partial class Form1 : Form
    {
        Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public Socket[] newserver = new Socket[200];
        int counter = 0; //Thread Number

        private const int MYKEYID = 0, YOUKEYID = 1;
        private const int WM_HOTKEY = 0x312;
        private const int MOD_ALT = 1;
        private const int MOD_CONTROL = 2;
        private const int MOD_SHIFT = 4;
        [DllImport("user32.dll")]
        private static extern int RegisterHotKey(IntPtr hWnd, int id, int modifier, Keys vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        string[] ip;
        private pc ppp;
        private System.Windows.Forms.Timer CheckIdleTimer;
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                login.log();
                CheckIdleTimer = new System.Windows.Forms.Timer();
                CheckIdleTimer.Interval = 1000;
                CheckIdleTimer.Start();
                CheckIdleTimer.Tick += new EventHandler(CheckIdleTimer_Tick);

               
                try
                {
                    IPEndPoint ippoint = new IPEndPoint(IPAddress.Any, 8687);
                    server.Bind(ippoint);
                    server.Listen(5);

                    Thread mythread = new Thread(new ThreadStart(RunServer));
                    mythread.Start();
                    //RunServer();
                    CheckForIllegalCrossThreadCalls = false;
                   
                    if (login.verify())
                    {

                        loadpcs();
                    }
                    else
                    {
                        MessageBox.Show("ارتباط با دیتا بیس برقرار نیست");
                    }
                }
                catch (Exception ex)
                {

                }
            }
            catch (Exception ex)
            {

            }
        }
        public void loadpcs()
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                SqlConnection con = new SqlConnection(login.connectionstring);

                SqlCommand cmd = new SqlCommand("select * from tbl_pcs ", con);
                con.Open();
                SqlDataReader drd = cmd.ExecuteReader();
                while (drd.Read())
                {
                    pc pp = new pc();
                    pp.ContextMenuStrip = contextMenuStrip1;
                    pp.name = drd["pc_name"].ToString();
                    pp.uname = drd["pc_uname"].ToString();
                    pp.IPADDRESS = drd["pc_ip"].ToString();
                  
                    pp.ContextMenuStrip = contextMenuStrip1;


                    this.flowLayoutPanel1.Controls.Add(pp);
                }
                con.Close();

              
            }
            catch (Exception ex)
            {

            }
        }

        private void CheckIdleTimer_Tick(object sender, System.EventArgs e)
        {
            try
            {

             
                foreach (pc pp in flowLayoutPanel1.Controls)
                {
                   
                   



                }
            }
            catch (Exception ex)
            {
            }
        }
        public void RunServer()
        {
            try
            {
                
                #region RunServer
                int i = counter;

                newserver[i] = server.Accept();
                char[] chrseperatore = new char[] { ':' };
                ip = newserver[i].RemoteEndPoint.ToString().Split(chrseperatore);
                Thread.Sleep(250);
                foreach (pc pp in flowLayoutPanel1.Controls)
                {
                   string ip11= pp.IPADDRESS;
                    if (pp.IPADDRESS.Trim() == ip[0])
                    {
                        //
                        pp.connect = true;
                        pp.count = i;
                        pp.port = 2012 + pp.count;
                        pp.ready();
                        senddata("checkstate", ip[0]);
                        break;
                    }

                }
              
                counter++;
                if (i >= 0)
                {
                    Thread mythread = new Thread(new ThreadStart(RunServer));
                    mythread.Start();
                    try
                    {
                        while (newserver[i].Connected)
                        {

                            byte[] rcvByte = new byte[10024];
                            newserver[i].Receive(rcvByte, rcvByte.Length, SocketFlags.None);


                            string str = Encoding.UTF8.GetString(rcvByte).Trim('\0');
                            switch (str)
                            {
                                case "checkstate":
                                    foreach (pc pp in flowLayoutPanel1.Controls)
                                    {
                                        if (pp.IPADDRESS == ip[0])
                                        {
                                            // 
                                            pp.connect = true;
                                            pp.count = i;
                                            pp.port = 2012 + pp.count;
                                            pp.ready();
                                            //senddata("checkstate", ip[0]);

                                        }

                                    }
                                    break;
                                case "test":
                                    foreach (pc pp in flowLayoutPanel1.Controls)
                                    {
                                        if (pp.IPADDRESS == ip[0])
                                        {
                                            // senddata("checkstate", ip[0]);
                                            pp.connect = true;
                                            pp.count = i;
                                            pp.ready();

                                        }

                                    }
                                    break;
                                case "dis":
                                    ip = newserver[i].RemoteEndPoint.ToString().Split(chrseperatore);
                                    foreach (pc pp in flowLayoutPanel1.Controls)
                                    {
                                        if (pp.IPADDRESS == ip[0])
                                        {

                                            pp.disconect();
                                            pp.connect = false;
                                            newserver[i].Close();
                                            counter--;
                                        }

                                    }
                                    break;
                               
                                case "ok":

                                    break;

                                default:
                                    {
                                        MessageBox.Show(str);
                                       
                                    }
                                    break;

                            }
                            //end if


                        }//end while

                    }
                    catch (SocketException se)
                    {

                        ip = newserver[i].RemoteEndPoint.ToString().Split(chrseperatore);
                        string puname = "";
                        foreach (pc pp in flowLayoutPanel1.Controls)
                        {

                            if (pp.IPADDRESS == ip[0])
                            {
                                puname = pp.uname;
                                pp.disconect();
                                pp.connect = false;
                                
                                newserver[i].Close();
                                counter--;
                            }

                        }

                        MessageBox.Show("اتصال قطع گردید ");

                    }

                #endregion
                }
            }
            catch (Exception ex)
            {
            }
        }

        public void senddata(string msg, string ipadd)
        {
            try
            {
                for (int i = 0; i <= counter; i++)
                {
                    char[] chrseperatore = new char[] { ':' };
                    if (newserver[i].Connected)
                    {
                        ip = newserver[i].RemoteEndPoint.ToString().Split(chrseperatore);
                        if (ip[0] == ipadd)
                        {
                            newserver[i].Send(Encoding.UTF8.GetBytes(msg));
                            break;
                        }
                    }
                }
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }

        }

        private void mn_shdesktop_Click(object sender, EventArgs e)
        {
       
            foreach (pc pp in flowLayoutPanel1.Controls)
            {
                if ((pp.mo == true))
                {
                    pp.mo = false;
                    //login.port = 2012 + pp.count;
                    login.port = pp.port;
                    senddata("desktop:" + login.port.ToString(), pp.IPADDRESS.Trim());
                    login.ip = pp.IPADDRESS.Trim();
                    
                    break;
                }

            }
            frm_desktop showdesktop = new frm_desktop(login.port);
            
            showdesktop.Show(this);
          
        }

        private void mn_msg_Click(object sender, EventArgs e)
        {
            frm_sendmsg sendmsg = new frm_sendmsg();
            sendmsg.ShowDialog();
            if (login.message!="")
            { 
            foreach (pc pp in flowLayoutPanel1.Controls)
            {
                if ((pp.mo == true))
                {
                    pp.mo = false;
                    senddata(login.message, pp.IPADDRESS.Trim());

                    break;
                }

            }
        }
   
        }

        private void mn_closedesktop_Click(object sender, EventArgs e)
        {
         
            foreach (pc pp in flowLayoutPanel1.Controls)
            {
                if ((pp.mo == true))
                {
                    pp.mo = false;
                    senddata("closedesktop", pp.IPADDRESS.Trim());

                    break;
                }

            }
        }

        private void mn_setting_Click(object sender, EventArgs e)
        {
            frm_setting frsetting = new frm_setting();
            frsetting.Show();
        }
       

    }
}
