/*
Programa:       Ex01_Divergente
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
Examen 01: Condicionales y Ciclos de control


Divergente – Análisis de resultados de la Ceremonia de Selección
******************************************************************

Ha llegado el momento de una nueva Ceremonia de Selección y Jeanine Matthews, líder de la 
facción Erudición, ha puesto en marcha su plan para erradicar las facciones que se le 
oponen en su plan por la dominación total. Su justificación para los ataques dependerá de 
la proporción de nuevos miembros en la facción Osadía, así como la aparición de una 
cantidad representativa de Divergentes.

Jeanine ha identificado que, si la cantidad de miembros de Osadía más los Divergentes 
supera el 40% del resultado de selección, puede dar marcha a su maléfico plan. En una 
ceremonia de selección, 20 nuevos miembros escogerán una facción: Abnegación (A), 
Cordialidad (C), Erudición (E), Osadía (O) y Verdad (V). Cualquier otra letra será 
entendida como que ha aparecido un Divergente.

Implemente una aplicación que lea las 20 asignaciones de facciones realizadas en la 
Ceremonia de Selección y calcule los porcentajes para cada una de las facciones 
incluyendo el porcentaje de Divergentes. Para cada facción o divergentes, debe indicar 
el total de miembros y el porcentaje obtenido.

- Si el porcentaje de miembros de Osadía más el porcentaje de Divergentes supera el 
 40% del total, la aplicación debe decir “Jeanine, puedes proceder con la dominación 
 total!”.

- Si el porcentaje de miembros de Erudición es el menor de todos y no hay Divergentes, la
 aplicación debe decir “Janine, ¡te tocó aplazar tu maléfico plan!”

*/

namespace Ex01_Divergente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Divergente – Análisis de resultados de la Ceremonia de Selección");
            Console.WriteLine("\nSe registrarán 20 asignaciones de facciones entre Abnegación (A)");
            Console.WriteLine("Cordialidad(C), Erudición(E), Osadía(O) y Verdad(V).");
            Console.WriteLine("Cualquier otra letra será entendida como Divergente.");

            //Aqui declaramos las variables que utilizaremos
            float totalA = 0, totalC = 0, totalE = 0, totalO = 0, totalV = 0, totalD = 0;
            int totalAsignaciones = 1;
            string asignacion = "";

            //Implementamos el ciclo de control para contar los 20 asignaciones
            while (totalAsignaciones <= 20)
            {
                Console.Write("\nPor favor indique la asignación para la persona No. {0} (A/C/E/O/V): ", totalAsignaciones);
                asignacion = Console.ReadLine()!.ToUpper();

                if (asignacion == "A" || asignacion == "C" || asignacion == "E" || asignacion == "O" || asignacion == "V")
                {
                    if (asignacion == "A")
                        totalA++;

                    if (asignacion == "C")
                        totalC++;

                    if (asignacion == "E")
                        totalE++;

                    if (asignacion == "O")
                        totalO++;

                    if (asignacion == "V")
                        totalV++;
                }

                else // Si es diferente a A/C/E/O/V Entonces ha aparecido un Divergente
                    totalD++;

                //Finalmente se incrementa el contador de lanzamientos, independiente si e divergente
                totalAsignaciones++;
            }

            //Aqui procedemos a calcular los porcentajes para cada facción y para los divergentes
            float porcA = (totalA / 20) * 100;
            float porcC = (totalC / 20) * 100;
            float porcE = (totalE / 20) * 100;
            float porcV = (totalV / 20) * 100;
            float porcO = (totalO / 20) * 100;
            float porcD = (totalD / 20) * 100;

            //Visualizamos los resultados...
            Console.WriteLine("\n\nResultados del proceso de asignación de facciones:\n");

            Console.WriteLine("A - Abnegación: {0} miembros, correspondiente al {1}%", totalA, porcA.ToString("00.00"));
            Console.WriteLine("C - Cordialidad: {0} miembros, correspondiente al {1}%", totalC, porcC.ToString("00.00"));
            Console.WriteLine("E - Erudición: {0} miembros, correspondiente al {1}%", totalE, porcE.ToString("00.00"));
            Console.WriteLine("O - Osadia: {0} miembros, correspondiente al {1}%", totalO, porcO.ToString("00.00"));
            Console.WriteLine("V - Verdad: {0} miembros, correspondiente al {1}%", totalV, porcV.ToString("00.00"));
            Console.WriteLine("D - Divergentes: {0} miembros, correspondiente al {1}%", totalD, porcD.ToString("00.00"));

            //Identificación de las condiciones para la frase final

            //Si porcentaje de Osadía más Divergentes suoera el 40%
            if ((porcO + porcD) > 40)
                Console.WriteLine("\n\nJeanine, ¡Puedes proceder con la dominación total!");

            //Si el porcentaje de Erudicción es el menor de todass y no hay divergentes...
            if (totalD == 0 &&
               porcE < porcA &&
               porcE < porcC &&
               porcE < porcO &&
               porcE < porcV)
                Console.WriteLine("\n\nJeanine, ¡Te tocó aplazar tu maléfico plan!");
        }
    }
}