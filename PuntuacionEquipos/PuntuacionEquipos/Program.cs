/*
Programa:       PuntuacionEquipos
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

namespace PuntuacionEquipos
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Programa para evaluar puntuación por equipos en partida de eSport");
            Console.WriteLine("Equipo clasifica a siguiente ronda si tiene 300 puntos mínimo");
            Console.WriteLine("y máximo 2 jugadores tienen puntuación inferior a 60\n");

            int[] puntajesEquipo = new int[5];
            int jugador = 0, puntajeJugador;

            while (jugador < 5)
            {
                try
                {
                    Console.Write("\nIngresa el puntaje para el jugador #{0}: ", jugador + 1);
                    puntajeJugador = int.Parse(Console.ReadLine()!);

                    if (puntajeJugador >= 1 && puntajeJugador <= 100)
                    {
                        puntajesEquipo[jugador] = puntajeJugador;
                        jugador++;
                    }
                    else
                        Console.WriteLine("Ingresaste un dato fuera del rango [1;100]. Intenta nuevamente!");

                }
                catch (FormatException error)
                {
                    Console.WriteLine("Ingresaste un dato no numérico. Intenta nuevamente");
                    Console.WriteLine($"Error: {error.Message}");
                }
            }

            bool resultadoEvaluacion = EvaluaClasificacion(puntajesEquipo);

            if (resultadoEvaluacion)
                Console.WriteLine("\nEl equipo puede clasificar a la siguiente ronda!");
            else
                Console.WriteLine("\nEl equipo no clasifica a la siguiente ronda!");

        }

        /// <summary>
        /// función que evalua si el equipo cumplió los criterios de clasificación
        /// </summary>
        /// <param name="arregloPuntajes">Arreglo con los puntajes del equipo</param>
        /// <returns>Booleano indicando si clasificaron o no</returns>
        static bool EvaluaClasificacion(int[] arregloPuntajes)
        {
            bool resultado = false;

            //Visualizamos resultados
            int totalPuntajeEquipo = 0, jugadoresFallidos = 0;


            Console.WriteLine("\nLos puntajes ingresados fueron: ");
            for (int i = 0; i < arregloPuntajes.Length; i++)
            {
                Console.WriteLine($"Jugador {i + 1}, puntaje: {arregloPuntajes[i]}");
                totalPuntajeEquipo += arregloPuntajes[i];

                if (arregloPuntajes[i] < 60)
                    jugadoresFallidos++;
            }

            Console.WriteLine($"\nEl puntaje total del equipo fue de {totalPuntajeEquipo}");
            Console.WriteLine($"El número de jugadores con puntaje fallido fue de {jugadoresFallidos}\n");

            if (totalPuntajeEquipo >= 300)
                Console.WriteLine("El equipo superó la meta de 300 puntos!");
            else
                Console.WriteLine("El equipo no superó la meta de 300 puntos!");

            if (jugadoresFallidos > 2)
                Console.WriteLine("El equipo superó el límite de jugadores fallidos");
            else
                Console.WriteLine("El equipo no superó el límite de jugadores fallidos");

            if (totalPuntajeEquipo >= 300 && jugadoresFallidos <= 2)
                resultado = true;

            return resultado;
        }
    }
}
