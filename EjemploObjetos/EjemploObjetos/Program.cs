/*
Programa:       EjemploObjetos
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Demostrar los conceptos básicos de clase, objeto, encapsulación, métodos
- Crear un arreglo de objetos, asignando y leyendo información para cada atributo
 
 */

using System;

namespace EjemploObjetos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para leer la información de personas");

            int cantidadPersonas = 3;
            Persona[] lasPersonas = new Persona[cantidadPersonas];

            int i = 0;
            while (i < cantidadPersonas)
            {
                try
                {
                    //Inicializamos cada posición del arreglo utilizando el constructor
                    lasPersonas[i] = new Persona();
                    
                    Console.Write($"\nCual es tu nombre, persona {(i + 1)}? ");
                    lasPersonas[i].Nombre = Console.ReadLine()!;
                    Console.Write("Cual es tu edad? ");
                    lasPersonas[i].Edad = int.Parse(Console.ReadLine()!);
                    Console.Write("Cual es tu telefono? ");
                    lasPersonas[i].Telefono = long.Parse(Console.ReadLine()!);
                    Console.Write("Cual es tu estatura? ");
                    lasPersonas[i].Estatura = float.Parse(Console.ReadLine()!);

                    i++;  //Clausula de salida... la que hace que el condicional eventualemente termine
                }
                catch (FormatException unError)
                {
                    Console.WriteLine("El dato ingresado no es numérico. Intenta nuevamente");
                    Console.WriteLine(unError.Message);
                }
            }

            //Aqui visualizamos la información ingresada
            VisualizaInformacion(lasPersonas);
        }

        static void VisualizaInformacion(Persona[] lasPersonas)
        {
            Console.WriteLine("\n Los datos de las personas son: ");

            for (int i = 0; i < lasPersonas.Length; i++)
            {
                Console.WriteLine($"\nLos datos ingresados para la persona {(i + 1)} fueron:");
                Console.WriteLine($"Nombre: {lasPersonas[i].Nombre}, edad: {lasPersonas[i].Edad}, \n" +
                    $"telefono: {lasPersonas[i].Telefono}, estatura: {lasPersonas[i].Estatura}");
            }
        }
    }
}