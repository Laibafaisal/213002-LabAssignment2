namespace _213002_WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] names = { "Sindh", "Balochistan", "Punjab", "Gilgit Baltistan", "KPK", "AJK" };
            foreach (string name in names)
            {
                comboBox1.Items.Add(name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedItem.ToString() == "Punjab")
            {
                comboBox2.Items.Add("Lahore");
                comboBox2.Items.Add("Multan");
                comboBox2.Items.Add("Bahawalpur");
                comboBox2.Items.Add("Okara");
                comboBox2.Items.Add("Pattoki");
            }
            if (comboBox1.SelectedItem.ToString() == "Balochistan")
            {
                comboBox2.Items.Add("Gwadar");
                comboBox2.Items.Add("Quetta");
                comboBox2.Items.Add("Pasni");
                comboBox2.Items.Add("Ormara");
                comboBox2.Items.Add("Waziristan Hills");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string province = comboBox1.SelectedItem.ToString();
            string city = comboBox2.SelectedItem.ToString();
            MessageBox.Show("You live in " + city + " in " + province + ".");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Progress progress = new Progress();
            progress.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Browser browser = new Browser();
            browser.Show();
        }
    }
}