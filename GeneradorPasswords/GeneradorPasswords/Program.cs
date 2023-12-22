/*
Programa:       GeneradorPasswords
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Implementar un generador de contraseñas a partir de los caracteres [a-z][A-Z][0-9] utilizando listas y Linq
- Actualizado a .NET 8

*/


namespace GeneradorPasswords
{
    public class Program
    {
        static public void Main()
        {
            Console.WriteLine("Programa para generar passwords aleatorios");

            //Almacenamos el código numérico equivalente de los caractéres disponibles
            List<int> caracteresValidos = [];
            caracteresValidos.AddRange(Enumerable.Range('a', 'z' - 'a' + 1).ToList());
            caracteresValidos.AddRange(Enumerable.Range('A', 'Z' - 'A' + 1).ToList());
            caracteresValidos.AddRange(Enumerable.Range('0', '9' - '0' + 1).ToList());

            //establecemos un orden aleatorio, utilizando una expresión de colección - C# 12+
            //Id de regla: IDE0305 - Uso de la expresión de colección para fluent
            caracteresValidos = [.. caracteresValidos.OrderBy(criterio => new Random().Next())];

            int maximaLongitudPassword = caracteresValidos.Count;
            Console.WriteLine($"El tamaño máximo del password es de {maximaLongitudPassword} caracteres");

            bool datoCorrecto, longitudValida = false;
            int passLength = 0;

            while (!longitudValida)
            {
                Console.Write("\nIngrese la longitud de la contraseña: ");
                datoCorrecto = int.TryParse(Console.ReadLine()!, out passLength);

                if (passLength > maximaLongitudPassword)
                    Console.WriteLine($"Dato ingresado supera longitud máxima de {maximaLongitudPassword}.");

                if (passLength <= 0)
                    Console.WriteLine($"La longitud de la contraseña debe ser un entero positivo.");

                if (passLength > 0 && passLength <= 62 && datoCorrecto)
                    longitudValida = true;
                else
                    Console.WriteLine($"El dato ingresado no se puede considerar como una longitud válida. Intenta nuevamente");
            }

            //Usamos linq para obtener la cantidad de caracteres que se utilizarán,
            //convirtiendo nuevamente del código entero a character
            var aPassword = new string(
                caracteresValidos
                .Select(letra => (char)letra)
                .Take(passLength)
                .ToArray()
                );

            Console.WriteLine($"La contraseña será: {aPassword} con una longitud de {aPassword.Length}");
        }
    }
}