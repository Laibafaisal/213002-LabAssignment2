using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _213002_WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string items = string.Empty;
            if (checkBox1.Checked)
            {
                items += "\n Pencil";
            }
            if (checkBox2.Checked)
            {
                items += "\n Eraser";
            }
            if (checkBox3.Checked)
            {
                items += "\n Sharpener";
            }

            MessageBox.Show("You have bought "+ items + ".");
            MessageBox.Show($"You have {items}.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string paymentMode = string.Empty;
            if (radioButton1.Checked == true)
            {
                paymentMode = "Cash";
            }
            if(radioButton2.Checked == true) 
            {
                paymentMode = "Card";
            }
            MessageBox.Show(paymentMode);
        }
    }
}
