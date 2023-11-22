/*
Programa:       GananciasCelebridades
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
Realice un programa en C# que calcule las ganancias de 4 celebridades, a partir de sus salarios. 

Estas 4 celebridades son:
- Gabriel: Su pago mensual es de 4,000$.
- Ana: Su pago mensual es de 3,000$.
- Catalina: Su pago mensual es de 4,500$.
- Francisco: Su pago mensual es de 5,800$

En el país en el que viven, hay una ley de impuestos que estipula que:
- A partir de 1,000$, se les descuenta un 5%.
- A partir de 3,500$, se les descuenta un 5% adicional.
- A partir de 4,500$, se les descuenta un 10% adicional.
- Si la cifra es superior a 5,500$, se les descuenta un 35% único. 
  Esto quiere decir, que no se adicionan los impuestos anteriores.

 */

using System;

namespace GananciasCelebridades
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Programa para calcular ganancias de celebridades\n");
            Console.WriteLine("Estos son los ingresos mensuales de las celebridades:");

            string[] nombreCelebridades = ["Gabriel", "Ana", "Catalina", "Francisco" ];
            float[] salariosCelebridades = [ 4000, 3000, 4500, 5800 ];

            for (int i = 0; i < nombreCelebridades.Length; i++)
                Console.WriteLine($"{nombreCelebridades[i]}, Sueldo: {salariosCelebridades[i]}");

            //Identificamos el tasa de impuestos aplicados a cada celebridad
            float[] tasaImpuestos = ObtieneTasaImpuestos(salariosCelebridades);

            //Calculamos los descuentos aplicados
            float[] descuentosImpuestos = new float[tasaImpuestos.Length];

            for (int i = 0; i < tasaImpuestos.Length; i++)
                descuentosImpuestos[i] = tasaImpuestos[i] * salariosCelebridades[i];

            //Visualizamos resultados
            Console.WriteLine("\nDe acuerdo con sus ingresos, estas son las tasas que le aplican a cada celebridad:");

            for (int i = 0; i < nombreCelebridades.Length; i++)
                Console.WriteLine($"{nombreCelebridades[i]}, Tasa impuestos: {(tasaImpuestos[i] * 100)}%, " +
                    $"Descuento por impuestos: {descuentosImpuestos[i]}");

            //Aqui calculamos el salario neto después de impuestos
            float[] salariosNetos = new float[salariosCelebridades.Length];

            for (int i = 0; i < salariosCelebridades.Length; i++)
                salariosNetos[i] = salariosCelebridades[i] - descuentosImpuestos[i];

            IdentificaBeneficiado(nombreCelebridades, salariosNetos);

        }

        /// <summary>
        /// Obtiene la tasa de impuestos de acuerdo al nivel de ingresos
        /// </summary>
        /// <param name="arregloSalarios">Los salarios de las celebridades</param>
        /// <returns>la tasa de impuestos para cada celebridad</returns>
        static float[] ObtieneTasaImpuestos(float[] arregloSalarios)
        {
            float[] resultadoTasas = new float[arregloSalarios.Length];

            //Aqui identificamos cual es la tasa que le aplica según el salario
            for (int i = 0; i < arregloSalarios.Length; i++)
            {
                if (arregloSalarios[i] < 1000)
                    resultadoTasas[i] = 0;

                if (arregloSalarios[i] >= 1000 && arregloSalarios[i] < 3500)
                    resultadoTasas[i] = 0.05f;

                if (arregloSalarios[i] >= 3500 && arregloSalarios[i] < 4500)
                    resultadoTasas[i] = 0.1f;

                if (arregloSalarios[i] >= 4500 && arregloSalarios[i] < 5500)
                    resultadoTasas[i] = 0.20f;

                if (arregloSalarios[i] >= 5500)
                    resultadoTasas[i] = 0.35f;
            }

            return resultadoTasas;
        }

        /// <summary>
        /// Identifica quien es la celebridad más beneficiada después de impuestos
        /// </summary>
        /// <param name="arregloNombres">Arreglo con los nombres de las celebridades</param>
        /// <param name="arregloSueldos">Arreglo con los sueldos netos</param>
        static void IdentificaBeneficiado(string[] arregloNombres, float[] arregloSueldos)
        {
            int posicionBeneficiado = 0;
            float salarioMayor = arregloSueldos[posicionBeneficiado];

            for (int i = 0; i < arregloSueldos.Length; i++)
            {
                if (arregloSueldos[i] > salarioMayor)
                {
                    salarioMayor = arregloSueldos[i];
                    posicionBeneficiado = i;
                }
            }

            Console.WriteLine($"\n\nSueldo netos de las celebridades:");

            for (int i = 0; i < arregloNombres.Length; i++)
                Console.WriteLine($"{arregloNombres[i]}, Sueldo neto: {arregloSueldos[i]}");

            //Aqui escribimos el resultado:
            Console.WriteLine($"\nLa celebridad con mayores ingresos después " +
                $"de impuestos es: {arregloNombres[posicionBeneficiado]}");
        }
    }
}
