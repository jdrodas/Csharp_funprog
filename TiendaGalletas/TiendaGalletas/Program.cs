/*
Programa:       TiendaGalletas
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Demostrar conceptos de clase objeto, encapsulación, atributos, propiedades
- Crear un arreglo de objetos y pasarlo como parámetro a una función.
- Crear un arreglo multidimensional y generar mecanismos para recorrerlo
 */

using System;

namespace TiendaGalletas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tienda de Galletas!");
            Console.WriteLine("Se hará pedido de 1000 galletas");
            Console.WriteLine("Diferente sabor, topping y relleno");
            Console.WriteLine("Al final se totaliza por atributo y se obtiene la más frecuente");

            //Aqui definimos los valores para los atributos de las galletas
            string[] sabores = { "Chocolate", "Yuca", "Aguacate", "Wasabi", "Queso" };
            string[] toppings = { "Chispas de Chocolate",
                                  "Chispitas de colores",
                                  "Mazapán",
                                  "Jamón",
                                  "Pasas",
                                  "Glaseado",
                                  "Gomitas" };
            string[] rellenos = { "Chocolate", "Piña", "Dulce de Auyama" };

            Galleta[] lasGalletas = new Galleta[1000];
            Random aleatorio = new Random();

            //aqui inicializamos el arreglo de galletas
            for (int i = 0; i < lasGalletas.Length; i++)
            {
                lasGalletas[i] = new Galleta();
                lasGalletas[i].Sabor = sabores[aleatorio.Next(sabores.Length)];
                lasGalletas[i].Relleno = rellenos[aleatorio.Next(rellenos.Length)];
                lasGalletas[i].Topping = toppings[aleatorio.Next(toppings.Length)];
            }

            //Aqui calculamos los totales por atributo
            int[] totalSabores = CalculaTotal("sabor", sabores, lasGalletas);
            int[] totalRellenos = CalculaTotal("relleno", rellenos, lasGalletas);
            int[] totalToppings = CalculaTotal("topping", toppings, lasGalletas);

            Console.WriteLine("\n\nVisualizando totales:");

            Console.WriteLine("Totales por sabor..");
            for (int i = 0; i < sabores.Length; i++)            
                Console.WriteLine("Sabor {0}, Total Galletas: {1}", sabores[i], totalSabores[i]);

            Console.WriteLine("\nTotales por topping..");
            for (int i = 0; i < toppings.Length; i++)
                Console.WriteLine("Topping {0}, Total Galletas: {1}", toppings[i], totalToppings[i]);

            Console.WriteLine("\nTotales por relleno..");
            for (int i = 0; i < rellenos.Length; i++)
                Console.WriteLine("Relleno {0}, Total Galletas: {1}", rellenos[i], totalRellenos[i]);

            //Totalizamos las combinaciones de sabores, rellenos y toppings
            int[,,] totalCombinacion = TotalizaCombinacion(sabores, rellenos, toppings, lasGalletas);

            //Aqui visualizamos las combinaciones enviadas por el panadero
            Console.WriteLine("\n\nCombinaciones enviadas por el panadero... \n");

            /*
             Se recorre el arreglo totalCombinacion, el tamaño de las dimensiones es el siguiente:

            0: sabores.length
            1: rellenos.length
            2: toppings.length
 
            */

            for (int i = 0; i < sabores.Length; i++)
                for (int j = 0; j < rellenos.Length; j++)
                    for (int k = 0; k < toppings.Length; k++)
                    {
                        Console.WriteLine("Combinación con sabor {0}, relleno {1} y topping {2}, total galletas: {3}",
                            sabores[i],
                            rellenos[j],
                            toppings[k],
                            totalCombinacion[i,j,k]);
                    }
        
        }

        /// <summary>
        /// Función que totaliza cuantas galletas llegaron por combinacion
        /// </summary>
        /// <param name="arregloSabores">El arreglo de sabores</param>
        /// <param name="arregloRellenos">El arreglo de rellenos</param>
        /// <param name="arregloToppings">El arreglo de toppings</param>
        /// <param name="arregloGalletas">El arreglo de galletas</param>
        /// <returns>El resultado de la totalización</returns>
        static int[,,] TotalizaCombinacion(string[] arregloSabores, string[] arregloRellenos, string[] arregloToppings, Galleta[] arregloGalletas)
        {
            int[,,] totales = new int[arregloSabores.Length,
                                      arregloRellenos.Length,
                                      arregloToppings.Length];

            //Aqui inicializamos los totales para garantizar que empiezan en cero
            for (int i = 0; i < arregloSabores.Length; i++)
                for (int j = 0; j < arregloRellenos.Length; j++)
                    for (int k = 0; k < arregloToppings.Length; k++)
                        totales[i, j, k] = 0;

            //aqui totalizamos la combinación
            for (int i = 0; i < arregloSabores.Length; i++)
                for (int j = 0; j < arregloRellenos.Length; j++)
                    for (int k = 0; k < arregloToppings.Length; k++)
                        for (int m = 0; m < arregloGalletas.Length; m++)
                        {

                            if (arregloGalletas[m].Sabor == arregloSabores[i] && arregloGalletas[m].Relleno == arregloRellenos[j] && arregloGalletas[m].Topping == arregloToppings[k])
                            {
                                totales[i, j, k]++;
                            }

                        }

            return totales;
        }


        /// <summary>
        /// Función para totalizar cuantas galletas hay según el atributo seleccionado
        /// </summary>
        /// <param name="atributo">el atributo seleccionado: sabor, relleno, topping</param>
        /// <param name="valoresAtributo">los valores según el atributo seleccionado</param>
        /// <param name="lasGalletas">Las galletas que tienen ese atributo</param>
        /// <returns>un arreglo con totales para cada valor del atributo especificado</returns>
        static int[] CalculaTotal(string atributo, string[] valoresAtributo, Galleta[] lasGalletas)
        {
            int[] totales = new int[valoresAtributo.Length];

            //inicializamos los totales para garantizar que comienzan en cero
            for (int i = 0; i < totales.Length; i++)
                totales[i] = 0;

            //recorremos el arreglo de valores para el atributo
            for (int j = 0; j < valoresAtributo.Length; j++)
            {
                //recorremos el arreglo de galletas
                for (int k = 0; k < lasGalletas.Length; k++)
                {
                    if (atributo == "sabor")
                    {
                        if (lasGalletas[k].Sabor == valoresAtributo[j])
                            totales[j]++;
                    }

                    if (atributo == "relleno")
                    {
                        if (lasGalletas[k].Relleno == valoresAtributo[j])
                            totales[j]++;
                    }

                    if (atributo == "topping")
                    {
                        if (lasGalletas[k].Topping == valoresAtributo[j])
                            totales[j]++;
                    }
                }
            }

            return totales;
        }
    }
}
