/*
Programa:       EjemploCiclosControl
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
Demostrar el funcionamiento de los principales ciclos de control implementando una sumatoria.

Ciclos de control:

- while
- do while
- for
 */

namespace EjemploCiclosControl
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Elementos importantes de un ciclo de control:
             - Variable de control con valor inicial que permite ejecutar el ciclo
             - Condición que se evaluará y permitirá ejecutar el ciclo mientras sea TRUE
             - Sentencia de salida que permite que el condicional sea FALSE y termine
            */

            Console.WriteLine("Suma de los numeros naturales hasta un límite especificado");

            bool esLimiteCorrecto = false; // Variable de control -- Variables tipo Bandera (flag)
            uint limite = 0;

            while (esLimiteCorrecto == false) //condición a evaluar
            {
                // Implementamos control de excepciones para evitar errores por formato o desbordamiento de rango
                try
                {
                    Console.Write("\nIngresa el número límite: ");
                    //Utilizamos el operador "!" para indicarle al compilador que sabemos que la variable NO SERÁ nula.
                    limite = uint.Parse(Console.ReadLine()!);

                    //Si el número es mayor que 0, el valor es correcto
                    if (limite > 0)
                        esLimiteCorrecto = true; //Condición de salida - Clausula de escape
                    else
                        Console.WriteLine("El valor del límite debe ser un entero > 0. Intenta nuevamente!");
                }
                catch (FormatException errorFormato)
                {
                    Console.WriteLine("El dato ingresado no se puede considerar como numero natural (entero > 0).");
                    Console.WriteLine($"Mensaje del error: {errorFormato.Message}");
                }
                catch (OverflowException errorRango)
                {
                    Console.WriteLine("El dato ingresado debe estar en el rango de los numeros naturales ( entero > 0).");
                    Console.WriteLine($"Mensaje del error: {errorRango.Message}");
                }
            }

            // Se inicializan las variables para otro ciclo
            int numero = 1; // variable de control con su valor inicial
            int suma = 0;

            // Implementación utilizando el ciclo while:
            while (numero <= limite) //Condicion a evaluar
            {
                suma = suma + numero; // acumulación
                numero = numero + 1; // contador -- sentencia de salida
            }

            Console.WriteLine($"\nUsando el ciclo while, la suma de los números naturales hasta {limite} es {suma}");

            // Se inicializan las variables para otro ciclo
            suma = 0;       // Se reinicia la acumulación del resultado
            numero = 1;     // Se reinicia la variable de control del ciclo

            //Implementación utilizando el ciclo do - while
            //Como la condición está al final del ciclo de instrucciones, se ejecutará al menos una vez, sea verdadero o falso

            do
            {
                suma += numero;      // otra forma de acumulación
                numero += 1;        //  otra forma de incrementar el contador -- sentencia de salida
            }
            while (numero <= limite);

            Console.WriteLine($"\nUsando el ciclo do - while, la suma de los números naturales hasta {limite} es {suma}");


            // Se inicializan las variables para otro ciclo
            suma = 0;       // Se reinicia la acumulación del resultado

            //Implementación utilizando el ciclo for
            for (numero = 1; numero <= limite; numero++)
            {
                suma += numero;
            }

            Console.WriteLine($"\nUsando el ciclo for, la suma de los números naturales hasta {limite} es {suma}");
        }
    }
}
