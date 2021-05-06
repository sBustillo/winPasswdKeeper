using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPassKeeper
{
    public partial class storepasswd_form : Form
    {

        private string MasterKey = null;

        public storepasswd_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Chekeamos las passwords, las almacenamos 
            // y escondemos el form
            this.Hide();

           
            Encryptor Cipher = new Encryptor();
            //Cipher.Encrypt();
            

            Program.storePassword(SP_TB_Password.Text, SP_TB_User.Text);
        }

        public void setMasterKey(String key)
        {
            this.MasterKey = key;
        }


    }
}
