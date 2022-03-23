/*
Programa:       ex02_ConversionRGBaCMYK
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Formulación: 
------------

Realice un programa que realice conversión en la notación de un color en formato RGB a CMYK.

Los componentes de los colores en RGB son expresados como valores en el intervalo [0;255]
Los componentes de los colores en CMYK son expresados como valores en el intervalo [0;255]

*/

using System;

namespace ex02_ConversionRGBaCMYK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short valorOpcion;
            bool datoCorrecto;

            do
            {
                Console.WriteLine("Programa para convertir colores de RGB a CMYK\n");
                Console.WriteLine("\t1. Conversión de RGB a CMYK");
                Console.WriteLine("\t2. Conversion de CMYK a RGB");
                Console.WriteLine("\t0. Salir del programa");

                Console.Write("\n\nSelecciona una opción: ");
                datoCorrecto = short.TryParse(Console.ReadLine(), out valorOpcion);

                //Si el dato no es correcto, debemos asignarle un valor a la opción
                //que repita el proceso. Por ejemplo, -1
                if (!datoCorrecto)
                    valorOpcion = -1;

                //Aqui invocamos las funciones según la opción:
                if (valorOpcion == 1)
                    ConvierteAEspacioCMYK();

                if (valorOpcion == 2)
                    ConvierteAEspacioRGB();

                if (valorOpcion != 1 && valorOpcion != 2 && valorOpcion != 0)
                {
                    Console.WriteLine("La opción ingresada no es válida. Intenta nuevamente!");
                    Console.Write("Presiona cualquier tecla para continuar... ");
                    Console.ReadKey();
                }

                //Borramos la consola cuando las opciones ingresadas no son para salir
                if (valorOpcion != 0)
                    Console.Clear();

            } while (valorOpcion != 0);

            //Aqui mostramos la salida
            Console.WriteLine("\n\nFin del programa");
        }

        /// <summary>
        /// Función que encapsula el proceso de conversión desde RGB a CMYK
        /// </summary>
        static void ConvierteAEspacioCMYK()
        {
            Console.Clear();
            Console.WriteLine("Programa para convertir colores de RGB a CMYK\n");

            //Arreglo de componentes del color: 0: Rojo, 1: Verde, 2: Azul
            uint[] componentesRGB = new uint[3];
            bool datoRojoCorrecto = false, datoVerdeCorrecto = false, datoAzulCorrecto = false;

            do
            {
                Console.Write("\nIngresa el valor del componente rojo [0;255]: ");
                datoRojoCorrecto = uint.TryParse(Console.ReadLine(), out componentesRGB[0]);

                Console.Write("Ingresa el valor del componente verde [0;255]: ");
                datoVerdeCorrecto = uint.TryParse(Console.ReadLine(), out componentesRGB[1]);

                Console.Write("Ingresa el valor del componente azul [0;255]: ");
                datoAzulCorrecto = uint.TryParse(Console.ReadLine(), out componentesRGB[2]);

                if (datoRojoCorrecto && datoVerdeCorrecto && datoAzulCorrecto)
                {
                    //Aqui validamos si los valores están en los rangos requeridos
                    //para cada componente de color

                    //Para el componente rojo
                    if (componentesRGB[0]>255)
                    {
                        Console.WriteLine("El Componente rojo no se encuentra en el intervalo esperado de [0;255]. Intenta nuevamente");
                        datoRojoCorrecto = false;
                    }

                    //Para el componente verde
                    if (componentesRGB[1] > 255)
                    {
                        Console.WriteLine("El Componente verde no se encuentra en el intervalo esperado de [0;255]. Intenta nuevamente");
                        datoVerdeCorrecto = false;
                    }

                    //Para el componente azul
                    if (componentesRGB[2] > 255)
                    {
                        Console.WriteLine("El Componente azul no se encuentra en el intervalo esperado de [0;255]. Intenta nuevamente");
                        datoAzulCorrecto = false;
                    }
                }
                else
                    Console.WriteLine("Los datos ingresados son inválidos. Intenta nuevamente!");
            }
            while (!datoRojoCorrecto || !datoVerdeCorrecto || !datoAzulCorrecto);

            //Aqui invocamos la función que hace la conversión de notación a CMYK
            uint[] componentesCMYK = CalculaCMYK(componentesRGB);

            //Aqui visualizamos resultados:
            Console.WriteLine("\nResultados de la conversión:");
            Console.WriteLine($"En notación RGB: " +
                $"{componentesRGB[0]}, " +
                $"{componentesRGB[1]}, " +
                $"{componentesRGB[2]}"
                );
            Console.WriteLine($"En notación CMYK: " +
                $"{componentesCMYK[0]}, " +
                $"{componentesCMYK[1]}, " +
                $"{componentesCMYK[2]}, " +
                $"{componentesCMYK[3]}"
                );

            Console.Write("\n\nPresiona cualquier tecla para continuar... ");
            Console.ReadKey();
        }
        
        /// <summary>
        /// Función que realiza el cálculo de conversión de los componentes RGB a CMYK
        /// </summary>
        /// <param name="componentesRGB">Arreglo con los componentes del color en RGB</param>
        /// <returns>Arreglo con los componentes del color en CMYK</returns>
        static uint[] CalculaCMYK(uint[] componentesRGB)
        {
            //Primero, normalizamos los componentes RGB en el intervalo [0;1]
            float[] normalizadoRGB = new float[componentesRGB.Length];

            for(int i = 0; i < componentesRGB.Length; i++)
                normalizadoRGB[i] = (float)componentesRGB[i]/255;

            //Aqui almacenamos los componentes CMYK normalizados
            //0: Cian, 1: Magenta, 2: Amarillo, 3: Negro
            float[] normalizadoCMYK = new float[4];

            //Componente negro: El máximo valor de los tres componentes
            normalizadoCMYK[3] = ValidaValorCero(1 - Math.Max(Math.Max(normalizadoRGB[0], normalizadoRGB[1]), normalizadoRGB[2]));

            //Componente cian - Basado en el componente rojo
            normalizadoCMYK[0] = ValidaValorCero((1 - normalizadoRGB[0] - normalizadoCMYK[3]) / (1 - normalizadoCMYK[3]));

            //Componente magenta - Basado en el componente verde
            normalizadoCMYK[1] = ValidaValorCero((1 - normalizadoRGB[1] - normalizadoCMYK[3]) / (1 - normalizadoCMYK[3]));

            //Componente amarillo - - Basado en el componente azul
            normalizadoCMYK[2] = ValidaValorCero((1 - normalizadoRGB[2] - normalizadoCMYK[3]) / (1 - normalizadoCMYK[3]));

            //Aqui definimos los resultados para cada componente en modelo CMYK
            uint[] resultadoCMYK = new uint[normalizadoCMYK.Length];

            //Aqui convertimos el CMYK normalizado nuevamente a sus valores en el intervalo [0;255]
            for (int i = 0; i < normalizadoCMYK.Length; i++)
                resultadoCMYK[i] = Convert.ToUInt32(normalizadoCMYK[i] * 255);

            return resultadoCMYK;
        }

        /// <summary>
        /// Función que encapsula el proceso de conversión desde CMYK a RGB
        /// </summary>
        static void ConvierteAEspacioRGB()
        {
            Console.Clear();
            Console.WriteLine("Programa para convertir colores de CMYK a RGB\n");

            //Arreglo de componentes del color: 0: Cian, 1: Magenta, 2: Amarillo, 3: Negro
            uint[] componentesCMYK = new uint[4];
            bool datoCianCorrecto = false, datoMagentaCorrecto = false, datoAmarilloCorrecto = false, datoNegroCorrecto = false;

            do
            {
                Console.Write("\nIngresa el valor del componente cian [0;255]: ");
                datoCianCorrecto = uint.TryParse(Console.ReadLine(), out componentesCMYK[0]);

                Console.Write("Ingresa el valor del componente magenta [0;255]: ");
                datoMagentaCorrecto = uint.TryParse(Console.ReadLine(), out componentesCMYK[1]);

                Console.Write("Ingresa el valor del componente amarillo [0;255]: ");
                datoAmarilloCorrecto = uint.TryParse(Console.ReadLine(), out componentesCMYK[2]);

                Console.Write("Ingresa el valor del componente negro [0;255]: ");
                datoNegroCorrecto = uint.TryParse(Console.ReadLine(), out componentesCMYK[3]);

                if (datoCianCorrecto && datoMagentaCorrecto && datoAmarilloCorrecto && datoNegroCorrecto)
                {
                    //Aqui validamos si los valores están en los rangos requeridos
                    //para cada componente de color

                    //Para el componente cian
                    if (componentesCMYK[0] > 255)
                    {
                        Console.WriteLine("El Componente cian no se encuentra en el intervalo esperado de [0;255]. Intenta nuevamente");
                        datoCianCorrecto = false;
                    }

                    //Para el componente magenta
                    if (componentesCMYK[1] > 255)
                    {
                        Console.WriteLine("El Componente magenta no se encuentra en el intervalo esperado de [0;255]. Intenta nuevamente");
                        datoMagentaCorrecto = false;
                    }

                    //Para el componente amarillo
                    if (componentesCMYK[2] > 255)
                    {
                        Console.WriteLine("El Componente amarillo no se encuentra en el intervalo esperado de [0;255]. Intenta nuevamente");
                        datoAmarilloCorrecto = false;
                    }

                    //Para el componente negro
                    if (componentesCMYK[3] > 255)
                    {
                        Console.WriteLine("El Componente negro no se encuentra en el intervalo esperado de [0;255]. Intenta nuevamente");
                        datoNegroCorrecto = false;
                    }
                }
                else
                    Console.WriteLine("Los datos ingresados son inválidos. Intenta nuevamente!");
            }
            while (!datoCianCorrecto || !datoMagentaCorrecto || !datoAmarilloCorrecto || !datoNegroCorrecto);

            //Aqui invocamos la función que hace la conversión de notación a CMYK
            uint[] componentesRGB = CalculaRGB(componentesCMYK);

            //Aqui visualizamos resultados:
            Console.WriteLine("\nResultados de la conversión:");
            Console.WriteLine($"En notación CMYK: " +
                $"{componentesCMYK[0]}, " +
                $"{componentesCMYK[1]}, " +
                $"{componentesCMYK[2]}, " +
                $"{componentesCMYK[3]}"
                );
            Console.WriteLine($"En notación RGB: " +
                $"{componentesRGB[0]}, " +
                $"{componentesRGB[1]}, " +
                $"{componentesRGB[2]}"
                );

            Console.Write("\n\nPresiona cualquier tecla para continuar... ");
            Console.ReadKey();
        }

        /// <summary>
        /// Función que realiza el cálculo de conversión de los componentes CMYK a RGB
        /// </summary>
        /// <param name="componentesRGB">Arreglo con los componentes del color en CMYK</param>
        /// <returns>Arreglo con los componentes del color en RGB</returns>
        static uint[] CalculaRGB(uint[] componentesCMYK)
        {
            //Primero, normalizamos los componentes RGB en el intervalo [0;1]
            //0: Cian, 1: Magenta, 2: Amarillo, 3: Negro
            float[] normalizadoCMYK = new float[componentesCMYK.Length];

            for (int i = 0; i < componentesCMYK.Length; i++)
                normalizadoCMYK[i] = (float)componentesCMYK[i] / 255;

            //Aqui almacenamos los componentes RGB normalizados
            //0: Rojo, 1: Verde, 2: Azul
            uint[] resultadoRGB = new uint[3];

            //Componente rojo
            resultadoRGB[0] = Convert.ToUInt32(255 * (1 - normalizadoCMYK[0]) * (1 - normalizadoCMYK[3]));

            //Componente verde
            resultadoRGB[1] = Convert.ToUInt32(255 * (1 - normalizadoCMYK[1]) * (1 - normalizadoCMYK[3]));

            //Componente azul
            resultadoRGB[2] = Convert.ToUInt32(255 * (1 - normalizadoCMYK[2]) * (1 - normalizadoCMYK[3]));

            return resultadoRGB;
        }

        /// <summary>
        /// Función que valida si el valor es cero o NaN y lo normaliza a cero
        /// </summary>
        /// <param name="valor">El valor a verificar</param>
        /// <returns>El valor normalizado en caso de necesitarse</returns>
        static float ValidaValorCero(float valor)
        {
            //Si el valor es cero o no es un numero (NaN), el valor será cero
            if (valor < 0 || float.IsNaN(valor))
                valor = 0;

            return valor;
        }
    }
}
