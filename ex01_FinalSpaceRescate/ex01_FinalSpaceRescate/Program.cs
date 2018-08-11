/*
Programa:       ex01_FinalSpaceRescate
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
Examen 01: Condicionales y Ciclos de control


Final Space – Rescate de Mooncake
*********************************

Con el propósito de llevar a cabo su maléfico plan, Lord Commander ha secuestrado a Mooncake para utilizar sus poderes 
y así abrir el portal a la dimensión del Final Space. Gary comprende las implicaciones de esta situación, no solo para 
el planeta Tierra sino para la vida de su apreciado amigo.

Con la ayuda de los S.A.M.E.S., androides que están en la capacidad de realizar las tareas más peligrosas, Gary planea 
un rescate en la nave de Lord Commander. Estando allí encuentra que la máquina que aprisiona Mooncake puede desactivarse 
si de manera simultánea se ingresa códigos numéricos en varias terminales.

El algoritmo de desactivación de la máquina es muy simple: En una pantalla aparece un número entero “Maestro” entre 
3 y 30. Para desactivar, en cada terminal se debe ingresar los números enteros “Componentes” de un dígito que sumándose 
generan dicho número, sin repetirse entre ellos.

Algunos ejemplos:
8	=   5 + 2 + 1
13	=   9 + 4
27	=   8 + 7 + 5 + 4 + 3

Cada número maestro puede utilizar diferentes combinaciones de números componentes que pueden variar en cantidad de 
números. No importa cual combinación se utilice, lo importante es que no tengan dígitos repetidos.

Ejemplo inválido:
9	=   3 + 3 + 2 + 1

Realice un programa en C# - Aplicación de Consola, en la que se pida un número entero entre 3 y 30 y se devuelva como 
resultado los números enteros componentes que sumados entre si generan dicho número. El programa debe indicar cuantos 
S.A.M.E.S. se requieren para liberar a Mooncake, teniendo presente que cada androide digitará un solo número componente.

*/

using System;

namespace ex01_FinalSpaceRescate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Final Space – Rescate de Mooncake");
            Console.WriteLine("Obtener los sumandos de un número entero");

            bool datoCorrecto = false;
            int numeroMaestro = 0;

            //Aqui validamos que el dato ingresado sea correcto
            while (datoCorrecto == false)
            {
                Console.Write("\nIngresa el número entero maestro entre 3 y 30: ");
                try
                {
                    numeroMaestro = int.Parse(Console.ReadLine());
                    if (numeroMaestro >= 3 && numeroMaestro <= 30)
                        datoCorrecto = true;
                    else
                        Console.WriteLine("El número no está en el rango. Intenta nuevamente!");
                }
                catch (FormatException error)
                {
                    Console.WriteLine("Ingresaste erróneamente un dato no numérico. Intenta nuevamente!");
                }
            }

            int suma = 0;
            int numeroComponente = 9;
            int totalSames = 0;

            Console.WriteLine("\nNúmeros componentes:");

            // este ciclo se repite hasta que la suma llegue al valor del número maestro
            while (suma < numeroMaestro)
            {
                if ((numeroComponente + suma) <= numeroMaestro)
                {
                    suma += numeroComponente;
                    Console.WriteLine("Componente: {0}, la suma va en {1}", numeroComponente, suma);

                    totalSames++;
                }

                numeroComponente--;
            }

            Console.WriteLine("\nSe necesitaron {0} S.A.M.E.S. para liberar a Mooncake", totalSames);
        }
    }
}