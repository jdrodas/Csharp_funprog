/*
Programa:       EjemploFuncionesArreglos
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Generar un arreglo con valores enteros aleatorios
- Implementar una función que encuentre el valor mayor del arreglo
- Implementar una función que encuentre las posiciones donde está un valor

*/

using System;


namespace EjemploFuncionesArreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para demostrar funciones y arreglos");
            Console.WriteLine("Arreglo de 50 números enteros con valores aleatorios entre 1 y 100");

            int[] conjunto = new int[50];
            Random aleatorio = new Random();

            //aqui inicializamos el arreglo con valores aleatorios
            for (int i = 0; i < conjunto.Length; i++)
                conjunto[i] = aleatorio.Next(1, 101); // intervalo cerrado en límite inferior
                                                      // intervalo abierto en límite superior

            //aqui visualizamos el contenido del arreglo
            Console.WriteLine("El contenido del arreglo es: \n\n");
            VisualizaArreglo(conjunto);

            //aqui buscamos el valor mayor del arreglo
            int mayor = EncuentraMayor(conjunto);
            Console.WriteLine("\nEl valor mayor encontrado es: " + mayor);

            //aqui vamos a identificar las posiciones donde aparece el número mayor
            int[] posicionesDelMayor = BuscaPosicionesValor(mayor, conjunto);

            Console.WriteLine("\nNúmero de posiciones donde está el número mayor: {0} ", posicionesDelMayor.Length);

            Console.WriteLine("\nLas posiciones donde está el número mayor son: ");
            for (int i = 0; i < posicionesDelMayor.Length; i++)
                Console.WriteLine(posicionesDelMayor[i] + 1); //Posiciones de Humano

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
        /// funcion para visualizar el contenido de un arreglo
        /// </summary>
        /// <param name="coleccion">El arreglo a visualizar</param>
        static void VisualizaArreglo(int[] coleccion)
        {
            int contador = 0;

            for (int i = 0; i < coleccion.Length; i++)
            {
                Console.Write(coleccion[i] + "\t");
                contador++;

                //si ya coloqué 10 numeros, salto de linea
                if (contador == 10)
                {
                    Console.WriteLine();
                    contador = 0;
                }
            }
        }
    }
}
