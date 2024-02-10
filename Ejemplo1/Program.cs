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
            /*
             * 1. recibir argumentos
             * 2. verificar si existe argumento -operacion
             * 3.  si: evaluar el tipo de operacion
             *     no: mostrar mensaje de error "Necesita especificar tipo de op"
             * 4. rescatar valores de -n1 y -n2
             * 5. operar
             * 6. mostrar resultado
             * 
             * Ejemplo de ejecución:
             * PM>Ejemplo1 -n1 30 -operación resta -n2 4
             */

            //Paso 1: Esta en args
            //Paso 2: iteraciones
            int longitud = args.Length;// 6
            //hablar sobre iteraciones (loops)



            int num, num2;
            num = 45;
            num2 = 3;

            int sum = num + num2;

            Console.WriteLine("La suma es: " + sum);

            float peso = 50.0f;
            double estatura = 1.7565465464;

            float distancia = 50;
            double altura = 40;
            double ancho = 40.5f;
            Console.WriteLine(altura + ancho);

            Console.WriteLine("La suma es: " + (altura + ancho));
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
