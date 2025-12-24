/*
Programa:       Ex01_SombreroSeleccionador
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
Examen 01: Condicionales y Ciclos de control


Harry Potter - Análisis de resultados del sombrero seleccionador
******************************************************************

Preocupados por los acontecimientos que llevaron a la subida al poder del señor oscuro, 
el Ministerio de Magia ha decidido enviar a su mejor aritmántico, Yallow Vaddlesprout, 
para que analice estadísticamente los resultados de las sesiones de clasificación que 
el Sombrero Seleccionador hace en Howgarts. Se quiere identificar en etapas tempranas 
cuando una casa estará en posición dominante respecto a otra.

La posición dominante se da cuando el porcentaje de nuevos miembros de una casa es superior 
al de los miembros de otra casa. Por ejemplo, si Ravenclaw obtiene 24% y Hufflepuff obtiene 
12%, Ravenclaw tiene posición dominante sobre Hufflepuff.

En una sesión de clasificación, 16 nuevos estudiantes recibirán asignación a una casa: 
Gryffindor (G), Ravenclaw (R), Slytherin (S) y Hufflepuff (H). Cualquier otra letra se 
entenderá como un Hatstall (indecisión del sombrero) y se preguntará nuevamente. Los 16 valores 
deben ser solamente H, G, R y S. 

Implemente una aplicación que lea las 16 asignaciones de casas realizadas por el sombrero 
seleccionador, calcule los porcentajes de cada una de las casas e identifique cuales son las 
posiciones dominantes que se puedan presentar. Si no hay posición dominante, la aplicación 
debe indicar que fue una clasificación normal.

*/

namespace Ex01_SombreroSeleccionador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Harry Potter - Análisis de resultados del sombrero seleccionador");
            Console.WriteLine("Las casas son Gryffindor (G), Ravenclaw(R), Slytherin(S) y Hufflepuff(H)");
            Console.WriteLine("Cualquier otra letra se entenderá como un Hatstall (indecisión del sombrero) y se preguntará nuevamente");
            Console.WriteLine("Se deben ingresar 16 clasificaciones de estudiantes\n\n");

            //aqui declaramos las variables que se utilizaran
            float totalG = 0, totalH = 0, totalR = 0, totalS = 0;
            int totalEstudiantes = 1;

            string laCasa;

            //aqui hacemos el ciclo while para leer la clasificacion
            while (totalEstudiantes <= 16)
            {
                Console.Write("Ingresa la clasificación (G,H,R,S) para el estudiante # {0}: ", totalEstudiantes);
                laCasa = Console.ReadLine()!.ToUpper();

                //aqui identificamos a cual casa pertenece
                if (laCasa == "G" || laCasa == "H" || laCasa == "R" || laCasa == "S")
                {

                    if (laCasa == "G")
                        totalG++;

                    if (laCasa == "H")
                        totalH++;

                    if (laCasa == "R")
                        totalR++;

                    if (laCasa == "S")
                        totalS++;

                    //aqui incrementamos el contador de estudiantes para el proximo
                    totalEstudiantes++;
                }
                else
                {
                    Console.WriteLine("Hatstall: indecisión del sombrero. Intenta nuevamente! \n");
                }
            }// fin del ciclo

            //aqui calculamos los porcentajes
            float porcG, porcH, porcR, porcS;

            porcG = (totalG / 16) * 100;
            porcH = (totalH / 16) * 100;
            porcR = (totalR / 16) * 100;
            porcS = (totalS / 16) * 100; ;

            //Visualizamos resultados obtenidos
            Console.WriteLine("\n\nResultados obtenidos:");

            Console.WriteLine("Gryffindor: {0} estudiantes, {1}% del total",
                totalG, porcG);

            Console.WriteLine("Hufflepuff: {0} estudiantes, {1}% del total",
                totalH, porcH);

            Console.WriteLine("Ravenclaw: {0} estudiantes, {1}% del total",
                totalR, porcR);

            Console.WriteLine("Slytherin: {0} estudiantes, {1}% del total",
                totalS, porcS);

            //aqui identificamos las posiciones dominantes
            if (porcG == 25 && porcH == 25 && porcR == 25 && porcS == 25)
            {
                Console.WriteLine("No hay posición dominante, clasificación normal.");
            }
            else
            {
                //hay posición dominante, se debe identificar

                // Revisando Gryffindor:
                if (porcG > porcH)
                    Console.WriteLine("Posición dominante de Gryffindor sobre Hufflepuff");

                if (porcG > porcR)
                    Console.WriteLine("Posición dominante de Gryffindor sobre Ravenclaw");

                if (porcG > porcS)
                    Console.WriteLine("Posición dominante de Gryffindor sobre Slytherin");

                // Revisando Hufflepuff:
                if (porcH > porcG)
                    Console.WriteLine("Posición dominante de Hufflepuff sobre Gryffindor");

                if (porcH > porcR)
                    Console.WriteLine("Posición dominante de Hufflepuff sobre Ravenclaw");

                if (porcH > porcS)
                    Console.WriteLine("Posición dominante de Hufflepuff sobre Slytherin");

                // Revisando Ravenclaw:
                if (porcR > porcG)
                    Console.WriteLine("Posición dominante de Ravenclaw sobre Gryffindor");

                if (porcR > porcH)
                    Console.WriteLine("Posición dominante de Ravenclaw sobre Hufflepuff");

                if (porcR > porcS)
                    Console.WriteLine("Posición dominante de Ravenclaw sobre Slytherin");

                // Revisando Slytherin:
                if (porcS > porcG)
                    Console.WriteLine("Posición dominante de Slytherin sobre Gryffindor");

                if (porcS > porcH)
                    Console.WriteLine("Posición dominante de Slytherin sobre Hufflepuff");

                if (porcS > porcR)
                    Console.WriteLine("Posición dominante de Slytherin sobre Ravenclaw");
            }
        }
    }
}
