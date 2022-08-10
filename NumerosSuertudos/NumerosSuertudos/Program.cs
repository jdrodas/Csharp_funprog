using System;

namespace NumerosSuertudos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para identificar si un numero es de buena o mala suerte");
            Console.WriteLine("Un numero de tres cifras se considera suertudo si la suma");
            Console.WriteLine("de sus dígitos da 7 o 9. Es de mala suerte si suma 3 o 6.\n");

            Console.WriteLine("- Si la suma tiene más de un dígito, se repite el proceso hasta obtener una sola cifra");
            Console.WriteLine("- Tres digitos son números entre 100 y 999");

            double numeroIngresado = 0;
            bool datoCorrecto = false;

            //Paso 1: Ingresar el número y validar que dato ingresado sea correcto (tipo y rango)
            while (datoCorrecto == false)
            {
                try
                {
                    Console.Write("\nIngresa un numero entero positivo de mínimo 3 dígitos: ");
                    numeroIngresado = int.Parse(Console.ReadLine());

                    //Aqui validamos si el numero es de mínimo 3 cifras
                    if (numeroIngresado < 100 || numeroIngresado>999)
                        Console.WriteLine("El numero ingresado no es de 3 cifras. Intenta nuevamente");
                    else                    
                        datoCorrecto = true;                    
                }
                catch (FormatException elError)
                {
                    Console.WriteLine("El dato ingresado no corresponde a un número. Intenta nuevamente!");
                    Console.WriteLine(elError.Message);
                }
            }

            //Paso 2: Descomponer el número en sus cifras
            double unidades, decenas, centenas;

            //Truncate: Obtiene la parte entera de un numero con decimales
            centenas = Math.Truncate(numeroIngresado / 100);
            decenas = Math.Truncate((numeroIngresado - centenas*100) / 10);
            unidades = numeroIngresado - (centenas * 100) - (decenas * 10);

            Console.WriteLine($"Cifras de {numeroIngresado}: Unidades {unidades}, Decenas {decenas}, Centenas {centenas}");

            //Paso 3: Sumar las cifras y verificar si tiene más de dos dígitos
            double sumaCifras = unidades + decenas + centenas;

            if (sumaCifras > 9)
            {
                Console.WriteLine($"La suma {sumaCifras} tiene más de un dígito. Procesando nuevamente:");
                decenas = Math.Truncate(sumaCifras / 10);
                unidades = sumaCifras - (decenas*10);

                sumaCifras = unidades + decenas;
            }

            Console.WriteLine($"La suma final es {sumaCifras}");

            if (sumaCifras == 7 || sumaCifras == 9)
                Console.WriteLine($"{numeroIngresado} es de buena suerte porque la suma final es {sumaCifras}");
            else
                if (sumaCifras == 3 || sumaCifras == 6)
                Console.WriteLine($"{numeroIngresado} es de mala suerte porque la suma final es {sumaCifras}");
            else
                Console.WriteLine($"{numeroIngresado} no es ni bueno ni malo... pudiste escoger mejor! :-)");
        }
    }
}
