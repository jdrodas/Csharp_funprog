/*
Programa:       CalificacionesPromedio
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
    Utilizando condicionales, ciclos de control y control de excepciones, realice un programa que lea
    5 calificaciones numéricas entre 0 y 5, calcule su promedio y finalmente que indique si aprobó o no.
    Se considera aprobación del semestre cuando el promedio sea mayor o igual a 3.00.

Adicionalmente:
    Identificar la cultura utilizada así como el separador decimal.

 */

using System;
using System.Globalization;

namespace CalificacionesPromedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para calcular el promedio de 5 calificaciones");
            Console.WriteLine("Si el promedio es mayor o igual de 3.00, se considera que aprobó.");
            Console.WriteLine("El valor de cada nota debe estar entre 0 y 5.");

            //Aqui declaramos un objeto de tipo CultureInfo - Información Regional
            CultureInfo miCultura = CultureInfo.CurrentCulture;

            Console.WriteLine($"\nLa configuración regional actual es {miCultura.Name}");
            Console.WriteLine($"El separador de decimales es \"{miCultura.NumberFormat.NumberDecimalSeparator}\"\n\n");

            //Constantes a utilizar
            const int cantidadNotas = 5;

            //Variables a utilizar:            
            int notaActual = 1; // Contador de notas
            float nota = 0, promedio = 0;  // Variables para leer la nota y almacenar el promedio
            bool datoCorrecto; // Variable booleana para saber si el dato ingresado es correcto

            while (notaActual <= cantidadNotas)
            {
                datoCorrecto = false; // Para cada numero, se asume que fue ingresado erróneament.
                while (datoCorrecto == false)
                {
                    try
                    {
                        Console.Write($"Ingresa el valor de la nota No. {notaActual}: ");
                        nota = float.Parse(Console.ReadLine()!);
                        if (nota >= 0 && nota <= 5.00)
                        {
                            datoCorrecto = true;
                        }
                        else
                        {
                            Console.WriteLine("La nota debe ser un valor numérico entre 0 y 5. Intenta nuevamente.\n\n");
                        }
                    }
                    catch (FormatException elError)
                    {
                        Console.WriteLine("El dato ingresado debe ser numérico. Intenta nuevamente.");
                        Console.WriteLine($"{elError.Message}\n\n");
                    }
                }

                notaActual++;
                promedio += nota;
            }

            // Terminado el ingreso de datos, se calcula el promedio
            promedio /= cantidadNotas; //Utilizamos la asignación compuesta: Dividimos lo que había en promedio con la cantidad de notas

            //Visualizamos los resultados
            Console.Write($"\n\nEl promedio de las 5 notas es {promedio}. ");

            //Evaluamos si aprobó o no el semestre
            if (promedio >= 3)
            {
                Console.WriteLine("El estudiante ha ganado el semestre");
            }
            else
            {
                Console.WriteLine("El estudiante ha perdido el semestre");
            }
        }
    }
}
