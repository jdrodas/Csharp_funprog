/*
Programa:       PagoImpuestos
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
    Utilizando condicionales, ciclos de control y control de excepciones, realice un programa que lea
	el valor del salario de un empleado y diga si debe pagar impuestos o no.
    Se considera que si debe pagar impuestos si el empleado gana más de $900.000.

 */

using System;

namespace PagoImpuestos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para identificar si un empleado debe pagar impuestos");
            Console.WriteLine("Si el salario es superior a $900.000, debe pagar impuestos.\n\n");

            //Constantes a utilizar
            const float salarioBase = 900000;

            //declaramos las variables a utilizar
            float salarioEmpleado = 0;
            bool datoCorrecto = false;

            while (datoCorrecto == false)
            {
                try
                {
                    Console.Write($"Ingresa el valor del salario: ");
                    salarioEmpleado = float.Parse(Console.ReadLine());
                    if (salarioEmpleado >= 0)
                    {
                        datoCorrecto = true;
                    }
                    else
                    {
                        Console.WriteLine("El salario debe ser un valor numerico positivo. Intenta nuevamente.\n\n");
                    }
                }
                catch (FormatException elError)
                {
                    Console.WriteLine("El dato ingresado debe ser numérico. Intenta nuevamente.");
                    Console.WriteLine($"{elError.Message}\n\n");
                }
            }

            //Finalmente comparamos el salario ingresado con el salario base
            if (salarioEmpleado > salarioBase)
            {
                Console.WriteLine($"El salario de {salarioEmpleado} supera el límite de {salarioBase}. Debe pagar impuestos!");
            }
            else
            {
                Console.WriteLine($"El salario de {salarioEmpleado} NO supera el límite de {salarioBase}. NO paga impuestos!");
            }
        }
    }
}
