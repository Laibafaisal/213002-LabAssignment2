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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*decimal res = numericUpDown1.Value * numericUpDown2.Value;
            MessageBox.Show($"Total amount: {res}.");*/
            decimal price = numericUpDown1.Value;
            int quantity = (int)numericUpDown2.Value;

            decimal total = price * quantity;
            MessageBox.Show(String.Format("Total amount: {0:C}", total));
        }
    }
}
