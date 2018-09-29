/*
Programa:       BarajaEspanola
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Demostrar conceptos de clase objeto, encapsulación, atibutos, propiedades
- Crear un arreglo de objetos e inicializarlo de manera secuencial según 
  valores establecidos para los atributos.
- Visualizar la colección de cartas, una carta a la vez
- Implementar un mecanismo para mezclar las cartas de manera aleatoria
 */

using System;

namespace BarajaEspanola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para generar la baraja española");
            Console.Write("Valores de 48 cartas... ");

            string[] palos = { "oros", "copas", "espadas", "bastos" };
            string[] valores = {
                            "uno",
                            "dos",
                            "tres",
                            "cuatro",
                            "cinco",
                            "seis",
                            "siete",
                            "ocho",
                            "nueve",
                            "sota",
                            "caballero",
                            "rey"};

            Carta[] Baraja = new Carta[palos.Length * valores.Length];

            //aqui inicializamos la baraja con palos y valores definidos
            int contadorCartas = 0;

            while (contadorCartas < Baraja.Length)
            {
                for (int contadorPalos = 0; contadorPalos < palos.Length; contadorPalos++)
                {
                    for (int contadorValores = 0; contadorValores < valores.Length; contadorValores++)
                    {
                        Baraja[contadorCartas] = new Carta();
                        Baraja[contadorCartas].Palo = palos[contadorPalos];
                        Baraja[contadorCartas].Valor = valores[contadorValores];

                        contadorCartas++;
                    }
                }
            }

            Console.WriteLine("Baraja inicializada!\n\n");
            int numeroCarta = 1;

            do
            {
                try
                {
                    Console.Write("Ingresa un número entre 1 y 48 o 0 para salir: ");
                    numeroCarta = int.Parse(Console.ReadLine());

                    if (numeroCarta >= 1 && numeroCarta <= 48)
                    {
                        Console.WriteLine("La carta No. {0}, tiene palo {1} y valor {2}",
                            numeroCarta,
                            Baraja[numeroCarta - 1].Palo,
                            Baraja[numeroCarta - 1].Valor);
                    }
                    else
                    {
                        if (numeroCarta != 0)
                            Console.WriteLine("Ingresaste un número fuera del rango. Intenta nuevamente!\n\n");
                    }
                }
                catch (FormatException error)
                {
                    Console.WriteLine("Ingresaste un dato no numérico. Intenta nuevamente!");
                    Console.WriteLine("Error: {0} \n\n", error.Message);
                }
            }
            while (numeroCarta != 0);

            Console.WriteLine("Fin de la visualización individual.");

            // un "algoritmo" para desordenar el arreglo
            Random aleatorio = new Random();
            Carta cartaTemporal;
            int posicionAleatoria;

            for (int i = 0; i < Baraja.Length; i++)
            {
                posicionAleatoria = aleatorio.Next(Baraja.Length);

                cartaTemporal = Baraja[posicionAleatoria];
                Baraja[posicionAleatoria] = Baraja[i];
                Baraja[i] = cartaTemporal;
            }

            Console.WriteLine("\n\nBaraja desordenada queda asi:");

            for (int i = 0; i < Baraja.Length; i++)
            {
                Console.WriteLine("Posicion {0}, Palo: {1}, Valor: {2}",
                    i + 1,
                    Baraja[i].Palo,
                    Baraja[i].Valor);
            }
        }
    }
}