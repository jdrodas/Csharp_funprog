/*
Programa:       Ex01_GravityFalls
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com
Propósito:
----------
Examen 01: Condicionales y Ciclos de control
Nueva administración en La Cabaña del Misterio en Gravity Falls
****************************************************************

Decepcionada por la forma como se maneja la Cabaña del Misterio, Mabel Pines le hace 
una apuesta al tío Stan creyendo que en un fin de semana puede recoger más dinero 
utilizando técnicas modernas de administración. El tío Stan acepta y mientras él se 
retira a participar en un concurso de televisión, Mabel se convierte en La Jefa.

Mabel define una meta de dinero a recoger y les asigna a todos, la responsabilidad de 
recoger una cuota correspondiente a la cuarta parte del meta. Coloca cuatro frascos 
de vidrio vacíos, con los nombres de los responsables: 1. Wendy, 2: Dipper, 3: Soos 
y 4: Mabel. 

Al final de la jornada, Mabel utilizará una aplicación para contabilizar el dinero 
recolectado por todos y generará indicadores para cada responsable, indicando que 
porcentaje del total recolectado fue conseguido por cada responsable.

La aplicación entonces:
•	Recolectará el valor numérico de la meta establecida por Mabel.
•	Recolectará cuatro valores numéricos correspondientes a lo recogido por cada 
   responsable.

La aplicación al final visualizará como resultados, el total recolectado por todos, 
el valor individual de cada responsable y su correspondiente porcentaje del total. 
Si el total recolectado es igual o superior a la meta establecida por Mabel, debe 
escribir la frase “Meta Cumplida, ¡eres buena jefe Mabel!”.

*/

namespace Ex01_GravityFalls
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nueva administración en La Cabaña del Misterio en Gravity Falls\n");

            Console.WriteLine("Mabel define una meta de dinero a recoger y les asigna a todos, la ");
            Console.WriteLine("responsabilidad de recoger una cuota correspondiente a la cuarta parte ");
            Console.WriteLine("del meta. Los responsables: 1.Wendy, 2: Dipper, 3: Soos y 4: Mabel.\n\n");

            //Las variables a utilizar
            float valorMeta = 0, cuotaWendy = 0, cuotaDipper = 0, cuotaSoos = 0, cuotaMabel = 0;
            bool datoCorrecto;

            //Aqui leemos el valor de la meta
            datoCorrecto = false;
            do
            {
                try
                {
                    Console.Write("\nIngresa el valor de la meta definida por Mabel: ");
                    valorMeta = float.Parse(Console.ReadLine()!);

                    //si el valor es positivo, el dato es correcto
                    if (valorMeta > 0)
                        datoCorrecto = true;
                    else
                        Console.WriteLine("La meta debe ser al menos mayor que cero. Intenta nuevamente!");
                }
                catch (FormatException error)
                {
                    Console.WriteLine("Ingresaste un dato no numérico. Intenta nuevamente!");
                    Console.WriteLine($"Error: {error.Message}\n");
                }
            }
            while (datoCorrecto == false);

            //Aqui leemos la cuota de Wendy
            datoCorrecto = false;
            while (datoCorrecto == false)
            {
                try
                {
                    Console.Write("\nIngresa el valor recogido por Wendy: ");
                    cuotaWendy = float.Parse(Console.ReadLine()!);

                    //si el valor es positivo, el dato es correcto
                    if (cuotaWendy > 0)
                        datoCorrecto = true;
                    else
                        Console.WriteLine("El valor debe ser al menos mayor que cero. Intenta nuevamente!");
                }
                catch (FormatException error)
                {
                    Console.WriteLine("Ingresaste un dato no numérico. Intenta nuevamente!");
                    Console.WriteLine($"Error: {error.Message}\n");
                }
            }

            //Aqui leemos la cuota de Dipper
            datoCorrecto = false;
            while (datoCorrecto == false)
            {
                try
                {
                    Console.Write("\nIngresa el valor recogido por Dipper: ");
                    cuotaDipper = float.Parse(Console.ReadLine()!);

                    //si el valor es positivo, el dato es correcto
                    if (cuotaDipper > 0)
                        datoCorrecto = true;
                    else
                        Console.WriteLine("El valor debe ser al menos mayor que cero. Intenta nuevamente!");
                }
                catch (FormatException error)
                {
                    Console.WriteLine("Ingresaste un dato no numérico. Intenta nuevamente!");
                    Console.WriteLine($"Error: {error.Message}\n");
                }
            }

            //Aqui leemos la cuota de Soos
            datoCorrecto = false;
            while (datoCorrecto == false)
            {
                try
                {
                    Console.Write("\nIngresa el valor recogido por Soos: ");
                    cuotaSoos = float.Parse(Console.ReadLine()!);

                    //si el valor es positivo, el dato es correcto
                    if (cuotaSoos > 0)
                        datoCorrecto = true;
                    else
                        Console.WriteLine("El valor debe ser al menos mayor que cero. Intenta nuevamente!");
                }
                catch (FormatException error)
                {
                    Console.WriteLine("Ingresaste un dato no numérico. Intenta nuevamente!");
                    Console.WriteLine($"Error: {error.Message}\n");
                }
            }

            //Aqui leemos la cuota de Mabel
            datoCorrecto = false;
            //Lo podemos hacer también con un ciclo do-while
            do
            {
                try
                {
                    Console.Write("\nIngresa el valor recogido por Mabel: ");
                    cuotaMabel = float.Parse(Console.ReadLine()!);

                    //si el valor es positivo, el dato es correcto
                    if (cuotaMabel > 0)
                        datoCorrecto = true;
                    else
                        Console.WriteLine("El valor debe ser al menos mayor que cero. Intenta nuevamente!");
                }
                catch (FormatException error)
                {
                    Console.WriteLine("Ingresaste un dato no numérico. Intenta nuevamente!");
                    Console.WriteLine($"Error: {error.Message}\n");
                }
            }
            while (datoCorrecto == false);

            //Aqui calculamos los porcentajes
            float totalRecogido = cuotaWendy + cuotaDipper + cuotaSoos + cuotaMabel;

            float porcWendy = (cuotaWendy / totalRecogido) * 100;
            float porcDipper = (cuotaDipper / totalRecogido) * 100;
            float porcSoos = (cuotaSoos / totalRecogido) * 100;
            float porcMabel = (cuotaMabel / totalRecogido) * 100;

            Console.WriteLine("\n\nResultados obtenidos:\n");

            Console.Write($"Total recogido: {totalRecogido.ToString("00.00")} ");

            if (totalRecogido >= valorMeta)
                Console.WriteLine("Meta Cumplida, ¡eres buena jefe Mabel!");
            else
                Console.WriteLine("Que mal Mabel! No cumpliste la meta.");

            Console.WriteLine("\n\nResultados por responsable:\n");
            Console.WriteLine($"Wendy: Total recogido {cuotaWendy}, que equivale al {porcWendy.ToString("00.00")}%");
            Console.WriteLine($"Dipper: Total recogido {cuotaDipper}, que equivale al {porcDipper.ToString("00.00")}%");
            Console.WriteLine($"Soos: Total recogido {cuotaSoos}, que equivale al {porcSoos.ToString("00.00")}%");
            Console.WriteLine($"Mabel: Total recogido {cuotaMabel}, que equivale al {porcMabel.ToString("00.00")}%");
        }
    }
}