/*
Programa:       Ex01_DungeonCraft
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
Examen 01: Condicionales y Ciclos de control

DungeonCraft - Analizador de Logros
************************************

Para el nuevo videojuego DungeonCraft se requiere implementar un mecanismo que permita saber
si el jugador ha obtenido el logro requerido para subir de nivel. En el videojuego, el jugador tendrá
que recolectar tres tipos de cubos: barro, madera y piedra.

El mecanismo propuesto por el diseñador del juego consiste en contar la totalidad de los elementos
recolectados y validar si de ese total, cada uno de los tipos está en un porcentaje específico. Los
rangos propuestos son:

Barro: Entre el 18% y el 25%
Madera: Entre el 30% t el 40%
Piedra: Entre el 40% y el 45%

El total de cubos recolectados para pasar de nivel debe ser mínimo de 100. Menos de este valor, el
jugador todavía no ha alcanzado la cantidad de cubos necesarios para pasar de nivel.

*/

namespace Ex01_DungeonCraft
{
    class Program
    {
        static void Main(string[] args)
        {
            float cubosBarro=0, cubosMadera=0, cubosPiedra=0;

            Console.WriteLine("DugeonCraft - Analizador de Logros para cambio de nivel.");
            Console.WriteLine("Debe recoger como mínimo 100 cubos, entre barro, madera y piedra.");
            Console.WriteLine("Los cubos de barro deben representar entre el 18% y el 25% del total.");
            Console.WriteLine("Los cubos de barro deben representar entre el 30% y el 40% del total.");
            Console.WriteLine("Los cubos de barro deben representar entre el 40% y el 45% del total.");

            Console.WriteLine("\n");

            //Esta variable nos indica que la lectura fue correcta
            bool datosCorrectos = false;

            //Este ciclo nos controla que los datos ingresados sean de formato numérico
            while(datosCorrectos==false)
            { 
                try
                {
                    //Aqui leemos la cantidad de cubos por material
                    Console.Write("Ingresa la cantidad de cubos de barro: ");
                    cubosBarro = float.Parse(Console.ReadLine()!);
                    Console.Write("Ingresa la cantidad de cubos de madera: ");
                    cubosMadera = float.Parse(Console.ReadLine()!);
                    Console.Write("Ingresa la cantidad de cubos de piedra: ");
                    cubosPiedra = float.Parse(Console.ReadLine()!);

                    //Si los datos fueron correctos, salimos del ciclo de control
                    datosCorrectos = true;
                }
                catch (FormatException error)
                {
                    Console.WriteLine("Ingresaste un dato no numérico al registrar el número de cubos de un material. Intenta nuevamente!");
                    Console.WriteLine("El error: {0} \n\n", error.Message);
                }
            }


            //Despues de ingresados los datos de los cubos, calculamos porcentajes
            float totalCubos = cubosBarro + cubosMadera + cubosPiedra;

            float porcBarro =  (cubosBarro / totalCubos) * 100;
            float porcMadera = (cubosMadera / totalCubos) * 100;
            float porcPiedra = (cubosPiedra / totalCubos) * 100;

            //Aqui analizamos el total de cubos y los porcentajes

            //Si el total de cubos no llega a los 100, no se puede pasar de nivel
            if (totalCubos < 100)
                Console.WriteLine("\n\nNo cumple con el mínimo de 100 cubos en total.");
            else
                Console.WriteLine("\n\nCumple con el mínimo de 100 cubos en total.");

            string cumpleBarro = "SI", cumpleMadera = "SI", cumplePiedra = "SI"; //Cumple hasta que se demuestre lo contrario
            string cumplimientoRangos = "SI";

            if (porcBarro < 18 || porcBarro > 25)
                cumpleBarro = "NO";

            if (porcMadera < 30 || porcMadera > 40)
                cumpleMadera = "NO";

            if (porcPiedra < 40 || porcPiedra > 45)
                cumplePiedra = "NO";

            //Si los tres cumplen, se puede pasar de nivel
            if (cumpleBarro == "SI" && cumpleMadera == "SI" && cumplePiedra == "SI")
                Console.WriteLine("Los materiales cumplen con los rangos requeridos.");
            else
            { 
                Console.WriteLine("Los materiales no cumplen con los rangos requeridos.");
                cumplimientoRangos = "NO";
            }


            Console.WriteLine("\n\nResumen de la situación:");
            Console.WriteLine("\n");
            Console.WriteLine("Material\tCantidad\tPorcentaje\tCumple?");
            Console.WriteLine("--------\t--------\t----------\t-------");

            Console.WriteLine("Barro:\t\t{0}\t\t{1}%\t\t{2}", cubosBarro.ToString("0.##"), porcBarro.ToString("0.##"), cumpleBarro);
            Console.WriteLine("Madera:\t\t{0}\t\t{1}%\t\t{2}", cubosMadera.ToString("0.##"), porcMadera.ToString("0.##"), cumpleMadera);
            Console.WriteLine("Piedra:\t\t{0}\t\t{1}%\t\t{2}", cubosPiedra.ToString("0.##"), porcPiedra.ToString("0.##"), cumplePiedra);

            Console.WriteLine("\nTotal cubos: {0}", totalCubos);

            if (totalCubos >= 100 & cumplimientoRangos == "SI")
                Console.WriteLine("\nPuede pasar de nivel!");
            else
                Console.WriteLine("\nNo puede pasar de nivel!");

        }
    }
}
