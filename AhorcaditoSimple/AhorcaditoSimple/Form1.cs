using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AhorcaditoSimple
{
    public partial class Form1 : Form
    {
        private Logica logicaJuego;
        private TextBox[] lasCasillas;

        public Form1()
        {
            InitializeComponent();

            //Inicializamos el atributo que tiene la lógica
            logicaJuego = new Logica();
            lasCasillas = new TextBox[10];
        }

        /// <summary>
        /// Inicializa los parametros de control del juego
        /// </summary>
        public void InicializaParametrosJuego()
        {
            //Inicializamos el atributo que tiene la lógica
            logicaJuego = new Logica();
            lasCasillas = new TextBox[10];
        }

        /// <summary>
        /// Inicializa los elementos informativos de la interfaz
        /// </summary>
        private void InicializaInterfaz()
        {
            textoLetraIngresada.Enabled = true;
            botonEvaluaLetra.Enabled = true;

            //Acciones de reinicio del juego
            logicaJuego.InicializaParametrosJuego();

            //Inicializa el arreglo de Casillas
            InicializaArregloCasillas();

            ActualizaInterfaz();
        }
        /// <summary>
        /// Actualiza los elementos informativos de la interfaz
        /// </summary>
        private void ActualizaInterfaz()
        {
            textoLetraIngresada.Text = "";
            textoLetraIngresada.Focus();

            textoFallos.Text = logicaJuego.TotalFallos.ToString();
            textoAciertos.Text = logicaJuego.TotalAciertos.ToString();
            textoLetrasColocadas.Text = logicaJuego.LetrasIngresadas;
        }

        /// <summary>
        /// Inicializa el arreglo de casillas para facilitar la manipulación
        /// </summary>
        private void InicializaArregloCasillas()
        {
            //Asignar cada casilla en su poisición dentro del arreglo
            lasCasillas[0] = textoLetra1;
            lasCasillas[1] = textoLetra2;
            lasCasillas[2] = textoLetra3;
            lasCasillas[3] = textoLetra4;
            lasCasillas[4] = textoLetra5;
            lasCasillas[5] = textoLetra6;
            lasCasillas[6] = textoLetra7;
            lasCasillas[7] = textoLetra8;
            lasCasillas[8] = textoLetra9;
            lasCasillas[9] = textoLetra10;

            //Borramos los contenidos de las casillas
            foreach (TextBox unaCasilla in lasCasillas)
                unaCasilla.Text = "";
        }

        private void botonReiniciaJuego_Click(object sender, EventArgs e)
        {
            InicializaInterfaz();
        }

        private void botonEvaluaLetra_Click(object sender, EventArgs e)
        {
            if (textoLetraIngresada.Text != "")
            {
                //aqui vamos a validar que solo sean letras
                Regex patron = new Regex("[a-zA-ZñÑ]");

                if (patron.IsMatch(textoLetraIngresada.Text) == true)
                {
                    logicaJuego.EvaluaLetra(textoLetraIngresada.Text.ToUpper());

                    ActualizaContenidoCasillas(textoLetraIngresada.Text.ToUpper());
                    EvaluaCondicionVictoria();
                }
                ActualizaInterfaz();
            }
        }

        /// <summary>
        /// Actualiza el contenido de las casillas si la letra está en la palabra
        /// </summary>
        /// <param name="unaLetra">Letra evaluada</param>
        private void ActualizaContenidoCasillas(string unaLetra)
        {
            char[] letrasEnPalabraBuscada = logicaJuego.PalabraBuscada!.ToCharArray();

            for (int i = 0; i < letrasEnPalabraBuscada.Length; i++)

                if (letrasEnPalabraBuscada[i].ToString() == unaLetra)
                    lasCasillas[i].Text = unaLetra;
        }

        /// <summary>
        /// Identifica si se ganó o perdió en el juego
        /// </summary>
        private void EvaluaCondicionVictoria()
        {
            if (logicaJuego.TotalFallos == 10)
            {
                MessageBox.Show($"La palabrada buscada era {logicaJuego.PalabraBuscada}",
                    "Fallaste!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textoLetraIngresada.Enabled = false;
                botonEvaluaLetra.Enabled = false;
            }

            if (logicaJuego.TotalAciertos == 10)
            {
                MessageBox.Show("Encontraste la palabra!",
                                "Ganaste!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                textoLetraIngresada.Enabled = false;
                botonEvaluaLetra.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InicializaInterfaz();
        }

    }
}