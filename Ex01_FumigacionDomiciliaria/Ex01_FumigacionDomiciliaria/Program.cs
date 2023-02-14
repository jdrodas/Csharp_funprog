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

using System;

namespace Ex01_FumigacionDomiciliaria
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa para registrar acciones de fumigación en conjuntos residenciales");
            Console.WriteLine("Se fumigarán casas por roedores, insectos y hongos");

            float casasSinFumigar = 0f, casasConRoedores = 0f, casasConInsectos = 0f, casasConHongos = 0f;
            bool datoIngresadoCorrecto;

            // Ingreso dato casas con roedores
            datoIngresadoCorrecto = false;
            do 
            {
                try
                {
                    Console.Write("\nCuántas casas se fumigaron contra roedores? ");
                    casasConRoedores = float.Parse(Console.ReadLine()!);

                    if (casasConRoedores < 0)
                        Console.WriteLine("La cantidad de casas no puede ser negativa. Intenta nuevamente.");
                    else
                        datoIngresadoCorrecto = true;
                }
                catch (FormatException elError)
                {
                    Console.WriteLine("El dato ingresado no está en el formato válido. Intenta nuevamente.");
                    Console.WriteLine($"{elError.Message}");
                }
            }
            while(datoIngresadoCorrecto == false);

            // Ingreso dato casas con insectos
            datoIngresadoCorrecto = false;
            do
            {
                try
                {
                    Console.Write("\nCuántas casas se fumigaron contra insectos? ");
                    casasConInsectos = float.Parse(Console.ReadLine()!);

                    if (casasConInsectos < 0)
                        Console.WriteLine("La cantidad de casas no puede ser negativa. Intenta nuevamente.");
                    else
                        datoIngresadoCorrecto = true;
                }
                catch (FormatException elError)
                {
                    Console.WriteLine("El dato ingresado no está en el formato válido. Intenta nuevamente.");
                    Console.WriteLine($"{elError.Message}");
                }
            }
            while (datoIngresadoCorrecto == false);

            // Ingreso dato casas con hongos
            datoIngresadoCorrecto = false;
            do
            {
                try
                {
                    Console.Write("\nCuántas casas se fumigaron contra hongos? ");
                    casasConHongos = float.Parse(Console.ReadLine()!);

                    if (casasConHongos < 0)
                        Console.WriteLine("La cantidad de casas no puede ser negativa. Intenta nuevamente.");
                    else
                        datoIngresadoCorrecto = true;
                }
                catch (FormatException elError)
                {
                    Console.WriteLine("El dato ingresado no está en el formato válido. Intenta nuevamente.");
                    Console.WriteLine($"{elError.Message}");
                }
            }
            while (datoIngresadoCorrecto == false);

            // Ingreso dato casas con hongos
            datoIngresadoCorrecto = false;
            do
            {
                try
                {
                    Console.Write("\nCuántas casas NO se fumigaron? ");
                    casasSinFumigar = float.Parse(Console.ReadLine()!);

                    if (casasSinFumigar < 0)
                        Console.WriteLine("La cantidad de casas no puede ser negativa. Intenta nuevamente.");
                    else
                        datoIngresadoCorrecto = true;
                }
                catch (FormatException elError)
                {
                    Console.WriteLine("El dato ingresado no está en el formato válido. Intenta nuevamente.");
                    Console.WriteLine($"{elError.Message}");
                }
            }
            while (!datoIngresadoCorrecto); // Negar el valor, antecediéndolo del símbolo "!"


            //Calculamos el total de casas fumigadas
            float totalCasasVisitadas = casasConHongos +
                                        casasConHongos +
                                        casasConRoedores +
                                        casasSinFumigar;

            //Aqui calculamos porcentajes.
            float porcFumHongos = (casasConHongos / totalCasasVisitadas) * 100;
            float porcFumInsectos = (casasConInsectos / totalCasasVisitadas) * 100;
            float porcFumRoedores = (casasConRoedores / totalCasasVisitadas) * 100;
            float porcNoFumigadas = (casasSinFumigar / totalCasasVisitadas) * 100;

            //Aqui visualizamos resultados:

            Console.WriteLine("\n *** Resultados del proceso de fumigación ***");

            Console.WriteLine($"\nSe fumigaron {casasConRoedores} casas contra roedores, " +
                $"equivalente a {porcFumRoedores.ToString("00.00")}%");

            Console.WriteLine($"\nSe fumigaron {casasConInsectos} casas contra insectos, " +
                $"equivalente a {porcFumInsectos.ToString("00.00")}%");

            Console.WriteLine($"\nSe fumigaron {casasConHongos} casas contra hongos, " +
                $"equivalente a {porcFumHongos.ToString("00.00")}%");

            Console.WriteLine($"\nNO se fumigaron {casasSinFumigar} casas, " +
                $"equivalente a {porcNoFumigadas.ToString("00.00")}%");

            //Escribimos el resultado de la evaluación de la actividad de fumigación:
            if (casasSinFumigar == 0)
                Console.WriteLine("\nFumigación exitosa! - la totalidad de los hogares fueron fumigados.");
            else
                Console.WriteLine("\nFumigación incompleta! - hay hogares que no se fumigaron.");


        }
    }
}