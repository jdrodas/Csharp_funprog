/*
Programa:       CodigoMurcielago
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
 - Demostrar el funcionamiento básico de los arreglos
 - Convertir cadena de caracteres a un arreglo de caracteres
 - utilizar la sentencia switch como opción a los condicionales múltiples
 - Crear una cadena de caracteres a partir de un arreglo de caracteres

*/

namespace CodigoMurcielago
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Programa para cifrar una frase en código murcielago");
            Console.WriteLine("se remplazan las letras de las frases que están en la palabra");
            Console.WriteLine("murcielago por el número de la posición de la letra en la palabra\n\n");

            Console.Write("Ingresa una frase para cifrar: ");
            string frase = Console.ReadLine()!.ToLower();

            Console.WriteLine($"La frase en minúsculas es {frase}");

            //aqui declaramos el arreglo
            char[] arregloFrase = frase.ToCharArray();

            //aqui recorremos el arreglo y validamos si la letra está en la palabra murcielago
            for (int i = 0; i < arregloFrase.Length; i++)
            {
                switch (arregloFrase[i])
                {
                    case 'm':
                        arregloFrase[i] = '1';
                        break;

                    case 'u':
                    case 'ú':
                        arregloFrase[i] = '2';
                        break;

                    case 'r':
                        arregloFrase[i] = '3';
                        break;

                    case 'c':
                        arregloFrase[i] = '4';
                        break;

                    case 'i':
                    case 'í':
                        arregloFrase[i] = '5';
                        break;

                    case 'e':
                    case 'é':
                        arregloFrase[i] = '6';
                        break;

                    case 'l':
                        arregloFrase[i] = '7';
                        break;

                    case 'a':
                    case 'á':
                        arregloFrase[i] = '8';
                        break;

                    case 'g':
                        arregloFrase[i] = '9';
                        break;

                    case 'o':
                    case 'ó':
                        arregloFrase[i] = '0';
                        break;
                }
            }

            //finalmente visualizamos la frase ya cifrada
            //Creamos un string a partir del arreglo de caracteres 
            string fraseCifrada = new(arregloFrase);

            Console.WriteLine($"La frase cifrada es {fraseCifrada}");
        }
    }
}
