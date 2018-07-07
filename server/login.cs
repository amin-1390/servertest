using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Reflection;
using System.Xml;
using System.IO;
namespace server
{
    static class login
    {
        private static XmlDocument xmldocument = new XmlDocument();
        private static string iAppPath = Application.StartupPath;
        private static string iDBName = "db";
        public static string connectionstring;
        public static string servername;
        private static bool _onelog;
        private static string _server;
        private static Int32 _sendport;
        private static Int32 _recport;
        public static int  port;
          public static string message;
        public static string ip;

        public static bool onelog
        {
            get
            {
                return _onelog;
            }
            set
            {
                value = _onelog;
            }
        }

        public static string server
        {
            get
            {
                return _server;
            }
            set
            {
                value = _server;
            }
        }
        public static Int32 sendport
        {
            get
            {
                return _sendport;
            }
            set
            {
                value = _sendport;
            }
        }
        public static Int32 recport
        {
            get
            {
                return _recport;
            }
            set
            {
                value = _recport;
            }
        }
        public static Boolean verify()
        {//چک کردن برقراری اتصال به دیتا بیس
            try
            {
                setdb();
                SqlConnection con = new SqlConnection(login.connectionstring);
                SqlCommand cmd = new SqlCommand("select * from tbl_user", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

   
        public static void setdb()
        {//بدست آوردن آدر س دیتابیس
            Assembly asm = Assembly.GetExecutingAssembly();
            string strconfigloc = asm.Location;
            string strtemp = strconfigloc;
            strtemp = Path.GetDirectoryName(strconfigloc);

            FileInfo fileinfo = new FileInfo(strtemp + "\\app.config");
            xmldocument.Load(fileinfo.FullName);
            XmlNodeList n0 = xmldocument.GetElementsByTagName("connectionStrings");
            foreach (XmlNode node in n0.Item(0))
            {
                if (node.Name == "add")
                {
                    if (node.Attributes.GetNamedItem("name").Value == "dbconnection")
                    {

                        login.servername = node.Attributes.GetNamedItem("ip").Value;
                        login.connectionstring = node.Attributes.GetNamedItem("connectionString").Value;
                        //server.Properties.Settings.Default.dbcon = login.connectionstring;
                        
                    }
                }
            }
        }

        public static void log()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            string strconfigloc = asm.Location;
            string strtemp = strconfigloc;
            strtemp = Path.GetDirectoryName(strconfigloc);

            FileInfo fileinfo = new FileInfo(strtemp + "\\app.config");
            xmldocument.Load(fileinfo.FullName);
            XmlNodeList n0 = xmldocument.GetElementsByTagName("setting");
            foreach (XmlNode node in n0.Item(0))
            {
                if (node.Name == "add")
                {
                    if (node.Attributes.GetNamedItem("name").Value == "onelog")
                        _onelog = bool.Parse(node.Attributes.GetNamedItem("value").Value);

                    if (node.Attributes.GetNamedItem("name").Value == "server")
                    {
                        _server = node.Attributes.GetNamedItem("value").Value;
                        _sendport = Int32.Parse(node.Attributes.GetNamedItem("sendport").Value);
                        _recport = Int32.Parse(node.Attributes.GetNamedItem("recport").Value);
                    }
                   

                }
            }
        }
        public static void setconfig(string srv, string seport, string rcport)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            string strconfigloc = asm.Location;
            string strtemp = strconfigloc;
            strtemp = Path.GetDirectoryName(strconfigloc);

            FileInfo fileinfo = new FileInfo(strtemp + "\\app.config");
            xmldocument.Load(fileinfo.FullName);
            XmlNodeList n0 = xmldocument.GetElementsByTagName("setting");
            foreach (XmlNode node in n0.Item(0))
            {
                if (node.Name == "add")
                {
                    if (node.Attributes.GetNamedItem("name").Value == "onelog")
                        node.Attributes.GetNamedItem("value").Value = "false";

                    if (node.Attributes.GetNamedItem("name").Value == "server")
                    {
                        node.Attributes.GetNamedItem("value").Value = srv;
                        node.Attributes.GetNamedItem("sendport").Value = seport;
                        node.Attributes.GetNamedItem("recport").Value = rcport;
                    }

                }
            }
            xmldocument.Save(fileinfo.FullName);

        }

    }
}

