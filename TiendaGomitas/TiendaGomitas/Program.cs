/*
Programa:       TiendaGomitas
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Demostrar conceptos de clase objeto, encapsulación, atributos, propiedades
- Crear un arreglo de objetos y pasarlo como parámetro a una función.
- Crear un arreglo multidimensional y generar mecanismos para recorrerlo
*/

namespace TiendaGomitas
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Programa para Simular una tienda de gomitas");
            Console.WriteLine("Con sabores, colores y formas diferentes. Se generarán 1000 gomitas");

            string[] colores = ["Salmón", "Esmeralda", "Zafiro", "Mostaza", "Magenta"];
            string[] sabores = ["Chontaduro", "Mamoncillo", "Arracacha"];
            string[] formas = ["Piramide", "Dragón", "Cóndor"];

            //Aqui declaramos un arreglo de 1000
            Gomita[] pedidoGomitas = new Gomita[1000];

            Random aleatorio = new();

            //Aqui inicializamos el arreglo de gomitas y asignamos valores aleatorios de sabor y color
            for (int i = 0; i < pedidoGomitas.Length; i++)
            {
                // inicializamos cada elemento del arreglo
                pedidoGomitas[i] = new()
                {
                    Color = colores[aleatorio.Next(colores.Length)],
                    Sabor = sabores[aleatorio.Next(sabores.Length)],
                    Forma = formas[aleatorio.Next(formas.Length)]
                };

                //Aqui visualizamos con cual combinación resultó la gomita
                Console.WriteLine("La gomita No.{0} tiene el sabor {1}, el color {2} y la forma {3}",
                    i + 1,
                    pedidoGomitas[i].Sabor,
                    pedidoGomitas[i].Color,
                    pedidoGomitas[i].Forma);
            }

            Console.WriteLine("\n\nTotales por atributo para las 1000 gomitas:");

            int[] totalSabores = TotalizaSaboresGomitas(pedidoGomitas, sabores);
            int[] totalColores = TotalizaColoresGomitas(pedidoGomitas, colores);
            int[] totalFormas = TotalizaFormasGomitas(pedidoGomitas, formas);

            Console.WriteLine("\nTotales por Color:");

            for (int i = 0; i < colores.Length; i++)
            {
                Console.WriteLine("Color {0}, total gomitas: {1}",
                    colores[i],
                    totalColores[i]);
            }

            Console.WriteLine("\nTotales por Forma:");

            for (int i = 0; i < formas.Length; i++)
            {
                Console.WriteLine("Forma {0}, total gomitas: {1}",
                    formas[i],
                    totalFormas[i]);
            }

            Console.WriteLine("\nTotales por Sabor:");

            for (int i = 0; i < sabores.Length; i++)
            {
                Console.WriteLine("Sabor {0}, total gomitas: {1}",
                    sabores[i],
                    totalSabores[i]);
            }

            //aqui obtenemos la combinación de moda
            string infoGomitaMasMenos = ObtieneInfoGomitas(pedidoGomitas, colores, sabores, formas);

            Console.WriteLine("\n\nInformación sobre las combinaciones es \n{0}", infoGomitaMasMenos);

        }

        /// <summary>
        /// Función que identifica cual es la combinación que más y menos sale en el pedido de gomitas
        /// </summary>
        /// <param name="arregloGomitas">El arreglo de gomitas</param>
        /// <param name="arregloColores">El arreglo de colores</param>
        /// <param name="arregloSabores">El arreglo de sabores</param>
        /// <param name="arregloFormas">El arreglo de formas</param>
        /// <returns>cadena de caracteres con la información</returns>
        static string ObtieneInfoGomitas(Gomita[] arregloGomitas, string[] arregloColores, string[] arregloSabores, string[] arregloFormas)
        {
            string resultado;

            //aqui se calcula cual es la combinación de moda...
            // i: colores
            // j: sabores
            // k: formas
            int[,,] totalizador = new int[arregloColores.Length,
                                          arregloSabores.Length,
                                          arregloFormas.Length];

            //Inicializamos el arreglo de totales
            for (int i = 0; i < totalizador.GetLength(0); i++)
                for (int j = 0; j < totalizador.GetLength(1); j++)
                    for (int k = 0; k < totalizador.GetLength(2); k++)
                        totalizador[i, j, k] = 0;

            //aqui recorremos el arreglo de gomitas contando las combinaciones de los atributos
            for (int contador = 0; contador < arregloGomitas.Length; contador++)
                for (int i = 0; i < totalizador.GetLength(0); i++)
                    for (int j = 0; j < totalizador.GetLength(1); j++)
                        for (int k = 0; k < totalizador.GetLength(2); k++)
                            if (arregloGomitas[contador].Color == arregloColores[i] &&
                                arregloGomitas[contador].Sabor == arregloSabores[j] &&
                                arregloGomitas[contador].Forma == arregloFormas[k])
                                totalizador[i, j, k]++;

            //ahora vamos a identificar cual es la primera combinación que tiene la mayor cantidad de gomitas
            int mayorValor, mayor_i = 0, mayor_j = 0, mayor_k = 0;

            // Asignamos el primer valor como el mayor de manera arbritaria
            mayorValor = totalizador[mayor_i, mayor_j, mayor_k];

            // Recorremos el arreglo del totalizador buscando el mayor valor y su posicion (i,j,k)
            for (int i = 0; i < totalizador.GetLength(0); i++)
                for (int j = 0; j < totalizador.GetLength(1); j++)
                    for (int k = 0; k < totalizador.GetLength(2); k++)
                        if (totalizador[i, j, k] > mayorValor)
                        {
                            mayorValor = totalizador[i, j, k];
                            mayor_i = i;
                            mayor_j = j;
                            mayor_k = k;
                        }

            //ya sabemos el sabor, el color y la forma de la que tiene mayor cantidad
            resultado = "Mayor Cantidad: de color " + arregloColores[mayor_i] +
                                " con sabor a " + arregloSabores[mayor_j] +
                                " con forma de " + arregloFormas[mayor_k] +
                                " y con una cantidad de " + mayorValor;

            //ahora vamos a identificar cual es la primera combinación que tiene la mayor cantidad de gomitas
            int menorValor, menor_i = 0, menor_j = 0, menor_k = 0;

            // Asignamos el primer valor como el mayor de manera arbritaria
            menorValor = totalizador[menor_i, menor_j, mayor_k];

            // Recorremos el arreglo del totalizador buscando el mayor valor y su posicion (i,j,k)
            for (int i = 0; i < totalizador.GetLength(0); i++)
                for (int j = 0; j < totalizador.GetLength(1); j++)
                    for (int k = 0; k < totalizador.GetLength(2); k++)
                        if (totalizador[i, j, k] < menorValor)
                        {
                            menorValor = totalizador[i, j, k];
                            menor_i = i;
                            menor_j = j;
                            menor_k = k;
                        }


            //ya sabemos el sabor, el color y la forma de la que tiene menor cantidad
            resultado += "\nMenor Cantidad: de color " + arregloColores[menor_i] +
                                " con sabor a " + arregloSabores[menor_j] +
                                " con forma de " + arregloFormas[menor_k] +
                                " y con una cantidad de " + menorValor;

            return resultado;
        }

        /// <summary>
        /// Totaliza por sabores el arreglo de las gomitas
        /// </summary>
        /// <param name="arregloGomitas">arreglo con las gomitas</param>
        /// <param name="arregloSabores">arreglo con los sabores</param>
        /// <returns>el arreglo con los totales por sabor</returns>
        static int[] TotalizaSaboresGomitas(Gomita[] arregloGomitas, string[] arregloSabores)
        {
            int[] totalesSabores = new int[arregloSabores.Length];

            //inicializamos el arreglo de totales
            for (int i = 0; i < totalesSabores.Length; i++)
                totalesSabores[i] = 0;

            //recorremos el arreglo de gomitas
            for (int i = 0; i < arregloGomitas.Length; i++)
            {
                //recorremos el arreglo de sabores
                for (int j = 0; j < arregloSabores.Length; j++)
                {
                    //si el sabor de la gomita es igual al sabor actual en el arreglo, 
                    //se incrementa el total
                    if (arregloGomitas[i].Sabor == arregloSabores[j])
                        totalesSabores[j]++;
                }
            }

            //finalmente devolvemos el resultado
            return totalesSabores;
        }

        /// <summary>
        /// Totaliza por colores el arreglo de las gomitas
        /// </summary>
        /// <param name="arregloGomitas">arreglo con las gomitas</param>
        /// <param name="arregloSabores">arreglo con los colores</param>
        /// <returns>el arreglo con los totales por color</returns>
        static int[] TotalizaColoresGomitas(Gomita[] arregloGomitas, string[] arregloColores)
        {
            int[] totalesColores = new int[arregloColores.Length];

            //inicializamos el arreglo de totales
            for (int i = 0; i < totalesColores.Length; i++)
                totalesColores[i] = 0;

            //recorremos el arreglo de gomitas
            for (int i = 0; i < arregloGomitas.Length; i++)
            {
                //recorremos el arreglo de sabores
                for (int j = 0; j < arregloColores.Length; j++)
                {
                    //si el sabor de la gomita es igual al sabor actual en el arreglo, 
                    //se incrementa el total
                    if (arregloGomitas[i].Color == arregloColores[j])
                        totalesColores[j]++;
                }
            }

            //finalmente devolvemos el resultado
            return totalesColores;
        }

        /// <summary>
        /// Totaliza por formas el arreglo de las gomitas
        /// </summary>
        /// <param name="arregloGomitas">arreglo con las gomitas</param>
        /// <param name="arregloSabores">arreglo con las formas</param>
        /// <returns>el arreglo con los totales por forma</returns>
        static int[] TotalizaFormasGomitas(Gomita[] arregloGomitas, string[] arregloFormas)
        {
            int[] totalesFormas = new int[arregloFormas.Length];

            //inicializamos el arreglo de totales
            for (int i = 0; i < totalesFormas.Length; i++)
                totalesFormas[i] = 0;

            //recorremos el arreglo de gomitas
            for (int i = 0; i < arregloGomitas.Length; i++)
            {
                //recorremos el arreglo de sabores
                for (int j = 0; j < arregloFormas.Length; j++)
                {
                    //si el sabor de la gomita es igual al sabor actual en el arreglo, 
                    //se incrementa el total
                    if (arregloGomitas[i].Forma == arregloFormas[j])
                        totalesFormas[j]++;
                }
            }

            //finalmente devolvemos el resultado
            return totalesFormas;
        }
    }
}