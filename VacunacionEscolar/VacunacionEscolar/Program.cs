/*

Vacunación Escolar

Este proyecto está basado en el tema del Examen No. 1 - Vacunación escolar
pero utilizaremos arreglos y funciones para facilitar la manipulación


*/

namespace VacunacionEscolar
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Programa para el registro de la vacunación escolar - Versión Funciones y Arreglos");
            Console.WriteLine("Se registrarán las vacunas de los estudiantes según sean ");
            Console.WriteLine("(A)stra Zeneca, (S)inovac, (P)fizer, (J)enssen y (M)oderna");

            int cantidadEstudiantes = 0;
            bool datoCorrecto = false;

            do
            {
                try
                {
                    Console.Write($"\nPor favor ingresa la cantidad de estudiantes a vacunar: ");
                    cantidadEstudiantes = int.Parse(Console.ReadLine()!);

                    if (cantidadEstudiantes > 0)
                        datoCorrecto = true;
                    else
                    {
                        Console.WriteLine("La cantidad de estudiantes debe ser positiva. Intenta nuevamente!");
                    }
                }
                catch (FormatException elError)
                {
                    Console.WriteLine("El dato ingresado no es numérico. Intenta nuevamente");
                    Console.WriteLine(elError.Message);
                }
            }
            while (datoCorrecto == false);

            Console.WriteLine($"Generando simulación de vacunación para {cantidadEstudiantes} estudiantes...");

            string[] lasVacunas = ["Astra Zeneca", "Sinovac", "Pfizer", "Jenssen", "Moderna"];

            string[] vacunasAplicadas = new string[cantidadEstudiantes];
            Random aleatorio = new();

            for (int i = 0; i < vacunasAplicadas.Length; i++)
                vacunasAplicadas[i] = lasVacunas[aleatorio.Next(lasVacunas.Length)];

            Console.WriteLine("\n\nLas vacunas aplicadas fueron las siguientes");
            VisualizaVacunasAplicadas(vacunasAplicadas);

            //Aqui totalizamos la cantidad de vacunados por medicamento
            int[] totalVacunadosPorMedicamento = CalculaTotalVacunadosPorMedicamento(lasVacunas, vacunasAplicadas);
            float[] porcentajesVacunadosPorMedicamento = CalculaPorcentajeVacunadosPorMedicamento(totalVacunadosPorMedicamento, cantidadEstudiantes); ;

            //Aqui visualizamos resultados por medicamento
            Console.WriteLine("\n\nResultados por medicamento:");
            for (int i = 0; i < lasVacunas.Length; i++)
            {
                Console.WriteLine($"Medicamento {lasVacunas[i]}: {totalVacunadosPorMedicamento[i]} estudiantes, " +
                    $"que representa el {porcentajesVacunadosPorMedicamento[i]}%");
            }


        }

        static float[] CalculaPorcentajeVacunadosPorMedicamento(int[] totalesVacunados, int cantidadEstudiantes)
        {
            float[] porcentajeVacunados = new float[totalesVacunados.Length];

            for (int i = 0; i < porcentajeVacunados.Length; i++)
                porcentajeVacunados[i] = ((float)totalesVacunados[i] / cantidadEstudiantes) * 100;

            return porcentajeVacunados;
        }

        static int[] CalculaTotalVacunadosPorMedicamento(string[] lasVacunas, string[] vacunasAplicadas)
        {
            int[] totalesVacunados = new int[lasVacunas.Length];

            //Aqui inicializamos el arreglos de totales en 0
            for (int i = 0; i < totalesVacunados.Length; i++)
                totalesVacunados[i] = 0;

            //Aqui totalizamos
            for (int i = 0; i < lasVacunas.Length; i++)
            {
                for (int j = 0; j < vacunasAplicadas.Length; j++)
                {
                    if (lasVacunas[i] == vacunasAplicadas[j])
                        totalesVacunados[i]++;
                }
            }

            return totalesVacunados;
        }

        static void VisualizaVacunasAplicadas(string[] arregloVacunas)
        {
            for (int i = 0; i < arregloVacunas.Length; i++)
                Console.WriteLine($"Estudiante No. {(i + 1)}, vacunado con {arregloVacunas[i]}");
        }
    }
}