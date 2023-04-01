/*
Programa:       MatricesNotasEstudiantes
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
Realice un programa que lea las notas de 5 materias para 5 estudiantes.
Las notas son valores reales que van entre 0 y 5. El programa debe
almacenar los valores en un arreglo bidimensional (matriz) en el que las
columnas corresponden a las materias y las filas corresponden a los estudiantes.

El programa debe visualizar para cada estudiante el valor de la calificación
de cada materia y el promedio de éstas.

Adicionalmente el programa debe visualizar la calificación promedio de cada
materia.

Implemente dos funciones, CalculaPromedioAlumno y CalculaPromedioMateria
que reciban como parametro la matriz de notas y devuelva un arreglo de float
con los valores correspondientes a los respectivos promedios

Observaciones:
--------------
    -   Cuando utilizo Console.ReadLine() le coloco al final un "!" el "null-forgiving operator"
        que me permite eliminar la advertencia asociada al código CS8601 - Posible asignación
        de referencia nula.

        https://docs.microsoft.com/es-mx/dotnet/csharp/language-reference/operators/null-forgiving
*/

using System;

namespace MatricesNotasEstudiantes
{
    public class Program
    {
        static void Main()
        {
            int cantidadEstudiantes = 5;
            int cantidadMaterias = 5;
            
            Console.WriteLine("Programa para calcular el promedio de las notas");
            Console.WriteLine($"Se ingresará {cantidadEstudiantes} estudiantes para {cantidadMaterias} materias");
            Console.WriteLine("Las notas van entre 0 y 5\n\n");

            /*
            Partes a implementar
            OK - Leer los nombres de 5 estudiantes y 5 materias
            OK - Leer las notas de cada estudiante por cada materia
            OK - Calcular el promedio por estudiante
            OK - Calcular el promedio por materia
            OK - Visualizar resultados
            */

            //Paso 1: Leer los nombres de estudiantes y las materias
            string[] nombreEstudiantes = new string[cantidadEstudiantes];

            Console.WriteLine("\n *** Nombres de los estudiantes *** ");
            int totalEstudiantes = 0;

            do
            {
                Console.Write($"\nIngresa el nombre del estudiante No. {totalEstudiantes+1}: ");
                nombreEstudiantes[totalEstudiantes] = Console.ReadLine()!;

                if (nombreEstudiantes[totalEstudiantes].Length > 0)
                    totalEstudiantes++;
                else
                    Console.WriteLine("El nombre del estudiante no puede ser vacío. Intenta nuevamente!");
            }
            while (totalEstudiantes < cantidadEstudiantes);

            string[] nombreMaterias = new string[cantidadMaterias];

            Console.WriteLine("\n *** Nombres de las materias *** ");
            int totalMaterias = 0;

            do
            {
                Console.Write($"\nIngresa el nombre de la materia No. {totalMaterias + 1}: ");
                nombreMaterias[totalMaterias] = Console.ReadLine()!;

                if (nombreMaterias[totalMaterias].Length > 0)
                    totalMaterias++;
                else
                    Console.WriteLine("El nombre de la materia no puede ser vacío. Intenta nuevamente!");
            }
            while (totalMaterias < cantidadMaterias);

            //Paso 2: Leer las notas de cada estudiante por cada materia
            Console.WriteLine("\n*** Ingreso de notas para cada materia y cada estudiante: ***");

            float[,] lasNotas = new float[nombreEstudiantes.Length, nombreMaterias.Length];

            int estudiante = 0, materia;

            while (estudiante < nombreEstudiantes.Length)
            {
                materia = 0;
                while (materia < nombreMaterias.Length)
                {
                    try
                    {
                        Console.Write($"\nIngresa la nota para {nombreEstudiantes[estudiante]} en " +
                        $"la materia {nombreMaterias[materia]}: ");
                        lasNotas[estudiante, materia] = float.Parse(Console.ReadLine()!);

                        if(lasNotas[estudiante, materia]>=0 && lasNotas[estudiante, materia]<=5)
                            materia++;
                        else
                            Console.WriteLine("El valor ingresado no está en el rango [0;5]. Intenta nuevamente!");
                    }
                    catch (FormatException elError)
                    {
                        Console.WriteLine("EL dato ingresado no es numérico. Intenta nuevamente!");
                        Console.WriteLine(elError.Message);
                    }
                }
                Console.WriteLine();
                estudiante++;
            }

            //Paso 3: Calcular el promedio por estudiante
            float[] promediosEstudiante = CalculaPromediosEstudiante(lasNotas);

            // Paso 4: Calcular el promedio por materia
            float[] promediosMateria = CalculaPromediosMateria(lasNotas);

            //Paso 5: Visualizar resultados

            //Visualizar por nombre de estudiantes
            Console.WriteLine("\nLos nombres de los estudiantes son:");
            for (estudiante = 0; estudiante < nombreEstudiantes.Length; estudiante++)
            {
                Console.WriteLine($"Estudiante: {nombreEstudiantes[estudiante]}");

                //Aqui recorremos la materia con su calificación
                for (materia = 0; materia < nombreMaterias.Length; materia++)
                    Console.WriteLine($"\tMateria: {nombreMaterias[materia]}, " +
                        $"Calificación: {lasNotas[estudiante, materia]}");

                //Aqui colocamos el promedio del estudiante
                Console.WriteLine($"\t\tEl promedio de {nombreEstudiantes[estudiante]} " +
                    $"fue de: {promediosEstudiante[estudiante].ToString(".00")}");
            }

            //Visualizar por nombre de materias
            Console.WriteLine("\nLos nombres de las materias son:");
            for (materia = 0; materia < nombreMaterias.Length; materia++)
            {
                Console.WriteLine($"Materia: {nombreMaterias[materia]}");

                //Aqui recorremos los estudiantes con su calificación
                for (estudiante = 0; estudiante < nombreEstudiantes.Length; estudiante++)
                    Console.WriteLine($"\tEstudiante: {nombreEstudiantes[estudiante]}, " +
                        $"Calificación: {lasNotas[estudiante,materia]}");

                //Aqui colocamos el promedio de la materia
                Console.WriteLine($"\t\tEl promedio de {nombreMaterias[materia]} " +
                    $"fue de {promediosMateria[materia].ToString(".00")}");
            }

        }

        /// <summary>
        /// Calcula el promedio de las notas de los estudiantes que cursan esas materias
        /// </summary>
        /// <param name="lasNotas">las notas de todos los estudiantes para todas las materias</param>
        /// <returns>el promedio de cada estudiante</returns>
        static float[] CalculaPromediosEstudiante(float[,] lasNotas)
        {
            //La dimensión 0 del arreglo de notas corresponde a las estudiantes
            //La dimensión 1 del arreglo de notas corresponde a las materias

            float[] losPromedios = new float[lasNotas.GetLength(0)];

            for (int estudiante = 0; estudiante < lasNotas.GetLength(0); estudiante++)
            {
                losPromedios[estudiante] = 0; // Inicializamos la acumulacion

                for (int materia = 0; materia < lasNotas.GetLength(1); materia++)
                    losPromedios[estudiante] += lasNotas[estudiante, materia];

                //Dividimos la suma de las notas por la cantidad de materias
                losPromedios[estudiante] /= lasNotas.GetLength(1);
            }

            return losPromedios;
        }

        /// <summary>
        /// Calcula el promedio de las notas de las materias que cursan esos estudiantes
        /// </summary>
        /// <param name="lasNotas">las notas de todos los estudiantes para todas las materias</param>
        /// <returns>el promedio de cada materia</returns>
        static float[] CalculaPromediosMateria(float[,] lasNotas)
        {
            //La dimensión 0 del arreglo de notas corresponde a las estudiantes
            //La dimensión 1 del arreglo de notas corresponde a las materias

            float[] losPromedios = new float[lasNotas.GetLength(1)];

            for (int materia = 0; materia < lasNotas.GetLength(1); materia++)
            {
                losPromedios[materia] = 0; // Inicializamos la acumulacion

                for (int estudiante = 0; estudiante < lasNotas.GetLength(0); estudiante++)
                    losPromedios[materia] += lasNotas[estudiante, materia];

                //Dividimos la suma de las notas por la cantidad de materias
                losPromedios[materia] /= lasNotas.GetLength(0);
            }
                
            return losPromedios;
        }
    }
}