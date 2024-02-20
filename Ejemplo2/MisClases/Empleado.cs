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
        public string apellido;
        public int telefono { get; set; }//variantes completas de get/set

        public void metodo2() { 
        
        }
    }
}
