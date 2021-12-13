/*
Programa:       EjemploCondicionales
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
Demostrar el funcionamiento de los condicionales utilizando operadores
relacionales, operadores de igualdad y operadores lógicos

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
 */


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
            //Es posible que Console.ReadLine() devuelva valor nulo, por eso el compilador da advertencia
            //Tarea: Como prevenir/corregir esta advertencia sin cambiar configuracion del compilador?
            string nacion = Console.ReadLine().ToUpper(); // ToUpper: Lo colocamos en mayúsculas

            //Condicional básico para validar si es mayor a 18 años
            if (edad > 18 || edad == 18)
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
