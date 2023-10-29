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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Font oldFont;
            Font newFont;
            oldFont = this.richTextBox1.SelectionFont;
            if (oldFont.Bold)
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | ~FontStyle.Bold);
            }
            this.richTextBox1.SelectionFont = newFont;
            this.richTextBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Font oldFont;
            Font newFont;

            oldFont = this.richTextBox1.SelectionFont;
            if (oldFont.Italic)
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);
            }

            //Insert the new font
            this.richTextBox1.SelectionFont = newFont;
            this.richTextBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Font oldFont;
            Font newFont;

            oldFont = this.richTextBox1.SelectionFont;
            if (oldFont.Italic)
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);
            }

            //Insert the new font
            this.richTextBox1.SelectionFont = newFont;
            this.richTextBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            obj.Show();
        }
    }
}
