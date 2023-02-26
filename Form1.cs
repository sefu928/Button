namespace Calculadora
{
    public partial class Form1 : Form
    {
        String[] monedes = new string[5] { "US$", "€", "¥ / 円", "£", "¥ / 元 " };

        Double[,] taula = new Double[5, 5] 
        { 
            { 1, 0.93, 133.26, 0.83, 6.85 }, 
            { 1.07, 1, 142.79, 0.89, 7.33 }, 
            { 0.0075, 0.007, 1, 0.0062, 0.051 }, 
            { 1.21, 1.13, 161.21, 1, 8.28 }, 
            { 0.15, 0.14, 19.47, 0.12, 1 } 
        };

        public Form1()
        {
            InitializeComponent();

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            for (int i = 0; i < monedes.Length; i++)
            {
                comboBox1.Items.Add(monedes[i]);
                comboBox2.Items.Add(monedes[i]);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            teclat(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            teclat(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            teclat(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            teclat(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            teclat(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            teclat(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            teclat(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            teclat(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            teclat(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            teclat(0);
        }

        public void teclat(int n)
        {
            if (textBox1.Text == "Error")
            {
                textBox1.Text = "";
            }
            textBox1.Text += n;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int len = textBox1.Text.Length;

            if (len > 0)
            {
                textBox1.Text = textBox1.Text.Remove(len - 1);
            }

        }

        public void conversor()
        {

            if (double.TryParse(textBox1.Text, out _))
            {
                double n = Convert.ToDouble(textBox1.Text);

                if (comboBox1.SelectedIndex != comboBox2.SelectedIndex)
                {

                    int i1 = comboBox1.SelectedIndex;
                    int i2 = comboBox2.SelectedIndex;

                    double m = taula[i1, i2];

                    textBox1.Text = (n * m).ToString("#0.00##");
                    label2.Text = comboBox2.SelectedItem.ToString();

                }

                else
                {
                    textBox1.Text = "Error";
                }
            }
            else
            {
                textBox1.Text = "Error";
            }


        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            conversor();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                conversor();
            }
        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.textBox1.SelectionLength == 0)
            {
                this.textBox1.SelectAll();
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (MouseButtons == MouseButtons.None)
            {
                this.textBox1.SelectAll();
            }
        }
    }
}