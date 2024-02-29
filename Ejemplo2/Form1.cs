using Ejemplo2.MisClases;
using Ejemplo2.Models;
using System.Drawing.Text;

namespace Ejemplo2
{
    public partial class Form1 : Form
    {
        public List<string> miListita;
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
            Empleado em1 = new Empleado("Sofia", "Rocha", 73012345);
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
            int num3 = (int)5.7f;
            float num4 = num3;

            Empleado em3 = new Jefe("Pepe", "Perales", "78945ASD", "Mantenimiento");
            Jefe jj = (Jefe)em2;
            jj.ordenar();
        }

        #endregion


        private void button7_Click(object sender, EventArgs e)
        {
            Rectangulo rect1 = new Rectangulo(double.Parse(txtAltura.Text), double.Parse(txtBase.Text));
            lblArea.Text = rect1.calcularArea().ToString();
            lblColor.Text = rect1.getColor();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            IFiguraGeometrica circ1 = new Circulo(double.Parse(txtRadio.Text));

            IFiguraGeometrica[] figuras = { circ1, new Rectangulo(10, 40) };
            int[] calificaciones = new int[4];
            int[] calificaciones2 = new int[calificaciones.Length + 1];
            for (int j = 0; j < calificaciones.Length; j++)
                calificaciones2[j] = calificaciones[j];
            calificaciones = calificaciones2;
            lblColorCirc.Text = "";
            for (int i = 0; i < figuras.Length; i++)
            {
                lblColorCirc.Text += figuras[i].calcularArea().ToString() + ", ";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (miListita == null)
                miListita = new List<string>();
            miListita.Add(txtGetLista.Text);
            txtGetLista.Text = "";
            lblMostrarLista.Text = "";

            miListita.Remove("RRR");
            for (int i = 0; i < miListita.Count; i++)
            {
                lblMostrarLista.Text += miListita.ElementAt(i) + "\n";
            }
            string elemento = miListita.First();

        }

        public List<Empleado> listaEmpleados = new List<Empleado>();
        private void button10_Click(object sender, EventArgs e)
        {
            listaEmpleados.Add(new Empleado(txtNombreEmpleado.Text, txtApellidoEmpleado.Text, int.Parse(txtTelefonoEmpleado.Text)));
            txtNombreEmpleado.Text = txtApellidoEmpleado.Text = txtTelefonoEmpleado.Text = "";
            lblMostrarListaEmpleados.Text = "";
            for (int i = 0; i < listaEmpleados.Count; i++)
            {
                lblMostrarListaEmpleados.Text += listaEmpleados.ElementAt(i) + "\n";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Empleado empAuxiliar = new Empleado(txtNombreEmpleado.Text, txtApellidoEmpleado.Text, int.Parse(txtTelefonoEmpleado.Text));
            listaEmpleados.Remove(empAuxiliar);
            txtNombreEmpleado.Text = txtApellidoEmpleado.Text = txtTelefonoEmpleado.Text = "";
            lblMostrarListaEmpleados.Text = "";
            for (int i = 0; i < listaEmpleados.Count; i++)
            {
                lblMostrarListaEmpleados.Text += listaEmpleados.ElementAt(i) + "\n";
            }

            Empleado x = new Empleado("a", "b", 1);
            Empleado y = x;
            x.nombre = "z";
        }

        private Stack<string> miPilita = new Stack<string>();
        private void button12_Click(object sender, EventArgs e)
        {
            string elemento = txtGetPila.Text;
            miPilita.Push(elemento);
            lblPila.Text = "";
            txtGetPila.Text = "";
            Stack<string> pilaAuxiliar = new Stack<string>();

            while (miPilita.Count > 0)
            {
                string elementoActual = miPilita.Pop();
                lblPila.Text += elementoActual + "\n";
                pilaAuxiliar.Push(elementoActual);
            }
            while (pilaAuxiliar.Count > 0)
                miPilita.Push(pilaAuxiliar.Pop());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string elementoEliminado = miPilita.Pop();
            lblEliminado.Text = $"Se acaba de eliminar:\n {elementoEliminado}";
            lblPila.Text = "";
            Stack<string> pilaAuxiliar = new Stack<string>();

            while (miPilita.Count > 0)
            {
                string elementoActual = miPilita.Pop();
                lblPila.Text += elementoActual + "\n";
                pilaAuxiliar.Push(elementoActual);
            }
            while (pilaAuxiliar.Count > 0)
                miPilita.Push(pilaAuxiliar.Pop());

            string variable = miPilita.Peek();//solo rescata el valor del elemento en la cima de la pila (sin eliminarlo de la pila)

        }
        private Queue<string> colaPlatos = new Queue<string>();
        private void button14_Click(object sender, EventArgs e)
        {
            colaPlatos.Enqueue(txtCola.Text);
            lblElementosCola.Text = "";
            txtCola.Text = "";
            Queue<string> colaAuxiliar = new Queue<string>();
            while (colaPlatos.Count > 0)
            {
                string plato = colaPlatos.Dequeue();
                lblElementosCola.Text += plato + "\n";
                colaAuxiliar.Enqueue(plato);
            }
            while (colaAuxiliar.Count > 0)
                colaPlatos.Enqueue(colaAuxiliar.Dequeue());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            colaPlatos.Dequeue();

            lblElementosCola.Text = "";
            Queue<string> colaAuxiliar = new Queue<string>();
            while (colaPlatos.Count > 0)
            {
                string plato = colaPlatos.Dequeue();
                lblElementosCola.Text += plato + "\n";
                colaAuxiliar.Enqueue(plato);
            }
            while (colaAuxiliar.Count > 0)
                colaPlatos.Enqueue(colaAuxiliar.Dequeue());
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var contexto = new LibreriaDbContext();
            var libros = contexto.Libros.ToList();
            lblRegistrosLibro.Text = "";
            foreach ( var libro in libros )
            {
                lblRegistrosLibro.Text += $"Titulo: {libro.titulo}, Autor: {libro.autor}\n";
            }
        }
    }
}
