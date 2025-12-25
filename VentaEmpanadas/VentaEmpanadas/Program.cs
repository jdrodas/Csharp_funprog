/*
Programa:       VentaEmpanadas
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Demostrar conceptos de clase, objeto, encapsulación, propiedades
- Crear un arreglo de objetos e inicializarlo de manera secuencial según valores establecidos para los atributos.
- Crear una función que totalice por cada tipo de atributo, cada uno de sus valores y se visualice los subtotales.

El programa simulará la preparación y venta de 1000 empanadas de acuerdo
a valores de relleno, masa y color que ingresará el usuario.

El programa al final indicará por cada propiedad, como se distribuyeron.
Tarea: Informar cual fue la combinación masa/relleno/color que más se produjo.

*/
namespace VentaEmpanadas
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Programa para definir producción de Empanadas del día");

            int cantidadMasas = 0, cantidadRellenos = 0, cantidadColores = 0;
            bool masasCorrectas = false, rellenosCorrectos = false, coloresCorrectos = false;

            do
            {
                try
                {
                    //Validamos primero que la cantidad de masas sea entero positivo
                    while (!masasCorrectas)
                    {
                        Console.Write("\nIngresa la cantidad de masas: ");
                        cantidadMasas = int.Parse(Console.ReadLine()!);

                        if (cantidadMasas > 0)
                            masasCorrectas = true;
                        else
                            Console.WriteLine("La cantidad de masas debe ser un entero positivo. Intenta nuevamente! :( \n\n");
                    }

                    //Validamos primero que la cantidad de colores sea entero positivo
                    while (!coloresCorrectos)
                    {
                        Console.Write("\nIngresa la cantidad de colores: ");
                        cantidadColores = int.Parse(Console.ReadLine()!);
                        if (cantidadColores > 0)
                            coloresCorrectos = true;
                        else
                            Console.WriteLine("La cantidad de colores debe ser un entero positivo. Intenta nuevamente! :( \n\n");
                    }

                    //Validamos primero que la cantidad de rellenos sea entero positivo
                    while (!rellenosCorrectos)
                    {
                        Console.Write("\nIngresa la cantidad de rellenos: ");
                        cantidadRellenos = int.Parse(Console.ReadLine()!);
                        if (cantidadRellenos > 0)
                            rellenosCorrectos = true;
                        else
                            Console.WriteLine("La cantidad de rellenos debe ser un entero positivo. Intenta nuevamente! :( \n\n");
                    }
                }
                catch (FormatException elError)
                {
                    Console.WriteLine("Los valores de cantidad de masa, relleno o color deben ser numeros enteros.");
                    Console.WriteLine("Intenta nuevamente");
                    Console.WriteLine(elError.Message + "\n\n");
                }
            }
            while (!rellenosCorrectos || !coloresCorrectos || !masasCorrectas);

            Console.WriteLine("\n\nValores de cantidad correctos, podemos continuar!");
            Console.WriteLine($"Cantidad Colores: {cantidadColores}, cantidad masas: {cantidadMasas} y cantidad rellenos: {cantidadRellenos}\n\n");

            //ingresamos los valores para los colores, rellenos y masas
            string[] tiposColores = new string[cantidadColores];
            string[] tiposMasas = new string[cantidadMasas];
            string[] tiposRellenos = new string[cantidadRellenos];

            //ingresamos los valores para relleno
            Console.WriteLine("\n*** Ingreso de Rellenos ***");
            for (int i = 0; i < tiposRellenos.Length; i++)
            {
                Console.Write($"Ingresa el valor de relleno No. {i + 1}: ");
                tiposRellenos[i] = Console.ReadLine()!;
            }

            //ingresamos los valores para masas
            Console.WriteLine("\n*** Ingreso de Masas ***");
            for (int i = 0; i < tiposMasas.Length; i++)
            {
                Console.Write($"Ingresa el valor de masa No. {i + 1}: ");
                tiposMasas[i] = Console.ReadLine()!;
            }

            //ingresamos los valores para colores
            Console.WriteLine("\n*** Ingreso de Colores ***");
            for (int i = 0; i < tiposColores.Length; i++)
            {
                Console.Write($"Ingresa el valor de color No. {i + 1}: ");
                tiposColores[i] = Console.ReadLine()!;
            }

            //Generamos el arreglo aleatorio de empanadas con 1000 posiciones
            Console.Write("\n\nGenerando arreglo aleatorio de empanadas para el día de hoy... ");

            Random aleatorio = new();

            Empanada[] lasEmpanadas = new Empanada[1000];

            // inicializamos el arreglo, asignado para cada empanada
            // un valor aleatorio en cada una de sus propiedades

            for (int i = 0; i < lasEmpanadas.Length; i++)
            {
                lasEmpanadas[i] = new Empanada
                {
                    Color = tiposColores[aleatorio.Next(tiposColores.Length)],
                    Masa = tiposMasas[aleatorio.Next(tiposMasas.Length)],
                    Relleno = tiposRellenos[aleatorio.Next(tiposRellenos.Length)]
                };
            }

            Console.WriteLine("finalizado!");

            ///Contamos cuantas empanadas por cada tipo de cada propiedad
            Console.WriteLine("\n\n Totales por cada tipo de propiedad:");
            Console.WriteLine("***********************************");

            int[] totalesPropiedad;
            int totalValores;
            float porcentaje;

            Console.WriteLine("\nTotales por tipo de Masa");
            totalesPropiedad = CalculaTotalesPorPropiedad(lasEmpanadas, tiposMasas, "masa");

            totalValores = 0;
            for (int i = 0; i < tiposMasas.Length; i++)
            {
                porcentaje = ((float)totalesPropiedad[i] / 1000) * 100;
                Console.WriteLine($"Para la masa {tiposMasas[i]} se hicieron {totalesPropiedad[i]} empanadas, {Math.Round(porcentaje, 2)}%");
                totalValores += totalesPropiedad[i];
            }
            Console.WriteLine($"\n***Total Empanadas: {totalValores}");


            Console.WriteLine("\nTotales por tipo de Relleno");
            totalesPropiedad = CalculaTotalesPorPropiedad(lasEmpanadas, tiposRellenos, "relleno");

            totalValores = 0;
            for (int i = 0; i < tiposRellenos.Length; i++)
            {
                porcentaje = ((float)totalesPropiedad[i] / 1000) * 100;
                Console.WriteLine($"Para el relleno {tiposRellenos[i]} se hicieron {totalesPropiedad[i]} empanadas, {Math.Round(porcentaje, 2)}%");
                totalValores += totalesPropiedad[i];
            }
            Console.WriteLine($"\n***Total Empanadas: {totalValores}");

            Console.WriteLine("\nTotales por tipo de Color");
            totalesPropiedad = CalculaTotalesPorPropiedad(lasEmpanadas, tiposColores, "color");

            totalValores = 0;
            for (int i = 0; i < tiposColores.Length; i++)
            {
                porcentaje = ((float)totalesPropiedad[i] / 1000) * 100;
                Console.WriteLine($"Para el color {tiposColores[i]} se hicieron {totalesPropiedad[i]} empanadas, {Math.Round(porcentaje, 2)}%");
                totalValores += totalesPropiedad[i];
            }
            Console.WriteLine($"\n***Total Empanadas: {totalValores}");

        }

        /// <summary>
        /// Calcula los valores totales por tipo de valor para cada propiedad
        /// </summary>
        /// <param name="arregloEmpanadas">El arreglo de empanadas a evaluar</param>
        /// <param name="arregloValoresPropiedad">los posibles valores de la propiedad</param>
        /// <param name="nombrePropiedad">la propiedad que se está evaluando</param>
        /// <returns></returns>
        static int[] CalculaTotalesPorPropiedad(Empanada[] arregloEmpanadas, string[] arregloValoresPropiedad, string nombrePropiedad)
        {
            int[] resultado = new int[arregloValoresPropiedad.Length];
            int i, j;

            // Inicializamos el arreglo de los resultados
            for (j = 0; j < resultado.Length; j++)
                resultado[j] = 0;

            //Dependiendo de la propiedad indicada, se realiza el cálculo del total
            for (i = 0; i < arregloEmpanadas.Length; i++)
                for (j = 0; j < arregloValoresPropiedad.Length; j++)
                {
                    if (nombrePropiedad == "masa")
                        if (arregloEmpanadas[i].Masa == arregloValoresPropiedad[j])
                            resultado[j]++;

                    if (nombrePropiedad == "relleno")
                        if (arregloEmpanadas[i].Relleno == arregloValoresPropiedad[j])
                            resultado[j]++;

                    if (nombrePropiedad == "color")
                        if (arregloEmpanadas[i].Color == arregloValoresPropiedad[j])
                            resultado[j]++;
                }

            return resultado;
        }
    }
}