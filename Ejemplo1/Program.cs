using Ejemplo1.ConsumidorAPI.HTTPS;


namespace Ejemplo1
{
    using MiSpace.Espacio;
    using OtroGrupo;
    internal class Program
    {
        ConexionSSL conexion;
        static void Main(string[] args)
        {
            int num;
            num = 45;

            float peso = 50.0f;
            double estatura = 1.7565465464;

            float distancia = 50;
            double altura = 40;
            double ancho = 40.5f;

            string usuario;
            usuario = "Pepe";

            usuario = "Perales";

            string apodo = "Pepe \"el ma\nfioso\" \\PEPE\\";
            Console.WriteLine(apodo);

            bool casado = true;
            casado = false;


            Persona p1;
            OtraClaseInterna otroObjeto;
            Clase1 clase1;

            Console.WriteLine(
                "Distancia: " + distancia + 
                "[m]\nAltura: " + altura + 
                "[m]\nAncho: " + ancho + "[m]");

            Console.WriteLine(
                $"Distancia: {distancia}[m]\nAltura: {altura}\nAncho: {ancho}"
            );
        }
    }
}
