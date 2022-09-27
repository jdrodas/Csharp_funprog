/*
Programa:       PuntuacionEquiposOO
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Enunciado:
----------

Puntuación por equipos – eSport

Para un nuevo juego que se pretende posicionar como eSport, se requiere realizar 
un seguimiento de la puntuación individual de los participantes del equipo y su 
aporte al puntaje global.El equipo está conformado por 5 jugadores que obtendrán 
puntuaciones entre 1 y 100.

Se define como puntaje de clasificación del equipo el valor mínimo de 300, siempre 
y cuando máximo 2 de los 5 jugadores tengan puntajes individuales inferiores a 60.
Realice un programa en C# que lea desde consola 5 valores enteros en el rango de 1 a 
100 y los almacene en un arreglo. Implemente una función que reciba el arreglo como 
parámetro y devuelva un valor booleano indicando si el equipo clasificó o no.

La condición de clasificación es que el puntaje total (suma de los puntajes individuales) 
sea mínimo de 300 y que máximo 2 jugadores tengan puntajes inferiores a 60.

*/

using System;

namespace PuntuacionEquiposOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Evaluación de puntaje de equipo para E-Sport");

            //Aqui declaramos e inicializamos el arreglo
            Jugador[] equipo = new Jugador[5];

            for (int i = 0; i < equipo.Length; i++)
                equipo[i] = new Jugador();

            //Leemos los datos desde consola
            int contadorJugador = 0;
            while (contadorJugador < equipo.Length)
            {
                try
                {
                    Console.Write($"\nIngresa el nombre del jugador No. {contadorJugador+1}: ");
                    equipo[contadorJugador].Nombre = Console.ReadLine();

                    Console.Write($"Cual fue el puntaje para {equipo[contadorJugador].Nombre}: ");
                    equipo[contadorJugador].Puntaje = int.Parse(Console.ReadLine());

                    //Verificamos si el puntaje está en el rango válido
                    if (equipo[contadorJugador].Puntaje >= 1 && equipo[contadorJugador].Puntaje <= 100)
                        contadorJugador++;
                    else
                    {
                        Console.WriteLine("El puntaje ingresado no está en el rango [1;100]. Intenta nuevamente!");
                    }
                }
                catch (FormatException elError)
                {
                    Console.WriteLine("El dato del puntaje no es numérico. Intenta nuevamente!");
                    Console.WriteLine(elError.Message);
                }
            }

            //Aqui calculamos el puntaje del equipo y contamos puntajes inferiores a 60
            int puntajeEquipo = 0, totalPuntajesInferiores = 0;

            foreach (Jugador unJugador in equipo)
            {
                puntajeEquipo+=unJugador.Puntaje;
                if (unJugador.Puntaje < 60)
                    totalPuntajesInferiores++;
            }

            if (puntajeEquipo >= 300 && totalPuntajesInferiores <= 2)
                Console.WriteLine($"El equipo logró clasificar con {puntajeEquipo} puntos " +
                    $"y solo {totalPuntajesInferiores} puntajes infereriores a 60");
            else
            {
                Console.WriteLine($"El equipo no pudo clasificar, solo hizo {puntajeEquipo} puntos " +
                    $"y {totalPuntajesInferiores} puntajes infereriores a 60");
            }
        }
    }
}
