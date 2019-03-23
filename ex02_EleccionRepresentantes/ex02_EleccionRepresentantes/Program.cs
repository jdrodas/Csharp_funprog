/*
Programa:       ex02_EleccionRepresentantes
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------

Elección de Representantes Estudiantiles

Ha llegado el final de la vigencia de los Representantes Estudiantiles para nuestra facultad por lo que se hace necesario convocar a
nuevas elecciones para el siguiente periodo. Para ello, se han establecido 8 mesas en la que los miembros de la facultad podrán 
depositar sus votos por cualquiera de los tres candidatos (A, B y C) que se presentaron para representar a los estudiantes.

Las mesas de votación están asignadas por semestre, de tal manera que en cada una de ellas votan los estudiantes de cada respectivo 
semestre. Ejemplo, los estudiantes de primer semestre votan en la mesa #1.

Al final de la jornada, se realiza el conteo de votos para identificar cual candidato ha sido elegido para participar en el Consejo
de Facultad. La elección se hace por la cantidad de mesas en las que ganó el candidato. En caso de presentarse empate en el primer 
lugar entre dos candidatos que ganen el mismo número de mesas, el desempate será el que tenga la mayor cantidad de votos.

Se requiere hacer un programa que permita registrar para cada mesa cuantos votos recibió cada candidato y que se visualice los 
resultados del escrutinio para cada mesa, generando una tabla como esta:

Mesa	A	B	C	Ganador Mesa
1	    8	3	11	C
2	    2	5	2	B
3	    4	2	7	C
4	    12	3	0	A
5	    0	4	2	B
6	    5	2	0	A
7	    2	0	5	C
8	    1	5	3	B
Total	34	24	30	 

En este ejemplo, los candidatos B y C ganaron en tres mesas, pero el candidato C obtuvo más votos. El candidato A obtuvo la mayor 
cantidad de votos, pero solo ganó en dos mesas. El ganador es el candidato C.

El programa debe implementar la función GanadorMesa, que recibe los valores de los votos obtenidos por cada candidato en una mesa y 
devuelve un valor tipo string con el ganador (A, B o C). En caso de empate en el máximo, devolverá la letra N (ninguno).

El programa debe generar la tabla de visualización de resultados planteada, utilizando tabuladores.
*/


using System;


namespace ex02_EleccionRepresentantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elección de Representantes Estudiantiles");
            Console.WriteLine("Se eligen tres candidatos en 8 mesas de votación");

            int[] votosA = new int[8];
            int[] votosB = new int[8];
            int[] votosC = new int[8];

            //aqui ingresamos los votos para los candidatos
            int mesa = 0;
            while (mesa < 8)
            {
                try
                {
                    Console.WriteLine("\nVotos para la mesa No. {0}", mesa + 1);

                    Console.Write("\tVotos para el candidato A: ");
                    votosA[mesa] = int.Parse(Console.ReadLine());

                    Console.Write("\tVotos para el candidato B: ");
                    votosB[mesa] = int.Parse(Console.ReadLine());

                    Console.Write("\tVotos para el candidato C: ");
                    votosC[mesa] = int.Parse(Console.ReadLine());

                    //validamos que los votos sean enteros positivos
                    if (votosA[mesa] >= 0 && votosB[mesa] >= 0 && votosC[mesa] >= 0)
                        mesa++;
                    else
                        Console.WriteLine("El conteo de votos por candidato debe ser mayor que cero. Intenta nuevamente!");
                    
                }
                catch (FormatException elError)
                {
                    Console.WriteLine("Ingresaste un dato no numérico. Debes ingresar nuevamente los valores para esta mesa!");
                    Console.WriteLine(elError.Message + "\n");
                }
            }

            //Aqui totalizamos los votos por Candidato
            int[] votosTotalesCandidato = new int[3];

            for (int i = 0; i < votosTotalesCandidato.Length; i++)
                votosTotalesCandidato[i] = 0;

            for (int i = 0; i < votosA.Length; i++)
            {
                votosTotalesCandidato[0] += votosA[i];
                votosTotalesCandidato[1] += votosB[i];
                votosTotalesCandidato[2] += votosC[i];
            }
            
            //Aqui visualizamos los resultados
            Console.WriteLine("\n\nResultados conteo de votos...\n");

            Console.WriteLine("Mesa \tA \tB \tC \tGanador");
            Console.WriteLine("--------------------------");
            for (int i = 0; i < mesa; i++)
            {
                Console.WriteLine("{0} \t{1} \t{2} \t{3} \t   {4}",
                    i+1,
                    votosA[i],
                    votosB[i],
                    votosC[i],
                    GanadorMesa(votosA[i], votosB[i], votosC[i]));
            }

            //aqui visualizamos los totales de votos por cada candidato
            Console.WriteLine("--------------------------");
            Console.WriteLine("Tot. \t{0} \t{1} \t{2}",
                votosTotalesCandidato[0],
                votosTotalesCandidato[1],
                votosTotalesCandidato[2]);

            //Aqui visualizamos el total de mesas en las que ganó cada candidato

            int[] mesasGanadoras = CalculaTotalMesasGanadoras(votosA, votosB, votosC);
            string[] candidatos = { "A", "B", "C" };

            Console.WriteLine("\n\nTotal mesas ganadoras por candidato...\n");

            for (int i = 0; i < mesasGanadoras.Length; i++)
                Console.WriteLine("Candidato: {0}, mesas ganadoras: {1}", candidatos[i], mesasGanadoras[i]);

            //finalmente visualizamos el resultado de la elección:
            string resultadoEleccion = ObtieneResultadoEleccion(mesasGanadoras, votosTotalesCandidato);
            Console.WriteLine("\n\nEl resultado de la elección es:");
            Console.WriteLine(resultadoEleccion + "\n");
            
        }

        /// <summary>
        /// Evalua el resultado de la elección según mesas y votos de los candidatos
        /// </summary>
        /// <param name="mesasCandidatos"></param>
        /// <param name="votosCandidatos"></param>
        /// <returns></returns>
        static string ObtieneResultadoEleccion(int[] mesasCandidatos, int[] votosCandidatos)
        {
            string resultado = "No hay ganador, debe repetirse la elección!";
            bool hayGanador=false;


            //primero validamos si hay ganador por mayoría de mesas
            if (mesasCandidatos[0] > mesasCandidatos[1] && mesasCandidatos[0] > mesasCandidatos[2])
            {
                resultado = "Ganador el candidato A!";
                hayGanador = true;
            }

            if (mesasCandidatos[1] > mesasCandidatos[0] && mesasCandidatos[1] > mesasCandidatos[2])
            {
                resultado = "Ganador el candidato B!";
                hayGanador = true;
            }

            if (mesasCandidatos[2] > mesasCandidatos[0] && mesasCandidatos[2] > mesasCandidatos[1])
            {
                resultado = "Ganador el candidato C!";
                hayGanador = true;
            }

            //Si no hay ganador por mayoría de mesas, se resuelve el empate por mayoría de votos
            if (hayGanador == false)
            {
                //Validando entre candidato A y B
                if (mesasCandidatos[0] == mesasCandidatos[1] && mesasCandidatos[0] > mesasCandidatos[2])
                {
                    if(votosCandidatos[0]>votosCandidatos[1])
                        resultado = "Ganador el candidato A por mayoría de votos!";
                    else
                        resultado = "Ganador el candidato B por mayoría de votos!";
                }

                //Validando entre candidato A y C
                if (mesasCandidatos[0] == mesasCandidatos[2] && mesasCandidatos[0] > mesasCandidatos[1])
                {
                    if (votosCandidatos[0] > votosCandidatos[2])
                        resultado = "Ganador el candidato A por mayoría de votos!";
                    else
                        resultado = "Ganador el candidato C por mayoría de votos!";
                }

                //Validando entre candidato B y C
                if (mesasCandidatos[1] == mesasCandidatos[2] && mesasCandidatos[1] > mesasCandidatos[0])
                {
                    if (votosCandidatos[1] > votosCandidatos[2])
                        resultado = "Ganador el candidato B por mayoría de votos!";
                    else
                        resultado = "Ganador el candidato C por mayoría de votos!";
                }

                //Si todos los canditatos tienen los mismos votos y mesas
                if (mesasCandidatos[0] == mesasCandidatos[1] && mesasCandidatos[1] == mesasCandidatos[2])
                {
                    if (votosCandidatos[0] == votosCandidatos[1] && votosCandidatos[1] == votosCandidatos[2])
                        resultado = "Empate total entre candidatos, debe repetirse la elección!";
                }
            }

            return resultado;
        }

        /// <summary>
        /// Calcula el total de mesas ganadoras por candidato
        /// </summary>
        /// <param name="votosA">Los votos del candidato A</param>
        /// <param name="votosB">Los votos del candidato B</param>
        /// <param name="votosC">Los votos del candidato C</param>
        /// <returns></returns>
        static int[] CalculaTotalMesasGanadoras(int[] votosA, int[] votosB, int[] votosC)
        {
            int[] resultado = new int[3];

            for (int i = 0; i < resultado.Length; i++)
                resultado[i] = 0;

            string ganador="";

            //Aqui identificamos el ganador de cada mesa
            for (int i = 0; i < votosA.Length; i++)
            {
                ganador = GanadorMesa(votosA[i], votosB[i], votosC[i]);

                switch(ganador)
                {
                    case "A":
                        resultado[0]++;
                        break;

                    case "B":
                        resultado[1]++;
                        break;

                    case "C":
                        resultado[2]++;
                        break;
                }
            }

            return resultado;
        }

        /// <summary>
        /// Obtiene el ganador absoluto de tres candidatos
        /// </summary>
        /// <param name="datoA">Votos del candidato A</param>
        /// <param name="datoB">Votos del candidato B</param>
        /// <param name="datoC">Votos del candidato C</param>
        /// <returns>El ganador</returns>
        static string GanadorMesa(int datoA, int datoB, int datoC)
        {
            string ganador = "N";

            if (datoA > datoB && datoA > datoC)
                ganador = "A";

            if (datoB > datoA && datoB > datoC)
                ganador = "B";

            if (datoC > datoA && datoC > datoB)
                ganador = "C";

            return ganador;
        }
    }
}
