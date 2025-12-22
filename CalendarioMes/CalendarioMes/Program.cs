/*
Programa:       CalendarioMes
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------

- Visualizar en consola el calendario de un mes a partir de los datos de año y mes
- Modificar la visualización para que las semanas comiencen el día lunes
- Utilización de la función AddDays() y la propiedad DayOfWeek de los objetos tipo DateTime

*/


using System;
using System.Globalization;

namespace CalendarioMes
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Programa para generar el calendario del mes");
            Console.WriteLine("Las semanas en Colombia comienzan los lunes");

            int año, mes;
            bool datoCorrecto;

            //Validamos que el dato del año ingresado sea correcto
            do
            {
                Console.Write("\nIngresa un valor de año mayor que cero: ");
                datoCorrecto = int.TryParse(Console.ReadLine(), out año);

                if (!datoCorrecto || año < 0)
                    Console.WriteLine("El dato ingresado no es un año válido. Intenta nuevamente!");
                else
                    datoCorrecto = true;
            }
            while (!datoCorrecto || año < 0);

            //Validamos que el dato de mes ingresado sea correcto
            do
            {
                Console.Write("\nIngresa un valor de mes (1 a 12): ");
                datoCorrecto = int.TryParse(Console.ReadLine(), out mes);

                if (!datoCorrecto || (mes < 1 || mes > 12))
                    Console.WriteLine("El dato ingresado no es un mes válido. Intenta nuevamente!");
                else
                    datoCorrecto = true;
            }
            while (!datoCorrecto || (mes < 1 || mes > 12));

            string nombreMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
            Console.WriteLine($"\nGenerando calendario para el mes {nombreMes} de {año}...\n");

            GeneraCalendarioDelMes(año, mes);
        }

        /// <summary>
        /// Genera una tabla con los días de los años distribuidos según
        /// </summary>
        /// <param name="año">año de la fecha</param>
        /// <param name="mes">mes de la fecha</param>
        static void GeneraCalendarioDelMes(int año, int mes)
        {
            //Generando encabezado del calendario con los nombres del día

            Console.WriteLine(" LUN MAR MIE JUE VIE SAB DOM");

            //Aqui creamos un objeto tipo fecha para mejor manipulación,
            //empezando con el día 1 del mes
            DateTime fechaInicial = new(año, mes, 1);
            int diaDeLaSemana = (int)fechaInicial.DayOfWeek;

            //Calculamos y escribimos el corrimiento del calendario para la
            ////primera semana
            int anchoCeldaDia = 4; //Espacio asignado para escribir el número
            string corrimientoInicial = "".PadLeft(anchoCeldaDia * (diaDeLaSemana - 1), ' ');
            Console.Write(corrimientoInicial);

            //Generamos un ciclo que se repite mientras estemos en el mes ingresado
            while (fechaInicial.Month == mes)
            {
                Console.Write($"{fechaInicial.Day.ToString().PadLeft(anchoCeldaDia, ' ')}");

                //Si se ha colocado un domingo (DayOfWeek = 0),
                // se comienza una nueva semana en una nueva linea
                if (diaDeLaSemana == 0)
                    Console.WriteLine();

                //Incrementamos la fecha en un día
                fechaInicial = fechaInicial.AddDays(1);

                //Obtenemos el nuevo día de la semana
                diaDeLaSemana = (int)fechaInicial.DayOfWeek;
            }

            Console.WriteLine("\n\n\n");
        }
    }
}