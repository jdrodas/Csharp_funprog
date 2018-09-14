/*
Programa:       ex01_MaltratoMorty
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com
Propósito:
----------
Examen 01: Condicionales y Ciclos de control

Evaluación de Traumas de Morty causados por Rick
*************************************************

Dentro del juicio que la Federación Galáctica le está haciendo a Rick Sánchez por 
los crímenes cometidos, ha llamado la atención a los jueces el maltrato que le ha 
causado a su nieto Morty Smith. Se ha identificado que en repetidas ocasiones, 
Morty ha sido sometido a situaciones que le han causado pánico, trauma mental e 
inclusive daño físico. 

La corte ha decidido contratar a un especialista en maltrato infantil, el cual 
revisará 20 situaciones en los que los fiscales basan las acusaciones contra Morty. 
El especialista calificará la gravedad de cada situación, asignándole una 
calificación en una escala de 1 a 10. 

Para ello, el especialista utilizará una aplicación desarrollada en C#, la cual le 
preguntará qué tipo de maltrato es, utilizando una letra de la siguiente forma: 
(P) para Pánico, (T) para Trauma mental y (F) para daño físico. Para cualquier otra 
letra, la aplicación indicará que la clasificación es errónea y volverá a solicitar 
el tipo de maltrato. Luego, la aplicación le preguntará al especialista cual es la 
calificación de la gravedad de la situación, en un número que va desde 0 hasta 10, 
con posibilidad de dígitos decimales. 

Luego de recolectar las 20 calificaciones, el programa informará cuantas situaciones 
corresponden a cada tipo y cuál es la calificación promedio de cada tipo. Si el 
promedio de la calificación de gravedad de las situaciones de Trauma mental (T) o 
de Daño físico (F) superan el valor de 7.0, la aplicación debe recomendar máximo 
castigo para el acusado. 

Datos de entrada:
20 calificaciones de situación para (P) para Pánico, (T) para Trauma mental y (F) 
para daño físico. Cada una de ellas con valor numérico con dígitos decimales entre 
1 y 10. 

Datos de Salida: 
Cuantas situaciones por cada tipo de maltrato, el promedio de calificación de cada 
tipo y la recomendación de castigo en caso de que supere el valor de 7.0 para las 
situaciones tipo (T) Trauma mental o (F) Daño físico. 

 */

using System;

namespace ex01_MaltratoMorty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Evaluación de Traumas de Morty causados por Rick\n");

            Console.WriteLine("Se analizarán 20 situaciones de (P) para Pánico, (T) para Trauma mental y (F) para daño físico");
            Console.WriteLine("Calificándolas con valor numérico entre 1 y 10\n\n");

            //aqui declaramos las variables que se utilizaran
            float totalF = 0, totalT = 0, totalP = 0;
            float totalCalF = 0, totalCalT = 0, totalCalP = 0;
            int totalSituaciones = 1;

            string laSituacion;
            float laCalificacion;

            //aqui hacemos el ciclo while para leer la calificación
            while (totalSituaciones <= 20)
            {
                Console.Write("\nIngresa el tipo  (T,F,P) para la situación # {0}: ", totalSituaciones);
                laSituacion = Console.ReadLine().ToUpper();

                //aqui identificamos el tipo de situación
                if (laSituacion == "T" || laSituacion == "F" || laSituacion == "P")
                {
                    try
                    {
                        Console.Write("Ingresa un valor numérico entre 1 y 10 para la calificación: ");
                        laCalificacion = float.Parse(Console.ReadLine());

                        if (laCalificacion >= 1 && laCalificacion <= 10)
                        {
                            if (laSituacion == "T")
                            {
                                totalT++;
                                totalCalT += laCalificacion;
                            }

                            if (laSituacion == "P")
                            {
                                totalP++;
                                totalCalP += laCalificacion;
                            }

                            if (laSituacion == "F")
                            {
                                totalF++;
                                totalCalF += laCalificacion;
                            }

                            //Solo cuando se tiene una situación del tipo correcto y la calificación
                            //entre el rango válido, se puede pasar a la siguiente situación
                            totalSituaciones++;
                        }
                        else
                        {
                            Console.WriteLine("La calificación no está en el rango válido. Intenta nuevamente! \n");
                        }

                    }
                    catch (FormatException error)
                    {
                        Console.WriteLine("No ingresaste un valor numérico para la calificación. Intenta nuevamente!");
                        Console.WriteLine("Error: " + error.Message + "\n");
                    }
                }

                else
                {
                    Console.WriteLine("No ingresaste un código de situación correcto. Intenta nuevamente! \n");
                }

            }//Fin del ciclo

            //Aqui calculamos los promedios de calificación por cada tipo de situación
            float promT = totalCalT / totalT;
            float promF = totalCalF / totalF;
            float promP = totalCalP / totalP;

            //Aqui visualizamos los resultados
            Console.WriteLine("\n\nResultados de las calificaciones de las situaciones...\n");

            Console.WriteLine("Situaciones de Pánico: {0} situaciones, {1} calificación promedio", totalP, promP.ToString("0.00"));
            Console.WriteLine("Situaciones de Trauma mental: {0} situaciones, {1} calificación promedio", totalT, promT.ToString("0.00"));
            Console.WriteLine("Situaciones de Daño Físico: {0} situaciones, {1} calificación promedio", totalF, promF.ToString("0.00"));

            //Aqui validamos si las calificaciones promedio para  las 
            //situaciones tipo(T) Trauma mental o(F) Daño físico superan el valor de 7
            if (promF > 7 || promT > 7)
            {
                Console.WriteLine("\nCalificaciones para situaciones de Daño Físico o Trauma mental superan 7. Máximo castigo para Rick!");
            }
            else
            {
                Console.WriteLine("\nCalificaciones insuficientes para máximo castigo. Se recomienda vigilar a Rick!");
            }


        }
    }
}
