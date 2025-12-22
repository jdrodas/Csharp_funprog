/*
Programa:       NumerosDeficientes
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Identificar si los números enteros positivos hasta 50 son deficientes o abundantes

Un número defectivo o deficiente es un número natural que es mayor que la suma de sus 
divisores propios exceptuándose a sí mismo.

Todos los números primos son defectivos,1​ y también lo son las potencias de los números 
primos y los divisores propios de los números defectivos y perfectos. Si la suma de sus 
divisores propios es mayor, entonces se considera al número como abundante.

https://es.wikipedia.org/wiki/N%C3%BAmero_defectivo

 */

namespace NumerosDeficientes
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Programa para identificar los números positivos hasta 50 son deficientes o abundantes ");

            int divisor, sumaDivisores;

            for (int numero = 1; numero <= 50; numero++)
            {
                //Para cada ciclo se reinicia la suma de divisores
                sumaDivisores = 0;

                Console.Write($"El número {numero} es ");

                //Aqui hallamos la suma de sus divisores

                for (divisor = 1; divisor < numero; divisor++)
                {
                    //verificamos si es divisor
                    if (numero % divisor == 0)
                        sumaDivisores += divisor;
                }

                //Aqui validamos si la suma de los divisores es menor que el numero
                if (sumaDivisores < numero)
                    Console.WriteLine("Deficiente!");
                else
                    Console.WriteLine("Abundante!");
            }
        }
    }
}