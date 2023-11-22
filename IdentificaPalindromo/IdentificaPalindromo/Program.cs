/*
Programa:       IdentificaPalindromo
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------

- Demostrar el funcionamiento básico de los arreglos
- Convertir cadena de caracteres a un arreglo de caracteres
- Convertir un arreglo de caracteres a una cadena de caracteres
- Implementar una función que remueva los espacios de una cadena de caracteres 

 */

using System;

namespace IdentificaPalindromo
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Programa para indetificar si una frase es palíndromo");
            Console.WriteLine("Palíndromo es que se lee igual en cualquier sentido\n");

            Console.Write("Ingresa una frase: ");
            string frase = Console.ReadLine()!.ToUpper();

            bool resultadoValidacion = ValidaPalindromo(frase);

            if (resultadoValidacion)
                Console.WriteLine("La frase ES un palíndromo");
            else
                Console.WriteLine("La frase NO ES un palíndromo");
        }

        /// <summary>
        /// Valida si una frase es palíndromo
        /// </summary>
        /// <param name="dato">la frase a validar</param>
        /// <returns>El resultado de la validación</returns>
        static bool ValidaPalindromo(string dato)
        {
            bool resultado = false;
            char[] arregloFrase = ObtieneFraseSinEspacios(dato);
            char[] arregloFraseInvertida = new char[arregloFrase.Length];

            int posicion = 0;
            for (int i = arregloFrase.Length - 1; i >= 0; i--)
            {
                arregloFraseInvertida[posicion] = arregloFrase[i];
                posicion++;
            }

            string fraseOriginal = new(arregloFrase);
            string frasePalindromo = new(arregloFraseInvertida);

            //Si la frase invertida es igual a la frase original, es un palíndromo
            if (frasePalindromo == fraseOriginal)
                resultado = true;

            return resultado;
        }

        /// <summary>
        /// Remueve los espacios de la frase
        /// </summary>
        /// <param name="frase">frase a procesar</param>
        /// <returns>arreglo de caracteres con la frase sin espacios</returns>
        static char[] ObtieneFraseSinEspacios(string frase)
        {
            char[] arregloFrase = frase.ToCharArray();
            int contadorEspacios = 0;

            //Aqui contamos los espacios de la frase original
            foreach (char letra in arregloFrase)
                if (letra == ' ')
                    contadorEspacios++;

            //Aqui declaramos un arreglo de caracteres con un tamaño menor
            //Que no incluira los espacios
            char[] fraseSinEspacios = new char[frase.Length - contadorEspacios];

            int j = 0;
            for (int i = 0; i < arregloFrase.Length; i++)
            {
                if (arregloFrase[i] != ' ')
                {
                    fraseSinEspacios[j] = arregloFrase[i];
                    j++;
                }
            }

            return fraseSinEspacios;
        }
    }
}
