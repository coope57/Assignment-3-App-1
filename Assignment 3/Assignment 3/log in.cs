using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class log_in : Form
    {
        public log_in()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_pass.Text=="admin"   & txt_user.Text=="admin")
            {
                Form1 f = new Form1();
                f.Show();
                log_in l=new log_in();
                l.Close();
            }
            else
            {
                MessageBox.Show("username or password not found");
            }
        }
    }
}
