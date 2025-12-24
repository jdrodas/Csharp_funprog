/*
Programa:       EjemploTipoParametrosFunciones
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------

- Demostrar los diferentes modificadores aplicables al paso de parametros de las funciones
- Paso de parámetros por valor
- Paso de parámetros por referencia
- Paso de parámetros con modificadores in y out

Para mayor información:
https://docs.microsoft.com/es-es/dotnet/csharp/programming-guide/classes-and-structs/passing-parameters

*/

namespace EjemploTipoParametrosFunciones
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Programa para demostrar los tipos de parametros en funciones");
            Console.Write("Ingresa un numero entero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            //Comenzamos con una función que recibe parámetros por valor              

            Console.WriteLine("\n*** Demostración paso de parametros por valor ***");
            Console.WriteLine($"El número antes de entrar a la función por valor es {numero}");
            IncrementaValorNumero(numero);
            Console.WriteLine($"El número despues de entrar a la función por valor es {numero}");
            Console.ReadKey();

            //Continuamos con una función que recibe parámetros por referencia 

            Console.WriteLine("\n*** Demostración paso de parametros por referencia ***");
            Console.WriteLine($"El número antes de entrar a la función por referencia es {numero}");
            IncrementaReferenciaNumero(ref numero);
            Console.WriteLine($"El número despues de entrar a la función por referencia es {numero}");
            Console.ReadKey();

            //Continuamos con una función que recibe parámetros por referencia, sentido "out"
            Console.WriteLine("\n*** Demostración paso de parametros por referencia - Sentido \"out\" ***");

            //Aqui declaramos las variables al momento de invocar el método - Inline Variable Declaration
            AsignaNombreMes(out string mes1, out string mes2, out string mes3);
            Console.WriteLine($"Los meses son {mes1}, {mes2}, {mes3}");
            Console.ReadKey();

            //Continuamos con una función que recibe parámetros por referencia, sentido "in"
            Console.WriteLine("\n*** Demostración paso de parametros por referencia - Sentido \"in\" ***");

            mes1 = "Enero"; mes2 = "Abril"; mes3 = "Octubre";
            EscribeNombresMeses(in mes1, in mes2, in mes3);
            Console.ReadKey();
        }

        /// <summary>
        /// Función que devuelve más de un valor a través de parámetros marcados como "out"
        /// </summary>
        /// <param name="mes1">Parámetro de entrada No. 1</param>
        /// <param name="mes2">Parámetro de entrada No. 2</param>
        /// <param name="mes3">Parámetro de entrada No. 3</param>
        static void EscribeNombresMeses(in string mes1, in string mes2, in string mes3)
        {
            //A pesar que los parámetros se comportan como variables dentro de la función
            //Como están marcados con "in" estos son solamente de lectura, no pueden
            //ser modificados.

            //Esta linea genera error CS8331: no se puede asignar porque es variable readonly
            //mes1 = "Diciembre";

            Console.WriteLine($"Los meses son {mes1}, {mes2}, {mes3}");
        }

        /// <summary>
        /// Función que devuelve más de un valor a través de parámetros marcados como "out"
        /// </summary>
        /// <param name="mes1">Parámetro de salida No. 1</param>
        /// <param name="mes2">Parámetro de salida No. 2</param>
        /// <param name="mes3">Parámetro de salida No. 3</param>
        static void AsignaNombreMes(out string mes1, out string mes2, out string mes3)
        {
            //A pesar que los parámetros tienen valor, no pueden usarse de lectura
            //Esta linea que sigue genera error CS029: Uso de parametro out sin asignar
            //Console.WriteLine($"Los meses son {mes1}, {mes2}, {mes3}");

            //Aqui les asignamos valor que sale (out) de la función
            mes1 = "Junio";
            mes2 = "Abril";
            mes3 = "Diciembre";
        }

        /// <summary>
        /// Función que incrementa un número recibido como parámetro por referencia
        /// </summary>
        /// <param name="otroDatoNumerico">El parámetro por referencia</param>
        static void IncrementaReferenciaNumero(ref int otroDatoNumerico)
        {
            otroDatoNumerico += 5;
            Console.WriteLine($"El número dentro de la función por referencia es {otroDatoNumerico}");
        }

        /// <summary>
        /// Función que incrementa un número recibido como parámetro por valor
        /// </summary>
        /// <param name="numero">el parámetro por valor</param>
        static void IncrementaValorNumero(int numero)
        {
            numero += 5;
            Console.WriteLine($"El número incrementado en la función por valor es {numero}");
        }
    }
}