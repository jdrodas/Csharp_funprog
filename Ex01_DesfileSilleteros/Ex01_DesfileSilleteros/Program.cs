/*
Programa:       Ex01_DesfileSilleteros
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
Examen 01: Condicionales y Ciclos de control

Feria de Flores – Desfile de Silleteros

Medellín se encuentra nuevamente en Feria de las Flores y uno de los eventos 
principales es el Desfile de Silleteros. Una de las preocupaciones de los 
organizadores del evento es que se le esté dando demasiada importancia a las 
silletas comerciales que son patrocinadas por las empresas en detrimento de las
silletas tradicionales que son las que pueden mostrar más variedad de las flores 
cultivadas en Santa Elena.

Normalmente hay cuatro categorías de silletas: Emblemática, Tradicional, 
Monumental y Comercial. Para un desfile, se registran los participantes 
clasificándolos de acuerdo al tipo de silleta. Dependiendo de la cantidad por 
cada categoría, los organizadores pueden corroborar si sus preocupaciones son 
infundadas.

Se pide realizar una aplicación que le pregunte a cada uno de 12 silleteros en 
cual categoría participa, para luego totalizar cuantos fueron. Solo se permiten 
esas 4 categorías, en caso que se ingrese una categoría inválida, deberá solicitar 
nuevamente el registro.

Requerimientos:
• Realice un programa en C#.NET, aplicación de consola que implemente la captura 
de datos, calculo de porcentajes y visualización de resultados.
• Aunque las cantidades de participantes son números enteros, utilice el tipo de 
dato “float” para almacenar los datos numéricos.
• Se debe implementar el control de excepciones y las validaciones para que los 
valores numéricos ingresados por el usuario cumplan con lo esperado. Ojo: No hay 
cantidades de participantes negativas.
• El programa visualizará el resumen del desfile, escribiendo en consola para cada 
tipo de silleta, la cantidad de participantes y el porcentaje del total.
• Al final se debe decir:
    o El desfile fue preocupante si la categoría comercial es la de mayor número de
      participantes.
    o El desfile fue tradicional si la categoría tradicional es la de mayor número 
      de participantes.
    o El desfile fue balanceado si todas las categorías tuvieron igual número de 
      participantes.

*/

namespace Ex01_DesfileSilleteros
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para valorar el Desfile de Silleteros");
            Console.WriteLine("Se identificará el tipo de silletas de 12 participantes");
            Console.WriteLine("Categorias: (E)mblematica, (T)radicional, (M)onumental y (C)omercial");

            float totalParticipantes = 12;
            float silleterosEmblematica = 0, silleterosTradicional = 0, silleterosMonumental = 0, silleterosComercial = 0;

            float silleteroActual = 1;
            string categoriaSilletero = "";

            do
            {
                Console.Write($"\nIngresa categoría para el silletero No. {silleteroActual} (E/T/M/C): ");
                categoriaSilletero = Console.ReadLine()!.ToUpper();

                if (categoriaSilletero == "E" || categoriaSilletero == "T" || categoriaSilletero == "M" || categoriaSilletero == "C")
                {
                    if (categoriaSilletero == "E")
                        silleterosEmblematica++;

                    if (categoriaSilletero == "T")
                        silleterosTradicional++;

                    if (categoriaSilletero == "M")
                        silleterosMonumental++;

                    if (categoriaSilletero == "C")
                        silleterosComercial++;

                    //Pasamos al siguiente silletero
                    silleteroActual++;
                }
                else
                {
                    Console.WriteLine("No ingresaste una categoría válida. Intenta nuevamente");
                }
            }
            while (silleteroActual <= totalParticipantes);

            //aqui calculamos los porcentajes
            float porcentajeEmblematica = (silleterosEmblematica / totalParticipantes) * 100;
            float porcentajeComercial = (silleterosComercial / totalParticipantes) * 100;
            float porcentajeMonumental = (silleterosMonumental / totalParticipantes) * 100;
            float porcentajeTradicional = (silleterosTradicional / totalParticipantes) * 100;

            //Aqui visualizamos resultados
            Console.WriteLine("\nResultados por categoría: ");
            Console.WriteLine($"Silletas Comerciales: {silleterosComercial} que corresponden al {porcentajeComercial}%");
            Console.WriteLine($"Silletas Emblemáticas: {silleterosEmblematica} que corresponden al {porcentajeEmblematica}%");
            Console.WriteLine($"Silletas Monumentales: {silleterosMonumental} que corresponden al {porcentajeMonumental}%");
            Console.WriteLine($"Silletas Tradicionales: {silleterosTradicional} que corresponden al {porcentajeTradicional}%\n");

            //Finalmente validamos las hipótesis:
            //Fue desfile preocupante? Es categoría Comercial la mayor?
            if (silleterosComercial > silleterosEmblematica &&
                silleterosComercial > silleterosMonumental &&
                silleterosComercial > silleterosTradicional)
            {
                Console.WriteLine("El desfile fue preocupante. La categoría comercial fue la de mayor cantidad de participantes");
            }

            //Fue desfile tradicional? Es categoría tradicional la mayor?
            if (silleterosTradicional > silleterosEmblematica &&
                silleterosTradicional > silleterosMonumental &&
                silleterosTradicional > silleterosComercial)
            {
                Console.WriteLine("El desfile fue preocupante. La categoría comercial fue la de mayor cantidad de participantes");
            }

            //Fue desfile balanceado? Todas las categorías tienen el mismo numero de participantes
            if (silleterosTradicional == silleterosEmblematica &&
                silleterosEmblematica == silleterosMonumental &&
                silleterosMonumental == silleterosComercial)
            {
                Console.WriteLine("El desfile fue balanceado. Todas las categorias tienen la misma cantidad de participantes");
            }
            else
            {
                Console.WriteLine("El desfile fue normal, sin preocupaciones!");
            }
        }
    }
}
