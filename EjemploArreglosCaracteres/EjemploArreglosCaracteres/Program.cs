/*
Programa:       EjemploArreglosCaracteres
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Demostrar la equivalencia de las variables tipo string como arreglo de caracteres
- Demostrar el funcionamiento de la sentencia Switch para verificar múltipes condiciones
*/

namespace EjemploArreglosCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadenas de caracteres como arreglos");

            Console.Write("Ingresa una frase en minúscula: ");
            string laFrase = Console.ReadLine()!.ToLower();

            Console.WriteLine($"\n\nLa frase ingresada es: {laFrase}");
            Console.WriteLine($"La frase tiene {laFrase.Length} caracteres");

            //Aqui declaramos un arreglo de caracteres y almancenamos la frase usando ToCharArray()
            char[] arregloLetras = laFrase.ToCharArray();

            Console.WriteLine($"\nEl arreglo de letras tiene {arregloLetras.Length} posiciones");

            Console.WriteLine("\nLa frase de manera vertical, tres letras por línea es:");


            for (int i = 0; i < arregloLetras.Length; i++)
            {
                Console.Write(arregloLetras[i]);

                //aqui visualizamos de a tres caracteres por linea
                if ((i + 1) % 3 == 0)  //De a tres posiciones: 0, 1 y 2              
                    Console.WriteLine();
            }

            //aqui vamos a contar las vocales y los espacios
            int totalVocales = 0, totalEspacios = 0, totalNumeros = 0, totalOtros = 0;

            for (int i = 0; i < arregloLetras.Length; i++)
            {
                switch (arregloLetras[i])
                {
                    //Casos para las vocales
                    case 'a':
                    case 'á':
                    case 'e':
                    case 'é':
                    case 'i':
                    case 'í':
                    case 'o':
                    case 'ó':
                    case 'u':
                    case 'ú':
                        totalVocales++;
                        break;

                    //Caso para el espacio
                    case ' ':
                        totalEspacios++;
                        break;

                    //Casos para los digitos numéricos
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        totalNumeros++;
                        break;

                    default:
                        totalOtros++;
                        break;
                }
            }

            Console.WriteLine($"\n\nLa frase tiene {totalVocales} vocal(es), {totalEspacios} espacio(s), {totalNumeros} número(s) y {totalOtros} otro(s)");

        }
    }
}