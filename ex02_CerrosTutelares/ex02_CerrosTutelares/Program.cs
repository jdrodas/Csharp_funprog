/*
Programa:       ex02_CerrosTutelares
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Formulación: 
------------
Cerros Tutelares – Limpieza de material inflamable

Es nuevamente la época del año cuando las altas temperaturas pueden causar grandes incendios
forestales en nuestra ciudad. Se hace necesario realizar brigadas de limpieza de hojas y troncos
secos que pueden ser inflamables y que en definitiva afectará el ecosistema de los cerros tutelares
de Medellín.

Pensando en llevar un mejor seguimiento de la eficiencia de los equipos asignados a cada brigada
de limpieza, se desea construir una aplicación que permita registrar para un día específico, cuantos
kilogramos de material inflamable fueron retirados por cada cerro.

Se definen entonces equipos para los siguientes cerros:

1. Nutibara
2. El Volador
3. Picacho
4. Pan de Azúcar
5. La Asomadera
6. Las 3 Cruces
7. Santo Domingo

Se define como meta diaria retirar 500 Kg por cerro, con valores que pueden ser superiores o
inferiores a este valor.

Se espera que la aplicación pueda generar un reporte indicando si se cumplió la meta de recolección
por cada cerro y si el promedio está por encima o por debajo de la meta.

Requerimientos:
----------------
* Utilice número reales (float o double) para almacenar el valor de la cantidad diaria
recolectada, teniendo presente que podrá tener dígitos decimales.

* Almacene los nombres de los cerros en un arreglo tipo string y utilice ciclos de control cada
vez que requiera referenciarlos para la lectura y visualización de datos de su cantidad de
material recolectado.

* Implemente control de excepciones para garantizar que el usuario no ingrese valores por
equivocación que no correspondan al tipo de dato requerido.

* Implemente control en el separador de dígito decimal de tal manera que se prevenga la
errónea lectura de dato ingresado.

* Cree una función que se llame “CalculaPromedioRecoleccion” que reciba el arreglo de
valores correspondientes a la recolección de material inflamable en cada cerro y devuelva
el valor promedio de estos valores.

* Genere reporte final indicando para cada cerro si cumplió la meta diaria de recolección
(cantidad >= 500)

* Visualice un mensaje de “Jornada de recolección exitosa” si el promedio de recolección es
igual o superior a la meta diaria. Si no se cumple esta condición, debe visualizar el mensaje
“Tarea pendiente, ¡se requiere esfuerzo adicional!”.
*/


using System;
using System.Globalization;

namespace ex02_CerrosTutelares
{
    class Program
    {
        static void Main(string[] args)
        {
            float metaRecoleccion = 500;

            Console.WriteLine("Cerros Tutelares - Limpieza de material inflamable - Registro de recolección");
            Console.WriteLine($"La meta es {metaRecoleccion} kg por cerro. El promedio de la jornada debe ser igual o superior a la meta.");

            //Aqui declaramos un objeto de tipo CultureInfo - Información Regional
            CultureInfo miCultura = CultureInfo.CurrentCulture;

            Console.WriteLine($"La configuración regional actual es {miCultura.Name}");
            Console.WriteLine($"El separador de decimales es \"{miCultura.NumberFormat.NumberDecimalSeparator}\" \n\n");

            // Declaramos arreglo para almacenar los nombres de los cerros
            string[] losCerros = { "Nutibara", "El Volador", "Picacho", "Pan de Azúcar", "La Asomadera", "Las 3 Cruces", "Santo Domingo" };

            // Declaramos arreglo para almacenar las cantidades recolectadas para los cerros
            float[] lasCantidades = new float[losCerros.Length];

            //leemos los datos
            bool esDatoCorrecto = false;
            int posicion = 0;
            while (posicion < losCerros.Length)
            {
                while (!esDatoCorrecto)
                {
                    try
                    {
                        Console.Write($"Ingresa la cantidad de material recolectada para el cerro {losCerros[posicion]}: ");
                        lasCantidades[posicion] = float.Parse(Console.ReadLine().Replace(".", miCultura.NumberFormat.NumberDecimalSeparator));

                        //Se valida que la cantidad sea mayor igual a cero
                        if (lasCantidades[posicion] >= 0)
                            esDatoCorrecto = true;
                        else
                            Console.WriteLine("La cantidad ingresada no es válida. Debe ser un numero mayor o igual a cero. Intenta nuevamente\n\n");

                    }
                    catch (FormatException elError)
                    {
                        Console.WriteLine("El dato ingresado debe ser numérico positivo. Intenta nuevamente.");
                        Console.WriteLine(elError.Message + "\n\n");
                    }
                }

                esDatoCorrecto = false;
                posicion++;
            }

            //Calculamos el promedio
            float promedioRecoleccion = CalculaPromedioRecoleccion(lasCantidades);

            Console.WriteLine("\n\nResultados obtenidos:\n");

            //Visualizamos los resultados
            for (int i = 0; i < losCerros.Length; i++)
            {
                Console.Write($"Para el cerro {losCerros[i]} se recolectó {lasCantidades[i]} kgs - ");
                if (lasCantidades[i] >= metaRecoleccion)
                    Console.WriteLine(" Cumplió la meta!");
                else
                    Console.WriteLine(" No cumplió la meta!");
            }

            //Visualización de la cantidad promedio de materia recolectada
            Console.Write($"\n\nSe recolectó en promedio {promedioRecoleccion.ToString("0.00")} Kgs en la jornada - ");

            if (promedioRecoleccion >= metaRecoleccion)
                Console.WriteLine("Jornada de recolección exitosa");
            else
                Console.WriteLine("Tarea pendiente, ¡se requiere esfuerzo adicional!");
        }

        /// <summary>
        /// Función para calcular el promedio de la cantidad recolectada por todos los cerros
        /// </summary>
        /// <param name="lasCantidades">Arreglo con la información de las cantidades</param>
        /// <returns>El valor promedio</returns>
        static float CalculaPromedioRecoleccion(float[] lasCantidades)
        {
            float resultado = 0;

            for (int i = 0; i < lasCantidades.Length; i++)
                resultado += lasCantidades[i];

            resultado /= lasCantidades.Length;

            return resultado;
        }
    }
}
