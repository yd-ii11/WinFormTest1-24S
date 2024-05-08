namespace WinFormTest1
{
    public partial class Form1 : Form
    {
        TextBox[] textBoxes = new TextBox[4];
        public Form1()
        {
            InitializeComponent();

            textBoxes[0] = textBox1;
            textBoxes[1] = textBox2;
            textBoxes[2] = textBox3;
            textBoxes[3] = textBox4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a, b, c, d;
            a = textBox1.Text;
            b = textBox2.Text;
            c = textBox4.Text;
            d = textBox3.Text;
            textBox1.Text = d;
            textBox2.Text = a;
            textBox4.Text = b;
            textBox3.Text = c;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a, b, c, d;
            a = textBox1.Text;
            b = textBox2.Text;
            c = textBox4.Text;
            d = textBox3.Text;
            textBox1.Text = b;
            textBox2.Text = c;
            textBox4.Text = d;
            textBox3.Text = a;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
