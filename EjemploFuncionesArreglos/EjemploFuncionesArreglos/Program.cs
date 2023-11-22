/*
Programa:       EjemploFuncionesArreglos
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Generar un arreglo con valores enteros aleatorios
- Implementar funciones que encuentre los valore menores y mayores del arreglo
- Implementar una función que encuentre las posiciones donde está un valor
- Implementar una función que ordene un arreglo entero utilizando el algortimo burbuja
*/

namespace EjemploFuncionesArreglos
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Programa para demostrar funciones y arreglos");
            Console.WriteLine("Arreglo de 50 números enteros con valores aleatorios entre 1 y 100");

            int[] conjunto = new int[50];
            Random aleatorio = new();

            //aqui inicializamos el arreglo con valores aleatorios
            for (int i = 0; i < conjunto.Length; i++)
                conjunto[i] = aleatorio.Next(1, 101); // intervalo cerrado en límite inferior
                                                      // intervalo abierto en límite superior

            //aqui visualizamos el contenido del arreglo
            Console.WriteLine("El contenido del arreglo es: \n\n");
            VisualizaArreglo(conjunto);

            //aqui buscamos el valor mayor del arreglo
            int mayor = EncuentraMayor(conjunto);
            Console.WriteLine($"\nEl valor mayor encontrado es: {mayor}");

            //aqui vamos a identificar las posiciones donde aparece el número mayor
            int[] posicionesDelMayor = BuscaPosicionesValor(mayor, conjunto);

            Console.WriteLine($"\nEl número mayor está {posicionesDelMayor.Length} veces en el arreglo ");

            Console.WriteLine("\nLas posiciones donde está el número mayor son: ");
            for (int i = 0; i < posicionesDelMayor.Length; i++)
                Console.WriteLine(posicionesDelMayor[i] + 1); //Posiciones de Humano

            //aqui buscamos el valor menor del arreglo
            int menor = EncuentraMenor(conjunto);
            Console.WriteLine($"\nEl valor menor encontrado es: {menor}");

            //aqui vamos a identificar las posiciones donde aparece el número menor
            int[] posicionesDelMenor = BuscaPosicionesValor(menor, conjunto);

            Console.WriteLine($"\nEl número menor está {posicionesDelMenor.Length} veces en el arreglo ");

            Console.WriteLine("\nLas posiciones donde está el número menor son: ");
            for (int i = 0; i < posicionesDelMenor.Length; i++)
                Console.WriteLine(posicionesDelMenor[i] + 1); //Posiciones de Humano

            //aqui ordenamos el arreglo
            int[] conjuntoOrdenado = OrdenaArregloBurbuja(conjunto);

            //aqui visualizamos el arreglo ordenado
            Console.WriteLine("\n\nEl contenido del arreglo ordenado es: \n\n");
            VisualizaArreglo(conjuntoOrdenado);

            //la supermega eficiente solución
            int[] otroOrdenado = conjunto;
            Array.Sort(otroOrdenado);

            Console.WriteLine("\n\nEl arreglo ordenado usando Array.Sort(): \n\n");
            VisualizaArreglo(otroOrdenado);
        }

        /// <summary>
        /// Función para ordenar un arreglo utilizando el método burbuja
        /// </summary>
        /// <param name="coleccion"></param>
        /// <returns>Arreglo ordenado</returns>
        static int[] OrdenaArregloBurbuja(int[] coleccion)
        {
            int[] coleccionOrdenada = coleccion;
            int datoTemporal;

            //aqui implementamos el algoritmo de ordenamiento burbuja en forma ascendente
            bool seHizoCambio = true;

            //se repite el ciclo hasta que no se haga cambio (seHizoCambio = false)
            while (seHizoCambio == true)
            {
                //iniciamos cada ciclo indicando que no se hizo cambio
                seHizoCambio = false;

                //recorremos el ciclo para hacer las comparaciones de dos números adjacentes
                for (int i = 0; i < coleccionOrdenada.Length - 1; i++)
                {
                    if (coleccionOrdenada[i] > coleccionOrdenada[i + 1])
                    {
                        //el primero es mayor que el segundo, se cambian de posición
                        datoTemporal = coleccionOrdenada[i + 1];
                        coleccionOrdenada[i + 1] = coleccionOrdenada[i];
                        coleccionOrdenada[i] = datoTemporal;

                        //se hizo ordenamiento, se coloca la variable "bandera" en true
                        seHizoCambio = true;
                    }
                }
            }

            return coleccionOrdenada;
        }

        /// <summary>
        /// Función que busca las posiciones en una coleccion que tienen el 
        /// valor especificado
        /// </summary>
        /// <param name="valor"> el valor a buscar</param>
        /// <param name="coleccion">la colección que contiene los valores</param>
        /// <returns>arreglo con las posiciones que tienen ese valor</returns>
        static int[] BuscaPosicionesValor(int valor, int[] coleccion)
        {
            //1.Encontrar la cantidad de posiciones que tienen ese valor almacenado
            int cantidad = 0; // cantidad de posiciones que tienen el valor buscado
            for (int i = 0; i < coleccion.Length; i++)
                if (coleccion[i] == valor)
                    cantidad++;

            //2. Declarar un arreglo de esa cantidad de posiciones
            int[] posiciones = new int[cantidad];

            int ubicacion = 0; //ubicación en arreglo de posiciones
                               //cada vez que encuentre una posición 
                               //con el valor requerido, incremento este contador

            //3. almacenar cada posición donde está el valor requerido
            for (int i = 0; i < coleccion.Length; i++)
            {
                if (coleccion[i] == valor)
                {
                    posiciones[ubicacion] = i;
                    ubicacion++;
                }
            }

            //finalmente, devolvemos el arreglo
            return posiciones;
        }

        /// <summary>
        /// Función para encontrar el número mayor en un arreglo de enteros
        /// </summary>
        /// <param name="coleccion"></param>
        /// <returns>el número mayor encontrado</returns>
        static int EncuentraMayor(int[] coleccion)
        {
            int datoMayor = coleccion[0]; //arbitrariamente decimos que el primer elemento
                                          //es el mayor de los valores del arreglo

            //aqui comparamos ese mayor a ver si hay otro mayor
            for (int i = 0; i < coleccion.Length; i++)
                if (coleccion[i] > datoMayor)
                    datoMayor = coleccion[i]; //se encontró un nuevo mayor

            return datoMayor;
        }

        /// <summary>
        /// Función para encontrar el número menor en un arreglo de enteros
        /// </summary>
        /// <param name="coleccion"></param>
        /// <returns>el número menor encontrado</returns>
        static int EncuentraMenor(int[] coleccion)
        {
            int datoMenor = coleccion[0]; //arbitrariamente decimos que el primer elemento
                                          //es el mayor de los valores del arreglo

            //aqui comparamos ese mayor a ver si hay otro mayor
            for (int i = 0; i < coleccion.Length; i++)
                if (coleccion[i] < datoMenor)
                    datoMenor = coleccion[i]; //se encontró un nuevo mayor

            return datoMenor;
        }

        /// <summary>
        /// funcion para visualizar el contenido de un arreglo
        /// </summary>
        /// <param name="coleccion">El arreglo a visualizar</param>
        static void VisualizaArreglo(int[] coleccion)
        {
            for (int i = 0; i < coleccion.Length; i++)
            {
                Console.Write(coleccion[i] + "\t");

                //si ya coloqué 10 numeros, salto de linea
                if ((i + 1) % 10 == 0)
                    Console.WriteLine();
            }
        }
    }
}
