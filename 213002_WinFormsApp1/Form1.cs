namespace _213002_WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!", "Help");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!", "Help", MessageBoxButtons.OKCancel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi!", "Help", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicking Button!");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //label1.Text = "I am label1";
            MessageBox.Show("I am label1", "Label1");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Google and Bing";
            MessageBox.Show("I am link label for google");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            obj.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form4 obj = new Form4();
            obj.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form5 obj = new Form5();
            obj.Show();
        }
    }
}