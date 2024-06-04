namespace Калькулятор
{
    public partial class Калькулятор : Form
    {

        public decimal a, b;
        public double k, kk;
        int c;
        bool sign = true;

        public Калькулятор()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (textBox1.Text=="0") textBox1.Text = B.Text;
            else textBox1.Text = textBox1.Text + B.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
           // if (textBox1.Text == "-") textBox1.Text = "";
            a = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            c = 1;
            label1.Text = a.ToString() + "+";
            sign = true;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
                a = decimal.Parse(textBox1.Text);
                textBox1.Clear();
                c = 2;
                label1.Text = a.ToString() + "-";
                sign = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            a = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            c = 3;
            label1.Text = a.ToString() + "*";
            sign = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            a = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            c = 4;
            label1.Text = a.ToString() + "/";
            sign = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            a = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            c = 5;
            label1.Text = a.ToString() + "²";
            sign = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            kk = double.Parse(textBox1.Text);
            textBox1.Clear();
            c = 6;
            label1.Text = "√" + kk.ToString();
            sign = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            calc();
            label1.Text = "";
        }

        private void calc()
        {
            switch (c)
            {
                case 1:
                    b = a + decimal.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - decimal.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * decimal.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    decimal r = decimal.Parse(textBox1.Text);
                    if (r == 0) textBox1.Text = "Деление на ноль невозможно";
                    else
                    {
                        b = a / decimal.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                    }
                    break;
                case 5:
                    b = a * a;
                    textBox1.Text = b.ToString();
                    break;
                case 6:
                    k = Math.Sqrt(kk);
                    textBox1.Text = k.ToString();
                    break;

                default:
                    break;
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            int len = textBox1.Text.Length;
            string t = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < len - 1; i++)
            {
                textBox1.Text = textBox1.Text + t[i];
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (sign == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                sign = false;
            }
            else if (sign == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                sign = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;
            if (!char.IsDigit(number) && (!char.IsControl(number))) e.Handled = true;

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }

            if (number == 43) button10.PerformClick(); // + 

            if (number == 45) // -
            {
                if (textBox1.Text != "") button11.PerformClick();
                    else button16.PerformClick();

                textBox1.SelectionStart = textBox1.Text.Length; // курсор в конец 
                textBox1.SelectionLength = 0;
            }

            if (number == 42) button12.PerformClick(); // *
            if (number == 47) button13.PerformClick(); // /
            if (number == 62) button14.PerformClick(); // ² (>)
            if (number == 60) button15.PerformClick(); // √ (<)

            if (number == 44 || number == 46) // ,
            {
                button17.PerformClick();
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.SelectionLength = 0;
            }

            if (number == 8)
            {
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.SelectionLength = 0;
            }

            if (number == 61 || number == 13) button18.PerformClick(); // =
            if (number == 27 || number == 67 || number == 99) button19.PerformClick(); // С (или esc)
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            //Сделать так чтобы запятая не повторялась больше - вывод ответа
            if (textBox1.Text == "") textBox1.Text = "0";
            int len = textBox1.Text.Length;
            string t = textBox1.Text;
            int l = 0;
            for (int i = 0; i < len; i++)
            {
                if (t[i] == ',') l++;
            }
            if (l == 0) textBox1.Text = textBox1.Text + ",";

            //textBox1.Text = textBox1.Text + ",";
        }
    }
}