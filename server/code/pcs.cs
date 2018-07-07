using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;

namespace server.code
{
    class pcs
    {
        //private string _name;
        ////private string _macaddress;
        //private string _ipaddress;
        //private string _port;
        ////private int _number;
        ////private int _sitenumber;
        //byte[] buffer = new byte[1024];


        //public string name
        //{
        //    get
        //    {
        //        return _name;
        //    }
        //    set
        //    {
        //        _name = value;
        //    }

        //}
        ////public string MACADDRESS
        ////{
        ////    get
        ////    {
        ////        return _macaddress;
        ////    }
        ////    set
        ////    {
        ////        _macaddress = value;
        ////    }

        ////}
        //public string IPADDRESS
        //{
        //    get
        //    {
        //        return _ipaddress;
        //    }
        //    set
        //    {
        //        _ipaddress = value;
        //    }

        //}
        //public string port
        //{
        //    get
        //    {
        //        return _port;
        //    }
        //    set
        //    {
        //        _port = value;
        //    }

        //}
        ////public int number
        ////{
        ////    get
        ////    {
        ////        return _number;
        ////    }
        ////    set
        ////    {
        ////        _number = value;
        ////    }

        ////}
        ////public int sitenumber
        ////{
        ////    get
        ////    {
        ////        return _sitenumber;
        ////    }
        ////    set
        ////    {
        ////        _sitenumber = value;
        ////    }

        ////}

        ///*
        //public int pcstatus(string ip, string sitenum)
        //{
        //    Socket Mainlistener = new Socket(AddressFamily.InterNetwork,
        //        SocketType.Stream, ProtocolType.Tcp);
        //    IPAddress localip = IPAddress.Parse(ip);
        //    IPEndPoint server = new IPEndPoint(localip, 1800);
        //    Mainlistener.Bind(server);

        //    AsyncCallback callBackMethod = new AsyncCallback(AcceptCallback);

        //    Mainlistener.Listen(4);
        //    Mainlistener.BeginAccept(AcceptCallback, Mainlistener);
           
        //    return state ;

        //}
        //private void AcceptCallback(IAsyncResult ar)
        //{
        //    Socket temp = ((Socket)ar.AsyncState);
        //    Socket worker = temp.EndAccept(ar);
        //    AsyncCallback ReceiveMethod = new AsyncCallback(ReceiveCallBack);
        //    worker.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveMethod, worker);
        //}

        //private void ReceiveCallBack(IAsyncResult ar)
        //{
        //    Socket worker = ((Socket)ar.AsyncState);
        //    int bytesReceived = worker.EndReceive(ar);

        //    string str = System.Text.UTF8Encoding.UTF8.GetString(buffer);
        //    ShowInfo(str);
        //    AsyncCallback ReceiveMethod = new AsyncCallback(ReceiveCallBack);
        //    worker.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveMethod, worker);
        //}

        //delegate void ShowInfoCallback(string text);
        //private void ShowInfo(string text)
        //{
        //    if (text == "1")
        //        state = 1;
        //    else
        //        state = 2;

        //}

        //*/

        //public int pcstatus(string ip)
        //{
        //    int state = 0;
        //    string strcv;
        //    byte[] data = new byte[2048];
        //    IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ip), 9050);
        //    Socket nsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //    nsock.Bind(ipep);
        //    //nsock.Listen(10);
        //    AsyncCallback callbackmethod = new AsyncCallback(acceptcallback);
        //    nsock.Listen(4);
        //    nsock.BeginAccept(acceptcallback, nsock);

        //    //nsock.Connect(ipep);


        //    /*  Socket client = nsock.Accept();
        //      IPEndPoint clientip = (IPEndPoint)client.RemoteEndPoint;

        //     state= client.Receive(data);
        //      //MessageBox.Show(Encoding.ASCII.GetString(data));
        //      strcv = Encoding.ASCII.GetString(data);
              
        //      client.Close();
        //      nsock.Close();
        //     */
        //    return state;




        //}
        //private void acceptcallback(IAsyncResult ar)
        //{
        //    Socket temp = ((Socket)ar.AsyncState);
        //    Socket worker = temp.EndAccept(ar);
        //    AsyncCallback ReceiveMethod = new AsyncCallback(ReceiveCallBack);
        //    worker.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveMethod, worker);
        //}
        //private void ReceiveCallBack(IAsyncResult ar)
        //{
        //    Socket worker = ((Socket)ar.AsyncState);
        //    int bytesReceived = worker.EndReceive(ar);
        //    string str = System.Text.UTF8Encoding.UTF8.GetString(buffer);

        //}

    }
}
