/*
Programa:       MaquinaExpendedoraComida
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Demostrar conceptos de clase, objeto, encapsulación, propiedades
- Crear un objeto "MaquinaVenta" que contiene un arreglo de "Ubicacion"
- Implementar funciones para inicializar ubicaciones, validar y acceder a ellas
- Implementar algoritmo para abastecer las ubicaciones con productos
- Visualizar cuales de las posiciones tienen productos abastecidos
- Implementar algoritmo para realizar venta de producto.
- Visualizar cuanto vendió y cuantos productos se vendieron

Tarea: Implementar el control de excepciones requerido para cuando se ingresan valores numéricos
      desde consola.

Características de la máquina:

- La maquina tiene 6 filas, 10 columnas para un total de 60 ubicaciones posibles de venta
- La máquina sabe cuanto ha vendido
- La máquina sabe cuantos productos ha vendido.

Caracteristicas de la ubicación:
- Identificacion
- Nombre de producto
- Valor
- Cantidad

*/

namespace MaquinaExpendedoraComida
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Programa para simular la utilización de una máquina expendedora de comida\n\n");
            Console.WriteLine("La máquina expendedora tiene 6 filas y 10 columnas");

            //Paso: Inicializar la maquinita
            MaquinaVenta miMaquinita = new();

            Console.WriteLine($"El valor actual de venta de mi maquina es {miMaquinita.ValorVendido}");

            Console.WriteLine("Comenzando ciclo de abastecimiento: \n\n");
            bool finalizadoAbastecimiento = false;
            string datoIdUbicacion;
            string seguirAbasteciendo;
            int indiceUbicacion;

            while (!finalizadoAbastecimiento)
            {
                Console.Write("Ingresa la identificación de la ubicación (A-F y 0-9, ej: F3): ");
                datoIdUbicacion = Console.ReadLine()!.ToUpper();

                //Si la ubicación es válida
                if (miMaquinita.ValidaUbicacion(datoIdUbicacion))
                {
                    indiceUbicacion = miMaquinita.ObtieneIndiceUbicacion(datoIdUbicacion);

                    Console.Write($"Nombre para el producto ubicado en {datoIdUbicacion}: ");
                    miMaquinita.LasUbicaciones[indiceUbicacion].NombreProducto = Console.ReadLine()!;

                    Console.Write($"Cantidad disponible para el producto ubicado en {datoIdUbicacion}: ");
                    miMaquinita.LasUbicaciones[indiceUbicacion].Cantidad = int.Parse(Console.ReadLine()!);

                    Console.Write($"Precio para el producto ubicado en {datoIdUbicacion}: ");
                    miMaquinita.LasUbicaciones[indiceUbicacion].Valor = int.Parse(Console.ReadLine()!);
                }
                else
                    Console.WriteLine("\nLa ubicación no es válida. Intenta nuevamente. \n\n");

                Console.Write("\n¿Desea abastecer otra ubicación (S/N)? ");
                seguirAbasteciendo = Console.ReadLine()!.ToUpper();

                if (seguirAbasteciendo == "N")
                    finalizadoAbastecimiento = true;
            }

            Console.WriteLine("\n\nAbastecimiento terminado. Estas son las posiciones que tienen productos:\n");
            VisualizaUbicacionesAbastecidas(miMaquinita);

            //Paso 2: comenzar la venta
            Console.WriteLine("Comenzando ciclo de venta: \n\n");

            bool finalizadaVenta = false;
            string seguirComprando;

            while (!finalizadaVenta)
            {
                Console.Write("Ingresa la identificación de la ubicación para la compra: (A-F y 0-9): ");
                datoIdUbicacion = Console.ReadLine()!.ToUpper();

                if (miMaquinita.ValidaUbicacion(datoIdUbicacion))
                {
                    //Buscamos el indice
                    indiceUbicacion = miMaquinita.ObtieneIndiceUbicacion(datoIdUbicacion);

                    //Validamos que el indice tenga producto para vender
                    if (miMaquinita.LasUbicaciones[indiceUbicacion].Cantidad > 0)
                    {
                        miMaquinita.RealizarVenta(datoIdUbicacion);
                        Console.WriteLine($"Has comprado {miMaquinita.LasUbicaciones[indiceUbicacion].NombreProducto} \n");
                    }
                    else
                        Console.WriteLine($"\nNo hay producto disponible en la ubicación {datoIdUbicacion}. Intenta nuevamente. \n\n");
                }
                else
                    Console.WriteLine("\nLa ubicación no es válida. Intenta nuevamente. \n\n");


                Console.Write("\n¿Desea seguir comprando en otra ubicación (S/N)? ");
                seguirComprando = Console.ReadLine()!.ToUpper();

                if (seguirComprando == "N")
                    finalizadaVenta = true;
            }


            Console.WriteLine($"\n\nVenta finalizada. Se recaudó: {miMaquinita.ValorVendido} en {miMaquinita.CantidadVentas} productos vendidos\n");

        }

        /// <summary>
        /// Visualiza cuales de las ubicaciones de la Maquina tiene productos disponibles para la venta
        /// </summary>
        /// <param name="laMaquinita">La máquina a revisar</param>
        static void VisualizaUbicacionesAbastecidas(MaquinaVenta laMaquinita)
        {
            int totalUbicacionesAbastecidas = 0;
            for (int i = 0; i < laMaquinita.LasUbicaciones.Length; i++)
            {
                if (laMaquinita.LasUbicaciones[i].Cantidad != 0)
                {
                    Console.WriteLine($"Id: {laMaquinita.LasUbicaciones[i].Identificacion}, " +
                    $"Nombre Producto: {laMaquinita.LasUbicaciones[i].NombreProducto}, " +
                    $"Cantidad disponible: {laMaquinita.LasUbicaciones[i].Cantidad}, " +
                    $"Valor Unitario: {laMaquinita.LasUbicaciones[i].Valor} ");

                    totalUbicacionesAbastecidas++;
                }
            }

            Console.WriteLine($"\nSe encontraron {totalUbicacionesAbastecidas} ubicaciones con productos");
        }
    }
}