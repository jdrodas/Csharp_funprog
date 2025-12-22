/*
Programa:       HolaMundo
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Demostrar el funcionamiento básico del Entorno Integrado de Desarrollo (IDE), realizando
  las actividades de edición de código, compilación, depuración y ejecución de la aplicación.

- Visualizar información en la consola, en forma de cadena de caracteres.

- Declarar variables tipo string y visualizar su contenido en la consola.

- Demostrar el funcionamiento de los métodos WriteLine y Write de la clase Console.
 */

using System;

namespace HolaMundo
{
    class Program
    {
        static void Main()
        {
            //Comenzamos con la forma más básica de colocar información en consola.
            //Utilizamos el método WriteLine de la clase Console.
            //Escribe una cadena de caracteres, delimitada por las comillas dobles (")
            Console.WriteLine("Hola Mundo!");

            //Esto mismo se puede lograr con el método Write más el caracter especial \n
            // \n corresponde al salto de línea - tecla Intro/Retorno
            Console.Write("Hola Mundo!\n");

            //Una invocacion a WriteLine sin argumentos, hace un salto de línea solamente
            Console.WriteLine();

            //Aqui declaramos una variable tipo string
            string unaFrase;

            //Aqui le asignamos el valor inicial
            unaFrase = "Esta es una frase";

            //Aqui declaramos y asignamos en una sola sentencia
            string otraFrase = "Esta es otra frase";

            //aqui visualizamos las frases, una por línea
            Console.WriteLine(unaFrase);
            Console.WriteLine(otraFrase);

            //Una invocación a Write con solo el caracter especial \n 
            //genera un salto de línea
            Console.Write("\n");

            //Aqui podemos visualizar concatenando las frases con el operador + y
            //el caracter especial \n para el salto de línea
            Console.WriteLine(unaFrase + "\n" + otraFrase + "\n");

            //Aqui podemos visualizar utilizando "Place Holders" y 
            //el caracter especial \n para el salto de línea
            Console.WriteLine("{0}\n{1}\n", unaFrase, otraFrase);

            //En versiones de C# 6.0 o superior, se puede utilizar otro tipo de 
            //place holders que hacen referencia directamente a la variable
            //Se identifican porque la cadena comienza con el símbolo $
            Console.WriteLine($"{unaFrase}\n{otraFrase}\n");
        }
    }
}