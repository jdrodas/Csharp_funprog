/*
Programa:       ex02_CoordenadasGeograficas
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Formulación: 
------------

Realice un programa que realice conversión en la notación de las coordenadas
geográficas, desde una notación decimal a una notación Grados-Minutos-Segundos.

Notación Grados-Minutos-Segundos-Orientación (GMSO): 
- Para la latitud, los grados son valores enteros positivos en el intervalo [-90;90] 
- Para la longitud, los grados son valores enteros positivos en el intervalo (-180 y 180) (intervalo abierto) 
- Para ambas, los minutos son valores enteros positivos en el intervalo [0;60) (sin incluir el 60) 
- Para ambas, los segundos son valores reales en el intervalo [0;60) (sin incluir el 60) 
- Los puntos cardinales que definen la orientación son: 
    - N – Norte, si la latitud es positiva. 
    - S – Sur, si la latitud es negativa. 
    - E – Este, si la longitud es positiva. 
    - W – Oeste, si la longitud es negativa. 

Notación Decimal: 
- La latitud es un valor real (con dígitos decimales) que va en el intervalo [-90;90] 
- La longitud es un valor real (con dígitos decimales) que va en el intervalo (-180 y 180) (intervalo abierto). 

Para realizar la conversión de GMSO a Decimal, se sigue el siguiente algoritmo o secuencia de pasos: 
    Identificación de signo: 
    - Si el componente de orientación tiene la letra “N” o “E”, la coordenada real será positiva; 
    de lo contrario (“S” o “W”) será negativa. 
    - El componente de grados es un valor entero positivo en el intervalo [0;90] para latitudes y 
    entero positivo en el intervalo [0;180] para longitudes. El componente de minutos es un valor entero 
    positivo en el intervalo [0;59] tanto para latitudes como longitudes. 
    - El componente de segundos es un valor real positivo en el intervalo [0:60) (sin incluir el 60) 
    tanto para latitudes como para longitudes. El valor real de la coordenada se obtiene con la siguiente fórmula:

        Valor = signo * (grados + (minutos / 60) + (segundos /3600)) 

*/

using System;

namespace ex02_CoordenadasGeograficas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short valorOpcion;
            bool datoCorrecto;

            do
            {
                Console.WriteLine("Programa para convertir notación de coordenadas geográficas\n");
                Console.WriteLine("\t1. De notación decimal a Grados-Minutos-Segundos-Orientación");
                Console.WriteLine("\t2. De notación Grados-Minutos-Segundos-Orientación a decimal");
                Console.WriteLine("\t0. Salir del programa");

                Console.Write("\n\nSelecciona una opción: ");
                datoCorrecto = short.TryParse(Console.ReadLine(), out valorOpcion);

                //Si el dato no es correcto, debemos asignarle un valor a la opción
                //que repita el proceso. Por ejemplo, -1
                if (datoCorrecto == false)
                    valorOpcion = -1;

                //Aqui invocamos las funciones según la opción:
                if (valorOpcion == 1)
                    ConvierteAGms();

                if (valorOpcion == 2)
                    ConvierteADecimal();

                if (valorOpcion != 1 && valorOpcion != 2 && valorOpcion != 0)
                {
                    Console.WriteLine("La opción ingresada no es válida. Intenta nuevamente!");
                    Console.WriteLine("Presiona cualquier tecla para continuar...");
                    Console.ReadKey();
                }

                //Borramos la consola cuando las opciones ingresadas no son para salir
                if (valorOpcion != 0)
                    Console.Clear();
            } while (valorOpcion != 0);

            //Aqui mostramos la salida
            Console.WriteLine("\n\nFin del programa");
        }

        /// <summary>
        /// Función que encapsula la conversion desde Decimal a GMS
        /// </summary>
        static void ConvierteAGms()
        {
            Console.Clear();
            Console.WriteLine("Programa para convertir notación de coordenadas geográficas");
            Console.WriteLine("De notación decimal a Grados-Minutos-Segundos-Orientación");

            //Arreglo de coordenadas: 0: Latitud, 1: Longitud
            double[] coordenada = new double[2]; 
            bool datoLongitudCorrecto = false, datoLatitudCorrecto = false;

            do
            {
                Console.Write("\nIngresa el valor de la latitud: ");
                datoLatitudCorrecto = double.TryParse(Console.ReadLine(), out coordenada[0]);

                Console.Write("Ingresa el valor de la longitud: ");
                datoLongitudCorrecto = double.TryParse(Console.ReadLine(), out coordenada[1]);

                if (datoLatitudCorrecto && datoLongitudCorrecto)
                {
                    //Aqui validamos si los valores están en los rangos requeridos
                    //para cada componente de coordenada

                    //Para la latitud
                    if (coordenada[0] < -90 || coordenada[0] > 90)
                    {
                        Console.WriteLine("El dato de latitud no se encuentra en el intervalo esperado de [-90;90]. Intenta nuevamente");
                        datoLatitudCorrecto = false;
                    }

                    //Para la longitud
                    if (coordenada[1] < -180 || coordenada[1] > 180)
                    {
                        Console.WriteLine("El dato de longitud no se encuentra en el intervalo esperado de [-180;180]. Intenta nuevamente");
                        datoLongitudCorrecto = false;
                    }                  
                }
                else
                    Console.WriteLine("Los datos ingresados son inválidos. Intenta nuevamente!");
            }
            while (datoLongitudCorrecto == false || datoLatitudCorrecto == false);

            //Aqui invocamos la función que hace la conversión de notación a GMSO
            string[] coordenadaGMSO = ConvierteNotacionGMSO(coordenada);

            //Aqui visualizamos resultados:
            Console.WriteLine("\nResultados de la conversión:");
            Console.WriteLine($"En notación decimal: {coordenada[0]}, {coordenada[1]}");
            Console.WriteLine($"En notación GMSO: {coordenadaGMSO[0]}, {coordenadaGMSO[1]}");

            Console.WriteLine("\n\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
        }

        /// <summary>
        /// Función que convierte cada componente de la coordenada a notación GMSO
        /// </summary>
        /// <param name="coordenada">Los componentes de la coordenada en notación decimal</param>
        /// <returns>Los componentes de la coordenada en notación GMSO</returns>
        static string[] ConvierteNotacionGMSO(double[] coordenada)
        {
            string[] resultado = new string[2];

            //Ambos componentes se calculan de la misma forma,
            //asi que encapsulamos esa lógica en una sola función
            resultado[0] = CalculaGMSO(coordenada[0], "Latitud");
            resultado[1] = CalculaGMSO(coordenada[1], "Longitud");

            return resultado;
        }

        /// <summary>
        /// Calcula la notación GMSO a partir del valor y el tipo de coordenada
        /// </summary>
        /// <param name="valor">Valor decimal del componente de la coordenada</param>
        /// <param name="tipoComponente">El tipo de componente: Latitud o Longitud</param>
        /// <returns>La cadena de caracteres que representa la coordenada en notación GMSO</returns>
        static string CalculaGMSO(double valor, string tipoComponente)
        {
            string orientacion = "";
            
            if (tipoComponente == "Latitud")
                if (valor < 0)
                    orientacion = "S";
                else
                    orientacion = "N";
            else
                if (valor < 0)
                    orientacion = "W";
                else
                    orientacion = "E";

            //Aqui calculamos el resto de las partes de la notación
            valor = Math.Abs(valor);
            double grados = Math.Truncate(valor);
            double minutos = Math.Truncate((valor - grados) * 60);
            double segundos = ((valor - grados) * 60 - minutos) * 60;

            string resultado = 
                                $"{grados}º " +
                                $"{minutos}\' " +
                                $"{Math.Round(segundos, 2)}\" " +
                                $"{orientacion}";

            return resultado;
        }

        /// <summary>
        /// Función que encapsula la conversión desde GMS a Decimal
        /// </summary>
        static void ConvierteADecimal()
        {
            Console.Clear();
            Console.WriteLine("Programa para convertir notación de coordenadas geográficas");
            Console.WriteLine("De notación Grados-Minutos-Segundos-Orientación a decimal");

            // Variables que utilizaremos en el proceso
            int gradosLatitud=0, gradosLongitud = 0, minutosLatitud = 0, minutosLongitud = 0;
            double segundosLatitud = 0, segundosLongitud = 0;
            string orientacionLatitud="", orientacionLongitud = "";
            bool datoLongitudCorrecto = false, datoLatitudCorrecto = false;

            //Captura de datos para la Latitud
            do
            {
                try
                {
                    Console.Write("\nIngresa el valor de grados de la latitud: ");
                    gradosLatitud = int.Parse(Console.ReadLine());
                    Console.Write("Ingresa el valor de minutos de la latitud: ");
                    minutosLatitud = int.Parse(Console.ReadLine());
                    Console.Write("Ingresa el valor de segundos de la latitud: ");
                    segundosLatitud = double.Parse(Console.ReadLine());
                    Console.Write("Ingresa el valor de orientación de la latitud (N/S): ");
                    orientacionLatitud = Console.ReadLine().ToUpper();

                    //Aqui hacemos validación de los valores de la latitud
                    if (
                        gradosLatitud < 0 || gradosLatitud > 90 ||
                        minutosLatitud < 0 || minutosLatitud >= 60 ||
                        segundosLatitud < 0 || segundosLatitud >= 60 ||
                        (orientacionLatitud != "N" && orientacionLatitud != "S")
                      )
                    {
                        Console.WriteLine("La información de latitud no está en los rangos esperados. Intenta nuevamente");
                        datoLatitudCorrecto = false;
                    }
                    else
                        datoLatitudCorrecto = true;

                }
                catch (FormatException errorFormato)
                {
                    Console.WriteLine("Los datos ingresados para la latitud son inválidos. Intenta nuevamente!");
                    Console.WriteLine($"Error: {errorFormato.Message}");
                }
            }
            while (datoLatitudCorrecto == false);

            //Captura de datos para la Latitud
            do
            {
                try
                {
                    Console.Write("\nIngresa el valor de grados de la longitud: ");
                    gradosLongitud = int.Parse(Console.ReadLine());
                    Console.Write("Ingresa el valor de minutos de la longitud: ");
                    minutosLongitud = int.Parse(Console.ReadLine());
                    Console.Write("Ingresa el valor de segundos de la longitud: ");
                    segundosLongitud = double.Parse(Console.ReadLine());
                    Console.Write("Ingresa el valor de orientación de la longitud (E/W): ");
                    orientacionLongitud = Console.ReadLine().ToUpper();

                    //Aqui hacemos validación de los valores de la longitud
                    if (
                        gradosLongitud < -180 || gradosLongitud > 180 ||
                        minutosLongitud < 0 || minutosLongitud >= 60 ||
                        segundosLongitud < 0 || segundosLongitud >= 60 ||
                        (orientacionLongitud != "W" && orientacionLongitud != "E")
                      )
                    {
                        Console.WriteLine("La información de longitud no está en los rangos esperados. Intenta nuevamente");
                        datoLongitudCorrecto = false;
                    }
                    else
                        datoLongitudCorrecto = true;
                }
                catch (FormatException errorFormato)
                {
                    Console.WriteLine("Los datos ingresados para la longitud son inválidos. Intenta nuevamente!");
                    Console.WriteLine($"Error: {errorFormato.Message}");
                }
            }
            while (datoLongitudCorrecto == false);

            double latitud = ConvierteNotacionDecimal(gradosLatitud, minutosLatitud, 
                segundosLatitud, orientacionLatitud);

            double longitud = ConvierteNotacionDecimal(gradosLongitud, minutosLongitud,
                segundosLongitud, orientacionLongitud);

            //Aqui visualizamos resultados:
            Console.WriteLine("\nResultados de la conversión:");
            Console.WriteLine("En notación GMSO: " +
                $"{gradosLatitud}º " +
                $"{minutosLatitud}\' " +
                $"{Math.Round(segundosLatitud, 2)}\" " +
                $"{orientacionLatitud}," +
                $"{gradosLongitud}º " +
                $"{minutosLongitud}\' " +
                $"{Math.Round(segundosLongitud, 2)}\" " +
                $"{orientacionLongitud}");

            Console.WriteLine($"En notación decimal: {latitud}, {longitud}");
            Console.WriteLine("\n\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
        }

        /// <summary>
        /// Función que retorna el componente de coordenada en notación decimal
        /// </summary>
        /// <param name="grados">Grados del componente de coordenada</param>
        /// <param name="minutos">Minutos del componente de coordenada</param>
        /// <param name="segundos">Segundos del componente de coordenada</param>
        /// <param name="orientacion">Orientación del componente de la coordenada</param>
        /// <returns></returns>
        static double ConvierteNotacionDecimal(int grados, int minutos, double segundos, string orientacion)
        {
            double resultado = 0;
            double signo = 0;
            if (orientacion == "N" || orientacion == "E")
                signo = 1;
            else
                signo = -1;

            resultado = Math.Round(signo * 
                (grados + 
                 ((double)minutos/60) + 
                 (segundos/3600)), 6);

            return resultado;
        }
    }
}
