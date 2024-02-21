using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2.MisClases
{
    public class Empleado
    {
        public Empleado(string nom, string ape, int telf) {
            nombre = nom;
            apellido = ape;
            telefono = telf;
        }public Empleado(string nombre, string apellido) {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public void metodo1() {
            nombre = "Pepe";
        }
        public void metodo1(int i)
        {
            nombre = "Pepe";
        }
        public void metodo1(string nombre) { 
        }
        public void metodo1(int edad, string nombre) { }
        public void metodo1(string nombre, string apellido) { }


        public string nombre;
        public string apellido { get; set; }//variantes completas de get/set
        private int _telefono;
        public int telefono { 
            get {
                return _telefono * 2;
            }
            set {
                if(value > 0)
                    _telefono = value;
            }
        }

        public void metodo2() { 
        
        }
    }

    public class Jefe : Empleado{
        public Jefe(string nombre1, string apellido1, string placa, string depto) : base(nombre1, apellido1){
            this.placa = placa;
            departamento = depto;
        }

        public Jefe() : base("NN","NA"){
            placa = "0000";
            departamento = "";
        }
        public string placa;
        public string departamento;
        public string ordenar() {
            return "Entregue esos informes.";
        }
    }
}
