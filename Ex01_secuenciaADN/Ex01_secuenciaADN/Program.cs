/*
Programa:       Ex01_secuenciaADN
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
Examen 01: Condicionales y Ciclos de control


Procesamiento de cadenas de ADN
********************************

En un laboratorio de genética están analizando muestras de ADN para la identificación de las proteínas que la conforman. 
Cada muestra está conformada por las iniciales de las proteínas, así: (A)denina, (C)itosina, (G)uanina y (T)imina.

Realice un programa en C# pregunte 20 valores para las proteínas que conforman la secuencia. Debe contar cuantas son las 
proteínas por cada tipo. Si no corresponde a los valores correctos, deberá contabilizarlas como datos erróneos.

Si los 20 valores son correctos, procederá a visualizar la cantidad por cada tipo de proteína, indicando cuanto 
representa este valor del total.

Si hay datos erróneos, deberá indicar solamente cuantos datos erróneos se presentaron.

 */

namespace Ex01_secuenciaADN
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Programa para procesar secuencias de ADN");
            Console.WriteLine("\nSe digitarán 20 elementos correspondientes a las proteinas");
            Console.WriteLine("Adenina (A), Citosina (C), Guanina (G) y Timina (T)");
            Console.WriteLine("Cualquier valor diferente será registrado como error");

            //aqui declaramos las variables que utilizaremos
            string datoProteina;
            int totalElementos = 1, totalErrores = 0;
            float totalA = 0, totalC = 0, totalG = 0, totalT = 0;
            
            //El ciclo de control
            while (totalElementos <= 20)
            {
                Console.Write("\nElemento No. {0}, Ingrese la proteina (A/C/G/T): ", totalElementos);
                datoProteina = Console.ReadLine()!.ToUpper();

                //Aqui validamos si el dato ingresado corresponde a los valores válidos
                if (datoProteina == "A" || datoProteina == "C" || datoProteina == "G" || datoProteina == "T")
                {
                    //Si es válido, se incrementa el contador respectivo
                    if (datoProteina == "A")
                        totalA++;

                    if (datoProteina == "C")
                        totalC++;

                    if (datoProteina == "G")
                        totalG++;

                    if (datoProteina == "T")
                        totalT++;                    
                }

                //En caso de que sea erroneo, se visualiza el error y se aumenta el conteo
                else
                {
                    totalErrores++;
                    Console.WriteLine("El dato de proteina, {0}, no es válido!", datoProteina);
                }

                //Finalmente incrementamos el total de elementos válidos que llevamos
                totalElementos++;


            }//Fin del ciclo while

            //Aqui visualizamos los resultados

            //Primero identificamos si el procesamiento fue correcto
            if (totalErrores == 0)
            { 
                Console.WriteLine("\nEl procesamiento fue correcto, no se presentaron errores.");

                // declaramos las variables de los porcentajes
                float porA, porC, porG, porT;

                //Aqui calculamos los porcentajes, del total de 20 proteinas, cuantas fueron de cada tipo
                porA = (totalA / 20) * 100;
                porC = (totalC / 20) * 100;
                porG = (totalG / 20) * 100;
                porT = (totalT / 20) * 100;

                Console.WriteLine("\nPara la Adenina (A), se registraron {0} elementos, correspondientes al {1}% del total",
                    totalA, porA.ToString("00.00"));    // ToString con máscara para visualizar redondeado
                Console.WriteLine("Para la Citocina (C), se registraron {0} elementos, correspondientes al {1}% del total",
                    totalC, porC.ToString("00.00"));
                Console.WriteLine("Para la Guanina (G), se registraron {0} elementos, correspondientes al {1}% del total",
                    totalG, porG.ToString("00.00"));
                Console.WriteLine("Para la Timina (T), se registraron {0} elementos, correspondientes al {1}% del total",
                    totalT, porT.ToString("00.00"));

            }
            else
                Console.WriteLine("\nEl procesamiento fue con fallas, se presentaron {0} errores.", totalErrores);

        }
    }
}
