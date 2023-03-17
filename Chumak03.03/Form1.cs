namespace Chumak03._03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Pochatok Robotu";
            BackColor = Color.White;
            textBox2.Text = "++++++++";
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BackColor= Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "Poka";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "Privit";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Kydurko LOX";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Text = "**********";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button15.Visible = false;
            button16.Visible = true;
            button17.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            button17.Visible = true;
            button18.Visible = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button14.Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button18.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button16.Visible = false;
            button18.Visible = false;
        }

      
    }
}