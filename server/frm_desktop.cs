using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net;
using System.IO;

namespace server
{
    public partial class frm_desktop : Form
    {  public int port;
    public string ip;
    private TcpClient clientdesktop;
    private TcpListener server_desktop;
    private NetworkStream mainstream;
    private readonly Thread listeninig;
    private readonly Thread getimage;
        public frm_desktop( int port1 )
    {
       
        port = port1;
            clientdesktop = new TcpClient();
            listeninig = new Thread(startlistening);
            getimage = new Thread(recieveimage);
            InitializeComponent();
        }
      
        private void frm_desktop_Load(object sender, EventArgs e)
        {

            server_desktop = new TcpListener(IPAddress.Parse(login.server), port);

            listeninig.Start();
        }

        private void startlistening()
        {
            while(!clientdesktop.Connected)
            {
                server_desktop.Start(); clientdesktop = server_desktop.AcceptTcpClient();
            }
            getimage.Start();
        }
        private void recieveimage()
        { pictureBox1.Image = null;
            BinaryFormatter binaryformatter = new BinaryFormatter();
            while(clientdesktop.Connected)
            {
                try
                {
                mainstream = null;
                mainstream = clientdesktop.GetStream();

                pictureBox1.Image = (Image)binaryformatter.Deserialize(mainstream);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {

                }
            }

        }
        private void stoplistening()
        {
            server_desktop.Stop();
            clientdesktop = null;
            if (listeninig.IsAlive) listeninig.Abort();
            if (getimage.IsAlive) getimage.Abort();
        }
        //protected override void OnLoad(EventArgs e)
        //{
            
        //    base.OnLoad(e);
        //    server2 = new TcpListener(IPAddress.Parse(ip), port);
        //    listeninig.Start();
        //}

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            stoplistening();
            //Form1 fr = new Form1();
            ////fr.senddata("closedesktop", login.ip);
            //fr.sendtest("closedesktop", login.ip);
        }
    }
}
