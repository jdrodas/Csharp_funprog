
/*
Programa:       CalculoDetalladoEdad
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Calcular la edad en años, meses y días a partir de la información ingresada
  para la fecha de nacimiento.

- Explorar el cambio del CultureInfo de acuerdo al valor de un país (es-CO)

- Utilizar las estructuras Datetime y TimeSpan para manipulación de datos tipo fecha

*/

using System;
using System.Globalization;

namespace CalculoDetalladoEdad
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Cambiamos la cultura usada en la aplicación para que se ajuste a Español - Colombia
            CultureInfo.CurrentCulture = new CultureInfo("es-CO", false);

            Console.WriteLine("Programa para calcular la edad de una persona a partir de su fecha de nacimiento");

            int dia, mes, año;
            bool diaCorrecto, mesCorrecto, añoCorrecto, fechaCorrecta;
            DateTime fechaNacimiento;

            do
            {
                Console.Write("\nIngresa tu día de nacimiento: ");
                diaCorrecto = int.TryParse(Console.ReadLine(), out dia);
                Console.Write("Ingresa tu mes de nacimiento: ");
                mesCorrecto = int.TryParse(Console.ReadLine(), out mes);
                Console.Write("Ingresa tu año de nacimiento: ");
                añoCorrecto = int.TryParse(Console.ReadLine(), out año);

                try
                {
                    //Aqui intentamos hacer una fecha
                    fechaNacimiento = new DateTime(año, mes, dia);

                    //Si está correcto, visualizamos la fecha generada
                    Console.WriteLine($"\nTu fecha de nacimiento es {fechaNacimiento.ToLongDateString()}");
                    fechaCorrecta = true;

                    //Aqui invocamos la función que calcula la edad
                    CalculaEdad(fechaNacimiento);

                }
                catch (ArgumentOutOfRangeException elError)
                {
                    Console.WriteLine("Los datos ingresados no permiten definir una fecha. Intenta nuevamente!");
                    Console.WriteLine($"{elError.Message}\n");
                    fechaCorrecta = false;
                }
            }
            while (!diaCorrecto || !mesCorrecto || !añoCorrecto || !fechaCorrecta);

        }

        /// <summary>
        /// Función que calcula la edad de una persona con respecto a la fecha de hoy
        /// </summary>
        /// <param name="fechaNacimiento">La fecha de nacimiento</param>
        static void CalculaEdad(DateTime fechaNacimiento)
        {
            DateTime fechaHoy = DateTime.Now;
            TimeSpan intervaloEdad = fechaHoy - fechaNacimiento;

            DateTime edad = DateTime.MinValue.AddDays(intervaloEdad.Days);

            int edadAños = edad.Year - 1;
            int edadMeses = edad.Month - 1;
            int edadDias = edad.Day - 1;

            Console.WriteLine($"La fecha actual es {fechaHoy.ToLongDateString()}");
            Console.WriteLine($"Tu edad en detallada es {edadAños} años, {edadMeses} meses y {edadDias} dias");
        }
    }
}
