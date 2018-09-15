/*
Programa:       ex02_ColonizacionMarte
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------

- Ejercicio utilizando condicionales, ciclos de control, funciones, arreglos


Colonización de Marte – Envío de Recursos

El exitoso lanzamiento del Falcon Heavy como transporte confiable interplanetario, 
abrió las posibilidades a la colonización interplanetaria, con primer objetivo el 
establecer asentamientos humanos en Marte.

Para ello, se realizarán 15 lanzamientos de materiales necesarios para la colonización, 
que estarán ubicados en las planicies (A)cidalia, (E)lysium y (U)topia. Cada lanzamiento 
tiene un cargamento de hasta 10.000 kg, pero por posibles daños durante el transporte, 
puede llegar menos cantidad. También se puede dar el caso que no llegue ninguno de los 
15 lanzamientos a alguna de las planicies.

Se requiere hacer un programa que permita capturar para cada lanzamiento a cuál planicie 
corresponde y cuánto material llegó, teniendo en cuenta el rango de valores válidos para 
los lanzamientos. Si la planicie no es válida o el valor no está en el rango, debe 
repetirse el ingreso del dato. 

Posteriormente se generarán los siguientes resultados por cada planicie:
- Cuantos lanzamientos llegaron a cada planicie
- El total de material que llegó intacto a cada planicie
- El promedio de efectividad del transporte a cada planicie: total de material dividido 
  por la cantidad de lanzamientos.

El programa debe:
- Utilizar arreglos, tanto para identificar las planicies como para almacenar el total de 
  lanzamientos, el total de material y el promedio.

- Realizar función CalculaPromedioEfectividad que recibe los arreglos que contienen la 
  cantidad de lanzamientos y total Material para que retorne el arreglo con los promedios.

- Debe visualizar de manera tabulada los resultados para cada planicie, es decir, en una sola 
  línea por cada planicie, escribir total lanzamientos, total material y promedio de efectividad.

- Debe tener control de excepciones en caso de se presenten errores por formato inválido y 
  posibles divisiones por cero.

*/

using System;

namespace ColonizacionMarte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Colonización a Marte - Envío de material a las planicies");
            Console.WriteLine("Se realizarán 15 lanzamientos de materiales necesarios para la colonización,");
            Console.WriteLine("que estarán ubicados en las planicies(A)cidalia, (E)lysium y (U)topia.");
            Console.WriteLine("Cada lanzamiento tiene un cargamento de hasta 10.000 kg.\n");

            int totalLanzamientos = 0;
            string destino = "";
            float pesoCarga = 0;

            /*
            Posiciones en los arreglos
                0: Acidalia
                1: Elysium
                2: Utopia
            */

            //Este arreglo almacenará los totales de carga por planicie
            float[] totalesCarga = new float[3];

            //Este arreglo almacenará los totales de lanzamiento por planicie
            int[] cantidadLanzamientos = new int[3];

            //inicializamos los arreglos que totalizan
            for (int i = 0; i < 3; i++)
            {
                totalesCarga[i] = 0;
                cantidadLanzamientos[i] = 0;
            }

            while (totalLanzamientos < 15)
            {
                Console.Write("\nIngresa el destino para el lanzamiento {0} (A,E,U): ", totalLanzamientos + 1);
                destino = Console.ReadLine().ToUpper();

                //verificamos que el destino sea válido
                if (destino == "A" || destino == "E" || destino == "U")
                {
                    try
                    {
                        //El destino es válido, leemos el valor del cargamento
                        Console.Write("Ingresa el valor del cargamento [0;10000]: ");
                        pesoCarga = float.Parse(Console.ReadLine());

                        if (pesoCarga >= 0 && pesoCarga <= 10000)
                        {
                            //El peso de la carga está en el destino válido, procedemos a acumular en la variable respectiva
                            switch (destino)
                            {
                                case "A":
                                    cantidadLanzamientos[0]++;
                                    totalesCarga[0] += pesoCarga;
                                    break;

                                case "E":
                                    cantidadLanzamientos[1]++;
                                    totalesCarga[1] += pesoCarga;
                                    break;

                                case "U":
                                    cantidadLanzamientos[2]++;
                                    totalesCarga[2] += pesoCarga;
                                    break;
                            }

                            //Finalmente incrementamos el conteo de lanzamientos, sentencia de salida del ciclo while
                            totalLanzamientos++;
                        }
                        else
                        {
                            Console.WriteLine("Ingresaste un valor de carga fuera del rango [0;10000]. Intenta nuevamente! \n");
                        }
                    }
                    catch (FormatException error)
                    {
                        Console.WriteLine("Ingresaste un dato no numérico. Intenta nuevamente!");
                        Console.WriteLine("Error: {0} \n", error.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Ingresaste un destino inválido. Intenta nuevamente! \n");
                }
            }

            //aqui calculamos los promedios de efectividad
            float[] promedios = CalculaPromedioEfectividad(cantidadLanzamientos, totalesCarga);

            //Aqui visualizamos resultados
            Console.WriteLine("\n\nResultados obtenidos de los lanzamientos:\n");

            Console.Write("\nPlanicie: \tA \tE \tU");
            Console.Write("\nLanzamientos: \t");
            for (int i = 0; i < 3; i++)
                Console.Write(cantidadLanzamientos[i] + "\t");

            Console.Write("\nTotal Carga: \t");
            for (int i = 0; i < 3; i++)
                Console.Write(totalesCarga[i] + "\t");

            Console.Write("\nPromedio: \t");
            for (int i = 0; i < 3; i++)
                Console.Write(promedios[i] + "\t");

            Console.WriteLine();

        }

        /// <summary>
        /// Función que calcula el promedio de carga recibido en cada planicie segun el número de lanzamientos
        /// </summary>
        /// <param name="arregloLanzamientos">Total de lanzamientos por planicie</param>
        /// <param name="arregloCargas">Total Carga recibida por planicie</param>
        /// <returns>los promedios de carga recibidos por planicie</returns>
        static float[] CalculaPromedioEfectividad(int[] arregloLanzamientos, float[] arregloCargas)
        {
            float[] promedios = new float[3];

            //aqui calculamos el promedio, evitando la división por cero
            for (int i = 0; i < promedios.Length; i++)
            {
                //Si no hay lanzamientos, el promedio es cero
                if (arregloLanzamientos[i] == 0)
                    promedios[i] = 0;
                else
                    promedios[i] = arregloCargas[i] / arregloLanzamientos[i];
            }
            return promedios;
        }
    }
}
