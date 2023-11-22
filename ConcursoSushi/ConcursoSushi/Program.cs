using System;

namespace ConcursoSushi
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Programa para simular la producción de Rollos de Sushi");

            string[] lasSalsas = [ "Anguila", "Soya", "Mayo-sriracha" ];
            string[] losAcabados = [ "Tempura", "Normal", "Acevichado" ];

            //Aqui ingresamos las proteinas y los toppings
            string[] lasProteinas = new string[4];
            string[] losToppings = new string[3];

            Console.WriteLine("\nDefinición de proteinas:");

            int contadorProteinas = 0;
            while (contadorProteinas < lasProteinas.Length)
            {
                Console.Write($"\nIngresa el valor para la proteina No. {contadorProteinas + 1}: ");
                lasProteinas[contadorProteinas] = Console.ReadLine()!;

                if (lasProteinas[contadorProteinas].Length == 0)
                    Console.WriteLine("No ingresaste una proteína válida. Intenta nuevamente!");
                else
                    contadorProteinas++;
            }

            Console.WriteLine("\nDefinición de Toppings:");
            int contadorToppings = 0;
            do
            {
                Console.Write($"\nIngresa el valor para el topping No. {contadorToppings + 1}: ");
                losToppings[contadorToppings] = Console.ReadLine()!;

                if (losToppings[contadorToppings].Length == 0)
                    Console.WriteLine("No ingresaste un topping válido. Intenta nuevamente!");
                else
                    contadorToppings++;

            }
            while (contadorToppings < losToppings.Length);

            //Visualizamos el contenido de los arreglos que contienen
            //los valores de los atributos
            Console.WriteLine("\n\n*** Visualización de valores de atributos ***");
            Console.WriteLine("\nLas salsas");
            foreach (string unaSalsa in lasSalsas)
                Console.WriteLine($"- {unaSalsa}");

            Console.WriteLine("\nLos acabados");
            foreach (string unAcabado in losAcabados)
                Console.WriteLine($"- {unAcabado}");

            Console.WriteLine("\nLas proteinas");
            foreach (string unaProteina in lasProteinas)
                Console.WriteLine($"- {unaProteina}");

            Console.WriteLine("\nLos toppings");
            foreach (string unTopping in losToppings)
                Console.WriteLine($"- {unTopping}");

            //Siguiemte, declaramos e inicializamos el arreglo de pedidos de rollos
            PedidoRollo[] losPedidos = new PedidoRollo[100];
            Random aleatorio = new();
            int cantidadRestaurantes = 10;

            for (int i = 0; i < losPedidos.Length; i++)
            {
                losPedidos[i] = new PedidoRollo
                {
                    Restaurante = aleatorio.Next(1, cantidadRestaurantes + 1), //Código del restaurante
                    Proteina = lasProteinas[aleatorio.Next(lasProteinas.Length)],
                    Acabado = losAcabados[aleatorio.Next(losAcabados.Length)],
                    Salsa = lasSalsas[aleatorio.Next(lasSalsas.Length)],
                    Topping = losToppings[aleatorio.Next(losToppings.Length)]
                };
            }

            //Aqui visualizamos como quedaron los pedidos luego de la inicialización
            Console.WriteLine("\nResultado de la inicialización:\n");
            for (int i = 0; i < losPedidos.Length; i++)
            {
                Console.WriteLine($"\nPedido No. {i + 1}: \n " +
                    $"{losPedidos[i].ObtieneInformacion()}");
            }

            //Aqui totalizamos pedidos por restaurante
            int[] totalPedidosRestaurantes = CalculaTotalPedidosRestaurante(losPedidos, cantidadRestaurantes);

            Console.WriteLine("\n\nTotal de pedidos por restaurante:");
            for (int i = 0; i < totalPedidosRestaurantes.Length; i++)
            {
                Console.WriteLine($"Restaurante No. {i + 1}, " +
                    $"totalPedidos: {totalPedidosRestaurantes[i]}");
            }

            //Aqui totalizmos pedidos por proteina
            int[] totalPedidosProteina = CalculaTotalPedidosProteina(losPedidos, lasProteinas);

            Console.WriteLine("\n\nTotal de pedidos por proteina:");
            for (int i = 0; i < lasProteinas.Length; i++)
            {
                Console.WriteLine($"proteina: {lasProteinas[i]}, " +
                    $"totalPedidos: {totalPedidosProteina[i]}");
            }
        }

        /// <summary>
        /// Calcula el total de pedidos por tipo de proteina
        /// </summary>
        /// <param name="arregloPedidos">Los pedidos realizados en el concurso</param>
        /// <param name="arregloProteinas">Las proteinas que conforman cada pedido</param>
        /// <returns>la cantidad de pedidos por proteina</returns>
        static int[] CalculaTotalPedidosProteina(PedidoRollo[] arregloPedidos, string[] arregloProteinas)
        {
            int[] totalPedidos = new int[arregloProteinas.Length];

            //Inicializar el arreglo
            for (int i = 0; i < totalPedidos.Length; i++)
                totalPedidos[i] = 0;

            for (int j = 0; j < arregloPedidos.Length; j++)
            {
                for (int k = 0; k < arregloProteinas.Length; k++)
                {
                    if (arregloPedidos[j].Proteina == arregloProteinas[k])
                        totalPedidos[k]++;
                }
            }

            return totalPedidos;

        }

        /// <summary>
        /// Calcula el total de pedidos que atendió cada restaurante
        /// </summary>
        /// <param name="arregloPedidos">El arreglo con los pedidos realizados</param>
        /// <param name="cantidadRestaurantes">La cantidad de restaurantes que participan</param>
        /// <returns>arreglo con los valores totales de pedidos por restaurante</returns>
        static int[] CalculaTotalPedidosRestaurante(PedidoRollo[] arregloPedidos, int cantidadRestaurantes)
        {
            int[] totalPedidos = new int[cantidadRestaurantes];

            //Inicializar el arreglo
            for (int i = 0; i < totalPedidos.Length; i++)
                totalPedidos[i] = 0;

            //Cada pedido tiene un código de restaurante
            //que corresponde a la posición del arreglo de los totales
            //se una "-1" porque los códigos comienzan en 1
            //mientras que las posiciones del arreglo comienzan en 0
            for (int i = 0; i < arregloPedidos.Length; i++)
                totalPedidos[arregloPedidos[i].Restaurante - 1]++;

            return totalPedidos;
        }
    }
}
