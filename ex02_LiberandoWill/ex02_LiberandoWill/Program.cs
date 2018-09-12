/*
Programa:       ex02_LiberandoWill
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Formulación: 
------------

Strangers Things: ¡Liberando a Will… otra vez!

Se acerca nuevamente Halloween y lo que se pensaba sería una alegre celebración rápidamente se
convierte en tragedia. Will comienza a tener visiones aterradoras sobre el “upside down” y es
poseído por el Mind Flayer, vinculándolo mentalmente con las enredaderas que están destruyendo
el pueblo de Hawkins.

En un intento por rescatar a Will de su trágico destino, sus amigos cercanos emprenden la búsqueda
de artefactos con poder místico que puedan ayudar destruir el monstruo de sombras que amenaza
con devastar la comunidad. En un texto antiguo se encuentra un fragmento en el que se indica que,
si logra acumular 1200 puntos de poder místico, Will podría quedar liberado de su tormento.

Rápidamente, Mike, Lucas, Dustin, Eleven y Max, emprenden la búsqueda de los artefactos,
comprometiéndose a conseguir cada uno tres artefactos. Los artefactos tienen un poder místico que
va desde 1 a 100 puntos, por lo que la meta es que cada uno de los amigos consiga artefactos que
totalicen como mínimo 250 puntos.

Bob Newby, el novio nerd de la mamá de Will, se compromete a construir un programa en C# para
llevar control de los puntos de poder místico de los artefactos recolectados por los chicos del AV
Club. Para cada artefacto se registrará sus puntos en el rango de 1 a 100, identificando quién lo
proporcionó.

El programa al final indicará cuantos puntos de Poder Místico fueron aportados por cada uno de los
chicos, que porcentaje representa del total recolectado y si cumplieron la meta del valor mínimo de
250 puntos.

El programa al final indicará si se logró la meta de 1200 puntos para liberar a Will, o si
definitivamente el pueblo de Hawkins está condenado a su destrucción.

El programa del Bob debe evidenciar la utilización de condicionales, ciclos de control, arreglos,
funciones y control de excepciones.

¡Ánimo Bob!

Recomendaciones para la implementación
======================================

- Utilice un arreglo de valores tipo int para almacenar en cada posición el total de puntos
místicos recolectados por cada chico.

- Utilice un arreglo de valores tipo float para almacenar en cada posición el porcentaje del
total puntos obtenido por cada chico.

- Cree una función denominada "CalculaPorcentajes" que reciba como parámetro el arreglo de
valores tipo int con los puntos de cada chico y devuelva un arreglo de valores float con el
porcentaje del total de puntos obtenido por cada chico. El porcentaje se calcula como el
valor obtenido por cada chico dividido por el total obtenido por todos los chicos.

- Cree una función denominada "CumpleMeta" que reciba como parámetro un valor tipo int
de puntos místicos obtenido por un chico y devuelva como resultado un valor tipo string
con la frase “Cumple la meta de 250” si el valor es igual o superior a 250 o “No cumple la
meta de 250” si es el caso contrario.

- Recuerde que se solicitará ingreso de un valor numérico que será leído con un
console.readline(). Se debe implementar un control de excepciones en caso de que el
usuario ingrese un valor que no se pueda convertir a número.

*/

using System;


namespace ex02_LiberandoWill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strangers Things: ¡Liberando a Will… otra vez!");
            Console.WriteLine("Programa para registrar los puntos místicos de los artefactos");
            Console.WriteLine("recolectados por Mike, Lucas, Dustin, Eleven y Max");
            Console.WriteLine("3 artefactos por chico, poder místico va desde 1 a 100 puntos");
            Console.WriteLine("Meta individual: 250 puntos, meta grupal 1200 puntos.\n");


            string[] chicos = { "Mike", "Lucas", "Dustin", "Eleven", "Max" };
            int[] totalPuntajesChicos = new int[chicos.Length];

            int totalArtefactos, poderArtefacto, metaLograda=0;

            //Aqui recolectamos la información solicitada del poder mistico de los artefactos
            for (int i = 0; i < chicos.Length; i++)
            {
                Console.WriteLine("\nArtefactos recolectados por {0}", chicos[i]);

                totalPuntajesChicos[i] = 0; //Inicializamos el total de la suma de cada puntaje
                totalArtefactos = 0;

                //Tres artefactos por chico
                while (totalArtefactos < 3)
                {
                    try
                    {
                        Console.Write("Ingrese el poder mistico del artefacto #{0}: ", totalArtefactos + 1);
                        poderArtefacto = int.Parse(Console.ReadLine());

                        //Validamos si el valor ingresado está en el rango
                        if (poderArtefacto >= 1 && poderArtefacto <= 100)
                        {
                            totalPuntajesChicos[i] += poderArtefacto;
                            totalArtefactos++;
                        }
                        else
                            Console.WriteLine("El puntaje del poder místico no está en el rango [1;100]. Intenta nuevamente! \n");
                    }
                    catch (FormatException error)
                    {
                        Console.WriteLine("Ingresaste un dato no numérico. Intenta nuevamente!");
                        Console.WriteLine("Error: " + error.Message + "\n");
                    }
                }

                //Aqui comenzamos a totalizar la meta alcanzada
                metaLograda += totalPuntajesChicos[i];
            }

            //Aqui calculamos los porcentajes logrados por los chicos
            float[] porcentajesChicos = CalculaPorcentajes(totalPuntajesChicos);

            //Aqui visualizamos los resultados individuales
            Console.WriteLine("\nResultados alcanzados por cada chico:\n");

            for (int i = 0; i < chicos.Length; i++)
            {
                Console.WriteLine("Para {0}, total recolectado: {1}, porcentaje: {2}% - {3}",
                    chicos[i],
                    totalPuntajesChicos[i],
                    porcentajesChicos[i].ToString("00.00"),
                    CumpleMeta(totalPuntajesChicos[i]));
            }

            //Finalmente visualizamos los resultados por el equipo
            Console.WriteLine("\nLa meta lograda fue de {0}", metaLograda);
            if(metaLograda>=1200)
                Console.WriteLine("Se logró la meta de 1200 puntos para liberar a Will");
            else
                Console.WriteLine("No se logró la meta de 1200 puntos, el pueblo de Hawkins está condenado a su destrucción!");

        }

        static float[] CalculaPorcentajes(int[] arregloValores)
        {
            float[] porcentajes = new float[arregloValores.Length];
            int total = 0;

            //Aqui sacamos el valor total logrado por todos los chicos
            for (int i = 0; i < arregloValores.Length; i++)
                total += arregloValores[i];

            //Aqui calculamos el porcentaje individual alcanzado
            for (int i = 0; i < porcentajes.Length; i++)
                porcentajes[i] = ((float)arregloValores[i] / total)*100;

            return porcentajes;
        }

        /// <summary>
        /// Función que evalua si el valor supera la meta de 250 puntos
        /// </summary>
        /// <param name="valor">total de puntos recolectado por cada chico</param>
        /// <returns>string con la frase que evalua el resultado contra la meta </returns>
        static string CumpleMeta(int valor)
        {
            string resultado = "";

            if (valor >= 250)
                resultado = "Cumple la meta de 250";
            else
                resultado = "No cumple la meta de 250";

            return resultado;
        }
    }
}
