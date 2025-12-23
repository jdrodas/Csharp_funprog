/*
Programa:       MatricesZoo
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com


Propósito:
----------

- Demostrar la utilización de matrices como estructura de datos
- Implementar funciones que totalicen por filas y por columnas
- Utilizar ciclos while y for para llenar y visualizar contenidos de la matriz
*/

namespace MatricesZoo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Programa para totalizar la cantidad de comida que se necesita en un Zoológico");
            Console.WriteLine("Se tienen animales herbívoros y carnívoros en entornos");
            Console.WriteLine("Aéreos, terrestres y acuáticos.");
            Console.WriteLine("La cantidad de alimento está entre [10;50] kg.");
            Console.WriteLine("Se visualizan totales por entorno y por tipo de alimentación\n\n");

            string[] tipos = ["Herbívoros", "Carnívoros"];
            string[] entornos = ["Acuático", "Terrestre", "Aéreo"];

            float[,] alimentos = new float[tipos.Length, entornos.Length];

            int tipo = 0, entorno;          //Son las variables de control de los ciclos while
            bool datoCorrecto;

            //Empezamos recorriendo cada tipo
            while (tipo < tipos.Length)
            {
                entorno = 0;
                //Seguimos recorriendo cada entorno
                while (entorno < entornos.Length)
                {
                    Console.Write($"Ingresa la cantidad de alimentos para {tipos[tipo]} " +
                        $"en el entorno {entornos[entorno]}: ");
                    datoCorrecto = float.TryParse(Console.ReadLine(), out float cantidad);

                    //Si el dato se convirtió correctamente a numero float
                    if (datoCorrecto == true)
                        //Si la cantidad está en el rango esperado
                        if (cantidad >= 10 && cantidad <= 50)
                        {
                            alimentos[tipo, entorno] = cantidad;
                            entorno++; //Condición de salida del while de los entornos
                        }
                        else
                            Console.WriteLine("La cantidad de alimento ingresada no está en el rango [10;50]. Intenta nuevamente!\n");
                    else
                        Console.WriteLine("Ingresaste un dato no numérico, intenta nuevamente!\n");
                }

                //Terminamos los entornos, Incrementamos para el siguiente tipo
                Console.WriteLine();
                tipo++; //Condición de salida del while de los tipos
            }

            //Aqui calculamos los totales
            float[] totalesEntorno = CalculaTotales(alimentos, "Entorno");
            float[] totalesTipo = CalculaTotales(alimentos, "Tipo");

            //Calculamos la cantidad total de alimento para zoologico
            float totalCantidad = 0;
            for (entorno = 0; entorno < alimentos.GetLength(1); entorno++)
                for (tipo = 0; tipo < alimentos.GetLength(0); tipo++)
                    totalCantidad += alimentos[tipo, entorno];


            //aqui visualizamos los resultados
            Console.WriteLine("\n\nLos resultados obtenidos son:");
            Console.WriteLine($"Total Kgs de alimento en todo el zoológico: {totalCantidad:00.00}");

            Console.WriteLine("\nTotal kgs de alimento por tipo de alimentación:");
            for (int i = 0; i < tipos.Length; i++)
                Console.WriteLine($"Tipo {tipos[i]} se consume {totalesTipo[i]:00.00}");

            Console.WriteLine("\nTotal kgs de alimento por entorno:");
            for (int i = 0; i < entornos.Length; i++)
                Console.WriteLine($"Tipo {entornos[i]} se consume {totalesEntorno[i]:00.00}");
        }

        /// <summary>
        /// Calcula los totales según el criterio, Entorno o Tipo
        /// </summary>
        /// <param name="cantidadAlimentos"></param>
        /// <param name="claseTotal"></param>
        /// <returns></returns>
        static float[] CalculaTotales(float[,] cantidadAlimentos, string claseTotal)
        {
            //La dimension 0 tiene los tipos
            //La dimension 1 tiene los entornos

            //Arbritrariamente lo declaro con el tamaño de la primera dimensión
            float[] totales = new float[cantidadAlimentos.GetLength(0)];
            int entorno, tipo;

            // Totalizamos por entorno del animal
            if (claseTotal == "Entorno")
            {
                totales = new float[cantidadAlimentos.GetLength(1)];

                for (entorno = 0; entorno < cantidadAlimentos.GetLength(1); entorno++)
                {
                    totales[entorno] = 0; //Inicializamos la acumulación por entorno
                    for (tipo = 0; tipo < cantidadAlimentos.GetLength(0); tipo++)
                        totales[entorno] += cantidadAlimentos[tipo, entorno];
                }
            }

            //Totalizamos por tipo de animal
            if (claseTotal == "Tipo")
            {
                totales = new float[cantidadAlimentos.GetLength(0)];
                for (tipo = 0; tipo < cantidadAlimentos.GetLength(0); tipo++)
                {
                    totales[tipo] = 0; //Inicializamos la acumulación por entorno
                    for (entorno = 0; entorno < cantidadAlimentos.GetLength(1); entorno++)
                        totales[tipo] += cantidadAlimentos[tipo, entorno];
                }
            }
            return totales;
        }
    }
}