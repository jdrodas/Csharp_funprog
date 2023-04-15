/*
Programa:       ZooPoo
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Demostrar la utilización de Objetos como elementos de almacenamiento de informacion
- Implementar funciones que totalicen por atributo
- Utilizar ciclos while y for para llenar y visualizar contenidos del arreglo de objetos
*/

using System;
using ZooPOO;

namespace ZooPoo
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Programa para totalizar la cantidad de comida que se necesita en un Zoológico");
            Console.WriteLine("Se tienen animales herbívoros y carnívoros en entornos");
            Console.WriteLine("Aéreos, terrestres y acuáticos.");
            Console.WriteLine("La cantidad de alimento está entre [10;50] kg.");
            Console.WriteLine("Se visualizan totales por entorno y por tipo de alimentación\n\n");

            int cantidadAnimales = 0;
            bool datoCorrecto = false;

            while (datoCorrecto == false)
            {
                try
                {
                    Console.Write("\nCuantos animales tiene el zoológico? ");
                    cantidadAnimales=int.Parse(Console.ReadLine()!);

                    if (cantidadAnimales >= 0)
                        datoCorrecto = true;
                    else
                        Console.WriteLine("La cantidad debe ser un numero entero positivo. Intenta nuevamente");
                }
                catch (FormatException elError)
                {
                    Console.WriteLine("La cantidad debe ser un numero entero positivo. Intenta nuevamente");
                    Console.WriteLine(elError.Message);
                }
            }

            //Definimos los medios válidos para los ambientes
            string[] losMedios = { "Aereo", "Acuatico", "Terrestre" };
            string[] losAlimentos = { "Carne", "Hierbas", "De todito" };

            Random aleatorio = new Random();

            Animal[] animalesZoo = new Animal[cantidadAnimales];

            for (int i = 0; i < animalesZoo.Length; i++)
            {
                //Inicializa cada posición del arreglo para que se entienda que es un
                //Objeto tipo Animal
                animalesZoo[i] = new Animal();

                animalesZoo[i].CantidadAlimento = aleatorio.Next(10, 51);
                animalesZoo[i].TipoAlimento = losAlimentos[aleatorio.Next(losAlimentos.Length)];
                animalesZoo[i].TipoMedio = losMedios[aleatorio.Next(losMedios.Length)];
            }

            //Aqui invocamos una función que recibe como parametro un arreglo de 
            //Objetos tipo animal
            VisualizaInformacionAnimales(animalesZoo);

            Console.WriteLine("\n Los totales de animales por medio son:");
            float[] totalesAnimalesPorMedio = TotalizaAnimalesPorMedio(animalesZoo, losMedios);

            for(int i=0;i<losMedios.Length;i++)
                Console.WriteLine($"Medio: {losMedios[i]}, " +
                    $"Total Animales: {totalesAnimalesPorMedio[i]} que equivale al" +
                    $" {((totalesAnimalesPorMedio[i]/cantidadAnimales)*100).ToString(".00")}%");

            Console.WriteLine("\n El total de comida por tipo de alimento es:");
            int[] totalesComidaPorTipo = TotalizaComidaAnimales(animalesZoo, losAlimentos);

            for (int i = 0; i < losAlimentos.Length; i++)
                Console.WriteLine($"Alimento: {losAlimentos[i]}, Total Kgs: {totalesComidaPorTipo[i]}");




        }

        static void VisualizaInformacionAnimales(Animal[] animalesZoo)
        {
            Console.WriteLine("\nLos animales del zoológico son");

            int contador = 1;
            foreach (Animal unAnimal in animalesZoo)
            {
                Console.WriteLine($"\nAnimal No. {contador}, \n" +
                    $"se alimenta de {unAnimal.TipoAlimento} y vive en medio {unAnimal.TipoMedio} \n" +
                    $"Se necesitan {unAnimal.CantidadAlimento} kgs para alimentarlo");
                contador++;
            }
        }

        static float[] TotalizaAnimalesPorMedio(Animal[] losAnimales, string[] losMedios)
        {
            float[] totalesPorMedio = new float[losMedios.Length];

            for (int i = 0; i < losMedios.Length; i++)
            {
                for (int j = 0; j < losAnimales.Length; j++)
                {
                    if (losAnimales[j].TipoMedio == losMedios[i])
                        totalesPorMedio[i]++;
                }
            }

            return totalesPorMedio;
        }

        static int[] TotalizaComidaAnimales(Animal[] losAnimales, string[] losAlimentos)
        {
            int[] TotalesAlimento = new int[losAlimentos.Length];

            for (int i = 0; i < losAlimentos.Length; i++)
            {
                for (int j = 0; j < losAnimales.Length; j++)
                {
                    if (losAnimales[j].TipoAlimento == losAlimentos[i])
                        TotalesAlimento[i]+= losAnimales[j].CantidadAlimento;
                }
            }

            return TotalesAlimento;

        }
    }
}