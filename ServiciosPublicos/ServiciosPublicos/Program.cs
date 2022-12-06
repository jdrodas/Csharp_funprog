using System;

namespace ServiciosPublicos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para simular el consumo de servicios publicos");
            Console.WriteLine("Se Generarán 1000 servicios de manera aleatoria");

            string[] nombresServicios = new string[] { "Energía", "Acueducto", "Gas", "Telefonía local", "Internet" };
            Servicio[] losServicios = new Servicio[1000];
            int i;

            //Inicializamos el arreglo con valores aleatorios para el nombre y el consumo
            Random aleatorio = new Random();

            for (i = 0; i < losServicios.Length; i++)
            {
                losServicios[i] = new Servicio();
                losServicios[i].Nombre = nombresServicios[aleatorio.Next(nombresServicios.Length)];
                losServicios[i].Consumo = aleatorio.Next(10000, 100001); //Se le suma 1 al limite superior para incluir el valor máximo

                Console.WriteLine($"Posicion {i + 1}, Servicio {losServicios[i].Nombre}, consumo: {losServicios[i].Consumo} ");
            }

            int[] totalesServicios = CalculaTotales(losServicios, nombresServicios);
            float[] promediosServicios = CalculaPromedios(losServicios, nombresServicios);
            float[] minimoConsumoServicios = BuscaMinimoConsumo(losServicios, nombresServicios);
            float[] maximoConsumoServicios = BuscaMaximoConsumo(losServicios, nombresServicios);

            //Visualizamos los resultados
            Console.WriteLine("\nResultados de la simulación:\n");
            int totalRegistros = 0;

            for (i = 0; i < nombresServicios.Length; i++)
            {
                Console.WriteLine($"Servicio: {nombresServicios[i]}, {totalesServicios[i]} registros, {promediosServicios[i]} valor promedio");
                Console.WriteLine($"El mínimo fue {minimoConsumoServicios[i]} y el máximo fue {maximoConsumoServicios[i]} \n");

                totalRegistros += totalesServicios[i];
            }

            Console.WriteLine($"Total registros: {totalRegistros}");
        }

        /// <summary>
        /// Busca el valor maximo del consumo para cada tipo de servicio
        /// </summary>
        /// <param name="arregloServicios">El arreglo con los servicios</param>
        /// <param name="arregloNombres">El arreglo con el nombre de los servicios</param>
        /// <returns>arreglo con el consumo máximo para cada tipo de servicio</returns>
        static float[] BuscaMaximoConsumo(Servicio[] arregloServicios, string[] arregloNombres)
        {
            float[] maximos = new float[arregloNombres.Length];
            int i;

            //Inicializamos el arreglo con el valor máximo para los consumos
            for (i = 0; i < maximos.Length; i++)
                maximos[i] = 10000;

            for (i = 0; i < arregloServicios.Length; i++)
                for (int j = 0; j < arregloNombres.Length; j++)
                    // Aqui validamos si el servicio es del tipo definido en los nombres
                    if (arregloServicios[i].Nombre == arregloNombres[j])
                        //Aqui preguntamos si el consumo de este servicio es menor
                        //que el valor actual encontrado para este servicio
                        if (arregloServicios[i].Consumo > maximos[j])
                            maximos[j] = arregloServicios[i].Consumo;

            return maximos;
        }

        /// <summary>
        /// Busca el valor mínimo del consumo para cada tipo de servicio
        /// </summary>
        /// <param name="arregloServicios">El arreglo con los servicios</param>
        /// <param name="arregloNombres">El arreglo con el nombre de los servicios</param>
        /// <returns>arreglo con el consumo mínimo para cada tipo de servicio</returns>
        static float[] BuscaMinimoConsumo(Servicio[] arregloServicios, string[] arregloNombres)
        {
            float[] minimos = new float[arregloNombres.Length];
            int i;

            //Inicializamos el arreglo con el valor máximo para los consumos
            for (i = 0; i < minimos.Length; i++)
                minimos[i] = 100000;

            for (i = 0; i < arregloServicios.Length; i++)
                for (int j = 0; j < arregloNombres.Length; j++)
                    // Aqui validamos si el servicio es del tipo definido en los nombres
                    if (arregloServicios[i].Nombre == arregloNombres[j])
                        //Aqui preguntamos si el consumo de este servicio es menor
                        //que el valor actual encontrado para este servicio
                        if (arregloServicios[i].Consumo < minimos[j])
                            minimos[j] = arregloServicios[i].Consumo;

            return minimos;
        }

        /// <summary>
        /// Calcula el promedio del consumo promedio para cada tipo de servicio
        /// </summary>
        /// <param name="arregloServicios">El arreglo con los servicios</param>
        /// <param name="arregloNombres">El arreglo con el nombre de los servicios</param>
        /// <returns>arreglo con el consumo promedio para cada tipo de servicio</returns>
        static float[] CalculaPromedios(Servicio[] arregloServicios, string[] arregloNombres)
        {
            float[] promedios = new float[arregloNombres.Length];
            int[] totales = CalculaTotales(arregloServicios, arregloNombres);
            int i;

            //inicializamos el arreglo con valores en cero
            for (i = 0; i < promedios.Length; i++)
                promedios[i] = 0;

            //Sumamos el consumo de todos los elementos que son de un tipo de servicios
            for (i = 0; i < arregloServicios.Length; i++)
                for (int j = 0; j < arregloNombres.Length; j++)
                    if (arregloServicios[i].Nombre == arregloNombres[j])
                        promedios[j] += arregloServicios[i].Consumo;

            //Dividimos el valor encontrado por la cantidad de elementos de ese tipo de servicios
            for (i = 0; i < promedios.Length; i++)
            {
                //promedios[i] /= totales[i];
                promedios[i] = promedios[i] / totales[i];
            }

            return promedios;
        }

        /// <summary>
        /// Calcula el total de registros por cada servicio
        /// </summary>
        /// <param name="arregloServicios">El arreglo de servicios</param>
        /// <param name="arregloNombres">los nombres de servicios válidos</param>
        /// <returns>Arreglo de valores con la cantidad por cada servicio</returns>
        static int[] CalculaTotales(Servicio[] arregloServicios, string[] arregloNombres)
        {
            int[] totales = new int[arregloNombres.Length];
            int i;

            //inicializamos el arreglo con valores en cero
            for (i = 0; i < totales.Length; i++)
                totales[i] = 0;

            //Contamos cuantos elementos hay por cada servicio
            for (i = 0; i < arregloServicios.Length; i++)
                for (int j = 0; j < arregloNombres.Length; j++)
                    if (arregloServicios[i].Nombre == arregloNombres[j])
                        totales[j]++;

            return totales;
        }
    }
}
