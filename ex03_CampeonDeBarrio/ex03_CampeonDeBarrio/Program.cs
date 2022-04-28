/*
/*
Programa:       ex03_CampeonDeBarrio
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Formulación: 
------------

El campeón del barrio

Ha salido el nuevo videojuego que tanto se había esperado y luego de muchas discusiones internas, 5
vecinos deciden organizar un torneo de fin de semana donde se identificará quien es el campeón del
barrio.

El videojuego tiene una mecánica que consiste en campañas que al ser finalizadas dan una puntuación
por cada una de ellas. Los puntos obtenidos al final del torneo tienen un valor mínimo de 100 puntos y un
valor máximo de 400 puntos.

Para identificar quien es el campeón, se estableció la regla del torneo que consiste en identificar quien
tuvo el mejor promedio durante el torneo. Dicho valor se calcula como la cantidad total de puntos dividido
por la cantidad de campañas jugadas. Para todos es claro que, si no jugó ninguna campaña, no puede
tener puntos y por lo tanto el promedio será 0.

Requerimientos:

* Realice un programa en C#.NET, aplicación de Consola que implemente la captura de datos,
  calculo de promedios y visualización de resultados.
* Los valores de cantidad de campañas y cantidad de puntos son valores enteros positivos, mientras
  que el promedio es un valor real.
* Se debe implementar el control de excepciones y las validaciones para que los valores numéricos
  ingresados por el usuario cumplan los rangos especificados.
* Implemente la clase “Jugador”, la cual contiene los siguientes atributos:

Nombre Atributo         Tipo de dato
nombre                  string
campañas                int
puntos                  int
promedio                float

* La clase “Jugador” debe tener un método privado llamado “CalculaPromedio” que realiza la
  operación matemática del promedio de puntos por campaña. Este método debe llamarse cada
  vez que se actualiza el valor de las campañas o de los puntos.
* En el método principal (Main) en la clase “Program” implementará un arreglo de 5 jugadores y
  almacenará en cada posición la información relacionada con cada jugador.
* El programa visualizará el resumen del torneo, escribiendo en consola para cada jugador, la
  cantidad de campañas, los puntos y el promedio obtenido.
* En la clase “Program” se implementará una función llamada “IdentificaCampeon” la cual recibe
  como parámetro el arreglo de jugadores y escribirá en consola el nombre del jugador campeón
  del torneo. Esta función implementa la regla del torneo en la cual el campeón es quien tenga
  mejor promedio o en caso de empate se escribirá en consola el nombre de los jugadores que
  empataron como campeón del torneo.
*/


using System;

namespace ex03_CampeonDeBarrio
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Campeón del Barrio *** \n\n");

            Console.WriteLine("Se registrarán la cantidad de campañas y puntos totales para 5 jugadores");
            Console.WriteLine("El campeón será quien tenga mejor promedio de puntos por campaña");
            Console.WriteLine("Si hay empate con el mejor promedio, se indicará el nombre de los jugadores");

            Jugador[] losJugadores = new Jugador[5];

            //Aqui inicializamos cada posición del arreglo
            for (int i = 0; i < losJugadores.Length; i++)
                losJugadores[i] = new Jugador();

            //Aqui ingresamos el nombre de los jugadores, validando que no hayan datos nulos en el nombre
            //y que los valores de cantidades de puntos y campañas correspondan a los requisitos
            int jugador = 0;
            while (jugador < losJugadores.Length)
            {                
                Console.Write($"\nIngresa el nombre del jugador No. {(jugador+1)}: ");
                losJugadores[jugador].Nombre = Console.ReadLine();

                //Aqui validamos si el dato es nulo
                if (losJugadores[jugador].Nombre.Length==0)
                    Console.WriteLine("El nombre del jugador no pueder ser nulo. Intenta nuevamente");
                else
                {
                    try
                    {
                        Console.Write("Cantidad de campañas jugadas: ");
                        losJugadores[jugador].Campañas = int.Parse(Console.ReadLine());

                        //Si la cantidad de campañas es diferente de cero, se pregunta por los puntos totales
                        if (losJugadores[jugador].Campañas != 0)
                        {
                            Console.Write("Cantidad de puntos obtenidos: ");
                            losJugadores[jugador].Puntos = int.Parse(Console.ReadLine());

                            //Si los puntos están en el rango y la cantidad de campañas son válidas,
                            //se pasa al siguiente jugador
                            if (losJugadores[jugador].Puntos >= 100 && losJugadores[jugador].Puntos <= 400 && losJugadores[jugador].Campañas >= 0)
                                jugador++;                            
                            else
                                Console.WriteLine("Las cantidades deben ser enteros positivos. " +
                                    "Los puntos deben estar en un rango [100-400]. " +
                                    "Intenta nuevamente!");
                        }
                        else
                        {
                            // Si las campañas son cero, los puntos son cero y se pasa al siguiente jugador
                            losJugadores[jugador].Puntos = 0;
                            jugador++;
                        }
                    }
                    catch (FormatException elError)
                    {
                        Console.WriteLine("Las cantidades deben ser enteros positivos. Intenta nuevamente!");
                        Console.WriteLine($"Error: {elError.Message}");
                    }
                }
            }

            //Visualizamos datos ingresados
            Console.WriteLine("\n\nLos datos ingresados para los jugadores son: \n");

            foreach (Jugador unJugador in losJugadores)
                Console.WriteLine(unJugador.InfoJugador());

            //Finalmente, identificamos quien es el campeón invocando la función
            IdentificaCampeon(losJugadores);
        }

        /// <summary>
        /// Identifica quien es el campeón entre los jugadores a partir del criterio definido
        /// </summary>
        /// <param name="losJugadores">Arreglo de los jugadores</param>
        static void IdentificaCampeon(Jugador[] arregloJugadores)
        {
            //Arbitrariamente seleccionamos el campeón como el primer jugador del arreglo
            Jugador jugadorCampeon = arregloJugadores[0];
            

            //Comparamos con el resto de jugadores
            for (int i = 1; i < arregloJugadores.Length; i++)
                //Si hay un jugador con mejor promedio, es el nuevo campeón
                if (jugadorCampeon.Promedio < arregloJugadores[i].Promedio)
                    jugadorCampeon = arregloJugadores[i];

            //Contamos cuantos jugadores tienen ese mejor puntaje
            int cantidadCampeones = 0;

            foreach (Jugador unJugador in arregloJugadores)
                if (unJugador.Promedio == jugadorCampeon.Promedio)
                    cantidadCampeones++;

            //Aqui visualizamos resultados
            if (cantidadCampeones == 1)
                Console.WriteLine($"\n\nEl Campeón del Barrio es {jugadorCampeon.Nombre}\n" +
                $" que obtuvo promedio de {jugadorCampeon.Promedio.ToString("0.00")} puntos por campaña.");
            else
            {
                Console.WriteLine($"\n\nSe presentó empate con un puntaje de {jugadorCampeon.Promedio.ToString("0.00")} entre: ");

                foreach (Jugador unJugador in arregloJugadores)
                    if (unJugador.Promedio == jugadorCampeon.Promedio)
                        Console.WriteLine($"- {unJugador.Nombre} con {unJugador.Campañas} campaña(s) jugadas");
            }
        }
    }
}
