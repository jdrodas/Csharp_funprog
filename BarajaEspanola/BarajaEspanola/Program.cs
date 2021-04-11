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


            //Aqui podemos consultar que carta hay en una posición
            do
            {
                try
                {
                    Console.Write("Ingresa un número entre 1 y 48 o 0 para salir: ");
                    numeroCarta = int.Parse(Console.ReadLine());

                    if (numeroCarta >= 1 && numeroCarta <= 48)
                        Console.WriteLine($"La carta No. {numeroCarta}, es {Baraja[numeroCarta - 1].Valor} de {Baraja[numeroCarta - 1].Palo}");
                    else
                        if (numeroCarta != 0)
                            Console.WriteLine("Ingresaste un número fuera del rango. Intenta nuevamente!\n\n");

                }
                catch (FormatException error)
                {
                    Console.WriteLine("Ingresaste un dato no numérico. Intenta nuevamente!");
                    Console.WriteLine($"Error: {error.Message} \n\n");
                }
            }
            while (numeroCarta != 0);

            Console.WriteLine("Fin de la visualización individual.");

            Console.WriteLine("\n\nBaraja ordenada queda asi:");
            VisualizaBaraja(Baraja);

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

            Console.WriteLine("\nLa baraja ha sido mezclada!");

            //Aqui buscamos donde quedaron las cartas de un valor específico
            string valorCarta = "oro";
            bool quieroSalir = false;

            Console.WriteLine("\nVerifica donde quedaron las cartas de un valor específico:");

            do
            {
                Console.Write("\n\nEscribe un valor de carta o 'ninguno' para salir: ");
                valorCarta = Console.ReadLine().ToLower();
                if (valorCarta == "" || valorCarta == "ninguno")
                    quieroSalir = true;

                if (ValidarValor(valorCarta, valores))
                {
                    for (int i = 0; i < Baraja.Length; i++)
                        if (Baraja[i].Valor == valorCarta)
                            Console.WriteLine($"Posicion: {i + 1}, es {Baraja[i].Valor} de {Baraja[i].Palo}");
                }
                else
                    if (!quieroSalir)
                    Console.WriteLine("Ingresaste un valor de carta inválido. Intenta nuevamente! \n");

            } while (!quieroSalir);

            Console.WriteLine("Ejecución Finalizada!");
        }

        /// <summary>
        /// Valida si el valor suministrado corresponde a los valores válidos de una baraja española
        /// </summary>
        /// <param name="datoValor">valor a validar</param>
        /// <param name="arregloValores">valores validos</param>
        /// <returns></returns>
        static bool ValidarValor(string datoValor, string[] arregloValores)
        {
            bool esValida = false;

            for (int i = 0; i < arregloValores.Length; i++)
                if (arregloValores[i] == datoValor)
                    esValida = true;

            return esValida;
        }

        /// <summary>
        /// Visualiza la baraja escribiendo en consola
        /// </summary>
        /// <param name="arregloCartas"></param>
        static void VisualizaBaraja(Carta[] arregloCartas)
        {
            for (int i = 0; i < arregloCartas.Length; i++)
                Console.WriteLine($"Posicion: {i + 1}, es {arregloCartas[i].Valor} de {arregloCartas[i].Palo}");
        }
    }
}
