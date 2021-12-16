/*
Programa:       EjemploArgsConsola
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Demostrar el funcionamiento de los argumentos que recibe la función Main()
- El programa generará una cantidad de numeros aleatorios de un rango especificado
  y los ordenará según el criterio que indique el usuario

El programa recibe 4 argumentos:
0: criterio de ordernamiento: ascendente/descendente
1: lìmite inferior de los números generados
2: lìmite superior de los nùmeros generados
3: Cantidad de numeros generados

Validaciones:
- Cantidad de argumentos: deben ser 4.
- el primer argumento debe ser la palabra "ascendente" o "descendente"
- el 2do, 3er y 4to argumento deben ser enteros positivos
- el 2do y 3er argumento deben delimitar un rango

Este programa debe ejecutarse desde una ventana de comandos para poder especificar los 4 argumentos
             
*/

namespace EjemploArgsConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para demostrar la utilización del arreglo de argumentos");

            if (args.Length != 4)
                Console.WriteLine($"El programa no recibió la cantidad de argumentos esperada. Se necesitan 4. \nRecibió {args.Length} argumentos.");
            else
            {
                Console.WriteLine($"El programa recibió {args.Length} argumentos. Podemos continuar!");

                //Aqui validamos que el primer argumento sea un string "ascendente" o "descendente"
                if (args[0].ToLower() != "ascendente" && args[0].ToLower() != "descendente")
                    Console.WriteLine("El primer argumento no corresponde a un criterio de ordenamiento");
                else
                {
                    Console.WriteLine($"El criterio de ordenamiento es: {args[0].ToLower()}");
                    string criterioOrden = args[0];

                    //Aqui validamos que el 2do, 3ro y 4to argumento sean enteros y positivos
                    int limiteInferior, limiteSuperior, cantidad;
                    try
                    {
                        limiteInferior = int.Parse(args[1]);
                        limiteSuperior = int.Parse(args[2]);
                        cantidad = int.Parse(args[3]);

                        //Validamos que sean enteros positivos
                        if (limiteInferior <= 0 || limiteSuperior <= 0 || cantidad <= 0)
                            Console.WriteLine("Los límites inferior y superior así como la cantidad deben ser enteros positivos");
                        else
                        {
                            Console.WriteLine("Los limites inferior, superior y cantidad son enteros positivos");

                            //Validamos que el 2do y 3er argumento delimiten un rango. 
                            //Si el inferior es mayor que el superior, no se delimita un rango
                            if (limiteInferior >= limiteSuperior)
                                Console.WriteLine($"{limiteInferior} y {limiteSuperior} NO delimitan un rango");
                            else
                            {
                                Console.WriteLine($"{limiteInferior} y {limiteSuperior} delimitan un rango");

                                //Por fin! Generemos el rango de valores
                                int[] losNumeros = new int[cantidad];

                                Random aleatorio = new Random();

                                for (int i = 0; i < losNumeros.Length; i++)
                                    losNumeros[i] = aleatorio.Next(limiteInferior, limiteSuperior + 1);

                                //Aqui visualizamos los numeros generados hasta el momento
                                EscribeNumerosEnConsola(losNumeros);

                                int[] numerosOrdenados = OrdenaNumeros(losNumeros, criterioOrden);

                                //Aqui visualizamos luego de la ordenación
                                Console.WriteLine($"\nAplicando el criterio de ordenamiento {criterioOrden}, los numeros quedan asì:\n");
                                EscribeNumerosEnConsola(numerosOrdenados);
                            }
                        }
                    }
                    catch (FormatException elError)
                    {
                        Console.WriteLine("Los argumentos de lìmite inferior, superior o cantidad no son nùmeros enteros");
                        Console.WriteLine(elError.Message);
                        Console.WriteLine($"\nHabías ingresado {args[1]}, {args[2]} y {args[3]}  como lìmite inferior, superior y cantidad");
                    }
                }
            }
        }

        /// <summary>
        /// Funciòn que ordena un arreglo de enteros segùn en criterio de ordenamiento especificado
        /// </summary>
        /// <param name="arregloNumeros">El arreglo de numeros</param>
        /// <param name="criterioOrdenamiento">el criterio de ordenamiento</param>
        /// <returns>el arreglo ordenado</returns>
        static int[] OrdenaNumeros(int[] arregloNumeros, string criterioOrdenamiento)
        {
            int[] resultado = arregloNumeros;
            bool seHizoCambio = true;
            int numeroTemporal;

            if (criterioOrdenamiento == "ascendente")
            {
                //Aqui se ordena ascendente
                //Se repetirá mientras se haga un cambio de posición
                while (seHizoCambio != false)
                {
                    seHizoCambio = false;
                    for (int i = 0; i < arregloNumeros.Length - 1; i++)
                        if (arregloNumeros[i] > arregloNumeros[i + 1])
                        {
                            numeroTemporal = arregloNumeros[i + 1];
                            arregloNumeros[i + 1] = arregloNumeros[i];
                            arregloNumeros[i] = numeroTemporal;
                            seHizoCambio = true;
                        }
                }
            }
            else
                //Aqui se ordena descendente
                //Se repetirá mientras se haga un cambio de posición
                while (seHizoCambio != false)
                {
                    seHizoCambio = false;
                    for (int i = 0; i < arregloNumeros.Length - 1; i++)
                    {
                        if (arregloNumeros[i] < arregloNumeros[i + 1])
                        {
                            numeroTemporal = arregloNumeros[i + 1];
                            arregloNumeros[i + 1] = arregloNumeros[i];
                            arregloNumeros[i] = numeroTemporal;
                            seHizoCambio = true;
                        }
                    }
                }

            return resultado;
        }

        /// <summary>
        /// Función que escribe en pantalla un arreglo de numeros enteros
        /// </summary>
        /// <param name="arregloNumeros">el arreglo de numeros enteros a escribir</param>
        static void EscribeNumerosEnConsola(int[] arregloNumeros)
        {
            for (int i = 0; i < arregloNumeros.Length; i++)
            {
                Console.Write($"{arregloNumeros[i]}\t");
                //Si ya se han escrito una cantidad de valores que sea múltiplo de 10, haga salto de lìnea
                if ((i + 1) % 10 == 0)
                    Console.WriteLine();
            }
        }
    }
}
