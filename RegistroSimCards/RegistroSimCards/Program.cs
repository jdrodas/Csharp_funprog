using System;

namespace RegistroSimCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("programa para simular venta de simcards");

            string[] losOperadores = { "Wom", "Claro", "Movil Exito", "Tigo", "Movistar", "Virgin" };
            string[] losTiposServicios = { "prepago", "postpago", "empresarial" };

            //declaramos un arreglo de simcards
            SimCard[] lasTarjetas = new SimCard[400];

            Random aleatorio = new Random();

            //Inicializamos el arreglo de tarjetas
            for (int i = 0; i < lasTarjetas.Length; i++)
            {
                lasTarjetas[i] = new SimCard();
                lasTarjetas[i].Operador = losOperadores[aleatorio.Next(losOperadores.Length)];
                lasTarjetas[i].TipoServicio = losTiposServicios[aleatorio.Next(losTiposServicios.Length)];
            }

            //Visualizamos el contenido del arreglo
            VisualizaSimCards(lasTarjetas);

            int[] totalesOperadores = CalculaTotales(lasTarjetas, losOperadores, "operador");
            int[] totalesTiposServicio = CalculaTotales(lasTarjetas, losTiposServicios, "tipoServicio");
            float porcentaje;

            Console.WriteLine("\n\nTotales por operador:");

            for (int i = 0; i < losOperadores.Length; i++)
            {
                porcentaje = ((float)totalesOperadores[i] / lasTarjetas.Length) * 100;
                Console.WriteLine($"Operador: {losOperadores[i]}, total Simcards: {totalesOperadores[i]}, {porcentaje.ToString("00.00")}%");

            }
            Console.WriteLine("\nTotales por tipo de servicio:");


            for (int i = 0; i < losTiposServicios.Length; i++)
            {
                porcentaje = ((float)totalesTiposServicio[i] / lasTarjetas.Length) * 100;
                Console.WriteLine($"Se vendieron {totalesTiposServicio[i]} del servicio {losTiposServicios[i]}, {porcentaje.ToString("00.00")}%");

            }
        }

        /// <summary>
        /// Función que calcula los totales para la propiedad especificada
        /// </summary>
        /// <param name="lasTarjetas"></param>
        /// <param name="valoresPropiedad"></param>
        /// <param name="nombrePropiedad"></param>
        /// <returns></returns>
        static int[] CalculaTotales(SimCard[] lasTarjetas, string[] valoresPropiedad, string nombrePropiedad)
        {
            int[] resultado = new int[valoresPropiedad.Length];

            for (int i = 0; i < resultado.Length; i++)
                resultado[i] = 0;

            for (int i = 0; i < lasTarjetas.Length; i++)
                for (int j = 0; j < valoresPropiedad.Length; j++)
                {
                    //Aqui estaremos totalizando por tipo de servicio
                    if (nombrePropiedad == "tipoServicio")

                        if (lasTarjetas[i].TipoServicio == valoresPropiedad[j])
                            resultado[j]++;

                    //Aqui estaremos totalizando por Operador
                    if (nombrePropiedad == "operador")
                        if (lasTarjetas[i].Operador == valoresPropiedad[j])
                            resultado[j]++;

                }
            return resultado;
        }


        static void VisualizaSimCards(SimCard[] lasTarjetas)
        {
            for (int i = 0; i < lasTarjetas.Length; i++)
                Console.WriteLine($"SimCard No.{(i + 1)}, Operador: {lasTarjetas[i].Operador}, Tipo Servicio: {lasTarjetas[i].TipoServicio}");
        }
    }
}
