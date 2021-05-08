using System;
using System.Drawing;
using System.Windows.Forms;

namespace OrdenaNumeros
{
    public partial class Form1 : Form
    {
        //Atributos propios del juego
        private int[,] matrizValores;
        private Button[,] matrizBotones;
        private int posicionFila, posicionColumna;

        /// <summary>
        /// Constructor de la clase Form1
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            posicionFila = 0;
            posicionColumna = 0;

            matrizBotones = new Button[4, 4];
            matrizValores = new int[4, 4];

            //Aqui se invocan los metodos que inicializan las matrices
            InicializaMatrizBotones();
            InicializaMatrizValores();
        }

        /// <summary>
        /// Evento que se usa cuando se carga la forma por primera vez
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            //Se invoca la inicialización de botones
            InicializaEtiquetaBotones();
        }

        /// <summary>
        /// Inicializa la matriz de botones, con los botones del interfaz
        /// </summary>
        private void InicializaMatrizBotones()
        {
            matrizBotones[0, 0] = boton1;
            matrizBotones[0, 1] = boton2;
            matrizBotones[0, 2] = boton3;
            matrizBotones[0, 3] = boton4;

            matrizBotones[1, 0] = boton5;
            matrizBotones[1, 1] = boton6;
            matrizBotones[1, 2] = boton7;
            matrizBotones[1, 3] = boton8;

            matrizBotones[2, 0] = boton9;
            matrizBotones[2, 1] = boton10;
            matrizBotones[2, 2] = boton11;
            matrizBotones[2, 3] = boton12;

            matrizBotones[3, 0] = boton13;
            matrizBotones[3, 1] = boton14;
            matrizBotones[3, 2] = boton15;
            matrizBotones[3, 3] = boton16;
        }

        /// <summary>
        /// Inicializa la matriz de valores, asignando los numeros a organizar
        /// </summary>
        private void InicializaMatrizValores()
        {
            int valor = 0;

            //Inicialmente se asignan los números del 0 al 15 en toda la matriz
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrizValores[i, j] = valor;
                    valor++;
                }
            }

            //Luego, procedemos a cambiar los valores de posición de manera aleatoria

            Random aleatorio = new Random();
            int posicionHorizontal, posicionVertical, valorTemporal;

            //Aqui desordenamos la matriz, calculando posiciones horizontales y
            //verticales dentro de la matriz
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    valorTemporal = matrizValores[i, j];
                    posicionHorizontal = aleatorio.Next(4);
                    posicionVertical = aleatorio.Next(4);

                    matrizValores[i, j] = matrizValores[posicionHorizontal, posicionVertical];
                    matrizValores[posicionHorizontal, posicionVertical] = valorTemporal;
                }
            }
        }

        /// <summary>
        /// Asigna los valores de la matrizValores como etiquetas de los
        /// botones en la matrizBotones
        /// </summary>
        private void InicializaEtiquetaBotones()
        {
            //Recalculamos la matriz de valores
            InicializaMatrizValores();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //El botón que tenga el valor 0, se verá como vacío
                    //para que el usuario pueda "desplazar" el valor allí
                    if (matrizValores[i, j] == 0)
                        matrizBotones[i, j].Text = "";
                    else
                        matrizBotones[i, j].Text = matrizValores[i, j].ToString();
                }
            }
        }

        /// <summary>
        /// Evento para reiniciar el juego desde la barra de Menus - ItemReiniciaJuego
        /// </summary>
        private void menuItemReiniciaJuego_Click(object sender, EventArgs e)
        {
            //Se invoca la inicialización de botones
            InicializaEtiquetaBotones();

            //Se activan los botones para que puedan ser usados 
            ActivaBotones();

            //Se le coloca el color de fondo predeterminado
            InicializaFondoBotones();

            //Se da la notificación si el valor se encuentra en la posición correcta
            NotificaPosicionCorrectaValor();
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            EvaluaBotonPresionado(1, 0, 0);
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            EvaluaBotonPresionado(2, 0, 1);
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            EvaluaBotonPresionado(3, 0, 2);
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            EvaluaBotonPresionado(4, 0, 3);
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            EvaluaBotonPresionado(5, 1, 0);
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            EvaluaBotonPresionado(6, 1, 1);
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            EvaluaBotonPresionado(7, 1, 2);
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            EvaluaBotonPresionado(8, 1, 3);
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            EvaluaBotonPresionado(9, 2, 0);
        }

        private void boton10_Click(object sender, EventArgs e)
        {
            EvaluaBotonPresionado(10, 2, 1);
        }

        private void boton11_Click(object sender, EventArgs e)
        {
            EvaluaBotonPresionado(11, 2, 2);
        }

        private void boton12_Click(object sender, EventArgs e)
        {
            EvaluaBotonPresionado(12, 2, 3);
        }

        private void boton13_Click(object sender, EventArgs e)
        {
            EvaluaBotonPresionado(13, 3, 0);
        }

        private void boton14_Click(object sender, EventArgs e)
        {
            EvaluaBotonPresionado(14, 3, 1);
        }

        private void boton15_Click(object sender, EventArgs e)
        {
            EvaluaBotonPresionado(15, 3, 2);
        }

        private void boton16_Click(object sender, EventArgs e)
        {
            EvaluaBotonPresionado(16, 3, 3);
        }

        /// <summary>
        /// Evento para item salir que cierra la aplicación
        /// </summary>
        private void menuItemSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Evalua información asociada al botón presionado
        /// </summary>
        /// <param name="numeroBoton">Consecutivo del botón presionado</param>
        /// <param name="datoFila">Fila en la matriz a la que pertenece el botón</param>
        /// <param name="datoColumna">Columna en la matriz a la que pertenece el botón</param>
        private void EvaluaBotonPresionado(int numeroBoton, int datoFila, int datoColumna)
        {
            posicionFila = datoFila;
            posicionColumna = datoColumna;

            //Aqui evaluamos en la matrizValores, la posición correspondiente al botón presionado
            EvaluaPosicion();

            //Finalmente, se da la notificación si el valor se encuentra en la posición correcta
            NotificaPosicionCorrectaValor();
        }

        /// <summary>
        /// Evalua si la posición presionada está adjacente al espacio disponible para usar
        /// </summary>
        private void EvaluaPosicion()
        {
            int valorTemporal = 0;

            //Validamos el valor superior a donde presionamos si está el cero
            if (posicionFila > 0)
            {
                if (matrizValores[posicionFila - 1, posicionColumna] == 0)
                {
                    valorTemporal = matrizValores[posicionFila, posicionColumna];
                    matrizValores[posicionFila, posicionColumna] = 0;
                    matrizValores[posicionFila - 1, posicionColumna] = valorTemporal;
                }
            }

            //Validamos el valor inferior a donde presionamos si está el cero
            if (posicionFila < 3)
            {
                if (matrizValores[posicionFila + 1, posicionColumna] == 0)
                {
                    valorTemporal = matrizValores[posicionFila, posicionColumna];
                    matrizValores[posicionFila, posicionColumna] = 0;
                    matrizValores[posicionFila + 1, posicionColumna] = valorTemporal;
                }
            }

            //Validamos el valor izquierdo a donde presionamos si está el cero
            if (posicionColumna > 0)
            {
                if (matrizValores[posicionFila, posicionColumna - 1] == 0)
                {
                    valorTemporal = matrizValores[posicionFila, posicionColumna];
                    matrizValores[posicionFila, posicionColumna] = 0;
                    matrizValores[posicionFila, posicionColumna - 1] = valorTemporal;
                }
            }

            //Validamos el valor derecho a donde presionamos si está el cero
            if (posicionColumna < 3)
            {
                if (matrizValores[posicionFila, posicionColumna + 1] == 0)
                {
                    valorTemporal = matrizValores[posicionFila, posicionColumna];
                    matrizValores[posicionFila, posicionColumna] = 0;
                    matrizValores[posicionFila, posicionColumna + 1] = valorTemporal;
                }
            }

            //Finalmente actualizamos etiquetas de los botones
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matrizValores[i, j] == 0)
                        matrizBotones[i, j].Text = "";
                    else
                        matrizBotones[i, j].Text = matrizValores[i, j].ToString();
                }
            }

            //Y valoramos la condición de victoria
            EvaluaCondicionVictoria();
        }

        /// <summary>
        /// Esta función valida si todos los números están organizados
        /// </summary>
        private void EvaluaCondicionVictoria()
        {
            //Partimos del supuesto que ya logramos la condición de victoria
            bool condicionVictoria = true;

            int valorBuscado = 0;

            //Aqui recorremos la matriz de valores buscando para cada posición si el valor está en orden
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //incrementamos el valor buscado
                    valorBuscado++;

                    //Si los valores son diferentes, entonces todavía necesitamos seguir jugando!!!
                    if (matrizValores[i, j] != valorBuscado)
                    {
                        // Validamos si estamos en la última casilla, el valor existente es 0,
                        // el valor buscado ya llegó a 16 y la condición de victoria sigue siendo true
                        if (matrizValores[i, j] == 0 && valorBuscado == 16 && condicionVictoria == true)
                            condicionVictoria = true;

                        // De lo contrario, es porque estamos en cualquier otra casilla y los valores
                        // Todavía no son iguales
                        else
                            condicionVictoria = false;
                    }
                }
            }


            //Si la condición de victoria se logró, mostramos el mensaje de Victoria y desactivamos los botones
            if (condicionVictoria == true)
            {
                MessageBox.Show("Todos los números organizados, Felicitaciones!", "Victoria Alcanzada!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                InactivaBotones();
            }
        }

        /// <summary>
        /// Esta función inactiva los botones para ser utilizados en el juego
        /// </summary>
        private void InactivaBotones()
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    matrizBotones[i, j].Enabled = false;
        }

        /// <summary>
        /// Esta función activa los botones para ser utilizados en el juego
        /// </summary>
        private void ActivaBotones()
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    matrizBotones[i, j].Enabled = true;
        }

        /// <summary>
        /// Notifica que el número se encuentra en la posición correcta, cambiando el color de fondo del botón
        /// </summary>
        private void NotificaPosicionCorrectaValor()
        {

            int[,] valoresEsperados = new int[4, 4];
            int valor = 1;

            int totalFilas = valoresEsperados.GetLength(0);
            int totalColumnas = valoresEsperados.GetLength(1);

            //Aqui llenamos la matriz de los valores esperados
            for (int i = 0; i < totalFilas; i++)
                for (int j = 0; j < totalColumnas; j++)
                {
                    valoresEsperados[i, j] = valor;
                    valor++;
                }

            //Al finalizar el juego, en la posición 4,4 se encuentra el 0
            valoresEsperados[3, 3] = 0;

            //Ahora comparamos con los valores actuales para saber si están en la posición correcta
            for (int i = 0; i < totalFilas; i++)
                for (int j = 0; j < totalColumnas; j++)
                {
                    if (matrizValores[i, j] == valoresEsperados[i, j])
                        matrizBotones[i, j].BackColor = Color.LightGreen;
                    else
                        matrizBotones[i, j].BackColor = Color.LightGray;

                    //El botón que tiene el 0 no deberá cambiar de color
                    if(matrizValores[i, j]==0)
                        matrizBotones[i, j].BackColor = Color.LightGray;
                }
        }


        private void InicializaFondoBotones()
        {
            int totalFilas = matrizBotones.GetLength(0);
            int totalColumnas = matrizBotones.GetLength(1);

            //Asignamos a todos los botones gris claro como color de fondo
            for (int i = 0; i < totalFilas; i++)
                for (int j = 0; j < totalColumnas; j++)
                    matrizBotones[i, j].BackColor = Color.LightGray;
        }
    }
}
