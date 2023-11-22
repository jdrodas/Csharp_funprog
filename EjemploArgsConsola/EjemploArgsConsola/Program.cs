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
- El primer argumento debe ser la palabra "ascendente" o "descendente"
- El 2do, 3er y 4to argumento deben ser enteros positivos
- El 2do y 3er argumento deben delimitar un rango
- El 4to argumento debe ser una cantidad > 0

Este programa debe ejecutarse desde una ventana de comandos para poder especificar los 4 argumentos
             
*/

namespace EjemploArgsConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Programa para demostrar la utilización del arreglo de argumentos");

            if (args.Length != 4)
                Console.WriteLine($"El programa no recibió la cantidad de argumentos esperada. " +
                    $"Se necesitan 4. Recibió {args.Length} argumentos.");
            else
            {
                // Aqui seguimos cuando los argumentos son exactamente 4
                Console.WriteLine("\nValidación de cantidad de argumentos cumplida! Argumentos recibidos");

                for (int i = 0; i < args.Length; i++)
                    Console.WriteLine($"Argumento No. {(i + 1)}, valor: {args[i]}");

                //Aqui validamos que el primer argumento sea un string "ascendente" o "descendente"
                //Utilizamos la función Equals para validar si son iguales,
                //pero lo negamos con "!" para validar si son diferentes
                if (!args[0].ToLower().Equals("ascendente") && !args[0].ToLower().Equals("descendente"))
                    Console.WriteLine("El primer argumento no corresponde a un criterio de ordenamiento");
                else
                {
                    Console.WriteLine($"\nEl criterio de ordenamiento es: {args[0].ToLower()}");
                    string criterioOrden = args[0];

                    bool datosCorrectos = true;
                    bool[] conversionDatos = new bool[3];
                    uint[] datosConvertidos = new uint[3];

                    //Aqui validamos si los datos convierten correctamente a enteros positivos
                    for (int i = 0; i < datosConvertidos.Length; i++)
                        conversionDatos[i] = uint.TryParse(args[i + 1], out datosConvertidos[i]);

                    //Aqui revisamos si todos convirtieron bien. Si al menos uno es falso,
                    //El proceso falla
                    for (int i = 0; i < conversionDatos.Length; i++)
                        if (conversionDatos[i] == false)
                            datosCorrectos = false;

                    //Si todos los datos se pudieron convertir, son enteros positivos
                    if (datosCorrectos == false)
                    {
                        Console.WriteLine("Los argumentos 2, 3 y 4 no son enteros positivos.");
                    }
                    else
                    {
                        Console.WriteLine("\nLos argumentos 2, 3 y 4 SON enteros positivos.");

                        //Luego, hay que verificar que el 2 y el 3 definan un rango
                        if (datosConvertidos[1] < datosConvertidos[0])
                        {
                            Console.WriteLine($"{datosConvertidos[0]} y {datosConvertidos[1]} NO definen un rango");
                        }
                        else
                        {
                            Console.WriteLine($"\n{datosConvertidos[0]} y {datosConvertidos[1]} SI definen un rango");

                            //ya casi... falta validar si el 4 es mayor que cero
                            if (datosConvertidos[2] == 0)
                            {
                                Console.WriteLine("El cuarto argumento no debe ser 0.");
                            }
                            else
                            {
                                Console.WriteLine($"\n{datosConvertidos[2]} define una cantidad!");

                                //Por fin! ahora si hacemos los aleatorios
                                int limiteInferior = (int)datosConvertidos[0];
                                int limiteSuperior = (int)datosConvertidos[1];
                                uint cantidad = datosConvertidos[2];

                                int[] losNumeros = new int[cantidad];
                                Random aleatorio = new();

                                //Aqui generamos los numeros de manera aleatoria
                                for (int i = 0; i < losNumeros.Length; i++)
                                    losNumeros[i] = aleatorio.Next(limiteInferior, limiteSuperior + 1);

                                //Aqui visualizamos los numeros generados
                                Console.WriteLine("\nLos numeros generados según los parámetros");

                                //Aqui visualizamos los numeros generados hasta el momento
                                EscribeNumerosEnConsola(losNumeros);

                                //Aqui obtenemos el arreglo ordenado según el criterio
                                int[] numerosOrdenados = OrdenaNumeros(losNumeros, criterioOrden);

                                //Aqui visualizamos los numeros ordenados según el criterio
                                Console.WriteLine("\nLos numeros ordenados según los parámetros");
                                EscribeNumerosEnConsola(numerosOrdenados);
                            }
                        }
                    }
                }
            }
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

    }
}