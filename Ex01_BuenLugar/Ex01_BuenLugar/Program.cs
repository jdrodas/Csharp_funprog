/*
Programa:       Ex01_BuenLugar
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
Examen 01: Condicionales, Ciclos de control.


El Buen Lugar – Valoración del Alma
***********************************

Ha llegado el momento de tu lamentable fallecimiento y te encuentras en el “Más Allá” en una 
cómoda y confortable sala. Michael, una figura casi angelical que pareciera estar encargado 
de recibirte, te da la bienvenida al “Buen Lugar” y te comienza a explicar como funciona la 
siguiente etapa de tu existencia.

Sin embargo, Michael tiene sospechas que Shawn, uno de los encargados del “Mal Lugar”, ha 
estado interfiriendo en el proceso de clasificación de los nuevos fallecidos, causando que 
todos ellos lleguen allí.

Decidido a identificar el fraude que está haciendo Shawn, Michael le solicita a Janet, la 
omnisciente asistente personal, que construya una aplicación en C# que le permita calcular 
de una manera simplificada, si la nueva alma merece estar en el Buen Lugar.

Michael define como requerimiento que se evaluarán las 12 acciones más representativas que la 
persona realizó en vida, clasificándolas en Redentoras, Genuinas, Interesadas y Maléficas. 
El programa pedirá entonces que para cada acción a evaluar se indique cuál es su respectiva 
clasificación. En caso de que no se pueda asignar alguno de estos valores, se volverá a pedir 
clasificación hasta que se completen las 12 evaluaciones.

Luego de estas evaluaciones, se estable las siguientes condiciones para realizar el juicio 
final y definir el lugar definitivo del alma:
•	Si las acciones Redentoras (R) superan la mitad de las evaluaciones, el alma se irá al 
    Buen Lugar.
•	Si las acciones Interesadas (I) más las acciones Maléficas (M) superan la mitad de las 
    evaluaciones, el alma se irá al Mal Lugar.
•	En cualquier otro resultado, el alma se irá al Lugar Medio, una especie de purgatorio para 
    aquellas almas que no lograron tener un impacto significativo durante su existencia.

Requerimiento:
Realice un programa en C# - Aplicación de Consola, en la que se pida la evaluación de 12 acciones 
realizadas por el alma. Las evaluaciones están representadas por las letras R, G, I, M. Cualquier 
otro valor será considerado inválido y se debe solicitar de nuevo la evaluación.

Luego de ingresar las evaluaciones, el programa debe indicar los resultados obtenidos, visualizando 
el total de acciones por cada tipo de resultado (cuantas Redentoras, cuantas Genuinas, cuantas 
Interesadas, Cuantas Maléficas).  La suma de estas acciones siempre debe dar 12.

Finalmente, debe emitir el juicio final, según las condiciones establecidas, de cual será el sitio 
final del alma: El Buen Lugar, El Mal Lugar o El Lugar Medio.

*/

namespace Ex01_BuenLugar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("El Buen Lugar - Valoración del alma");
            Console.WriteLine("\nSe Evaluarán 12 acciones realizadas por el recién fallecido");
            Console.WriteLine("Se Clasificarán en (R)edentoras, (G)enuinas, (I)nteresadas y (M)aléficas.");

            int totalR = 0, totalG = 0, totalI = 0, totalM = 0;
            int totalAcciones = 1;
            string evaluacion = "";

            while (totalAcciones <= 12)
            {
                Console.Write("Ingresa la evaluación para la acción No. {0}: ", totalAcciones);
                evaluacion = Console.ReadLine()!.ToUpper();

                //aqui se valida si la evaluación está con las opciones disponibles
                if (evaluacion == "R" || evaluacion == "G" || evaluacion == "I" || evaluacion == "M")
                {
                    if (evaluacion == "R")
                        totalR++;

                    if (evaluacion == "G")
                        totalG++;

                    if (evaluacion == "I")
                        totalI++;

                    if (evaluacion == "M")
                        totalM++;

                    totalAcciones++;
                }
                else
                {
                    Console.WriteLine("No ingresaste una evaluación válida. Intenta nuevamente! \n\n");
                }
            }

            //Aqui se visualizan los resultados

            Console.WriteLine("\n\nResultado de la Evaluación:");
            Console.WriteLine("Acciones Redentoras: {0}", totalR);
            Console.WriteLine("Acciones Genuinas: {0}", totalG);
            Console.WriteLine("Acciones Interesadas: {0}", totalI);
            Console.WriteLine("Acciones Maléficas: {0}", totalM);
            Console.WriteLine("Total acciones evaluadas: {0}\n", (totalR + totalG + totalI + totalM));

            //Aqui se emite el juicio según las acciones

            // Si las acciones redentoras son más que la mitad
            if (totalR > 6) // son 12 acciones
                Console.WriteLine("La mayoría de las acciones son Redentoras, el alma va al Buen Lugar!");
            else
                if ((totalI + totalM) > 6)
                    Console.WriteLine("La mayoría de las acciones son Maléficas e interesadas, el alma va al Mal Lugar!");
                else
                    Console.WriteLine("Las acciones no tienen el impacto suficiente, el alma va al Lugar Medio");
        }
    }
}
