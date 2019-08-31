using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;
using System.IO;
using BookManageSystem.Common;
namespace BookManageSystem
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            DbHelperSQL.connectionString = getConncetion();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
            Application.Run(new frmMain());
        }
        private static string getConncetion()
        {
            XmlDocument xmldoc = new XmlDocument();
            FileInfo file = new FileInfo("../../app.config");
            StreamReader sr = file.OpenText();
            string content = sr.ReadToEnd();
            sr.Close();
            xmldoc.LoadXml(content);
            XmlNode node = xmldoc.SelectSingleNode("//configuration/connectionStrings/add");
            return node.Attributes["connectionString"].Value;
        }
    }
}
