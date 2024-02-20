using Ejemplo2.MisClases;

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
        #region Dos metodos simples
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
        
        private void VaciarCampos(object sender, EventArgs e)
        {
            num1.Text = num2.Text = "";
            //Ejemplos simpres
            Empleado em1 = new Empleado("Sofia","Rocha",73012345);
            em1.metodo1(22, "Pepe");
            em1.metodo1("Pepe", "Perales");
            em1.telefono = 20;
            Empleado em2 = new Empleado("Ana", "Sosa");
        }

        #endregion


    }
}
