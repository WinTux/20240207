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
            int telefonoMultiplicado = em1.telefono;
            Empleado em2 = new Empleado("Ana", "Sosa");
            em2.metodo1();
            

            Jefe jefe_depto_1 = new Jefe("Samantha", "Roca", "5432CBA", "Recursos Humanos");
            jefe_depto_1.metodo1();
            jefe_depto_1.ordenar();

            float num = 7;
            int num2 = (int)5.7f;
            float num3 = num2;

            Empleado em3 = new Jefe("Pepe", "Perales", "78945ASD", "Mantenimiento");
            Jefe jj = (Jefe)em2;
            jj.ordenar();
        }

        #endregion


    }
}
