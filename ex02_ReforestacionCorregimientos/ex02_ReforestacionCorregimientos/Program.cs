/*
Programa:       ex02_ReforestacionCorregimientos
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Ejercicio utilizando condicionales, ciclos de control, funciones, arreglos

Reforestación Corregimientos de Medellín

Como parte de los esfuerzos de la Alcaldía de Medellín por combatir los efectos del cambio climático, se
ha dado prioridad a las actividades de reforestación que pretenden aumentar las zonas verdes en los 5
corregimientos de la ciudad:

- San (S)ebastián de Palmitas
- San (C)ristóbal
- (A)ltaVista
- San Antonio de (P)rado
- Santa (E)lena

Para ello, se realizarán 15 actividades de reforestación en los diferentes corregimientos. Inicialmente se
plantarán 100 árboles por actividad, pero por problemas de sequía en los terrenos, pueden resultar menos
cantidad plantada. También puede darse el caso que la situación esté tan grave que ningún árbol resulte
plantado.

Se requiere hacer un programa que permita registrar para cada actividad de reforestación, a cuál
corregimiento corresponde y cuantos árboles resultaron plantados, teniendo en cuenta el rango de
valores válidos para las actividades de reforestación. Si el corregimiento no es válido o el valor no está en
el rango, debe repetirse el ingreso del dato.

Posteriormente se generarán los siguientes resultados:
- Cuantas actividades de reforestación se hicieron por cada corregimiento
- Cuantos árboles se plantaron por cada corregimiento.
- Promedio de árboles plantados por actividad para cada corregimiento (Cantidad Arboles/Cantidad Actividades)

Requerimientos:
- Utilice número enteros para almacenar el valor de la cantidad de árboles plantada para cada
corregimiento, teniendo presente que no podrá tener dígitos decimales. Estos valores deben
almacenarse en arreglos.

- Almacene los nombres de los corregimientos en un arreglo tipo string y utilice ciclos de control
cada vez que requiera referenciarlos para la lectura y visualización de datos de su cantidad
plantada.

- Implemente control de excepciones para garantizar que el usuario no ingrese al arreglo valores
equivocados que no correspondan al tipo de dato requerido. Importante: Los datos deben ser
digitados, no son generados aleatoriamente.

- Puede utilizar las Iniciales resaltadas (A, C, E, P, S) para implementar los condicionales que
pueda necesitar al clasificar las cantidades de arboles y actividades de reforestación.

- Tenga presente al momento de calcular el promedio, si para un corregimiento no se hicieron
actividades de reforestación, no puede haber árboles plantados. El promedio debe ser cero.
Recuerde que el promedio puede ser un número con dígitos decimales.

- Debe visualizar de manera tabulada los resultados para cada corregimiento, es decir, en una
sola línea por cada corregimiento, escribir total actividades, total árboles y promedio de árboles
plantados por actividad.

*/


using System;


namespace ex02_ReforestacionCorregimientos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reforestación Corregimientos de Medellín");
            Console.WriteLine("Se realizarán 15 actividades de reforestación en los corregimientos");

            string[] nombresCorregimientos = 
            {
                "San (S)ebastián de Palmitas",
                "San (C)ristóbal",
                "(A)ltaVista",
                "San Antonio de (P)rado",
                "Santa (E)lena"
            };

            foreach (string nombre in nombresCorregimientos)
                Console.WriteLine($"- {nombre}");

            Console.WriteLine("\nCada actividad de reforestación plantará hasta 100 arboles.\n");

            //Arreglos que contendrán las cantidades de actividaes y de arboles
            int[] cantidadActividades = new int[nombresCorregimientos.Length];
            int[] cantidadArboles = new int[nombresCorregimientos.Length];

            //Aqui hacemos el ingreso de datos
            int contadorActividades = 1;
            string inicialCorregimiento = "";
            int cantidad;

            while (contadorActividades<=15)
            {
                Console.Write($"\nPara la actividad No. {contadorActividades}, Ingresa la inicial " +
                    $"del corregimiento (A,C,E,P,S): ");
                inicialCorregimiento = Console.ReadLine().ToUpper();

                if (inicialCorregimiento == "A" || inicialCorregimiento == "C" || inicialCorregimiento == "E"
                    || inicialCorregimiento == "P" || inicialCorregimiento == "S")
                {
                    try
                    {
                        Console.Write("Ingresa la cantidad de arboles: ");
                        cantidad = int.Parse(Console.ReadLine());

                        if (cantidad >= 0)
                        {
                            /*
                            Los arreglos almacenarán en las siguientes para cada corregimiento:
                            0: San (S)ebastián de Palmitas
                            1: San (C)ristóbal
                            2: (A)ltaVista
                            3: San Antonio de (P)rado
                            4: Santa (E)lena
                            */
                            switch (inicialCorregimiento)
                            {
                                case "S":
                                    cantidadActividades[0]++;
                                    cantidadArboles[0] += cantidad;
                                    break;

                                case "C":
                                    cantidadActividades[1]++;
                                    cantidadArboles[1] += cantidad;
                                    break;

                                case "A":
                                    cantidadActividades[2]++;
                                    cantidadArboles[2] += cantidad;
                                    break;

                                case "P":
                                    cantidadActividades[3]++;
                                    cantidadArboles[3] += cantidad;
                                    break;

                                case "E":
                                    cantidadActividades[4]++;
                                    cantidadArboles[4] += cantidad;
                                    break;
                            }

                            //Finalmente, avanzamos a la siguiente actividad
                            contadorActividades++;
                        }
                        else
                        {
                            Console.WriteLine("La cantidad debe ser un entero positivo. Intenta nuevamente!");
                        }
                    }
                    catch (FormatException elError)
                    {
                        Console.WriteLine("El valor ingresado no es numérico. Intenta nuevamente!");
                        Console.WriteLine(elError.Message);
                    }
                    
                }
                else
                {
                    Console.WriteLine("No ingresaste un corregimiento válido. Intenta nuevamente!");
                }
            };

            //Aqui Visualizamos resultados
            float[] promediosCorregimiento = CalculaPromedios(cantidadActividades, cantidadArboles);

            Console.WriteLine("\n *** Resultados Obtenidos para Cada corregimiento ***");
            for (int i = 0; i < nombresCorregimientos.Length; i++)
            {
                Console.WriteLine($"Corregimiento: {nombresCorregimientos[i]} \n" +
                    $"Total Actividades: {cantidadActividades[i]}\n" +
                    $"Total Arboles: {cantidadArboles[i]}\n" +
                    $"Promedio reforestación: {promediosCorregimiento[i].ToString("0.00")} árboles por actividad\n\n");
            }
        }

        /// <summary>
        /// Función que Calcula los promedios de arboles sembrados por actividad
        /// </summary>
        /// <param name="cantidadActividades">La cantidad de actividades</param>
        /// <param name="cantidadArboles">La cantidad de arboles</param>
        /// <returns></returns>
        static float[] CalculaPromedios(int[] cantidadActividades, int[] cantidadArboles)
        {
            float[] promedios = new float[cantidadActividades.Length];

            for (int i = 0; i < cantidadActividades.Length; i++)
            {
                if (cantidadActividades[i] == 0)
                    promedios[i] = 0;
                else
                    promedios[i] = (float)cantidadArboles[i]/cantidadActividades[i];
            }

            return promedios;
        }
    }
}
