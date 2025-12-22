/*
Programa:       ClasificaTriangulos
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com
Propósito:
----------
   Utilizando condicionales, ciclos de control y control de excepciones, realice un programa que lea
   los valores de los tres lados de un triangulo y determine su clasificación:
   - Equilatero: Los tres lados son iguales
   - Isóceles: Dos lados son iguales
   - Escaleno: Los tres lados son diferentes   
*/

using System;

namespace ClasificaTriangulos
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Programa para clasificar un triángulo según la longitud de sus lados");
            Console.WriteLine("Los triangulos pueden ser equilateros, isoceles y escalenos\n\n");

            //Declaramos las variables a utilizar
            uint lado1 = 0, lado2 = 0, lado3 = 0;
            bool datoCorrecto;

            /*
            Nota de JuanD:
            La versión increiblemente simplificada asume que todos los datos se ingresarán correctamente,
            es decir, números mayores que cero.

            En la vida real esto no pasa, por lo que es necesario establecer los controles necesarios para
            "blindar" el funcionamiento a pesar de posibles errores del usuario.

            En esta etapa de formación todavía no podemos usar estructuras de datos como arreglos, por lo
            que tendremos mucho código "repetido". Cuando estemos más avanzados (dos semanas) veremos como
            solucionarlo mejor.
             */

            //Para el primer lado
            datoCorrecto = false;
            while (datoCorrecto == false)
            {
                try
                {
                    Console.Write("\nIngresa el valor para el primer lado: ");
                    lado1 = uint.Parse(Console.ReadLine()!);
                    datoCorrecto = true;
                }
                catch (FormatException elError)
                {
                    Console.WriteLine("El dato ingresado debe ser numérico. Intenta nuevamente.");
                    Console.WriteLine($"{elError.Message}\n");
                }
                catch (OverflowException rangoErroneo)
                {
                    Console.WriteLine("El dato ingresado debe ser entero positivo. Intenta nuevamente.");
                    Console.WriteLine($"{rangoErroneo.Message}\n");
                }
            }

            //Para el segundo lado
            datoCorrecto = false;
            while (datoCorrecto == false)
            {
                try
                {
                    Console.Write("\nIngresa el valor para el segundo lado: ");
                    lado2 = uint.Parse(Console.ReadLine()!);
                    datoCorrecto = true;
                }
                catch (FormatException elError)
                {
                    Console.WriteLine("El dato ingresado debe ser numérico. Intenta nuevamente.");
                    Console.WriteLine($"{elError.Message}\n");
                }
                catch (OverflowException rangoErroneo)
                {
                    Console.WriteLine("El dato ingresado debe ser entero positivo. Intenta nuevamente.");
                    Console.WriteLine($"{rangoErroneo.Message}\n");
                }
            }

            //Para el tercer lado
            datoCorrecto = false;
            while (datoCorrecto == false)
            {
                try
                {
                    Console.Write("\nIngresa el valor para el tercer lado: ");
                    lado3 = uint.Parse(Console.ReadLine()!);
                    datoCorrecto = true;
                }
                catch (FormatException elError)
                {
                    Console.WriteLine("El dato ingresado debe ser numérico. Intenta nuevamente.");
                    Console.WriteLine($"{elError.Message}\n");
                }
                catch (OverflowException rangoErroneo)
                {
                    Console.WriteLine("El dato ingresado debe ser entero positivo. Intenta nuevamente.");
                    Console.WriteLine($"{rangoErroneo.Message}\n");
                }
            }

            //Visualizamos resultados
            Console.WriteLine($"\n\nLos valores para los lados son: lado1: {lado1}, lado2: {lado2}, lado3: {lado3}");

            //Aqui evaluamos si es equilatero
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("El triángulo es EQUILÁTERO porque todos sus lados son iguales!");
            }
            else
            {
                //Evaluamos aqui si es isóceles, dos de sus lados son iguales
                if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1)
                {
                    Console.WriteLine("El triángulo es ISÓCELES porque dos de lados son iguales!");
                }
                else
                {
                    // De lo contrario, es escaleno
                    Console.WriteLine("El triángulo es ESCALENO porque todos sus lados son diferentes!");
                }
            }
        }
    }
}