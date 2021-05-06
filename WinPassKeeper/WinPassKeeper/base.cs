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
    public partial class @base : Form
    {
        public @base()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new storepasswd_form()).Show();
        }
    }
}
