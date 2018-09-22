/*
Programa:       MatricesZoo
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com


Propósito:
----------
- Demostrar los conceptos básicos de clase, objeto, encapsulación, métodos
- Crear un arreglo de objetos, asignando y leyendo información para cada atributo
 
 */

using System;

namespace EjemploObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para demostrar la utilización de objetos");
            Console.WriteLine("Usando un arreglo de 5 objetos tipo persona");

            //el arreglo a utilizar
            Persona[] gentio = new Persona[5];

            //Pilas: inicialice cada posición del arreglo con una instancia de la clase
            //Aqui se evita el NullReferenceException al intentar usar una instancia no inicializada
            for (int i = 0; i < gentio.Length; i++)
                gentio[i] = new Persona();

            int totalPersonas = 0; // variable de control para el ciclo

            while (totalPersonas < gentio.Length)
            {
                try
                {
                    Console.WriteLine("\nInformación de la persona No. {0}", totalPersonas + 1);

                    Console.Write("Cual es el nombre? ");
                    gentio[totalPersonas].Nombre = Console.ReadLine();

                    Console.Write("Cual es la edad? ");
                    gentio[totalPersonas].Edad = int.Parse(Console.ReadLine());

                    Console.Write("Cual es el telefono? ");
                    gentio[totalPersonas].Telefono = int.Parse(Console.ReadLine());

                    //Si todo está ok, se pasa a la siguiente persona
                    totalPersonas++;
                }
                catch (FormatException error)
                {
                    Console.WriteLine("Ingresaste un dato no numérico para el teléfono o la edad. Intenta nuevamente!");
                    Console.WriteLine("Error: {0} \n\n", error.Message);
                }
            }

            //aqui visualizamos los resultados
            Console.WriteLine("\n\nInformación de las personas");

            for (int i = 0; i < gentio.Length; i++)
            {
                Console.WriteLine("Persona No {0}, nombre: {1}, edad: {2} telefono: {3}",
                    (i+1), // contando como humanos
                    gentio[i].Nombre,
                    gentio[i].Edad,
                    gentio[i].Telefono);
            }
        }
    }
}


/*
-- codigo previo ya no requerido.

-- utilización tradicional de variables
string nombre;
int edad, telefono;

Console.Write("Cual es tu nombre? ");
nombre = Console.ReadLine();

Console.Write("Cual es tu edad? ");
edad = int.Parse(Console.ReadLine());

Console.Write("Cual es tu telefono? ");
telefono = int.Parse(Console.ReadLine());

Console.WriteLine("Tu nombre es {0}, tu edad es {1} y tu telefono es {2}",
    nombre, edad, telefono);

-- utilización utilizando un objeto tipo Persona
    
Persona fulanito = new Persona();

Console.Write("Cual es tu nombre? ");
//fulanito.SetNombre(Console.ReadLine());       // utilizando el método SetNombre
fulanito.Nombre = Console.ReadLine();           // utilizando la propiedad Nombre

Console.Write("Cual es tu edad? ");
//fulanito.SetEdad(int.Parse(Console.ReadLine()));
fulanito.Edad = int.Parse(Console.ReadLine());

Console.Write("Cual es tu telefono? ");
//fulanito.SetTelefono(int.Parse(Console.ReadLine()));
fulanito.Telefono = int.Parse(Console.ReadLine());

-- Visualizando la información de los atributos, utilizando los metodos Get
Console.WriteLine("Tu nombre es {0}, tu edad es {1} y tu telefono es {2}",
fulanito.GetNombre(), 
fulanito.GetEdad(), 
fulanito.GetTelefono());

-- Visualizando la información de los atributos, utilizando las propiedades
Console.WriteLine("Tu nombre es {0}, tu edad es {1} y tu telefono es {2}",
fulanito.Nombre,
fulanito.Edad,
fulanito.Telefono);

*/