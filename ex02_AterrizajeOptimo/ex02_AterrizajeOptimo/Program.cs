/*
Programa:       ex02_AterrizajeOptimo
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Formulación: 
------------

Simulador de Vuelo – Aterrizaje Óptimo

Con el propósito de preparar mejor a los pilotos, la aerolínea Cochinito Airlines le ha encargado la
implementación de un simulador de vuelo en el cual se pueda evaluar las capacidades para realizar
un aterrizaje óptimo.

En la pista del aeropuerto virtual se ha demarcado una línea a partir de la cual los aviones deben
aterrizar, buscando que los pilotos minimicen la distancia entre el punto de contacto y la línea.
Dicha distancia es un valor que va entre -3 metros (antes de la línea) y 3 metros(después de la
línea).

Cada piloto tendrá 10 oportunidades de aterrizaje y se deberá identificar la menor distancia de los
intentos que no sea cero (aterrizó en la línea). Solo se deben considerar los intentos con
distancias positivas para identificar la oportunidad de mejor desempeño del piloto.

Por ejemplo, un piloto que utilizó el simulador, obtuvo los siguientes valores en distancia al punto
óptimo de aterrizaje:
        0,23 1,72 -0,05 2,83 0,13 0,87 0,13 2,4 0 -2,3

La mejor distancia es 0,13 y se obtuvo en los intentos 5 y 7. Aunque en el intento 9 obtuvo el valor
de 0, no es el valor buscado.

Realice un programa en C# que lea de consola 10 números reales en el rango [-3;3] e identifique
cuales de ellos están más cerca al valor cero, sin ser el cero. Solo se deben tomar en cuenta los
valores positivos.

El programa debe leer de consola los valores y validar que se ingrese datos numéricos (control de
excepciones) y que dichos números estén en el rango solicitado. Dichos valores deben ser
almacenados en un arreglo.

Cree una función denominada “ObtieneMenorDistancia” que reciba el arreglo de números reales
y devuelva un número real con la menor distancia a cero de los valores encontrados. Cero no es un
valor válido para devolver por la función

Cree una función denominada “ObtienePosicionesMenores” que reciba el arreglo de números
reales y devuelva un arreglo de enteros con las posiciones del arreglo que tienen la menor
distancia encontrada con la función ObtieneMenorDistancia.

Finalmente Visualice el arreglo en consola, los 10 valores en una sola línea separados por
tabulador. Visualice también la menor distancia encontrada y cuales fueron los intentos en los
cuales ocurrió dicho aterrizaje óptimo.

*/
using System;


namespace ex02_AterrizajeOptimo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para identificar el aterrizaje óptimo");
            Console.WriteLine("Se registran 10 intentos de aterrizaje,");
            Console.WriteLine("midiendo la distancia entre la línea ideal y el punto de contacto");
            Console.WriteLine("La menor distancia que no sea cero es el mejor intento del piloto.\n\n");

            int posicion = 0;
            float[] arregloIntentos = new float[10];


            while (posicion < 10)
            {
                try
                {
                    Console.Write("Ingresa la distancia de aterrizaje para el intento No. {0}: ", posicion + 1);
                    arregloIntentos[posicion] = float.Parse(Console.ReadLine());

                    if (arregloIntentos[posicion] >= -3 && arregloIntentos[posicion] <= 3)
                        posicion++;
                    else
                        Console.WriteLine("El valor ingresado no está en el rango [-3;3]. Intenta nuevamente! \n");

                }
                catch (FormatException error)
                {
                    Console.WriteLine("Ingresaste un dato no numérico. Intenta nuevamente!");
                    Console.WriteLine("Error: " + error.Message + "\n");
                }
            }

            //aqui visualizamos resultados
            Console.WriteLine("Las distancias ingresadas fueron las siguientes:\n");

            for (int i = 0; i < arregloIntentos.Length; i++)           
                Console.Write(arregloIntentos[i] + "\t");

            float menorDistancia = ObtieneMenorDistancia(arregloIntentos);
            Console.WriteLine("\n\nLa menor distancia registrada fue {0}", menorDistancia);

            Console.WriteLine("Esta distancia se encontró en los siguientes intentos");
            int[] intentosMenores = ObtienePosicionesMenores(arregloIntentos);

            for (int i = 0; i < intentosMenores.Length; i++)            
                Console.WriteLine("Intento No. {0}", intentosMenores[i]);
        }

        /// <summary>
        /// Función para encontrar las posiciones en el arreglo que tienen el menor valor
        /// </summary>
        /// <param name="arregloValores">arreglo con valores numéricos reales</param>
        /// <returns>Arreglo con las posiciones en arreglo original que tienen el valor menor</returns>
        static int[] ObtienePosicionesMenores(float[] arregloValores)
        {
            //identificamos cual es el valor menor que tenemos que buscar en el arreglo
            float valorMenor = ObtieneMenorDistancia(arregloValores);

            int cuentaPosiciones = 0;

            //recorremos el arreglo identificando cuantos tienen ese valor
            for (int i = 0; i < arregloValores.Length; i++)
            {
                if (arregloValores[i] == valorMenor)
                    cuentaPosiciones++;
            }

            //Ahora declaramos un arreglo de esa cantidad de valores
            int[] posicionesEncontradas = new int[cuentaPosiciones];

            //reiniciamos el contador de posiciones
            cuentaPosiciones = 0;
            // y lo llenamos con las posiciones que tienen ese valor menor
            for (int i = 0; i < arregloValores.Length; i++)
            {
                if (arregloValores[i] == valorMenor)
                {
                    posicionesEncontradas[cuentaPosiciones] = i+1; //contando posiciones como humanos
                    cuentaPosiciones++;
                }
            }
            return posicionesEncontradas;
        }

        /// <summary>
        /// Función para encontrar el menor valor mayor que cero en un arreglo de valores
        /// </summary>
        /// <param name="arregloValores">arreglo con valores numéricos reales</param>
        /// <returns>el menor valor mayor que cero</returns>
        static float ObtieneMenorDistancia(float[] arregloValores)
        {
            float menorValor = 3; //el máximo valor posible que es válido.

            //encontramos la menor distancia mayor que cero y menor que 3
            for (int i = 0; i < arregloValores.Length; i++)            
                if (arregloValores[i] > 0 && arregloValores[i] < menorValor)
                    menorValor = arregloValores[i];
            
            return menorValor;
        }
    }
}
