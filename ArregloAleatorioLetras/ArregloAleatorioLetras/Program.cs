/*
Programa:       ArregloAleatorioLetras
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Enunciado:
----------
Sea el siguiente conjunto de letras las que conforman el abecedario en español:

abcdefghijklmnñopqrstuvwxyz

Realice un programa en C# que:

- genere un arreglo caracteres de 500 posiciones llenado con las letras del abecedario seleccionadas de manera aleatoria. 
- Implemente una función que reciba el arreglo como parámetro y visualice en consola el contenido del arreglo, 25 elementos por línea.
- Implemente una función que reciba en los parámetros el arreglo de letras y el abecedario y visualice en consola el total de veces que aparece cada letra del abecedario en el arreglo de letras.

*/

namespace ArregloAleatorioLetras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para demostrar funciones y Arreglos");
            Console.WriteLine("Se generará un arreglo de 500 letras de manera aleatoria");

            string abecedario = "abcdefghijklmnñopqrstuvwxyz";

            //este arreglo será la base para generar los valores aleatorios
            char[] arregloAbecedario = abecedario.ToCharArray();

            Console.WriteLine($"El abecedario que usaremos es {abecedario} y tiene longitud de {abecedario.Length} caracteres.");
            Console.WriteLine($"El arreglo de caracteres tiene una longitud de {arregloAbecedario.Length}");

            //Aqui declaramos un arreglo de 500 posiciones de caracteres
            //Y los llenamos de manera aleatoria con las letras del abecedario
            char[] bolsaLetras = new char[500];

            Random aleatorio = new Random();

            //llenamos el arregloAleatorio con valores del arreglo base

            for (int i = 0; i < bolsaLetras.Length; i++)
                bolsaLetras[i] = arregloAbecedario[aleatorio.Next(arregloAbecedario.Length)];

            //Aqui visualizamos el contenido del arreglo
            VisualizaArreglo(bolsaLetras);

            //Aqui generamos totales e información sobr el arreglo
            TotalizaLetras(bolsaLetras, arregloAbecedario);

            //Aqui ordenamos el arreglo de varias maneras
            OrganizaArregloPrimerMetodo(bolsaLetras);

            OrganizaArregloSegundoMetodo(bolsaLetras);

            OrganizaArregloTercerMetodo(bolsaLetras);

            OrganizaArregloCuartoMetodo(bolsaLetras,arregloAbecedario);
        }

        /// <summary>
        /// Visualiza el arreglo de caracteres
        /// </summary>
        /// <param name="arregloDeLetras">El arreglo de letras</param>
        static void VisualizaArreglo(char[] arregloDeLetras)
        {
            //aqui visualizamos las letras en el arreglo
            Console.WriteLine("\nLas letras en el arreglo son: \n");

            for (int i = 0; i < arregloDeLetras.Length; i++)
            {
                Console.Write(arregloDeLetras[i] + " ");

                if ((i + 1) % 25 == 0) //Colocamos 25 elementos por línea
                    Console.WriteLine();
            }

            Console.WriteLine();
        }


        /// <summary>
        /// Función para totalizar y visualizar cuantas hay por cada letra del abecedario
        /// </summary>
        /// <param name="arreglo">El arreglo con las letras aleatorias</param>
        /// <param name="abecedario">el patrón de las letras con las que se genera el arreglo</param>
        static void TotalizaLetras(char[] arregloDeLetras, char[] abecedario)
        {
            //aqui declaramos el arreglo de totales
            int[] totalesLetras = new int[abecedario.Length];

            //inicializamos el arreglo de totales
            for (int i = 0; i < totalesLetras.Length; i++)
                totalesLetras[i] = 0;

            //aqui contamos por cada letra
            for (int i = 0; i < arregloDeLetras.Length; i++)
                for (int j = 0; j < abecedario.Length; j++)
                    if (arregloDeLetras[i] == abecedario[j])
                        totalesLetras[j]++;

            //Finalmente visualizamos los totales
            Console.WriteLine("Los totales por letra son los siguientes:");

            for (int i = 0; i < abecedario.Length; i++)
                Console.WriteLine($"Letra {abecedario[i]}, total de veces encontrada: {totalesLetras[i]}");

        }

        /// <summary>
        /// Organiza un arreglo de letras utilizando un algoritmo básico
        /// </summary>
        /// <param name="arregloDeLetras">El arreglo de letras</param>
        static void OrganizaArregloPrimerMetodo(char[] arregloDeLetras)
        {
            //La bolsa de resultado tiene el mismo tamaño que el arreglo de letras
            char[] bolsaResultado = arregloDeLetras;

            bool seHizoCambioUbicacion = false;
            char letraTemporal;

            do
            {
                seHizoCambioUbicacion = false;
                for (int i = 0; i < bolsaResultado.Length - 1; i++)
                {
                    if (bolsaResultado[i] > bolsaResultado[i + 1])
                    {
                        letraTemporal = bolsaResultado[i + 1];
                        bolsaResultado[i + 1] = bolsaResultado[i];
                        bolsaResultado[i] = letraTemporal;
                        seHizoCambioUbicacion = true;
                    }
                }
            }
            while (seHizoCambioUbicacion);

            //Finalmente visualizamos el arreglo organizado
            Console.WriteLine("\nEl arreglo organizado utilizando un algoritmo básico");
            VisualizaArreglo(bolsaResultado);
        }

        /// <summary>
        /// Organiza un arreglo de letras utilizando la función SORT
        /// </summary>
        /// <param name="arregloDeLetras">El arreglo de letras</param>
        static void OrganizaArregloSegundoMetodo(char[] arregloDeLetras)
        {
            //La bolsa de resultado tiene el mismo tamaño que el arreglo de letras
            char[] bolsaResultado = arregloDeLetras;

            Array.Sort(bolsaResultado);

            //Finalmente visualizamos el arreglo organizado
            Console.WriteLine("El arreglo organizado utilizando la funcion SORT");
            VisualizaArreglo(bolsaResultado);
        }

        /// <summary>
        /// Organiza un arreglo de letras utilizando la función OrderBy
        /// </summary>
        /// <param name="arregloDeLetras">El arreglo de letras</param>
        static void OrganizaArregloTercerMetodo(char[] arregloDeLetras)
        {
            //La bolsa de resultado tiene el mismo tamaño que el arreglo de letras
            char[] bolsaResultado = arregloDeLetras.OrderBy(c => c).ToArray();

            //Finalmente visualizamos el arreglo organizado
            Console.WriteLine("El arreglo organizado utilizando la funcion OrderBy");
            VisualizaArreglo(bolsaResultado);
        }

        /// <summary>
        /// Organiza un arreglo de letras utilizando como guía el orden del abecedario
        /// </summary>
        /// <param name="arregloDeLetras">El arreglo de letras</param>
        /// <param name="arregloAbecedario">El abecedario representado como un arreglo</param>
        static void OrganizaArregloCuartoMetodo(char[] arregloDeLetras, char[] arregloAbecedario)
        {
            //La bolsa de resultado tiene el mismo tamaño que el arreglo de letras
            char[] bolsaResultado = new char[arregloDeLetras.Length];
            int posicionActual = 0;

            //Nos vamos recorriendo el arreglo del abecedario
            for (int i = 0; i < arregloAbecedario.Length; i++)
            {
                //recorremos el arreglo de letras comparando cada una de ellas con la actual del abecedario
                for (int j = 0; j < arregloDeLetras.Length; j++)
                {
                    //Si son iguales, las copiamos al arreglo y avanzamos a la siguiente posicion
                    if (arregloAbecedario[i] == arregloDeLetras[j])
                    {
                        bolsaResultado[posicionActual] = arregloDeLetras[j];
                        posicionActual++;
                    }
                }
            }

            //Finalmente visualizamos el arreglo organizado
            Console.WriteLine("El arreglo organizado utilizando como guía el orden del abecedario:");
            VisualizaArreglo(bolsaResultado);

        }
    }
}
