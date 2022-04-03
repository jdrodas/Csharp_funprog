/*
Programa:       EjemploMatricesNotasEstudiantes
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com


Propósito:
----------

Realice un programa que lea las notas de 5 materias para 5 estudiantes.
Las notas son valores reales que van entre 0 y 5. El programa debe
almacenar los valores en un arreglo bidimensional (matriz) en el que las
columnas corresponden a las materias y las filas corresponden a los estudiantes.

el programa debe visualizar para cada estudiante el valor de la calificación
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

namespace EjemploMatricesNotasEstudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para calcular el promedio de las notas");
            Console.WriteLine("Se ingresará 5 estudiantes para 5 materias");
            Console.WriteLine("Las notas van entre 0 y 5\n\n");

            /*
            Partes a implementar
            - Leer los nombres de 5 estudiantes y 5 materias
            - Leer las notas de cada estudiante por cada materia
            - Calcular el promedio por estudiante
            - Calcular el promedio por materia
            - Visualizar resultados
             */

            //Paso 1: Leer los nombres de estudiantes y las materias
            string[] nombreEstudiantes = new string[5];

            Console.WriteLine("\n *** Nombres de los estudiantes *** ");
            for (int i = 0; i < nombreEstudiantes.Length; i++)
            {
                Console.Write($"Ingresa el nombre del estudiante No. {i + 1}: ");
                nombreEstudiantes[i] = Console.ReadLine()!;
            }

            string[] nombreMaterias = new string[5];

            Console.WriteLine("\n *** Nombres de las materias *** ");
            for (int i = 0; i < nombreMaterias.Length; i++)
            {
                Console.Write($"Ingresa el nombre de la materia No. {i + 1}: ");
                nombreMaterias[i] = Console.ReadLine()!;
            }

            //Paso 2: Leer las notas de cada estudiante por cada materia
            Console.WriteLine("\nIngreso de notas para cada materia y cada estudiante: \n");

            float[,] lasNotas = new float[nombreEstudiantes.Length, nombreMaterias.Length];

            for (int estudiante = 0; estudiante < nombreEstudiantes.Length; estudiante++)
            {
                for (int materia = 0; materia < nombreMaterias.Length; materia++)
                {
                    Console.Write($"Ingresa la nota para {nombreEstudiantes[estudiante]} en " +
                        $"la materia {nombreMaterias[materia]}: ");
                    lasNotas[estudiante, materia] = float.Parse(Console.ReadLine()!);
                }
                Console.WriteLine();
            }
            /*
             Para mejorar: Implementa control de excepciones al realizar el parse de
             la entrada del usuario.
             */

            //Paso 3: Calcular el promedio por estudiante
            float[] promediosEstudiante = CalculaPromediosEstudiante(lasNotas);

            // Paso 4: Calcular el promedio por materia
            float[] promediosMateria = CalculaPromediosMateria(lasNotas);


            //Paso 5: Visualizar resultados
            //Visualizar por nombre de estudiantes
            Console.WriteLine("\nLos nombres de los estudiantes son:");
            for (int estudiante = 0; estudiante < nombreEstudiantes.Length; estudiante++)
            {
                Console.WriteLine($"{nombreEstudiantes[estudiante]}");

                //Aqui recorremos la materia con su calificación
                for (int materia = 0; materia < nombreMaterias.Length; materia++)
                {
                    Console.WriteLine($"\tMateria: {nombreMaterias[materia]}, " +
                        $"Calificación: {lasNotas[estudiante, materia]}");
                }

                //Aqui colocamos el promedio del estudiante
                Console.WriteLine($"\t\tEl promedio de {nombreEstudiantes[estudiante]} " +
                    $"fue de: {promediosEstudiante[estudiante]}");
            }

            //Visualizar por nombre de materias
            Console.WriteLine("\nLos nombres de las materias son:");

            for (int materia = 0; materia < nombreMaterias.Length; materia++)
            {
                Console.WriteLine($"{nombreMaterias[materia]}");
                //Aqui recorremos el estudiante con su calificación
                for (int estudiante = 0; estudiante < nombreEstudiantes.Length; estudiante++)
                {
                    Console.WriteLine($"\tEstudiante: {nombreEstudiantes[estudiante]}, " +
                        $"Calificación: {lasNotas[estudiante, materia]}");
                }
                //Aqui colocamos el promedio de la materia              
                Console.WriteLine($"\t\tEl promedio de {nombreMaterias[materia]} " +
                    $"fue de: {promediosMateria[materia]}");
            }
        }

        /// <summary>
        /// Función que calcula el promedio de las notas del estudiante
        /// </summary>
        /// <param name="lasNotas">La matriz de notas</param>
        /// <returns>los promedios de los alumnos</returns>
        static float[] CalculaPromediosEstudiante(float[,] lasNotas)
        {
            //La dimensión 0 del arreglo de notas corresponde a las estudiantes
            //La dimensión 1 del arreglo de notas corresponde a las materias
            float[] promedios = new float[lasNotas.GetLength(0)];

            for (int estudiante = 0; estudiante < lasNotas.GetLength(0); estudiante++)
            {
                promedios[estudiante] = 0; // Inicializamos la acumulacion

                for (int materia = 0; materia < lasNotas.GetLength(1); materia++)
                    promedios[estudiante] += lasNotas[estudiante, materia];

                //Dividimos la suma de las notas por la cantidad de materias
                promedios[estudiante] /= lasNotas.GetLength(1);
            }
            return promedios;
        }

        /// <summary>
        /// Función que calcula el promedio de las notas de la materia
        /// </summary>
        /// <param name="lasNotas"></param>
        /// <returns>los promedios de las materias</returns>
        static float[] CalculaPromediosMateria(float[,] lasNotas)
        {
            //La dimensión 0 del arreglo de notas corresponde a las estudiantes
            //La dimensión 1 del arreglo de notas corresponde a las materias
            float[] promedios = new float[lasNotas.GetLength(1)];

            for (int materia = 0; materia < lasNotas.GetLength(1); materia++)
            {
                promedios[materia] = 0; // Inicializamos la acumulacion

                for (int estudiante = 0; estudiante < lasNotas.GetLength(0); estudiante++)
                    promedios[materia] += lasNotas[estudiante, materia];

                //Dividimos la suma de las notas por la cantidad de estudiantes
                promedios[materia] /= lasNotas.GetLength(0);
            }
            return promedios;
        }
    }
}
