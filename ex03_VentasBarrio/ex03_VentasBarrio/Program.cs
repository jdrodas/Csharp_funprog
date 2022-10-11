/*
Programa:       ex03_VentasBarrio
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Formulación
-----------

Ventas de Barrio

La empresa de galletas Panda’s Cookie Factory ha comenzado una nueva campaña para posicionar su
nuevo producto dentro de las tiendas de barrio de la ciudad.

Para implementar esta estrategia, ha seleccionado a 5 tiendas ubicados en diferentes barrios con el
propósito de llevar control de los pedidos de galletas y así identificar si el producto se puede masificar en
otras ciudades del país.

Teniendo esto presente, se decide hacer una aplicación que se encarga de registrar los pedidos,
identificando cual es el barrio y la cantidad de galletas que se solicitan a la fábrica. Un pedido puede tener
como mínimo 10 galletas y máximo 100 galletas.

La valoración del mejor tendero se obtiene como aquel que tenga el mejor promedio de galletas por
pedido. Durante el tiempo de la estrategia de venta, una tienda podrá pedir varios pedidos o simplemente
no participar.

Requerimientos:

- Implemente una clase “Pedido” que tiene como atributo el nombre del barrio y la cantidad de
galletas del pedido. Realice la implementación del constructor de la clase donde se inicializa los
atributos, así como las respectivas propiedades para obtener y establecer los valores de cada
atributo. La cantidad de galletas es un valor entero.

- En la función principal de la clase “Program”, implemente la funcionalidad que permita leer el
nombre de los 5 barrios que se utilizarán en el programa debe controlar que no se ingresen valores
nulos como nombre del barrio.

- En la función principal de la clase “Program”, implemente un arreglo de 100 pedidos, que
inicializará aleatoriamente cada elemento con un nombre de barrio y una cantidad de galletas.
No es necesario visualizar el detalle de cada pedido una vez se encuentren inicializados.

- En la clase “Program”, implemente una función llamada TotalizaPedidosBarrio que se encarga de
saber para cada uno de los 5 barrios, cuantos pedidos se hicieron.

- En la clase “Program”, implemente una función llamada TotalizaGalletasBarrio que se encarga de
saber para cada uno de los 5 barrios, cuantas galletas se solicitaron en todos los pedidos
registrados para esa tienda.

- En la función principal de la clase “Program”, realice el cálculo del promedio de galletas por
pedido de cada una de las tiendas, utilizando como insumos los resultados de las funciones
anteriormente solicitadas.

- Como informe final, visualice para cada tienda, su nombre, el total de pedidos, el total de galletas
y el promedio obtenido.Formulación: 

*/

using System;

namespace ex03_VentasBarrio
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para identificar Barrio con mejor tendero");

            //Aqui inicializamos el nombre de los barrios
            string[] nombresBarrios = new string[5];

            //Aqui leemos los nombres de los barrios
            int contadorBarrio = 0;
            while (contadorBarrio < nombresBarrios.Length)
            {
                Console.Write($"\nIngresa el nombre del barrio No. {contadorBarrio + 1}: ");
                nombresBarrios[contadorBarrio] = Console.ReadLine();

                //La longitud del nombre ingresado debe ser mayor que cero
                if (nombresBarrios[contadorBarrio].Length > 0)
                    contadorBarrio++;
                else
                    Console.WriteLine("No se ha ingresado un valor de barrio correcto. Intenta nuevamente!");
            }

            //Aqui inicializamos el arreglo de pedidos
            Pedido[] losPedidos = new Pedido[100];
            Random aleatorio = new Random();

            for (int i = 0; i < losPedidos.Length; i++)
            { 
                losPedidos[i] = new Pedido();
                losPedidos[i].Barrio = nombresBarrios[aleatorio.Next(nombresBarrios.Length)];
                losPedidos[i].CantidadGalletas = aleatorio.Next(10, 101);
            }

            //Aqui calculamos el total de galletas por cada barrio
            int[] totalGalletasBarrio = TotalizaGalletasBarrio(losPedidos, nombresBarrios);

            //Aqui calculamos el total de pedidos realizados por cada barrio
            int[] totalPedidosBarrio = TotalizaPedidosBarrio(losPedidos, nombresBarrios);

            //Aqui calculamos el promedio de galletas por pedido para cada barrio
            float[] PromediosBarrios = new float[nombresBarrios.Length];

            for (int i = 0; i < nombresBarrios.Length; i++)
                PromediosBarrios[i] = (float)totalGalletasBarrio[i] / totalPedidosBarrio[i];

            //Visualizamos los resultados
            Console.WriteLine("\n\nResultados obtenidos por tienda:");

            for (int i = 0; i < nombresBarrios.Length; i++)
            {
                Console.WriteLine($"\nBarrio: {nombresBarrios[i]}, Total Galletas: {totalGalletasBarrio[i]}\n" +
                    $"Total Pedidos: {totalPedidosBarrio[i]}, Promedio: {PromediosBarrios[i]} galletas/pedido");
            }

            //Aqui identificamos el tendero con mejor promedio
            float promedioMejorBarrio = 0;
            string nombreMejorBarrio = "";

            IdentificaMejorPromedioBarrio(PromediosBarrios,
                                            nombresBarrios,
                                            out promedioMejorBarrio,
                                            out nombreMejorBarrio);

            //Visualizamos el resultado del mejor promedio
            Console.WriteLine($"\nSe ha identificado que el mejor promedio fue del " +
                $"barrio {nombreMejorBarrio} con promedio de {promedioMejorBarrio.ToString("0.00")}");
        }

        /// <summary>
        /// Identifica quien fue el tendero que tuvo mejor promedio
        /// </summary>
        /// <param name="arregloPromedios">Arreglo con promedios</param>
        /// <param name="arregloBarrios">Arreglo con los nombres de los barrios</param>
        /// <param name="mejorPromedio">Mejor promedio identificado</param>
        /// <param name="nombreMejorBarrio">Nombre del Barrio con mejor promedio</param>
        static void IdentificaMejorPromedioBarrio(float[] arregloPromedios,
                                                  string[] arregloBarrios,
                                                  out float mejorPromedio,
                                                  out string nombreMejorBarrio)
        {
            mejorPromedio = 0;
            nombreMejorBarrio = "";

            //Arbitrariamente decidimos que el mejor promedio es la posición 0 del arreglo
            mejorPromedio = arregloPromedios[0];
            nombreMejorBarrio = arregloBarrios[0];

            //Aqui corroboramos o cambiamos esa decisión
            for (int i = 1; i < arregloPromedios.Length; i++)
            {
                //Si el siguiente promedio es mayor que el actual, hay nuevo mejor promedio
                if (arregloPromedios[i] > mejorPromedio)
                {
                    mejorPromedio = arregloPromedios[i];
                    nombreMejorBarrio = arregloBarrios[i];
                }
            }
        }

        /// <summary>
        /// Calcula la cantidad de pedidos por barrio
        /// </summary>
        /// <param name="arregloPedidos">Los pedidos realizados por los barrios</param>
        /// <param name="arregloBarrios">Los nombres de los barrios</param>
        /// <returns>El total de pedidos por barrio</returns>
        static int[] TotalizaPedidosBarrio(Pedido[] arregloPedidos, string[] arregloBarrios)
        {
            int[] totalPedidosBarrio = new int[arregloBarrios.Length];

            //Inicializamos el totalizador
            for (int i = 0; i < totalPedidosBarrio.Length; i++)
                totalPedidosBarrio[i] = 0;

            //Recorremos los pedidos y totalizamos las galletas por cada barrio
            for (int j = 0; j < arregloPedidos.Length; j++)
            {
                for (int k = 0; k < arregloBarrios.Length; k++)
                {
                    if (arregloPedidos[j].Barrio == arregloBarrios[k])
                        totalPedidosBarrio[k]++;
                }
            }

            return totalPedidosBarrio;
        }

        /// <summary>
        /// Calcula la cantidad de galletas por barrio que se hicieron en todos los pedidos
        /// </summary>
        /// <param name="arregloPedidos">Los pedidos realizados por los barrios</param>
        /// <param name="arregloBarrios">Los nombres de los barrios</param>
        /// <returns>El total de galletas por barrio</returns>
        static int[] TotalizaGalletasBarrio(Pedido[] arregloPedidos, string[] arregloBarrios)
        {
            int[] totalGalletasBarrio = new int[arregloBarrios.Length];

            //Inicializamos el totalizador
            for (int i = 0; i < totalGalletasBarrio.Length; i++)
                totalGalletasBarrio[i] = 0;

            //Recorremos los pedidos y totalizamos las galletas por cada barrio
            for (int j = 0; j < arregloPedidos.Length; j++)
            {
                for (int k = 0; k < arregloBarrios.Length; k++)
                {
                    if (arregloPedidos[j].Barrio == arregloBarrios[k])
                        totalGalletasBarrio[k]+= arregloPedidos[j].CantidadGalletas;
                }
            }

            return totalGalletasBarrio;
        }
    }
}
