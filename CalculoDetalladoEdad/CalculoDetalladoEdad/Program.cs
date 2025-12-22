
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
        static void Main()
        {
            // Cambiamos la cultura usada en la aplicación para que se ajuste a Español - Colombia
            CultureInfo.CurrentCulture = new CultureInfo("es-CO", false);

            Console.WriteLine("Programa para calcular la edad de una persona a partir de su fecha de nacimiento");

            int dia, mes, año;
            bool diaCorrecto, mesCorrecto, añoCorrecto, fechaCorrecta;
            DateTime fechaNacimiento;

            do
            {
                do
                {
                    Console.Write("\nIngresa el número de tu día de nacimiento: ");
                    diaCorrecto = int.TryParse(Console.ReadLine(), out dia);
                    if (diaCorrecto == false)
                        Console.WriteLine("El dato del día no es válido, intenta nuevamente!");
                } while (!diaCorrecto);

                do
                {
                    Console.Write("Ingresa  el número de tu mes de nacimiento: ");
                    mesCorrecto = int.TryParse(Console.ReadLine(), out mes);
                    if (mesCorrecto == false)
                        Console.WriteLine("El dato del mes no es válido, intenta nuevamente!");
                } while (!mesCorrecto);

                do
                {
                    Console.Write("Ingresa  el número de tu año de nacimiento: ");
                    añoCorrecto = int.TryParse(Console.ReadLine(), out año);
                    if (añoCorrecto == false)
                        Console.WriteLine("El dato del año no es válido, intenta nuevamente!");
                } while (!añoCorrecto);

                //Ahora intentamos validar si esa combinación produce una fecha válida
                //Aqui intentamos hacer una fecha
                try
                {
                    fechaNacimiento = new DateTime(año, mes, dia);

                    //Si está correcto, visualizamos la fecha generada
                    Console.WriteLine($"\nTu fecha de nacimiento es {fechaNacimiento.ToLongDateString()}");
                    fechaCorrecta = true;

                    //Como la fecha es correcta, podemos calcular la edad
                    //Usaremos una función con parámetros tipo out:
                    CalculaEdad(fechaNacimiento, out int edadAños, out int edadMeses, out int edadDias);
                    Console.WriteLine($"Tu edad en detallada es {edadAños} años, {edadMeses} meses y {edadDias} dias");
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
        /// Función que calcula la edad en años, meses y días
        /// </summary>
        /// <param name="fechaNacimiento">La fecha de nacimiento</param>
        /// <param name="edadAños">Parametro de salida con el dato de los años</param>
        /// <param name="edadMeses">Parametro de salida con el dato de los meses</param>
        /// <param name="edadDias">Parametro de salida con el dato de los días</param>
        static void CalculaEdad(DateTime fechaNacimiento,
                                out int edadAños,
                                out int edadMeses,
                                out int edadDias)
        {
            DateTime fechaHoy = DateTime.Now;
            TimeSpan intervaloEdad = fechaHoy - fechaNacimiento;

            DateTime edad = DateTime.MinValue.AddDays(intervaloEdad.Days);

            edadAños = edad.Year - 1;
            edadMeses = edad.Month - 1;
            edadDias = edad.Day - 1;

            Console.WriteLine($"La fecha actual es {fechaHoy.ToLongDateString()}");
        }
    }
}