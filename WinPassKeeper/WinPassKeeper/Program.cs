using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WinPassKeeper
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
            
        }

        public static void storePassword(string password, string user = "NULL_USER")
        {

            //We must encrypt the data before saving
            //

            var passwd_path = @".\Data\passwords.dat";

            if (!Directory.Exists(@".\Data"))
            {
                Directory.CreateDirectory(@".\Data");
            }

            if (!File.Exists(passwd_path))
            {
                using (StreamWriter sw = File.CreateText(passwd_path)){
                    sw.WriteLine("# DO NOT MODIFY THIS FILE MAY CAUSE DATA LOSE");
                }
            }

            using (StreamWriter sw = File.AppendText(passwd_path))
            {
                if(user == "NULL_USER")
                {
                    sw.WriteLine(password);
                }
                else
                {
                    sw.WriteLine(user + " : " + password);
                }
                
                
            }






        }


    }
}
