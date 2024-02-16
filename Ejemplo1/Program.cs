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
             * PM> Ejemplo1 -n1 30 -operación resta -n2 4
             */

            //Paso 1: Esta en args
            //Paso 2: iteraciones
            int longitud = args.Length;// 6
            string operacion = "";
            //hablar sobre iteraciones (loops)
            for (int i = 0; i < longitud; i++) {
                string argumento = args[i];
                if (argumento.Equals("-operacion")) {
                    operacion = args[i + 1];
                    break;
                }
            }
            if (operacion.Equals(""))
            {
                Console.WriteLine("No se encontro el argumento -operacion; revise el manual de usuario");
            }
            else {
                int resultado = 0, n1 = 0,n2 = 0;

                for (int i = 0; i < longitud; i++)
                {
                    if (args[i].Equals("-n1"))
                    {
                        n1 = int.Parse(args[i + 1]);
                    }
                    if (args[i].Equals("-n2"))
                    {
                        n2 = int.Parse(args[i + 1]);
                    }
                }
                switch (operacion) {
                    case "suma":
                        resultado = n1 + n2;
                        break;
                    case "resta":
                        resultado = n1 - n2;
                        break;
                    case "multiplicacion":
                        resultado = n1 * n2;
                        break;
                    case "division":
                        resultado = n1 / n2;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"Error, operacion aritmetica no contemplada: {operacion}");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        resultado = -9999;
                        break;
                }
                Console.WriteLine($"El resultado de la {operacion} es: {resultado}");
            }

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

            // Una iteracion con while
            Console.WriteLine("Por favor ingrese un numero entero");
            int contador;
            string lineaLeida = Console.ReadLine();
            bool convertido = int.TryParse(lineaLeida, out contador);//contador = int.Parse(lineaLeida);
            if (convertido)
            {
                while (contador > 0)
                {
                    Console.WriteLine("Estoy dentro una iteracion");
                    contador--;
                }
            }
            else {
                Console.WriteLine($"El valor \"{lineaLeida}\" no es un numero valido.");
            }

            //Intentos indefinidos
            Console.WriteLine("Por favor ingrese un numero entero");
            lineaLeida = Console.ReadLine();
            convertido = int.TryParse(lineaLeida, out contador);
            while (!convertido) {
                Console.WriteLine("Por favor ingrese un numero entero");
                lineaLeida = Console.ReadLine();
                convertido = int.TryParse(lineaLeida, out contador);
            }
            if (convertido)
            {
                while (contador > 0)
                {
                    Console.WriteLine("Estoy dentro una iteracion");
                    contador--;
                }
            }
        }
    }
}
