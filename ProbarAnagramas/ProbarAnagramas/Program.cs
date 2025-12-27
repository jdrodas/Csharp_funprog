/*
Programa:       ProbarAnagramas
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Implementar una validación básica de anagramas utilizando arreglos

*/

namespace ProbarAnagramas
{
    public class Program
    {
        static public void Main()
        {
            Console.WriteLine("Programa probar que dos cadenas de caracteres son anagramas");

            Console.Write("Ingresa la primera frase: ");
            string primeraFrase = Console.ReadLine()!;

            Console.Write("Ingresa la segunda frase: ");
            string segundaFrase = Console.ReadLine()!;

            Console.WriteLine($"\nLas frases ingresadas son: \n{primeraFrase} \n{segundaFrase}\n");

            //Procesamos las cadenas
            char[] primerArreglo = primeraFrase
                .ToLower()
                .Where(caracter => !char.IsWhiteSpace(caracter))
                .ToArray();

            char[] segundoArreglo = segundaFrase
                .ToLower()
                .Where(caracter => !char.IsWhiteSpace(caracter))
                .ToArray();

            if (primerArreglo.Length != segundoArreglo.Length)
            {
                Console.WriteLine("Las frases no tienen la misma cantidad de caracteres. No son anagramas");
            }
            else
            {
                Array.Sort(primerArreglo);
                Array.Sort(segundoArreglo);
                bool sonAnagramas = true;

                for (int i = 0; i < primerArreglo.Length; i++)
                {
                    if (primerArreglo[i] != segundoArreglo[i])
                    {
                        Console.WriteLine("Las frases no tienen las mismas letras. No son anagramas");
                        sonAnagramas = false;
                        break;
                    }
                }

                if (sonAnagramas)
                    Console.WriteLine("Las dos frases son anagramas");
            }
        }
    }
}