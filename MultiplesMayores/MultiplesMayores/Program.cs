using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesMayores
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
                - Leer 5 numeros enteros y almacenarlos en un arreglo
                - Crear una función que identifique el valor mayor y la cantidad de veces que ocurre
                - Visualizar resultados
             */

            Console.WriteLine("Programa para identificar el número mayor y cuantas veces ocurre");

            int[] losNumeros = new int[5];

            //Aqui leemos desde consola y los almacenamos en el arreglo
            int contador = 0;            
            while (contador < losNumeros.Length)
            {
                try
                {
                    Console.Write($"\nIngresa el dato No. {contador + 1}: ");
                    losNumeros[contador] = int.Parse(Console.ReadLine());
                    contador++;
                }
                catch (FormatException elError)
                {
                    Console.WriteLine("El dato ingresado no corresponde a un numero. Intenta nuevamente!");
                    Console.WriteLine(elError.Message);
                }
            }

            Console.WriteLine("\nLos números ingresados fueron:");
            foreach(int numero in losNumeros)
                Console.WriteLine($"\t{numero}");

            //Aqui invocamos la función para identificar el número mayor y las veces que ocurre
            int numeroMayor,cantidadMayores;

            EncuentraMayores(losNumeros, out numeroMayor, out cantidadMayores);

            //Visualice resultados
            Console.WriteLine($"\n\nEl número mayor fue {numeroMayor} que apareció {cantidadMayores} veces");
        }

        /// <summary>
        /// Función que identifica el número mayor y cuantas veces ocurre
        /// </summary>
        /// <param name="arregloNumeros">Numeros a evaluar</param>
        /// <param name="numeroMayor">El numero mayor encontrado</param>
        /// <param name="cantidadMayores">la cantidad de veces encontrada</param>
        public static void EncuentraMayores(int[] arregloNumeros, out int numeroMayor, out int cantidadMayores)
        {
            //Arbitrariamente definimos el primer elemento del arreglo como el mayor
            numeroMayor = arregloNumeros[0];
            cantidadMayores = 1;

            for (int i = 1; i < arregloNumeros.Length; i++)
            {
                //Validamos si es mayor al mayor encontrado hasta el momento
                if (arregloNumeros[i] > numeroMayor)
                {
                    numeroMayor = arregloNumeros[i];
                    cantidadMayores = 1;
                }
                else
                {
                    //Validamos si el número es igual al mayor encontrado hasta el momento
                    if (arregloNumeros[i] == numeroMayor)
                        cantidadMayores++;
                }
            }
        }
    }
}
