/*
Programa:       NumerosAmigos
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Identificar si dos números enteros positivos son amigos

Dos números amigos son dos números enteros positivos a y b tales que la suma de los 
divisores propios de uno es igual al otro número y viceversa

https://es.wikipedia.org/wiki/N%C3%BAmeros_amigos

Ejemplos : 220 y 284
           17296 y 18416
           9363584 y 9437056

 */

namespace NumerosAmigos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para identificar si dos numeros enteros son amigos\n");

            bool esCorrecto = false, correctoA = false, correctoB = false;
            long numeroA = 0, numeroB = 0;

            //Repetimos el ciclo hasta que los datos sean correctos
            while (!esCorrecto)
            {
                try
                {
                    Console.Write("Ingresa para A, un numero entero positivo: ");
                    numeroA = long.Parse(Console.ReadLine()!);

                    Console.Write("Ingresa para B, un numero entero positivo: ");
                    numeroB = long.Parse(Console.ReadLine()!);

                    //Validamos si A está en el rango correcto
                    if (numeroA > 0)
                        correctoA = true;
                    else
                        Console.WriteLine("El dato para A no es un entero positivo. Intenta nuevamente! \n");

                    //Validamos si B está en el rango correcto
                    if (numeroB > 0)
                        correctoB = true;
                    else
                        Console.WriteLine("El dato para B no es un entero positivo de hasta 5 cifras. Intenta nuevamente! \n");

                    //Si ambos son correctos, podemos continuar
                    if (correctoA && correctoB)
                        esCorrecto = true;
                }
                catch (FormatException error)
                {
                    Console.WriteLine("El dato ingresado no está en el formato requerido. Intenta nuevamente!");
                    Console.WriteLine("Error: " + error.Message + "\n");
                }
            }

            //Una vez ingresados los datos correctos, validamos la suma de sus divisores

            long sumaDivisoresA = 0, sumaDivisoresB = 0;
            int divisor;

            //Encontramos la suma de divisores para A
            for (divisor = 1; divisor < numeroA; divisor++)
            {
                //verificamos si es divisor
                if (numeroA % divisor == 0)
                    sumaDivisoresA += divisor;
            }

            //Encontramos la suma de divisores para B
            for (divisor = 1; divisor < numeroB; divisor++)
            {
                //verificamos si es divisor
                if (numeroB % divisor == 0)
                    sumaDivisoresB += divisor;
            }

            //Finalmente comparamos los resultados e indicamos si son amigos.
            if (numeroA == sumaDivisoresB && numeroB == sumaDivisoresA)
                Console.WriteLine($"Los numeros {numeroA} y {numeroB} son amigos!");
            else
                Console.WriteLine($"Los numeros {numeroA} y {numeroB} NO son amigos!");

            Console.WriteLine($"La suma de los divisores de {numeroA} es {sumaDivisoresA}");
            Console.WriteLine($"La suma de los divisores de {numeroB} es {sumaDivisoresB}");
        }
    }
}
