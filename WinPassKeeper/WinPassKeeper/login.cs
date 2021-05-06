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
    public partial class login : Form
    {

        private string MasterKey;

        public login()
        {
            InitializeComponent();
        }
               
        
        private void MasterKeyTB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MasterKeyTB.Text != null)
            {
                if(MasterKeyTB.TextLength <= 6)
                {
                    login_ErrorLabel.Text = "Your password is too weak";
                }
                else
                {
                    (new @base()).Show();
                    storepasswd_form StorePasswdForm =  new storepasswd_form();
                    StorePasswdForm.setMasterKey(MasterKeyTB.Text);


                    this.Hide();
                   

                }
            }
        }

       
    }
}
