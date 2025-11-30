namespace Calculater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void num(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Text;

        }
        double n1, n2;
        char op;

        private void button16_Click(object sender, EventArgs e)
        {
            n1 = Double.Parse(textBox1.Text);
            op = '+';
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {

            n1 = Double.Parse(textBox1.Text);
            op = '-';
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {

            n1 = Double.Parse(textBox1.Text);
            op = '*';
            textBox1.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {

            n1 = Double.Parse(textBox1.Text);
            op = '/';
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {

            n1 = Double.Parse(textBox1.Text);
            op = '%';
            textBox1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {

            n1 = Double.Parse(textBox1.Text) * -1;
            op = '+';
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n2 = Double.Parse(textBox1.Text);
            textBox1.Clear();
            if (op == '+')
                textBox1.Text = (n1 + n2).ToString();

            if (op == '-')
                textBox1.Text = (n1 - n2).ToString();

            if (op == '*')
                textBox1.Text = (n1 * n2).ToString();

            if (op == '/')
                if (n2 == 0)
                    textBox1.Text = "ERROR";
                else
                    textBox1.Text = (n1 + n2).ToString();

            if (op == '%')
                textBox1.Text = (n1 % n2).ToString();
            if (op == 'p')
            {
                for (int i = 1; i < n2; i++)
                {
                    n1 *= n1;
                }
                textBox1.Text = n1.ToString();
            }
            if (op == 'l')
                textBox1.Text = (Math.Log(n1, n2)).ToString();


        }

        private void button21_Click(object sender, EventArgs e)
        {
            n1 = Double.Parse(textBox1.Text);
            op = 'p';
            textBox1.Clear();


        }

        private void button20_Click(object sender, EventArgs e)
        {
            n1 = Double.Parse(textBox1.Text);
            op = 'l';
            textBox1.Clear();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            n1 = Double.Parse(textBox1.Text);
            op = 's';
            textBox1.Text = Math.Sin(n1).ToString();

        }

        private void button23_Click(object sender, EventArgs e)
        {
            n1 = Double.Parse(textBox1.Text);
            op = 's';
            textBox1.Text = Math.Cos(n1).ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            n1 = Double.Parse(textBox1.Text);
            op = 't';
            textBox1.Text = Math.Tan(n1).ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            n1 = Double.Parse(textBox1.Text);
            op = 'q';
            textBox1.Text =Math.Sqrt(n1).ToString();
        }
    }
}
