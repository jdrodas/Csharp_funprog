/*
Programa:       TiendaGomitas_v2
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Modificaciones al proyecto TiendaGomitas para hacerlo más organizado
  conservando la misma visualización.

- Demostrar conceptos de clase objeto, encapsulación, atributos, propiedades
- Crear un arreglo de objetos y pasarlo como parámetro a una función.
- Crear un arreglo multidimensional y generar mecanismos para recorrerlo
 */

using System;

namespace TiendaGomitas_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para Simular una tienda de gomitas");
            Console.WriteLine("Con sabores, colores y formas diferentes. Se generarán 1000 gomitas");

            //aqui inicializamos el objeto de la lógica
            Logica logicaTienda = new Logica();

            //Inicializamos la simulación
            logicaTienda.InicializaSimulacion();

            //Aqui visualizamos la información de las gomitas
            Console.WriteLine(logicaTienda.ObtieneInfoDetallePedido());

            Console.WriteLine("\n\nTotales por atributo para las 1000 gomitas:");

            Console.WriteLine("\nTotales por Color:");
            Console.WriteLine(logicaTienda.ObtieneResumenTotales("color"));

            Console.WriteLine("\nTotales por Sabor:");
            Console.WriteLine(logicaTienda.ObtieneResumenTotales("sabor"));

            Console.WriteLine("\nTotales por Forma:");
            Console.WriteLine(logicaTienda.ObtieneResumenTotales("forma"));


            Console.WriteLine("\n\nInformación sobre las combinaciones es \n{0}", 
                logicaTienda.ObtieneMayorMenorFrecuencia());

        }
    }
}
