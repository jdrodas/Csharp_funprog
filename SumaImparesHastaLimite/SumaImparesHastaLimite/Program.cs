/*
Programa:       SumaImparesHastaLimite
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Hallar la suma de los números impares hasta un límite usando una función
- Implementar el control de ingreso de datos con la función TryParse()

*/

namespace SumaImparesHastaLimite
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Programa para sumar los números impares hasta un límite\n");
            Console.Write("Ingresa el límite para generar los números impares: ");

            bool datoCorrecto = false;
            int limite = 0, suma;

            while (!datoCorrecto)
            {
                Console.Write("\nIngresa el número límite: ");
                datoCorrecto = int.TryParse(Console.ReadLine(), out limite);

                if (datoCorrecto == false)
                {
                    Console.WriteLine("Ingresaste un dato no numérico. Intenta nuevamente!\n");
                }
            }

            suma = CalculaSumaImpares(limite);

            Console.WriteLine("La suma de los impares hasta el número {0} es {1}", limite, suma);
        }

        static int CalculaSumaImpares(int datoLimite)
        {
            int resultado = 0;

            for (int i = 1; i <= datoLimite; i += 2)
                resultado += i;

            return resultado;
        }
    }
}