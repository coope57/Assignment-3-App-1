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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
        
            property p=new property {number=Convert.ToInt32(txt_number.Text),inventory=txt_inv.Text,item=txt_item.Text ,count=Convert.ToInt32(txt_count.Text), price=Convert.ToInt32(txt_price.Text) };
            p.save();
            MessageBox.Show($"property {p.item} succesfully added");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
