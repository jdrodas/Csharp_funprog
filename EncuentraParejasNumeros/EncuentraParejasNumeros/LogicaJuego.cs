
using System;
using System.Windows.Forms;

namespace EncuentraParejasNumeros
{
    public class LogicaJuego
    {
        private int totalIntentos;
        private int totalParejas;
        private int[] arregloValores;
        private bool[] valoresEncontrados;


        //Estos atributos se refieren a la parte de la pareja a encontrar
        int parejaParteA, parejaParteB;

        public LogicaJuego()
        {
            InicializaLogica();
        }

        public int TotalIntentos
        {
            get { return totalIntentos; }
        }

        public int TotalParejas
        {
            get { return totalParejas; }
        }

        public int ParejaParteA
        {
            get { return parejaParteA; } 
        }

        public int ParejaParteB
        {
            get { return parejaParteB; }
        }

        public int[] ArregloValores
        {
            get { return arregloValores; }
        }

        public bool[] ValoresEncontrados
        {
            get { return valoresEncontrados; }
        }

        public void InicializaLogica()
        {
            totalIntentos = 0;
            totalParejas = 0;

            //Inicializamos las partes de la pareja
            parejaParteA = 0;
            parejaParteB = 0;

            //Aqui invocamos las funciones de inicialización de arreglo
            InicializaArregloValores();
        }

        public string AnalizaPosicionSeleccionada(int posicion)
        {
            //Aqui leemos el valor del dato correspondiente al boton presionado
            int datoValor = arregloValores[posicion - 1];

            //Aqui identificamos si el valor presionado corresponde a la parte A o B
            if (parejaParteA == 0)
            {
                //Luego almacenamos en la respectiva parte el valor del arreglo
                parejaParteA = datoValor;
            }
            else
            {
                // De lo contrario, lo almacenamos en la parteB
                parejaParteB = datoValor;
            }

            string resultadoAnalisis="";
            // Si las partes son iguales, se encontró una pareja
            if (parejaParteA == parejaParteB)
            {
                valoresEncontrados[datoValor - 1] = true;
                resultadoAnalisis = $"Pareja encontrada!" + Environment.NewLine +
                    $"Parte A: {parejaParteA} " + Environment.NewLine +
                    $"Parte B: {parejaParteB}";
            }
            else
            {
                resultadoAnalisis = "Valores revelados:" + Environment.NewLine +
                    $"Parte A: {parejaParteA} " + Environment.NewLine +
                    $"Parte B: {parejaParteB}"; ;
            }

            bool resultadoCondicionVictoria = EvaluarCondicionVictoria();

            return resultadoAnalisis;
        }

        public void ActualizaIntentos()
        {
            //reiniciamos los valores de las partes para el siguiente intento
            parejaParteA = 0;
            parejaParteB = 0;

            //En cualquier caso, se incrementa el número de intentos
            totalIntentos++;
        }

        //Aqui validamos la condición de victoria
        public bool EvaluarCondicionVictoria()
        {
            bool resultadoEvaluacion=false;
            
            //Reiniciamos el contador de parejas encontradas
            totalParejas = 0;

            for (int i = 0; i < valoresEncontrados.Length; i++)
            {
                if (valoresEncontrados[i] == true)
                    totalParejas++;
            }

            //Si el total de parejas es 8, la victoria se ha obtenido
            if (totalParejas == 8)
                resultadoEvaluacion = true;

            return resultadoEvaluacion;
        }

        //Este metodo Inicializa el arreglo de valores
        private void InicializaArregloValores()
        {
            //Estas son las variables de la función
            //Los números a ubicar... va de 1 a 8
            int contadorNumeros = 1;
            //Las ubicaciones: cada número tiene 2 ubicaciones
            int contadorUbicacion = 0;

            //La variable que llevará control de la ubicación del número
            int ubicacionValor;

            //Esta es la variable aleatoria que utilizaremos
            Random aleatorio = new Random();

            //primero inicializamos el arreglo en ceros
            arregloValores = new int[16];

            for (int i = 0; i < arregloValores.Length; i++)
                arregloValores[i] = 0;

            //Este ciclo while ubica los numeros en el arreglo
            while (contadorNumeros <= 8) //Total números a ubicar
            {
                ubicacionValor = aleatorio.Next(arregloValores.Length);

                //Si en esa ubicación hay un cero, almacenamos el número
                if (arregloValores[ubicacionValor] == 0)
                {
                    arregloValores[ubicacionValor] = contadorNumeros;
                    contadorUbicacion++;
                }

                // Si ya ubicamos los dos valores por numero, continuamos 
                // con el siguiente valor
                if (contadorUbicacion == 2)
                {
                    contadorNumeros++;
                    contadorUbicacion = 0;
                }
            }

            //Aqui inicializamos el arreglo que contiene los valores encontrados
            valoresEncontrados = new bool[8];

            for (int i = 0; i < valoresEncontrados.Length; i++)
                valoresEncontrados[i] = false;

        }
    }
}
