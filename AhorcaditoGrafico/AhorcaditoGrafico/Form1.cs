/*

Ahorcadito Gráfico

Requerimientos del programa

- Se adivinará una sola palabra de 10 letras
- Se tendrán 10 intentos erróneos antes de perder
- No marcará error por letra repetida
- Tendrá un botón de reinicio de juego y selecciona una nueva palabra
- Se evaluará la condición de victoria si adivina la totalidad de las letras
- Contamos los aciertos y los fallos
- No tendrá en cuenta las tildes
- Visualizará las letras ingresadas.
- Dibujará el personaje a medida que se incrementen los fallos

*/

using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AhorcaditoGrafico
{
    public partial class Form1 : Form
    {
        //atributos de la clase
        private Logica miLogica;
        private TextBox[] lasCasillas;

        public Form1()
        {
            InitializeComponent();
            miLogica = new Logica();
            lasCasillas = new TextBox[10];
            InicializaCasillas();
        }

        private void InicializaCasillas()
        {
            lasCasillas[0] = TextoLetra1;
            lasCasillas[1] = TextoLetra2;
            lasCasillas[2] = TextoLetra3;
            lasCasillas[3] = TextoLetra4;
            lasCasillas[4] = TextoLetra5;
            lasCasillas[5] = TextoLetra6;
            lasCasillas[6] = TextoLetra7;
            lasCasillas[7] = TextoLetra8;
            lasCasillas[8] = TextoLetra9;
            lasCasillas[9] = TextoLetra10;

            for (int i = 0; i < lasCasillas.Length; i++)
                lasCasillas[i].Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InicializaInterfaz();
        }

        private void BotonReiniciaJuego_Click(object sender, EventArgs e)
        {
            InicializaInterfaz();

            //habilitamos las funcionalidades nuevamente
            BotonEvaluaLetra.Enabled = true;
            TextoLetraIngresada.Enabled = true;
        }

        private void InicializaInterfaz()
        {
            miLogica.ReiniciaJuego();

            //Aqui inicializamos las casillas de letras
            InicializaCasillas();

            //Borramos la palabra buscada
            TextoPalabraBuscada.Text = "";

            TextoTotalFallos.Text = miLogica.ContadorFallos.ToString();
            TextoTotalAciertos.Text = miLogica.ContadorAciertos.ToString();
            CuadroImagen.Image = miLogica.ImagenAhorcado;
            TextoLetrasColocadas.Text = miLogica.LetrasColocadas;
        }

        private void BotonEvaluaLetra_Click(object sender, EventArgs e)
        {
            //aqui prevenimos que se evalue sin ingresar letra
            if (TextoLetraIngresada.Text.Length > 0)
            {
                //aqui vamos a validar que solo sean letras
                Regex patron = new Regex("[a-zA-ZñÑ]");

                //aqui preguntamos si la letra está en el patrón
                if (patron.IsMatch(TextoLetraIngresada.Text) == true)
                {
                    bool resultado = miLogica.EvaluaLetra(TextoLetraIngresada.Text.ToUpper());

                    if (resultado == true)
                        VisualizaLetraEnCasilla();
                }
            }

            TextoLetraIngresada.Text = "";
            TextoTotalFallos.Text = miLogica.ContadorFallos.ToString();
            TextoTotalAciertos.Text = miLogica.ContadorAciertos.ToString();
            CuadroImagen.Image = miLogica.ImagenAhorcado;
            TextoLetrasColocadas.Text = miLogica.LetrasColocadas;

            //Preguntamos si ya nos derrotaron
            if (miLogica.FuimosDerrotados() == true)
            {
                //si está true, ya perdimos. No seguimos evaluando letras
                BotonEvaluaLetra.Enabled = false;
                TextoLetraIngresada.Enabled = false;

                //Se visualiza la palabra buscada
                TextoPalabraBuscada.Text = miLogica.PalabraBuscada;

                //visualizamos una ventana emergente notificando la derrota
                MessageBox.Show("Has sido derrotado!!!",
                    "No se consiguió la victoria!");
            }

            //Preguntamos si ya ganamos
            if (miLogica.FuimosVictoriosos() == true)
            {
                //si está true, ya perdimos. No seguimos evaluando letras
                BotonEvaluaLetra.Enabled = false;
                TextoLetraIngresada.Enabled = false;

                //Se visualiza la palabra buscada
                TextoPalabraBuscada.Text = miLogica.PalabraBuscada;

                //visualizamos una ventana emergente notificando la derrota
                MessageBox.Show("Has sido victorioso!!!",
                    "Se ha ganado la partida!");

            }
        }

        /// <summary>
        /// Compara la letra ingresada con las posiciones de las letras
        /// en la palabra buscada y se activa la casilla correspondiente
        /// </summary>
        private void VisualizaLetraEnCasilla()
        {
            char[] letrasBuscadas = miLogica.PalabraBuscada.ToCharArray();

            for (int i = 0; i < letrasBuscadas.Length; i++)
            {
                //si la letra ingresada corresponde con esta posición
                //la visualizamos en la casilla equivalente
                if (TextoLetraIngresada.Text.ToUpper() == letrasBuscadas[i].ToString())
                {
                    lasCasillas[i].Text = TextoLetraIngresada.Text.ToUpper();
                }
            }
        }
    }
}
