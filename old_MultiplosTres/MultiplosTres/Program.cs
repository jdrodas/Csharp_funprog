/*
Programa:       MultiplosTres
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
Demostrar el funcionamiento de los principales ciclos de control implementando una aplicación
que visualice los múltiplos de tres hasta un número límite.

Ciclos de control:

- while
- do while
- for

 */

namespace MultiplosTres
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Programa que visualiza los múltiplos de tres hasta un número límite\n");

            Console.Write("Ingresa el valor límite: ");
            int limite = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nCon el ciclo for, los múltiplos de tres hasta el número {0} son:", limite);

            // declaramos una variable i que será el control del ciclo
            int i;

            // Implementando con el ciclo for
            // simplificando el exceso de {} por ser bloques de una sentencia
            for (i = 1; i <= limite; i++)
                if ((i % 3) == 0)   //Residuo de la división por tres es cero, entonces es múltiplo de tres
                    Console.WriteLine("{0} es múltiplo de 3!", i);

            Console.WriteLine("\nCon el ciclo while, los múltiplos de tres hasta el número {0} son:", limite);

            // Implementando con el ciclo while
            // Inicializamos la variable de control del ciclo
            i = 1;

            // simplificando el exceso de {} por ser bloques de una sentencia
            while (i <= limite)
            {
                if ((i % 3) == 0)   //Residuo de la división por tres es cero, entonces es múltiplo de tres
                    Console.WriteLine("{0} es múltiplo de 3!", i);

                ++i; // Incremento en el contador -- ¿Cuál es el efecto?
            }

            Console.WriteLine("\nCon el ciclo do - while, los múltiplos de tres hasta el número {0} son:", limite);

            // Implementando con el ciclo do - while
            // Inicializamos la variable de control del ciclo
            i = 1;

            // simplificando el exceso de {} por ser bloques de una sentencia
            do
            {
                if ((i % 3) == 0)   //Residuo de la división por tres es cero, entonces es múltiplo de tres
                    Console.WriteLine("{0} es múltiplo de 3!", i);

                i++;    // Incremento en el contador -- ¿Cuál es el efecto?
            }
            while (i <= limite);

        }
    }
}
