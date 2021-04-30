using System;
using System.Windows.Forms;

namespace AhorcaditoSimple
{
    public partial class Form1 : Form
    {
        Logica logicaJuego;
        TextBox[] lasCasillas;

        public Form1()
        {
            InitializeComponent();
            InicializaParametrosJuego();
        }
        public void InicializaParametrosJuego()
        {
            //Creamos una instancia de la lógica del juego
            logicaJuego = new Logica();

            //Inicializamos arreglo que contiene las casillas de letras de la palabra buscada
            InicializaArregloCasillas();

            //Visualizamos en la interfaz de usuario los valores iniciales
            textoAciertos.Text = logicaJuego.TotalAciertos;
            textoFallos.Text = logicaJuego.TotalFallos;

            textoLetrasColocadas.Text = "";
            textoPalabraBuscada.Text = "";

            textoLetraIngresada.Enabled = true;
            botonEvaluaLetra.Enabled = true;
        }
        public void InicializaArregloCasillas()
        {
            lasCasillas = new TextBox[10];

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

            //borramos el contenido de las casillas para cada juego
            for (int i = 0; i < lasCasillas.Length; i++)
                lasCasillas[i].Text = "";
        }
        private void botonReiniciaJuego_Click(object sender, EventArgs e)
        {
            InicializaParametrosJuego();
        }

        private void botonEvaluaLetra_Click(object sender, EventArgs e)
        {
            string letraIngresada = textoLetraIngresada.Text.ToUpper();

            logicaJuego.EvaluaLetra(letraIngresada);

            //Aqui actualizamos los controles de la forma según la información de la lógica
            VisualizaLetraEnCasilla(letraIngresada);

            //Aqui contamos casillas reveladas
            int totalCasillasReveladas = 0;

            for (int i = 0; i < lasCasillas.Length; i++)
                if (lasCasillas[i].Text != "")
                    totalCasillasReveladas++;

            if (totalCasillasReveladas == 10)
            {
                MessageBox.Show("Identificaste la palabra buscada: " + logicaJuego.PalabraBuscada,
                    "Éxito!!!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                textoLetraIngresada.Enabled = false;
                botonEvaluaLetra.Enabled = false;
                textoPalabraBuscada.Text = logicaJuego.PalabraBuscada;
            }

            //Validamos si se ha alcanzado el tope de fallos
            if (int.Parse(logicaJuego.TotalFallos) == 10)
            {
                MessageBox.Show("Alcanzaste 10 fallos. No identificaste la palabra buscada: " + logicaJuego.PalabraBuscada,
                    "Fallo!!!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                textoLetraIngresada.Enabled = false;
                botonEvaluaLetra.Enabled = false;
                textoPalabraBuscada.Text = logicaJuego.PalabraBuscada;
            }


            textoLetraIngresada.Text = "";
            textoLetrasColocadas.Text = logicaJuego.LetrasColocadas;

            textoAciertos.Text = logicaJuego.TotalAciertos;
            textoFallos.Text = logicaJuego.TotalFallos;

        }

        public void VisualizaLetraEnCasilla(string letraIngresada)
        {
            char[] letrasPalabraBuscada = logicaJuego.PalabraBuscada.ToCharArray();

            for (int i = 0; i < letrasPalabraBuscada.Length; i++)
                if (letrasPalabraBuscada[i].ToString() == letraIngresada)
                    lasCasillas[i].Text = letraIngresada;
        }
    }
}
