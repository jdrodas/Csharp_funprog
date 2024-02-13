/*
Programa:       Componentes Colores
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Realizar extracciones de los componentes ARGB de un color utilizando operaciones "Bitwise"
- Actualizado a .NET 8

- https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators

*/

using System;
using System.Drawing;

namespace ComponentesColores
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Programa para extraer los componentes ARGB de un Color usando operaciones Bitwise\n");

            Color unColor = Color.Turquoise;
            uint valorEnteroColor = (uint)unColor.ToArgb();
            Console.WriteLine($"El color seleccionado para esta prueba es: {unColor.Name}");
            Console.WriteLine($"El valor entero es {valorEnteroColor} mientras " +
                $"que en binario es {Convert.ToString(valorEnteroColor, toBase: 2).PadLeft(32, '0')}\n");
            
            Console.WriteLine("Utilizando máscaras, extraemos cada uno de los componentes, asi:");
            //Aqui definimos una máscara de 8 bits equivalente a 255 (11111111)
            uint mascara = 0xff;

            //Aqui utilizamos el operador desplazamiento de bits a la derecha y rotamos 24 bits
            //luego utilizamos el operador lógico AND con la máscara
            uint componenteAlpha = (valorEnteroColor >> 24) & mascara;
            Console.WriteLine($"Alpha: \t{componenteAlpha} \t {Convert.ToString(componenteAlpha, toBase: 2).PadLeft(8,'0')}");

            //Aqui utilizamos el operador desplazamiento de bits a la derecha y rotamos 16 bits
            //luego utilizamos el operador lógico AND
            uint componenteRojo = (valorEnteroColor >> 16) & mascara;
            Console.WriteLine($"Rojo: \t{componenteRojo} \t {Convert.ToString(componenteRojo, toBase: 2).PadLeft(8, '0')}");

            //Aqui utilizamos el operador desplazamiento de bits a la derecha y rotamos 8 bits
            //luego utilizamos el operador lógico AND con la máscara
            uint ComponenteVerde = (valorEnteroColor >> 8) & mascara;
            Console.WriteLine($"Verde: \t{ComponenteVerde} \t {Convert.ToString(ComponenteVerde, toBase: 2).PadLeft(8, '0')}");

            //Aqui no desplazamos los bits, simplemente operamos con la máscara
            uint ComponenteAzul = valorEnteroColor & mascara;
            Console.WriteLine($"Azul: \t{ComponenteAzul} \t {Convert.ToString(ComponenteAzul, toBase: 2).PadLeft(8, '0')}");
        }
    }
}

