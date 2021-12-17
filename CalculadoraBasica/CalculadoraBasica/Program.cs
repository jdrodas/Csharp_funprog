/*
Programa:       CalculadoraBasica
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Implementar una calculadora básica con las operaciones suma, resta, multiplicación y división
  utilizando el ciclo de control While, el selector múltiple "switch/case" y control de excepciones
  con try/catch

 */

namespace CalculadoraBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = -1; // Opcion inicial que no afecta la navegación de la app
            float numero1 = 0, numero2 = 0, resultado = 0;

            //El menu principal se repite mientras la opción ingresada no sea 0
            while (opcion != 0)
            {
                Console.WriteLine("*********** Calculadora básica para dos números ***********");
                Console.WriteLine("\t1. Sumar");
                Console.WriteLine("\t2. Restar");
                Console.WriteLine("\t3. Multiplicar");
                Console.WriteLine("\t4. Dividir");
                Console.WriteLine("\n\t0. Salir");

                Console.Write("\n\tElija una opción: ");
                try
                {
                    opcion = int.Parse(Console.ReadLine()!);

                    //aqui verificamos si la opción es válida
                    if (opcion == 1 || opcion == 2 || opcion == 3 || opcion == 4)
                    {
                        Console.Write("Ingresa el primer número: ");
                        numero1 = float.Parse(Console.ReadLine()!);

                        Console.Write("Ingresa el segundo número: ");
                        numero2 = float.Parse(Console.ReadLine()!);

                        //Identificamos la opción
                        switch (opcion)
                        {
                            case 1:
                                resultado = numero1 + numero2;
                                Console.WriteLine("Opción seleccionada: Suma");
                                break;

                            case 2:
                                resultado = numero1 - numero2;
                                Console.WriteLine("Opción seleccionada: Resta");
                                break;

                            case 3:
                                resultado = numero1 * numero2;
                                Console.WriteLine("Opción seleccionada: Multiplicación");
                                break;

                            case 4:
                                //Solo se divide si numero2 es diferente de cero
                                if (numero2 != 0)
                                    resultado = numero1 / numero2;

                                Console.WriteLine("Opción seleccionada: División");
                                break;
                        }

                        //si la operación es división y el numero2 es cero, diga que no hay división
                        if (opcion == 4 && numero2 == 0)
                            Console.WriteLine("No se puede dividir por cero!");
                        else
                            Console.WriteLine($"El resultado es: {resultado} \n\n");
                    }
                    else
                    {
                        if (opcion != 0)
                            Console.WriteLine("Ingresate un número de opción inválido. Intenta nuevamente!\n");
                    }
                }
                catch (FormatException errorCapturado)
                {
                    Console.WriteLine("Ingresaste un valor no numérico. Intenta nuevamente!");
                    Console.WriteLine(errorCapturado.Message + "\n");
                }

            }//Fin del ciclo while

            Console.WriteLine("Ejecución Finalizada. Ha seleccionado salir.");
        }
    }
}
