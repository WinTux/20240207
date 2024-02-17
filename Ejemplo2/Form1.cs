namespace Ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string n1 = num1.Text;
            string n2 = num2.Text;
            bool esNum1 = double.TryParse(n1, out double numeroA);
            bool esNum2 = double.TryParse(n2, out double numeroB);
            if (esNum1 && esNum2) // ||
            {
                double res = numeroA + numeroB;
                resultado.Text = res.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string n1 = num1.Text;
            string n2 = num2.Text;
            bool esNum1 = double.TryParse(n1, out double numeroA);
            bool esNum2 = double.TryParse(n2, out double numeroB);
            if (esNum1 && esNum2) // ||
            {
                double res = numeroA - numeroB;
                resultado.Text = res.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string n1 = num1.Text;
            string n2 = num2.Text;
            bool esNum1 = double.TryParse(n1, out double numeroA);
            bool esNum2 = double.TryParse(n2, out double numeroB);
            if (esNum1 && esNum2) // ||
            {
                double res = numeroA * numeroB;
                resultado.Text = res.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string n1 = num1.Text;
            string n2 = num2.Text;
            bool esNum1 = double.TryParse(n1, out double numeroA);
            bool esNum2 = double.TryParse(n2, out double numeroB);
            if (esNum1 && esNum2) // ||
            {
                double res = numeroA / numeroB;
                resultado.Text = res.ToString();
            }
        }
    }
}
