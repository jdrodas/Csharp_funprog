/*
Programa:       PromedioPonderadoNotas
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------

Realice una aplicación de consola que calcule el promedio ponderado del semestre para un estudiante
que está cursando n materias, cada una de ellas con un valor de crédito específico. Tanto el semestre
como la materia se ganan cuando la calificación o el promedio ponderado supera el valor de 3.00.

El programa debe preguntar cuantas materias está cursando el estudiante y para cada una de ellas
debe solicitar el valor de créditos como un número entero positivo y la calificación como un numero 
real entre 0.00 y 5.00

el promedio ponderado se calcula como la sumatoria del producto de cada calificación individual por 
su crédito. Luego se divide dicha sumatoria por la cantidad total de créditos.

El programa debe visualizar al final una tabla que en cada fila contenga el número de la materia,
la calificación obtenida, el número de créditos y la observación si ganó o no la materia.

Finalmente el programa debe visualizar el promedio ponderado del semestre, indicando si ganó o no
el semestre.

Implementar la solución utilizando control de excepciones, condicionales, ciclos de control,
funciones y arreglos.

 */


using System;

namespace PromedioPonderadoNotas
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Programa para calcular el promedio ponderado de las notas de un semestre");
            Console.WriteLine("Las notas y el promedio se representan en el rango de 0.00 a 5.00");

            bool esCorrecto = false;
            int totalMaterias = 0;

            while (!esCorrecto)
            {
                try
                {
                    Console.Write("Cuantas materias estás cursando en este semestre? ");
                    totalMaterias = int.Parse(Console.ReadLine()!);

                    if (totalMaterias > 0)
                        esCorrecto = true;
                    else
                        Console.WriteLine("El número de materias debe ser mayor que cero. Intenta nuevamente! \n");
                }
                catch (FormatException elError)
                {
                    Console.WriteLine("Ingresaste un dato no numérico. Intenta nuevamente");
                    Console.WriteLine(elError.Message + "\n");
                }
            }

            int[] creditosMaterias = new int[totalMaterias];
            float[] notasMaterias = new float[totalMaterias];

            //Aqui solicitamos el ingreso de las notas y sus respectivos valores de créditos
            int notasIngresadas = 0;

            while (notasIngresadas < totalMaterias)
            {
                try
                {
                    Console.Write("\nMateria No. {0}, Cuántos créditos tiene? ", notasIngresadas + 1);
                    creditosMaterias[notasIngresadas] = int.Parse(Console.ReadLine()!);

                    if (creditosMaterias[notasIngresadas] > 0)
                    {
                        Console.Write("Materia No. {0}, Cuál fue la nota final? ", notasIngresadas + 1);
                        notasMaterias[notasIngresadas] = float.Parse(Console.ReadLine()!);

                        //Si la nota está en el rango requerido, avanzamos a la siguiente nota
                        if (notasMaterias[notasIngresadas] >= 0f && notasMaterias[notasIngresadas] <= 5f)
                            notasIngresadas++;
                        else
                            Console.WriteLine("La nota no está en el rango [0;5]. Debes ingresar otra vez la información de esta nota! \n");
                    }
                    else
                        Console.WriteLine("El número de créditos de esta materia debe ser mayor que cero. Intenta nuevamente! \n");
                }
                catch (FormatException elError)
                {
                    Console.WriteLine("Ingresaste un dato no numérico. Debes ingresar otra vez la información de esta nota!");
                    Console.WriteLine(elError.Message + "\n");
                }
            }

            Console.WriteLine("\n\nVisualización de resultados...");

            Console.WriteLine("No.  \tNota \tCréditos \tObservación");
            Console.WriteLine("---  \t---- \t-------- \t-----------");

            for (int i = 0; i < notasMaterias.Length; i++)
            {
                Console.WriteLine("{0} \t{1} \t\t{2} \t{3}",
                    i + 1,
                    notasMaterias[i].ToString("0.00"),
                    creditosMaterias[i],
                    ValoraNota(notasMaterias[i]));
            }


            //Aqui calculamos el promedio
            float promedioPonderado = CalculaPromedio(creditosMaterias, notasMaterias);

            Console.WriteLine("\nEl promedio ponderado del semestre es {0}", promedioPonderado.ToString("0.00"));

            if (promedioPonderado >= 3f)
                Console.WriteLine("Felicitaciones, has ganado el semestre!");
            else
                Console.WriteLine("Lástima, has perdido el semestre!");

        }

        /// <summary>
        /// Valora si la nota fue aprobada o reprobada
        /// </summary>
        /// <param name="datoNota">el valor de la calificación</param>
        /// <returns>la valoración de aprobación</returns>
        static string ValoraNota(float datoNota)
        {
            string resultado;
            if (datoNota >= 3)
                resultado = "Aprobado";
            else
                resultado = "Reprobado";

            return resultado;
        }

        /// <summary>
        /// Calcula el promedio ponderado a partir de los créditos y notas de las materias
        /// </summary>
        /// <param name="arregloCreditos">el arreglo con los créditos de cada materia</param>
        /// <param name="arregloMaterias">el arreglo con las notas de cada materia</param>
        /// <returns>El promedio</returns>
        static float CalculaPromedio(int[] arregloCreditos, float[] arregloMaterias)
        {
            float promedio = 0;
            int totalCreditos = 0;

            for (int i = 0; i < arregloCreditos.Length; i++)
            {
                promedio += (arregloCreditos[i] * arregloMaterias[i]);
                totalCreditos += arregloCreditos[i];
            }

            promedio /= totalCreditos;

            return promedio;
        }
    }
}
