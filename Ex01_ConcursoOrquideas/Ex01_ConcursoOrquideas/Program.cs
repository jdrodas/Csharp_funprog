/*

Programa:       Ex01_ConcursoOrquideas
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
Examen 01: Condicionales y Ciclos de control
 
Feria de Flores – Concurso de Orquídeas

Medellín se encuentra nuevamente en Feria de las Flores y uno de los eventos principales
es el Concurso de Orquídeas. En esta oportunidad, un grupo de floricultores está interesado 
en saber cuáles son las especies que más se presentan a concursar de acuerdo al favoritismo 
de los visitantes.

Cada día, realizan una encuesta a participantes y le preguntan cuál fue la que más le gustó. 
Para facilitar la tabulación, han limitado su interés en solo 5 tipos de orquídeas: Cattleya, 
Houlletias, Josefinas, Stelis y Zapatico.

Se pide realizar una aplicación que permita ingresar cuantos visitantes prefirieron cada uno
de los tipos de orquídeas, visualice el porcentaje del total e identifique cual fue la 
favorita del día.

Requerimientos:
• Realice un programa en C#.NET, aplicación de consola que implemente la captura de datos,
calculo de porcentajes y visualización de resultados.

• Aunque las cantidades de visitantes son números enteros, utilice el tipo de dato “float” para
almacenar los datos numéricos.

• Se debe implementar el control de excepciones y las validaciones para que los valores numéricos
ingresados por el usuario cumplan con lo esperado. Ojo: No hay cantidades de visitantes
negativas.

• El programa visualizará el resumen del concurso, escribiendo en consola para cada orquídea, la
cantidad de visitantes que votaron por ese tipo y el porcentaje del total.
 
• Se debe identificar la favorita, la cual es la que tenga el mayor porcentaje de votos. Si no hay una
favorita, se debe indicar simplemente que no hubo una única favorita.

*/

namespace Ex01_ConcursoOrquideas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para identificar la orquidea favorita del concurso");
            Console.WriteLine("Se escogerán entre Cattleya, Houlletias, Josefinas, Stelis y Zapatico");

            bool datosCorrectos = false;
            float totalCattleya=0, totalHoulettias=0, totalJosefinas=0, totalStelis=0, totalZapatico=0;

            //Este ciclo se repetirá hasta que TODOS los valores sean válidos
            while (datosCorrectos == false)
            {
                try
                {
                    Console.Write("\nIngresa el número de visitantes que votaron por Cattleya: ");
                    totalCattleya = float.Parse(Console.ReadLine()!);

                    Console.Write("\nIngresa el número de visitantes que votaron por Houlletias: ");
                    totalHoulettias = float.Parse(Console.ReadLine()!);

                    Console.Write("\nIngresa el número de visitantes que votaron por Josefinas: ");
                    totalJosefinas = float.Parse(Console.ReadLine()!);

                    Console.Write("\nIngresa el número de visitantes que votaron por Stelis: ");
                    totalStelis = float.Parse(Console.ReadLine()!);

                    Console.Write("\nIngresa el número de visitantes que votaron por Zapatico: ");
                    totalZapatico = float.Parse(Console.ReadLine()!);

                    //Aqui validamos que los numeros sean positivos
                    if (totalCattleya >= 0 && totalHoulettias >= 0 && totalJosefinas >= 0 && totalStelis >= 0 && totalZapatico >= 0)
                        datosCorrectos = true;
                   else
                        Console.WriteLine("Los datos ingresados no son validos como cantidad de visitantes.Intenta nuevamente");
                }
                catch (FormatException elError)

                {
                    Console.WriteLine("Los datos deben ser numericos positivos. Intenta nuevamente");
                    Console.WriteLine(elError.Message);
                }
            }

            //Aqui calculamos los porcentajes
            float totalVisitantes = totalCattleya +
                                    totalHoulettias +
                                    totalJosefinas +
                                    totalStelis +
                                    totalZapatico;

            float porcentajeCattleya = (totalCattleya / totalVisitantes) * 100;
            float porcentajeHulettias = (totalHoulettias / totalVisitantes) * 100;
            float porcentajeJosefinas = (totalJosefinas / totalVisitantes) * 100;
            float porcentajeStelis = (totalStelis / totalVisitantes) * 100;
            float porcentajeZapatico = (totalZapatico / totalVisitantes) * 100;

            //Aqui visualizamos resultados

            Console.WriteLine("\nResultados obtenidos:");
            Console.WriteLine($"- Cattleya: {totalCattleya} votos, {porcentajeCattleya.ToString("0.00")}%");
            Console.WriteLine($"- Houlettias: {totalHoulettias} votos, {porcentajeHulettias.ToString("0.00")}%");
            Console.WriteLine($"- Josefinas: {totalJosefinas} votos, {porcentajeJosefinas.ToString("0.00")}%");
            Console.WriteLine($"- Stelis: {totalStelis} votos, {porcentajeStelis.ToString("0.00")}%");
            Console.WriteLine($"- Zapatico: {totalZapatico} votos, {porcentajeZapatico.ToString("0.00")}%");

            Console.WriteLine($"\nTotal visitantes: {totalVisitantes}");

            //Aqui identificamos cual es la favorita
            bool favoritaEncontrada = false;

            if (totalCattleya > totalHoulettias && totalCattleya > totalJosefinas && totalCattleya > totalStelis && totalCattleya > totalZapatico)
            {
                Console.WriteLine("La Cattleya es la favorita!");
                favoritaEncontrada = true;
            }

            if (totalHoulettias > totalCattleya && totalHoulettias > totalJosefinas && totalHoulettias > totalStelis && totalHoulettias > totalZapatico)
            {
                Console.WriteLine("La Houlettias es la favorita!");
                favoritaEncontrada = true;
            }

            if (totalJosefinas > totalCattleya && totalJosefinas > totalHoulettias && totalJosefinas > totalStelis && totalJosefinas > totalZapatico)
            {
                Console.WriteLine("La Josefina es la favorita!");
                favoritaEncontrada = true;
            }

            if (totalStelis > totalCattleya && totalStelis > totalJosefinas && totalStelis > totalHoulettias && totalStelis > totalZapatico)
            {
                Console.WriteLine("La Stelis es la favorita!");
                favoritaEncontrada = true;
            }

            if (totalZapatico > totalHoulettias && totalZapatico > totalJosefinas && totalZapatico > totalStelis && totalZapatico > totalCattleya)
            {
                Console.WriteLine("La Zapatico es la favorita!");
                favoritaEncontrada = true;
            }

            //Si despues de pasar por todas, no hay favorita, se indica que no hubo única favorita
            if (favoritaEncontrada == false)
                Console.WriteLine("No se encontró una única favorita!");

        }
    }
}
