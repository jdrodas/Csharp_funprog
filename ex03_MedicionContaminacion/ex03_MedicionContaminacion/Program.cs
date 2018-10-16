/*
Programa:       ex03_MedicionContaminacion
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com


Propósito:
-------------

Calidad del Aire – Medición de agentes contaminantes

Nuevamente se presenta en la ciudad una situación de contingencia ambiental en donde una
combinación de condiciones atmosféricas desfavorables y un incremento de la contaminación
da como resultado un deterioro en la calidad del aire.

En la incansable labor de identificar fuentes contaminantes y proponer planes de mitigación, las
autoridades han lanzado un ambicioso plan para desplegar microestaciones de monitoreo que
medirán la proporción existente de 4 agentes tóxicos: Dióxido de Carbono (CO2), Monóxido de
Nitrógeno (NO), Metano (CH4) y Dióxido de Azufre (SO2).

Cada una de las estaciones reportará una medición, conformada por los valores de estos cuatro
agentes tóxicos.En dicha Medición, también indicará cual es el agente que tiene el mayor valor
porcentual. 

En caso de que dos o más agentes tengan el valor mayor, se considerará que la medición es crítica
y se reportará la palabra “Varios”.

Para validar este diseño, se realizará un programa en C# donde se realice una simulación de 1000
mediciones, asignando de manera aleatoria los valores para los cuatro agentes contaminantes y
calculando su porcentaje de contribución a la medición.

El programa tendrá una clase “Medicion” que tiene como atributos los valores enteros y los
porcentajes representantes para cada agente. Los valores asignados serán enteros aleatorios entre
1 y 100, mientras que los porcentajes se expresarán con dos dígitos decimales. Cuando los cuatro
valores estén asignados, se calcularán los porcentajes y se obtendrá el mayor contaminante como
el que tiene el porcentaje mayor.Si hay más de un agente con el mismo valor porcentual, el mayor
contaminante reportará “Varios”.

El programa principal tendrá un arreglo de 1000 objetos tipo Medicion, e implementará una función
llamada “CalculaTotales” que recibirá el arreglo de mediciones y obtendrá un arreglo de números
enteros con los totales de mediciones que tienen mayor contaminante uno de los agentes indicados.

 */

using System;

namespace ex03_MedicionContaminacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para simular 1000 mediciones de calidad de aire");
            Console.WriteLine("Se buscarán concentraciones altas de CO2, CH4, NO Y SO2\n");

            Console.Write("Generando el arreglo de mediciones ...");

            Medicion[] lasMediciones = new Medicion[1000];
            Random aleatorio = new Random();

            //inicializamos el arreglo de mediciones con los valores aleatorios entre 1 y 100
            for (int i = 0; i < lasMediciones.Length; i++)
            {
                lasMediciones[i] = new Medicion();
                lasMediciones[i].ValorCH4 = aleatorio.Next(100) + 1;
                lasMediciones[i].ValorCO2 = aleatorio.Next(100) + 1;
                lasMediciones[i].ValorNO = aleatorio.Next(100) + 1;
                lasMediciones[i].ValorSO2 = aleatorio.Next(100) + 1;

                lasMediciones[i].CalculaPorcentajes();
            }

            Console.WriteLine("... terminado!\n");

            Console.WriteLine("Calculando el total de mediciones por mayor Contaminante...\n");

            string[] losContaminantes = { "CH4", "CO2", "NO", "SO2", "Varios" };
            int[] totalesMediciones = CalculaTotales(lasMediciones, losContaminantes);
            int totalizado = 0;

            //recorremos ambos arreglos para visualizar el total
            for (int i = 0; i < losContaminantes.Length; i++)
            {
                Console.WriteLine("Mayor Contaminante {0}: Total estaciones: {1}",
                    losContaminantes[i],
                    totalesMediciones[i]);
                totalizado += totalesMediciones[i];
            }

            Console.WriteLine("Total de estaciones: {0}", totalizado);
        }

        static int[] CalculaTotales(Medicion[] arregloMediciones, string[] arregloNombres)
        {
            int[] totales = new int[arregloNombres.Length];

            //inicializamos los totales
            for (int i = 0; i < totales.Length; i++)
                totales[i] = 0;

            //aqui contabilizamos según el contaminante
            for (int i = 0; i < arregloMediciones.Length; i++)
            {
                //para cada medición verificamos si el contaminante mayor 
                //es el que está en el arreglo de nombres
                for (int j = 0; j < arregloNombres.Length; j++)
                {
                    if (arregloNombres[j] == arregloMediciones[i].MayorContaminante)
                        totales[j]++;
                }
            }

            return totales;

        }
    }
}
