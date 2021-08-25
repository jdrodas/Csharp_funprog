/*
Programa:       AdivinaAleatorio
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Programa para adivinar un numero entero aleatorio en el rango entre 1 y 100. 
- Se utiliza control de excepciones para evitar ingresar un dato no numérico.
- Se coloca un condicional para validar que el número se encuentre en el rango.

 */

using System;

namespace AdivinaAleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para adivinar un número aleatorio entre 1 y 100");

            /*
             1. Generar un numero aleatorio entre 1 y 100 - Check!
             2. Generar un contador de intentos - Check!
             3. Comparar si estoy por encima, por debajo o en el número
             4. Si encontré el número, finaliza la ejecución indicando cuantos intentos utilicé.
            */

            Random aleatorio = new Random();
            int numeroBuscado = aleatorio.Next(1, 101); //limite superior abierto - no incluye
            //Console.WriteLine("\nEl número que buscamos es {0}", numeroBuscado);

            int contadorIntentos = 0, numeroIngresado = 0;
            bool estaOK = false;

            //repetir el ciclo hasta que el número ingresado sea igual al numero buscado
            while (numeroBuscado != numeroIngresado)
            {
                estaOK = false; // reinicio la variable de control del while de lectura del dato
                while (estaOK == false)
                {
                    try
                    {
                        Console.Write("\nCuál crees que es el número buscado? ");
                        numeroIngresado = int.Parse(Console.ReadLine());

                        estaOK = true;

                        if (numeroIngresado >= 1 && numeroIngresado <= 100)
                        {
                            contadorIntentos++;

                            //Aqui identificamos si estamos por encima, por debajo o igual
                            if (numeroIngresado > numeroBuscado)
                                Console.WriteLine("Te pasaste! el número buscado es menor!");

                            if (numeroIngresado < numeroBuscado)
                                Console.WriteLine("Te faltó! el número buscado es mayor!");

                            if (numeroIngresado == numeroBuscado)
                                Console.WriteLine("\nTe ganaste un cupcake imaginario! Encontraste el número!");
                        }
                        else
                        {
                            Console.WriteLine("El número ingresado no está en el rango. Intenta otra vez!");
                        }
                    }
                    catch (FormatException elError)
                    {
                        Console.WriteLine("No ingresaste un número. Intenta nuevamente!");
                        Console.WriteLine(elError.Message + "\n");
                    }
                }
            }

            Console.WriteLine($"Te gastaste {contadorIntentos} intentos en hallar el número");
        }
    }
}
