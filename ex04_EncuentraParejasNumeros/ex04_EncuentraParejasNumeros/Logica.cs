using System;

namespace ex04_EncuentraParejasNumeros
{
    class Logica
    {
        //Atributos de la clase
        private int totalIntentos, totalParejas;
        
        //Estos atributos se refieren a la parte de la pareja a encontrar
        private int parejaParteA, parejaParteB;

        //Estos dos arreglos tienen tienen los valores y los botones
        private int[] arregloValores;
        private bool[] valoresEncontrados;



        //Constructor de la clase
        public Logica()
        {
            InicializaJuego();
        }

        public void InicializaJuego()
        {
            totalIntentos = 0;
            totalParejas = 0;

            //Inicializamos las partes de la pareja
            parejaParteA = 0;
            parejaParteB = 0;

            //Inicializamos el arreglo de valores
            InicializaArregloValores();
        }

        //propiedades para los atributos

        public bool[] ValoresEncontrados
        {
            get { return valoresEncontrados; }
        }

        public int[] ArregloValores
        {
            get { return arregloValores; }
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

        //Aqui validamos la condición de victoria
        public void EvaluarCondicionVictoria()
        {
            //Reiniciamos el contador de parejas encontradas
            totalParejas = 0;

            for (int i = 0; i < valoresEncontrados.Length; i++)
            {
                if (valoresEncontrados[i] == true)
                    totalParejas++;
            }
        }


        public void AnalizaValorEncontrado(int ubicacion)
        {
            //Aqui leemos el valor del dato correspondiente al boton presionado
            int datoValor = arregloValores[ubicacion - 1];

            //Aqui identificamos si el valor presionado corresponde a la parte A o B
            if (parejaParteA == 0)
                //Luego almacenamos en la respectiva parte el valor del arreglo
                parejaParteA = datoValor;
            else // De lo contrario, lo almacenamos en la parteB
                parejaParteB = datoValor;

            //Aqui se comparan las partes de la pareja
            //Primero se valida si las partes están ingresadas
            if (parejaParteA != 0 && parejaParteB != 0)
            {

                // Si las partes son iguales, se encontró una pareja
                if (parejaParteA == parejaParteB)
                {
                    valoresEncontrados[datoValor -1] = true;
                    EvaluarCondicionVictoria();
                }

                //Finalmente, se incrementa el número de intentos
                totalIntentos++;
            }
        }

        public int ObtieneValorEncontrado(int ubicacion)
        {
            return (arregloValores[ubicacion - 1]);
        }

        public void ReiniciaPareja()
        {
            parejaParteA = 0;
            parejaParteB = 0;
        }

    }
}
