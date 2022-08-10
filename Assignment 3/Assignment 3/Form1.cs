using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            


            property p=new property {type=types,number=Convert.ToInt32(txt_number.Text),inventory=txt_inv.Text,item=txt_item.Text ,count=Convert.ToInt32(txt_count.Text), price=Convert.ToInt32(txt_price.Text) };
            /* Regex reg = new Regex(@"^[0-9]{3}$");
             Regex reg1 = new Regex(@"^[A-Z]{1}[a-z]+$");
             Regex reg2 = new Regex(@"^[A-Z]{1}[0-9]{2}[a-z]{3}$");

             if (!reg.IsMatch(txt_count.Text))
             {
                 errorProvider1.SetError(txt_count, "invald count");

             }

             if (!reg1.IsMatch(txt_item.Text))
             {
                 errorProvider1.SetError(txt_item, "ivlaid item name");
             }

             if (!reg.IsMatch(txt_number.Text))
             {
                 errorProvider1.SetError(txt_number, "number should be >1000");
             }

             if (!reg.IsMatch(txt_price.Text))
             {
                 errorProvider1.SetError(txt_number, "price should be >1000");
             }

             if (!reg2.IsMatch(txt_inv.Text))
             {
                 errorProvider1.SetError(txt_number, "invalid inventory number");
             }
            */



            p.save();
            dataGridView1.DataSource = null;
                dataGridView1.DataSource = property.getallproducts();
           
            errorProvider1.Clear();

        }
        string types;
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radio1_CheckedChanged(object sender, EventArgs e)
        {
            types = radio1.Text;
        }

        private void radio2_CheckedChanged(object sender, EventArgs e)
        {
            types = radio2.Text;
        }
    }
}
