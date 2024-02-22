using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2.MisClases
{
    public interface IFiguraGeometrica
    {
        double calcularArea();
    }
    public interface IColor {
        string getColor();
    }

    public class Rectangulo : IFiguraGeometrica, IColor
    {
        public double a;
        public double b;
        public Rectangulo(double altura, double anchura)
        {
            a = altura;
            b = anchura;
        }
        public double calcularArea()
        {
            double area = a * b;
            return area;
        }

        public string getColor()
        {
            return "Rectangulo verde.";
        }
    }
    public class Circulo : IFiguraGeometrica, IColor
    {
        public double radio;
        public Circulo(double radio) {
            this.radio = radio;
        }
        public double calcularArea()
        {
            return (Math.PI * Math.Pow(radio,2));
        }

        public string getColor()
        {
            return "Círculo rojo.";
        }
    }
}
