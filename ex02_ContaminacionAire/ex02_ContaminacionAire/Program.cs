/*
Programa:       ex02_ContaminacionAire
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com


Formulación: 
------------

Contaminación del Aire – Días peligrosos

Nuevamente llega a nuestra ciudad la situación climática conocida como “Contingencia Ambiental” donde la contaminación 
del aire se concentra en condiciones elevadas causando días en los que es peligroso estar fuera de nuestros hogares.

Para evaluar esta situación se ha definido el ICA, Índice de Calidad del Aire, el cual toma los siguientes valores 
para nuestra ciudad:

Rango Valores	Color Alerta	Clasificación
0 – 50	        Verde	        Buena
51-100	        Amarilla	    Moderada
101-150	        Naranja	        Dañina Grupos Sensibles
151-200	        Roja	        Dañina Salud
201-300	        Púrpura	        Muy Peligrosa

Para validar el funcionamiento de las estaciones de monitoreo, se ha decidido implementar un mecanismo de simulación 
en el que se valorarán 60 mediciones correspondientes a valores aleatorios entre 0 y 300.

El mecanismo busca realizar las siguientes acciones:
•	indicar para cada tipo de alerta, cuantos días tuvieron valores del ICA en el rango asociado. 
•	Indicar cuando se presenta una ALERTA AMBIENTAL, es decir, cuando más de 5 días consecutivos tienen ICA con valores superiores a 100.

Requerimiento:

Realice un programa en C# - Aplicación de Consola, en la que se haga lo siguiente:
•	Genere un arreglo de 60 posiciones que contiene valores aleatorios enteros entre 0 y 300 inclusive.
•	Implemente una función VisualizaMediciones que recibe el arreglo de mediciones como parámetro y visualiza en consola los valores tabulados, 10 valores por línea.
•	Implemente una función TotalizaMediciones que recibe el arreglo de mediciones y devuelve un arreglo de enteros que contiene los totales de valores por cada rango.
•	Implemente una función EvaluaAlerta que recibe el arreglo de mediciones y devuelve un valor booleano que indica si hay o no alerta ambiental según la definición presentada previamente.


El programa deberá visualizar:
•	Las 60 mediciones generadas, presentadas de manera tabulada con 10 valores por línea. El resultado de la función VisualizaMediciones.
•	Para cada rango de valores, cuantas mediciones se tuvieron. El resultado de la función TotalizaMediciones.
•	Si hay o no alerta ambiental. El resultado de la función EvaluaAlerta.

*/

using System;


namespace ex02_ContaminacionAire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para simular la evaluación de la contaminación del aire\n");

            Console.WriteLine("Se generan 60 mediciones aleatorias entre 0 y 300... \n\n");

            Random aleatorio = new Random();
            int[] mediciones = new int[60];

            //aqui inicializamos el arreglo con los valores aleatorios
            for (int i = 0; i < mediciones.Length; i++)
                mediciones[i] = aleatorio.Next(0, 301);

            //Aqui invocamos la función que visualiza los valores de las mediciones de manera tabulada
            VisualizaMediciones(mediciones);

            //aqui visualizamos los totales por rango
            Console.WriteLine("\nLos totales de días por rango son:\n");

            string[] nombreAlertas = {
                "0 – 50: Verde",
                "51 - 100: Amarilla",
                "101 - 150: Naranja",
                "151 - 200: Roja",
                "201 - 300: Púrpura"
            };

            int[] totalesRango = TotalizaMediciones(mediciones);

            Console.WriteLine("Total\t Nombre Alerta");
            Console.WriteLine("-----\t -------------");

            for (int i = 0; i < nombreAlertas.Length; i++)
            {
                Console.WriteLine("{0}\t {1}",
                    totalesRango[i],
                    nombreAlertas[i]);
            }

            //Aqui identificamos si hubo alerta ambiental
            bool huboAlerta = EvaluaAlerta(mediciones);

            if (huboAlerta)
                Console.WriteLine("\nSe presentó alerta ambiental! Hubo más de 5 días consecutivos con mediciones dañinas!");
            else
                Console.WriteLine("\nNo se presentó alerta ambiental!");
        }

        /// <summary>
        /// Evalua si se presentaron más de 5 días con mediciones dañinas
        /// </summary>
        /// <param name="arregloMediciones">Arreglo con las mediciones</param>
        /// <returns>Valor booleano si hubo o no alerta</returns>
        static bool EvaluaAlerta(int[] arregloMediciones)
        {

            int diasAlerta = 0;
            bool existeAlerta = false;

            //Se recorre el arreglo preguntando por cada valor
            for (int i = 0; i < arregloMediciones.Length; i++)
            {
                if (arregloMediciones[i] > 100)
                {
                    diasAlerta++;

                    //Si hay más de 5 días valor superior a 100, existe alerta
                    if (diasAlerta > 5)
                    { 
                        existeAlerta = true;
                        break; // Si se presenta alerta, no se necesita seguir evaluando
                    }
                }
                else
                    //si el valor siguiente no es superior a 100, se reinicia el contador
                    diasAlerta = 0;
            }

            //si se presentó alerta, se devuelve el resultado en verdadero

            return existeAlerta;
        }

        /// <summary>
        /// Totaliza el número de días por rango de valores del ICA
        /// </summary>
        /// <param name="arregloMediciones">Arreglo con las mediciones</param>
        /// <returns>arreglo con los totales por rango</returns>
        static int[] TotalizaMediciones(int[] arregloMediciones)
        {
            int[] resultado = new int[5];

            //inicializamos cada posición del arreglo de resultado con valor 0
            for (int i = 0; i < resultado.Length; i++)
                resultado[i] = 0;

            //luego recorremos el arreglo de mediciones para totalizar valores por rango
            for (int i = 0; i < arregloMediciones.Length; i++)
            {
                //Si el valor está en el primer rango - Verde
                if (arregloMediciones[i] <= 50)
                    resultado[0]++;

                //Si el valor está en el segundo rango - Amarillo
                if (arregloMediciones[i] >= 51 && arregloMediciones[i] <= 100)
                    resultado[1]++;

                //Si el valor está en el tercer rango - Naranja
                if (arregloMediciones[i] >= 101 && arregloMediciones[i] <= 150)
                    resultado[2]++;

                //Si el valor está en el cuarto rango - Rojo
                if (arregloMediciones[i] >= 151 && arregloMediciones[i] <= 200)
                    resultado[3]++;

                //Si el valor está en el quinto rango - Púrpura
                if (arregloMediciones[i] >= 201 && arregloMediciones[i] <= 300)
                    resultado[4]++;
            }

            return resultado;
        }


        /// <summary>
        /// Visualiza el contenido del arreglo de mediciones de manera tabulada, 10 valores por línea
        /// </summary>
        /// <param name="arreglo"></param>
        static void VisualizaMediciones(int[] arregloMediciones)
        {
            for (int i = 0; i < arregloMediciones.Length; i++)
            {
                Console.Write(arregloMediciones[i] + "\t");
                if ((i + 1) % 10 == 0)
                    Console.WriteLine();
            }
        }
    }
}
