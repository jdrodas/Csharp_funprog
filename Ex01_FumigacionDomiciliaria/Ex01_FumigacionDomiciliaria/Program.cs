/*
Programa:       Ex01_FumigacionDomiciliaria
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
Examen 01: Condicionales y Ciclos de control


Fumigación contra plagas – Conjuntos Residenciales
**************************************************

El cambio climático es una realidad y uno de los efectos imprevistos de esta situación es la proliferación
de roedores, insectos y hongos en los conjuntos residenciales.

Para cumplir su labor, los conjuntos residenciales contratan empresas especializadas para que realicen
actividades de fumigación en recintos cerrados con las debidas precauciones para los habitantes de los
hogares.

Dependiendo del control que se pretenda hacer, la empresa se prepara con el producto respectivo. Para
nuestro caso, se limitarán las opciones a fumigación contra Roedores, Insectos y Hongos.

Cada hogar del conjunto residencial puede escoger que tratamiento aplicar, teniendo presente que
- En este caso particular, cada hogar solo realizará un proceso de fumigación.
- En este caso particular, puede presentarse que un hogar no realice fumigación

Se requiere realizar un programa que permita llevar el registro de las fumigaciones de los hogares de un
conjunto residencial, indicando para cada tipo de plaga, la cantidad de hogares que se fumigarán.

El programa visualizará los resultados indicando :
- Cuantos hogares se fumigaron
- Para cada plaga, cuantos hogares se fumigaron y que porcentaje del total representa.
- Cuantos hogares no se fumigaron y qué porcentaje del total representa.

Para evaluar el proceso de fumigación, el programa visualizará los siguientes mensajes en caso de que se
presenten estos escenarios:
-  “Fumigación exitosa”, si la totalidad de los hogares fueron fumigados.
-  “Fumigación incompleta”, Si hay hogares que no se fumigaron.

Requerimientos:
-   Realice un programa en C#.NET, aplicación de consola que implemente la captura de datos,
   cálculo de porcentajes y visualización de resultados.
-   Aunque las cantidades de hogares son números enteros, utilice el tipo de dato “float” para
   almacenar los datos numéricos.
-   Se debe implementar el control de excepciones y las validaciones para que los valores numéricos
   ingresados por el usuario cumplan con lo esperado. Ojo: No hay cantidades de hogares negativas.
   Si se ingresa un dato erróneo, se debe controlar el error y volver a solicitar el dato.
-   El programa visualizará el resumen del proceso de fumigación, de acuerdo con la especificación
   presentada previamente.

*/

namespace Ex01_FumigacionDomiciliaria
{
    public class Program
    {
        static public void Main()
        {
            Console.WriteLine("Programa para llevar el control de hogares fumigados");
            Console.WriteLine("Se fumigarán contra Hongos, Insectos y Roedores");

            float hogaresHongos = 0, hogaresInsectos = 0, hogaresRoedores = 0, hogaresSinFumigar = 0;
            bool esDatoCorrecto = false;

            //Aqui leemos los hogares fumigados contra hongos
            do
            {
                try
                {
                    Console.Write("\nIngresa la cantidad de hogares fumigados contra hongos: ");
                    hogaresHongos = float.Parse(Console.ReadLine()!);

                    if (hogaresHongos >= 0)
                        esDatoCorrecto = true;
                    else
                        Console.WriteLine("La cantidad debe ser entera mayor que cero. Intenta nuevamente");

                }
                catch (FormatException elError)
                {
                    Console.WriteLine("El dato ingresado no tiene el formato esperado. Intenta nuevamente");
                    Console.WriteLine($"{elError.Message}");
                }
            }
            while (esDatoCorrecto == false);

            //Aqui leemos los hogares fumigados contra insectos
            esDatoCorrecto = false;
            do
            {
                try
                {
                    Console.Write("\nIngresa la cantidad de hogares fumigados contra insectos: ");
                    hogaresInsectos = float.Parse(Console.ReadLine()!);

                    if (hogaresInsectos >= 0)
                        esDatoCorrecto = true;
                    else
                        Console.WriteLine("La cantidad debe ser entero mayor o igual a cero. Intenta nuevamente");

                }
                catch (FormatException elError)
                {
                    Console.WriteLine("El dato ingresado no tiene el formato esperado. Intenta nuevamente");
                    Console.WriteLine($"{elError.Message}");
                }
            }
            while (esDatoCorrecto == false);

            //Aqui leemos los hogares fumigados contra roedores
            esDatoCorrecto = false;
            do
            {
                try
                {
                    Console.Write("\nIngresa la cantidad de hogares fumigados contra roedores: ");
                    hogaresRoedores = float.Parse(Console.ReadLine()!);

                    if (hogaresRoedores >= 0)
                        esDatoCorrecto = true;
                    else
                        Console.WriteLine("La cantidad debe ser entero mayor o igual a cero. Intenta nuevamente");

                }
                catch (FormatException elError)
                {
                    Console.WriteLine("El dato ingresado no tiene el formato esperado. Intenta nuevamente");
                    Console.WriteLine($"{elError.Message}");
                }
            }
            while (esDatoCorrecto == false);

            //Aqui leemos los hogares que no fueron fumigados
            esDatoCorrecto = false;
            do
            {
                try
                {
                    Console.Write("\nIngresa la cantidad de no fueron fumigados: ");
                    hogaresSinFumigar = float.Parse(Console.ReadLine()!);

                    if (hogaresSinFumigar >= 0)
                        esDatoCorrecto = true;
                    else
                        Console.WriteLine("La cantidad debe ser entero mayor o igual a cero. Intenta nuevamente");

                }
                catch (FormatException elError)
                {
                    Console.WriteLine("El dato ingresado no tiene el formato esperado. Intenta nuevamente");
                    Console.WriteLine($"{elError.Message}");
                }
            }
            while (esDatoCorrecto == false);

            float totalHogares = hogaresHongos + hogaresInsectos + hogaresRoedores + hogaresSinFumigar;
            float totalHogaresFumigados = hogaresHongos + hogaresInsectos + hogaresRoedores;

            Console.WriteLine("\n *** Resultados del proceso de fumigación ***");

            if (totalHogares <= 0)
            {
                Console.WriteLine("No se fumigó ningún hogar para ninguna plaga.");
            }
            else
            {
                //Aqui se calculan los porcentajes
                float porcentajeHongos = (hogaresHongos / totalHogares) * 100;
                float porcentajeInsectos = (hogaresInsectos / totalHogares) * 100;
                float porcentajeRoedores = (hogaresRoedores / totalHogares) * 100;
                float porcentajeSinFumigar = (hogaresSinFumigar / totalHogares) * 100;

                Console.WriteLine($"- Del total de hogares que fue {totalHogares}, " +
                    $"se fumigaron {totalHogaresFumigados}.");

                Console.WriteLine($"Para hongos se fumigaron {hogaresHongos} hogares " +
                    $"que corresponde a {Math.Round(porcentajeHongos, 2)}%");

                Console.WriteLine($"Para insectos se fumigaron {hogaresInsectos} hogares " +
                    $"que corresponde a {Math.Round(porcentajeInsectos, 2)}%");

                Console.WriteLine($"Para roedores se fumigaron {hogaresRoedores} hogares " +
                    $"que corresponde a {Math.Round(porcentajeRoedores, 2)}%");

                if (hogaresSinFumigar > 0)
                {
                    Console.WriteLine($"\nNo se fumigaron {hogaresSinFumigar} " +
                    $"hogares que corresponde al {Math.Round(porcentajeSinFumigar, 2)}%");

                    Console.WriteLine("FUMIGACIÓN INCOMPLETA: Hay hogares sin fumigar");
                }
                else
                {
                    Console.WriteLine("\nFUMIGACIÓN EXITOSA: Todos los hogares fueron fumigados");
                }
            }
        }
    }
}