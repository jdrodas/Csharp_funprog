/*
Programa:       ex02_ColonizacionMarte
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
Pesca recreativa en Antioquia

Como parte de las actividades promocionadas por la Gobernación de Antioquia 
para la recuperación económica post-pandemia, la Secretaría de Desarrollo 
Económico ha decidido fomentar y regular la actividad de pesca recreativa 
en las principales cuencas identificadas para este deporte.

Pensando en llevar un control pertinente de pesca recreativa, se desea 
construir una aplicación que permita registrar para un día específico, 
cuantos kilogramos fueron extraídos de los ríos por cada una de las especies 
autorizadas.

Se define entonces las siguientes especies autorizadas:
 - Sabaleta
 - Carpa
 - Tilapia
 - Cachama
 - Trucha
 - Mojarra

Se define como tope máximo de 200 Kg por especie, con valores que pueden ser 
superiores o inferiores a ese valor.

Se espera que la aplicación pueda generar un reporte indicando para cuales 
especies se realizó una pesca excesiva que pueda poner en riesgo la especie.

Requerimientos:

 - Utilice número reales (float o double) para almacenar el valor de la cantidad 
diaria pescada para cada especie, teniendo presente que podrá tener dígitos 
decimales.

 - Almacene los nombres de las especies en un arreglo tipo string y utilice 
ciclos de control cada vez que requiera referenciarlos para la lectura y 
visualización de  datos de su cantidad pescada.

 - Implemente control de excepciones para garantizar que el usuario no ingrese
al arreglo valores equivocados que no correspondan al tipo de dato requerido. 
Importante: Los datos deben ser digitados, no son generados aleatoriamente.

 - Cree una función que se llame “CalculaPromedioPesca” que reciba el arreglo 
de valores correspondientes a la cantidad pescada y devuelva el valor promedio 
de estos valores.

 - Genere reporte final indicando para cada especie si se superó el tope máximo de pesca
(cantidad>200)
 
- Visualice un mensaje de “Jornada de pesca exitosa” si el promedio de Pesca es igual o inferior al
tope máximo. Si no se cumple esta condición, debe visualizar el mensaje “Pesca excesiva, ¡se
debe ejercer control más estricto!”

*/

using System;

namespace ex02_PescaRecreativa
{
    public class Program
    {
        static void Main(string[] args)
        {

            float topePesca = 200;

            Console.WriteLine("*** Pesca recreativa en Antioquia - Registro de recolección *** \n\n");
            Console.WriteLine($"La meta es {topePesca} kg por especie. El promedio de la jornada debe ser menor o igual al tope.\n");

            // Declaramos arreglo para almacenar los nombres de las especies
            string[] lasEspecies = { "Sabaleta", "Carpa", "Tilapia", "Cachama", "Trucha", "Mojarra" };

            // Declaramos arreglo para almacenar las cantidades recolectadas para los cerros
            float[] lasCantidades = new float[lasEspecies.Length];

            //leemos los datos
            bool esDatoCorrecto = false;
            int posicion = 0;
            while (posicion < lasCantidades.Length)
            {
                while (!esDatoCorrecto)
                {
                    try
                    {
                        Console.Write($"Ingresa la cantidad de pesca para la especie {lasEspecies[posicion]}: ");
                        lasCantidades[posicion] = float.Parse(Console.ReadLine());

                        //Se valida que la cantidad sea mayor igual a cero
                        if (lasCantidades[posicion] >= 0)
                            esDatoCorrecto = true;
                        else
                            Console.WriteLine("La cantidad ingresada no es válida. Debe ser un numero mayor o igual a cero. Intenta nuevamente\n\n");

                    }
                    catch (FormatException elError)
                    {
                        Console.WriteLine("El dato ingresado debe ser numérico positivo. Intenta nuevamente.");
                        Console.WriteLine(elError.Message + "\n\n");
                    }
                }

                esDatoCorrecto = false;
                posicion++;
            }

            //Calculamos el promedio
            float promedioPesca = CalculaPromedioPesca(lasCantidades);

            Console.WriteLine("\n\nResultados obtenidos:\n");

            //Visualizamos los resultados
            for (int i = 0; i < lasEspecies.Length; i++)
            {
                Console.Write($"Para la especie {lasEspecies[i]} se pescó {lasCantidades[i]} kgs - ");
                if (lasCantidades[i] <= topePesca)
                    Console.WriteLine(" No se superó el tope!");
                else
                    Console.WriteLine(" Se superó el tope máximo para la especie!");
            }

            //Visualización de la cantidad promedio de materia recolectada
            Console.Write($"\n\nSe pescó en promedio {promedioPesca.ToString("0.00")} Kgs en la jornada - ");

            if (promedioPesca <= topePesca)
                Console.WriteLine("Jornada de pesca exitosa");
            else
                Console.WriteLine("Pesca excesiva, ¡se\r\ndebe ejercer control más estricto!");

        }

        /// <summary>
        /// Función para calcular el promedio de la cantidad pescada por todas las especies
        /// </summary>
        /// <param name="lasCantidades">Arreglo con la información de las cantidades</param>
        /// <returns>El valor promedio</returns>
        static float CalculaPromedioPesca(float[] lasCantidades)
        {
            float resultado = 0;

            for (int i = 0; i < lasCantidades.Length; i++)
                resultado += lasCantidades[i];

            resultado /= lasCantidades.Length;

            return resultado;
        }
    }
}
