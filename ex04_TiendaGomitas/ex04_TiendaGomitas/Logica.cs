using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04_TiendaGomitas
{
    class Logica
    {
        //atributos de la clase
        private Gomita[] pedidoGomitas;
        private string[] colores, sabores, formas;
        private int[] totalesColores, totalesSabores, totalesFormas;
        private string mayorFrecuencia, menorFrecuencia;

        //Constructor de la clase
        public Logica()
        {
            pedidoGomitas = new Gomita[1000];

            //los valores de referencia para los atributos de las gomitas
            colores = new string[] { "Salmón", "Esmeralda", "Zafiro", "Mostaza", "Magenta" };
            sabores = new string[] { "Chontaduro", "Mamoncillo", "Arracacha" };
            formas = new string[] { "Piramide", "Dragón", "Cóndor" };

            totalesColores = new int[colores.Length];
            totalesSabores = new int[sabores.Length];
            totalesFormas = new int[formas.Length];

            mayorFrecuencia = "";
            menorFrecuencia = "";
        }

        public void InicializaSimulacion()
        {
            Random aleatorio = new Random();

            //Aqui inicializamos el arreglo de gomitas y asignamos valores aleatorios de sabor y color
            for (int i = 0; i < pedidoGomitas.Length; i++)
            {
                pedidoGomitas[i] = new Gomita(); // inicializamos cada elemento del arreglo

                pedidoGomitas[i].Color = colores[aleatorio.Next(colores.Length)];
                pedidoGomitas[i].Sabor = sabores[aleatorio.Next(sabores.Length)];
                pedidoGomitas[i].Forma = formas[aleatorio.Next(formas.Length)];
            }

            //totalizamos por cada atributo
            CalculaTotalesAtributo();

            //Calculamos la mayor y menor frecuencia
            CalculaMayorMenorFrecuencia();
        }

        private void CalculaTotalesAtributo()
        {
            //aqui calculamos los totales por colores
            //inicializamos los arreglos de totales
            for (int i = 0; i < totalesColores.Length; i++)
                totalesColores[i] = 0;

            for (int i = 0; i < totalesSabores.Length; i++)
                totalesSabores[i] = 0;

            for (int i = 0; i < totalesFormas.Length; i++)
                totalesFormas[i] = 0;

            //recorremos el arreglo de gomitas
            for (int i = 0; i < pedidoGomitas.Length; i++)
            {
                //recorremos el arreglo de colores
                for (int j = 0; j < colores.Length; j++)
                {
                    //si el color de la gomita es igual al color actual en el arreglo, 
                    //se incrementa el total
                    if (pedidoGomitas[i].Color == colores[j])
                        totalesColores[j]++;
                }

                //recorremos el arreglo de sabores
                for (int j = 0; j < sabores.Length; j++)
                {
                    //si el sabor de la gomita es igual al sabor actual en el arreglo, 
                    //se incrementa el total
                    if (pedidoGomitas[i].Sabor == sabores[j])
                        totalesSabores[j]++;
                }

                //recorremos el arreglo de formas
                for (int j = 0; j < formas.Length; j++)
                {
                    //si la forma de la gomita es igual a la forma actual en el arreglo, 
                    //se incrementa el total
                    if (pedidoGomitas[i].Forma == formas[j])
                        totalesFormas[j]++;
                }
            }
        }

        private void CalculaMayorMenorFrecuencia()
        {

            //aqui se calcula cual es la combinación de moda...
            // i: colores
            // j: sabores
            // k: formas
            int[,,] totalizador = new int[colores.Length,
                                          sabores.Length,
                                          formas.Length];

            //Inicializamos el arreglo de totales
            for (int i = 0; i < totalizador.GetLength(0); i++)
                for (int j = 0; j < totalizador.GetLength(1); j++)
                    for (int k = 0; k < totalizador.GetLength(2); k++)
                        totalizador[i, j, k] = 0;

            //aqui recorremos el arreglo de gomitas contando las combinaciones de los atributos
            for (int contador = 0; contador < pedidoGomitas.Length; contador++)
                for (int i = 0; i < totalizador.GetLength(0); i++)
                    for (int j = 0; j < totalizador.GetLength(1); j++)
                        for (int k = 0; k < totalizador.GetLength(2); k++)
                            if (pedidoGomitas[contador].Color == colores[i] &&
                                pedidoGomitas[contador].Sabor == sabores[j] &&
                                pedidoGomitas[contador].Forma == formas[k])
                                totalizador[i, j, k]++;

            //ahora vamos a identificar cual es la primera combinación que tiene la mayor cantidad de gomitas
            int mayorValor = 0, mayori = 0, mayorj = 0, mayork = 0;

            // Asignamos el primer valor como el mayor de manera arbritaria
            mayorValor = totalizador[mayori, mayorj, mayork];

            // Recorremos el arreglo del totalizador buscando el mayor valor y su posicion (i,j,k)
            for (int i = 0; i < totalizador.GetLength(0); i++)
                for (int j = 0; j < totalizador.GetLength(1); j++)
                    for (int k = 0; k < totalizador.GetLength(2); k++)
                        if (totalizador[i, j, k] > mayorValor)
                        {
                            mayorValor = totalizador[i, j, k];
                            mayori = i;
                            mayorj = j;
                            mayork = k;
                        }

            //ya sabemos el sabor, el color y la forma de la que tiene mayor cantidad
            mayorFrecuencia = "Mayor frecuencia: de color " + colores[mayori] +
                                " con sabor a " + sabores[mayorj] +
                                " con forma de " + formas[mayork] +
                                " y con una cantidad de " + mayorValor;

            //ahora vamos a identificar cual es la primera combinación que tiene la mayor cantidad de gomitas
            int menorValor = 0, menori = 0, menorj = 0, menork = 0;

            // Asignamos el primer valor como el mayor de manera arbritaria
            menorValor = totalizador[menori, menorj, mayork];

            // Recorremos el arreglo del totalizador buscando el mayor valor y su posicion (i,j,k)
            for (int i = 0; i < totalizador.GetLength(0); i++)
                for (int j = 0; j < totalizador.GetLength(1); j++)
                    for (int k = 0; k < totalizador.GetLength(2); k++)
                        if (totalizador[i, j, k] < menorValor)
                        {
                            menorValor = totalizador[i, j, k];
                            menori = i;
                            menorj = j;
                            menork = k;
                        }

            //ya sabemos el sabor, el color y la forma de la que tiene menor cantidad
            menorFrecuencia = "\nMenor frecuencia: de color " + colores[menori] +
                                " con sabor a " + sabores[menorj] +
                                " con forma de " + formas[menork] +
                                " y con una cantidad de " + menorValor;

        }

        public string ObtieneInfoDetallePedido()
        {
            StringBuilder infoPedido = new StringBuilder();

            //aqui recorremos el arreglo de gomitas para visualizar el detalle de cada elemento
            for (int i = 0; i < pedidoGomitas.Length; i++)
            {
                infoPedido.Append("La gomita No. " +
                    (i + 1).ToString() +
                    " tiene el sabor " +
                    pedidoGomitas[i].Sabor +
                    ", el color " +
                    pedidoGomitas[i].Color +
                    " y la forma " +
                    pedidoGomitas[i].Forma +
                    Environment.NewLine);
            }

            return infoPedido.ToString();
        }

        public string ObtieneMayorMenorFrecuencia()
        {
            string infoFrecuencia = menorFrecuencia +
                Environment.NewLine +
                mayorFrecuencia;

            return infoFrecuencia;
        }

        public int ObtieneTotalAtributo(string atributo, int codigoTotal)
        {
            int resultado = 0;

            switch (atributo)
            {
                case "color":
                    resultado = totalesColores[codigoTotal];
                    break;

                case "sabor":
                    resultado = totalesSabores[codigoTotal];
                    break;

                case "forma":
                    resultado = totalesFormas[codigoTotal];
                    break;

            }

            return resultado;
        }
    }
}
