/*
Programa:       EjemploCondicionales
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
Demostrar el funcionamiento de los condicionales utilizando operadores
relacionales, operadores de igualdad, operadores lógicos y operadores de nulidad

Operadores de igualdad:
==     es igual
!=     es diferente

Operadores relacionales:
>      mayor
<      menor
>=     mayor o igual
<=     menor o igual

Operadores lógicos:
&&      operador lógico Y
||      operador lógico O

Operadores de nulidad:
?       Permite indicar al compilador que el valor puede ser nulo
        Se coloca después del tipo de datos al momento de la declaración de la variable

!       Permite indicar al compilador que sabemos que el valor NO SERÁ nulo
        Se coloca despues de la variable y antes de cualquier otra operación

 */

using System;

namespace EjemploCondicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            // \n lo utilizo para dar saltos de línea adicionales

            Console.WriteLine("Ejemplo de utilización de condicionales\n");
            Console.Write("Ingresa por favor tu edad: ");

            //int edad = int.Parse(Console.ReadLine());
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nCual es tu país de nacimiento? ");
            
            // A partir de .NET 5, se hace necesario hacer explicito el manejo de nulos
            // El operador "?" nos permite indicar que este valor puede ser nulo
            // El operador "!" nos permite que sabemos que este valor NO SERÁ nulo
            //string? nacion = Console.ReadLine()!.ToUpper(); // ToUpper: Lo colocamos en mayúsculas

            //En .NET Framework 4.x lo hacemos así:
            string nacion = Console.ReadLine().ToUpper();

            //Condicional básico para validar si es mayor a 18 años
            if (edad >= 18)
            {
                Console.WriteLine("Tu edad es mayor o igual a 18 años, puedes ser considerado como ciudadano.");
            }
            else
            {
                Console.WriteLine("Tu edad es menor a 18 años, todavía no eres ciudadano.");
            }

            //Cuando es una sola línea, se puede obviar las llaves.
            //Se puede utilizar operadores lógicos para combinar varias condiciones
            if (edad > 18 || edad == 18)
                Console.WriteLine("Ya eres considerado un adulto.");
            else
                Console.WriteLine("Todavía no eres considerado un adulto.");

            //Se pueden combinar diferentes condiciones
            //Se puede tener solo con la parte asociada a la evaluación verdadera del condicional 
            if (edad >= 18 && nacion == "COLOMBIA")
                Console.WriteLine("Eres mayor de edad en Colombia, puedes participar en votaciones!");

            //Se puede preguntar si una variable es diferente a un valor
            if (nacion != "COLOMBIA")
                Console.WriteLine("En Colombia eres considerado extranjero.");
        }
    }
}
