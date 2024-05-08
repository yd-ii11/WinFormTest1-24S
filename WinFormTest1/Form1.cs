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


    }
}
