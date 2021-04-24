using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhorcaditoSimple
{
    public partial class Form1 : Form
    {
        //atributos necesarios para el programa
        public int totalFallos, totalAciertos;
        string palabraBuscada, letrasColocadas;
        string[] diccionarioPalabras;
        TextBox[] lasCasillas;

        public Form1()
        {
            InitializeComponent();
            InicializaParametrosJuego();
        }

        public void InicializaParametrosJuego()
        {
            totalAciertos = 0;
            totalFallos = 0;
            palabraBuscada = "";
            letrasColocadas = "";

            InicializaArregloCasillas();

            diccionarioPalabras = new string[]
            {
                "PALINDROMO",
                "COMBUSTION",
                "EMPANADITA",
                "ENERGUMENO",
                "BRASILEÑOS",
                "REVERENCIA",
                "ARQUITECTO",
                "VENGADORES",
                "FEMINISTAS",
                "AFGANISTAN",
                "EVALUACION",
                "PROLETARIO",
                "ICOSAEDROS",
                "CATASTROFE",
                "AHORCADITO",
                "MAMONCILLO",
                "JESUCRISTO",
                "CHONTADURO",
                "SERENDIPIA",
                "MURCIELAGO",
                "SACERDOTES",
                "ADIVINARAS",
                "SABANDIJAS",
                "PRIMAVERAL",
                "GIGANTESCO",
                "ARREPENTIR",
                "HABICHUELA",
                "ECLIPSABLE"
            };

            Random aleatorio = new Random();
            palabraBuscada = diccionarioPalabras[aleatorio.Next(diccionarioPalabras.Length)];

            //Visualizamos en la interfaz de usuario los valores iniciales
            textoAciertos.Text = totalAciertos.ToString();
            textoFallos.Text = totalFallos.ToString();

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
            //Primero validamos si ya fue previamente ingresada
            bool yaFueIngresada = EvaluaIngresoPrevioLetra(textoLetraIngresada.Text.ToUpper());

            if (yaFueIngresada == false)
            {
                letrasColocadas += textoLetraIngresada.Text.ToUpper();

                //Validamos si la letra está en la palabra
                bool estaEnPalabraBuscada = EvaluaLetraEnPalabraBuscada(textoLetraIngresada.Text.ToUpper());

                if (estaEnPalabraBuscada == true)
                {
                    totalAciertos++;
                    VisualizaLetraEnCasilla(textoLetraIngresada.Text.ToUpper());

                    //Aqui contamos casillas reveladas
                    int totalCasillasReveladas = 0;

                    for (int i = 0; i < lasCasillas.Length; i++)
                        if (lasCasillas[i].Text != "")
                            totalCasillasReveladas++;

                    if (totalCasillasReveladas == 10)
                    {
                        MessageBox.Show("Identificaste la palabra buscada: " + palabraBuscada,
                            "exito!!!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);

                        textoLetraIngresada.Enabled = false;
                        botonEvaluaLetra.Enabled = false;
                        textoPalabraBuscada.Text = palabraBuscada;
                    }
                }
                else
                {
                    totalFallos++;

                    //Validamos si se ha alcanzado el tope de fallos
                    if (totalFallos == 10)
                    {
                        MessageBox.Show("Alcanzaste 10 fallos. No identificaste la palabra buscada",
                            "fallo!!!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        textoLetraIngresada.Enabled = false;
                        botonEvaluaLetra.Enabled = false;
                        textoPalabraBuscada.Text = palabraBuscada;
                    }
                }
            }

            textoLetraIngresada.Text = "";
            textoLetrasColocadas.Text = letrasColocadas;
            textoAciertos.Text = totalAciertos.ToString();
            textoFallos.Text = totalFallos.ToString();

        }

        public void VisualizaLetraEnCasilla(string letraIngresada)
        {
            char[] letrasPalabraBuscada = palabraBuscada.ToCharArray();

            for (int i = 0; i < letrasPalabraBuscada.Length; i++)
                if (letrasPalabraBuscada[i].ToString() == letraIngresada)
                    lasCasillas[i].Text = letraIngresada;
        }

        public bool EvaluaLetraEnPalabraBuscada(string letraIngresada)
        {
            bool resultado = false;

            char[] letrasPalabraBuscada = palabraBuscada.ToCharArray();

            for (int i = 0; i < letrasPalabraBuscada.Length; i++)
                if (letrasPalabraBuscada[i].ToString() == letraIngresada)
                    resultado = true;

            return resultado;
        }

        public bool EvaluaIngresoPrevioLetra(string letraIngresada)
        {
            bool resultado = false;

            if (letrasColocadas.Length > 0)
            {
                char[] lasLetrasIngresadas = letrasColocadas.ToCharArray();

                for (int i = 0; i < lasLetrasIngresadas.Length; i++)
                    if (lasLetrasIngresadas[i].ToString() == letraIngresada)
                        resultado = true;
            }

            return resultado;
        }
    }
}
