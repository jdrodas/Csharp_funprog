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

namespace BarajaEspanola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para generar la baraja española");
            Console.WriteLine("Valores de 48 cartas:");

            string[] losPalos = { "oros", "copas", "espadas", "bastos" };
            string[] losValores =
            {
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
                "rey"
            };

            Console.WriteLine("Los palos de la baraja son:");

            foreach (string unPalo in losPalos)
                Console.WriteLine($"- {unPalo}");

            Console.WriteLine("\nLos valores de la baraja son:");

            foreach (string unValor in losValores)
                Console.WriteLine($"- {unValor}");

            int totalCartas = losValores.Length * losPalos.Length;
            Carta[] baraja = new Carta[totalCartas];

            //Procedemos a inicializar el arreglo de cartas
            int contadorCarta = 0;

            for (int i = 0; i < losPalos.Length; i++)
            {
                for (int j = 0; j < losValores.Length; j++)
                {
                    baraja[contadorCarta] = new Carta();
                    baraja[contadorCarta].Valor = losValores[j];
                    baraja[contadorCarta].Palo = losPalos[i];
                    contadorCarta++;
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
                    numeroCarta = int.Parse(Console.ReadLine()!);

                    if (numeroCarta >= 1 && numeroCarta <= 48)
                        Console.WriteLine($"La carta No. {numeroCarta}, es {baraja[numeroCarta - 1].Valor} de {baraja[numeroCarta - 1].Palo}");
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
            VisualizaBaraja(baraja);

            // un "algoritmo" para desordenar el arreglo
            Random aleatorio = new Random();
            Carta cartaTemporal;
            int posicionAleatoria;

            for (int i = 0; i < baraja.Length; i++)
            {
                posicionAleatoria = aleatorio.Next(baraja.Length);

                cartaTemporal = baraja[posicionAleatoria];
                baraja[posicionAleatoria] = baraja[i];
                baraja[i] = cartaTemporal;
            }

            Console.WriteLine("\nLa baraja ha sido mezclada!");

            //Aqui buscamos donde quedaron las cartas de un valor específico
            string valorCarta = "oro";
            bool quieroSalir = false;

            Console.WriteLine("\nVerifica donde quedaron las cartas de un valor específico:");

            do
            {
                Console.Write("\n\nEscribe un valor de carta o 'ninguno' para salir: ");
                valorCarta = Console.ReadLine()!.ToLower();
                if (valorCarta == "" || valorCarta == "ninguno")
                    quieroSalir = true;

                //utilizamos una función para verificar si el dato es válido
                if (ValidarValor(valorCarta, losValores))
                {
                    for (int i = 0; i < baraja.Length; i++)
                        if (baraja[i].Valor == valorCarta)
                            Console.WriteLine($"Posicion: {i + 1}, es {baraja[i].Valor} de {baraja[i].Palo}");
                }
                else
                {
                    if (!quieroSalir)
                        Console.WriteLine("Ingresaste un valor de carta inválido. Intenta nuevamente! \n");
                }

            } while (!quieroSalir);

            Console.WriteLine("\n\nEjecución Finalizada!");
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
