/*
Programa:       EjemploArreglos
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Demostrar los conceptos básicos de los arreglos
- Llenar un arreglo con numeros aleatorios y visualizar su contenido
*/

namespace EjemploArreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para demostrar la utilización de arreglos");

            //aqui declaramos el arreglo de una dimensión - vector
            int[] elArreglo = new int[5];

            Console.WriteLine($"El arreglo tiene un tamaño de {elArreglo.Length}");

            //aqui asignamos individualmente un valor en cada posición
            elArreglo[0] = 1;
            elArreglo[1] = 26;
            elArreglo[2] = -43;
            elArreglo[3] = 0;
            elArreglo[4] = 18;

            //Aqui visualizamos el contenido del arreglo
            Console.WriteLine($"En la posición 1 está almacenado {elArreglo[0]}");
            Console.WriteLine($"En la posición 2 está almacenado {elArreglo[1]}");
            Console.WriteLine($"En la posición 3 está almacenado {elArreglo[2]}");
            Console.WriteLine($"En la posición 4 está almacenado {elArreglo[3]}");
            Console.WriteLine($"En la posición 5 está almacenado {elArreglo[4]}");

            Console.WriteLine("\n\nAqui declaramos otro arreglo y lo llenamos con valores aleatorios entre 1 y 10:");

            int[] otroArreglo = new int[60];

            Console.WriteLine($"El arreglo tiene un tamaño de {otroArreglo.Length}");

            //aqui lo inicializamos con valores aleatorios entre 1 y 10
            Random aleatorio = new Random();

            for (int i = 0; i < otroArreglo.Length; i++)
                otroArreglo[i] = aleatorio.Next(10) + 1; //desde cero hasta antes de 10, por eso +1

            //aqui visualizamos el arreglo, 10 valores por línea
            int contador = 0;

            for (int i = 0; i < otroArreglo.Length; i++)
            {
                Console.Write(otroArreglo[i] + "\t"); //Separamos cada valor con tabulador (\t)
                contador++;

                if (contador % 10 == 0) //si ya se han visualizado 10, salto de linea y reinicio contador
                {
                    Console.WriteLine();
                    contador = 0;
                }
            }
        }
    }
}
