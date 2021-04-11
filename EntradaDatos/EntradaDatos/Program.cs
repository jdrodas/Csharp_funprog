/*
Programa:       EntradaDatos
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
Demostrar el funcionamiento básico de la captura de datos desde la consola, utilizando
el método ReadLine().

Demostrar el cambio de tipo de datos desde string hasta int y float, utilizando los métodos
float.Parse() y Convert.ToInt32()

Demostrar la prevención básica de errores por ingreso de datos equivocados utilizando
el control de excepciones con las instrucciones try - catch
 
 */

using System;

namespace EntradaDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para leer y escribir en la consola\n\n");

            //Aqui se declara una variable para almacenar el dato de nombre
            string nombre;

            Console.Write("¿Cuál es tu nombre? ");
            nombre = Console.ReadLine();

            //Para el apellido, se puede también asignar al momento de la declaración
            Console.Write("¿Cuál es tu apellido? ");
            string apellido = Console.ReadLine();

            //El contenido se puede visualizar con WriteLine
            Console.WriteLine($"Mucho gusto conocerte, {nombre} {apellido}.");

            //Para datos tipo entero, se debe hacer conversión de string a entero
            //Se debe controlar el error por posibles datos erroneamente ingresados

            try
            {
                int edad;
                Console.Write("¿Cuál es tu edad? ");
                edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Me contaste que tu edad era: {0}", edad);
            }
            catch (FormatException error)
            {
                Console.WriteLine("¡Ingresaste un dato que no puede convertirse a entero!");
                Console.WriteLine("Error: " + error.Message + "\n\n");
            }

            //Para datos tipo float, se debe hacer conversión de string a float
            //Se debe controlar el error por posibles datos erroneamente ingresados

            try
            {
                float estatura;
                Console.Write("¿Cuál es tu estatura en metros? ");

                //Colocar el tipo de datos entre parentesis se llama "hacer cast"
                //estatura = (float)Convert.ToDouble(Console.ReadLine()); 

                // Float es un alias para Single, para convertirlo usamos ToSingle
                estatura = Convert.ToSingle(Console.ReadLine());
                //estatura = float.Parse(Console.ReadLine());
                Console.WriteLine($"Dijiste que tu estatura es de {estatura.ToString("0.00")}");
            }
            catch (FormatException error)
            {
                Console.WriteLine("¡Ingresaste un dato que no puede convertirse a float!\n\n");
                Console.WriteLine($"Error: {error.Message}\n\n");
            }
        }
    }
}