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

            //Aqui declaramos la matriz que utilizaremos
            float[,] lasNotas = new float[5, 5];
            int alumno = 0, materia;
            float valorNota;

            //las filas corresponden a estudiantes y las columnas a materias
            while (alumno < 5)
            {
                //Inicializamos el contador de materias
                materia = 0;

                while (materia < 5)
                {
                    try
                    {
                        Console.Write("Ingresa la calificación para la materia {0} del alumno {1}: ",
                            materia + 1,
                            alumno + 1);

                        valorNota = float.Parse(Console.ReadLine()!);

                        //aqui validamos que el número esté en el rango
                        if (valorNota >= 0 && valorNota <= 5)
                        {
                            lasNotas[alumno, materia] = valorNota;

                            //incrementamos para la siguiente materia
                            materia++;
                        }
                        else
                        {
                            Console.WriteLine("El valor no está en el rango válido [0;5]. Intenta nuevamnente! \n");
                        }
                    }
                    catch (FormatException error)
                    {
                        Console.WriteLine("Ingresaste un dato no numérico. Intenta nuevamente!");
                        Console.WriteLine("Error: {0} \n", error.Message);
                    }
                }

                //Incrementamos para el siguiente alumno
                alumno++;

                Console.WriteLine();
            }

            //aqui calculamos promedios
            float[] promedioAlumnos = CalculaPromedioAlumno(lasNotas);
            float[] promedioMaterias = CalculaPromedioMateria(lasNotas);

            //aqui visualizamos el contenido de las notas ingresadas
            Console.WriteLine("Las notas ingresadas fueron: ");

            for (alumno = 0; alumno < 5; alumno++)
            {
                Console.Write("Alumno {0}: ", alumno + 1);

                for (materia = 0; materia < 5; materia++)
                    Console.Write(lasNotas[alumno, materia] + "\t");

                //aqui visualizamos el promedio del alumno
                Console.WriteLine("Promedio: {0}", promedioAlumnos[alumno]);
            }

            Console.Write("Prom. \t");
            for (materia = 0; materia < promedioMaterias.Length; materia++)
            {
                Console.Write(promedioMaterias[materia] + "\t");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Función que calcula el promedio de las notas del alumno
        /// </summary>
        /// <param name="matrizNotas">La matriz de notas</param>
        /// <returns>los promedios de los alumnos</returns>
        static float[] CalculaPromedioAlumno(float[,] matrizNotas)
        {
            float[] promedios = new float[5];
            int i, j; //recorrer el arreglo con el ciclo for

            //i son filas (alumnos), j son columnas (materias)
            for (i = 0; i < 5; i++)
            {
                promedios[i] = 0; // Inicializamos la acumulacion

                for (j = 0; j < 5; j++)
                {
                    promedios[i] += matrizNotas[i, j];
                }

                promedios[i] /= 5; //aqui dividimos por la cantidad de elementos
            }
            return promedios;
        }

        static float[] CalculaPromedioMateria(float[,] matrizNotas)
        {
            float[] promedios = new float[5];
            int i, j; //recorrer el arreglo con el ciclo for

            //i son filas (alumnos), j son columnas (materias)
            for (j = 0; j < 5; j++)
            {
                promedios[j] = 0;
                for (i = 0; i < 5; i++)
                {
                    promedios[j] += matrizNotas[i, j];
                }

                promedios[j] /= 5;
            }

            return promedios;
        }

    }
}
