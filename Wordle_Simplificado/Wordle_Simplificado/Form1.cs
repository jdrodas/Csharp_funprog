using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordle_Simplificado
{
    public partial class Form1 : Form
    {
        //Atributos de la clase
        private string[] diccionarioPalabras;
        private string palabraBuscada;
        private int intentoActual;
        private bool hayDerrota;
        private char[] evaluacionLetras;

        //atributos asociados a los colores de alto contraste
        private Color colorLetraCorrecta, colorLetraFallida, colorLetraDesubicada;
        private bool activadoAltoContraste = false;

        //atributos para manejar las casillas de las letras
        private TextBox[,] matrizCasillas;

        public Form1()
        {
            InitializeComponent();

            //Este método inicializa los atributos de la lógica
            InicializaLogicaJuego();
        }

        /// <summary>
        /// Asigna las palabras que serán utilizadas en el juego
        /// </summary>
        private void InicializaDiccionario()
        {
            diccionarioPalabras = new string[] {
                "CARPA",
                "ARMAS",
                "GATOS",
                "FALSO",
                "SABOR",
                "CASCO",
                "PERAS",
                "MOTOR",
                "ARROZ",
                "CARRO",
                "LOCAL",
                "PECES",
                "ZORRA",
                "CANTO",
                "BARCO",
                "PALMA",
                "NOCHE",
                "TORRE",
                "BARBA",
                "ALMAS",
                "APODO",
                "MUERE",
                "GORRA",
                "PIZZA",
                "TORTA",
                "MIXTA"
            };
        }

        /// <summary>
        /// Inicializa los controles de la interfaz de usuario
        /// </summary>
        private void InicializaPresentacionJuego()
        {
            txtPalabraIngresada.Text = "";

            //Asignamos los colores para utilizar en el juego
            activadoAltoContraste = false;
            CambiaColorAltoContraste();

            //Inicializamos la matriz de casillas
            InicializaMatrizCasillas();
        }

        private void CambiaColorAltoContraste()
        {
            //Aqui cambiamos el estado del color de alto contraste
            if (activadoAltoContraste)
                activadoAltoContraste = false;
            else
                activadoAltoContraste = true;

            //cambiamos los colores
            if (activadoAltoContraste == true)
            {
                colorLetraCorrecta = Color.DarkBlue;
                colorLetraFallida = Color.Black;
                colorLetraDesubicada = Color.Orange;
            }
            else
            {
                colorLetraCorrecta = Color.DarkGreen;
                colorLetraFallida = Color.DarkGray;
                colorLetraDesubicada = Color.Orange;
            }

            //Asignamos los colores
            txtColorCorrecto.BackColor = colorLetraCorrecta;
            txtColorDesubicado.BackColor = colorLetraDesubicada;
            txtColorFallido.BackColor = colorLetraFallida;
        }

        /// <summary>
        /// Inicializa los atributos de la lógica antes del juego
        /// </summary>
        private void InicializaLogicaJuego()
        {
            intentoActual = 0;
            hayDerrota = false;

            //Inicializamos el diccionario
            InicializaDiccionario();

            //Seleccionar una palabra buscada
            Random aleatorio = new Random();
            palabraBuscada =
                diccionarioPalabras[aleatorio.Next(diccionarioPalabras.Length)];

            //Inicializamos el resultado de la validación de letras
            evaluacionLetras = "-----".ToCharArray();
        }



        private void btnEvaluaPalabra_Click(object sender, EventArgs e)
        {
            //Aqui evaluamos si la palabra tiene 5 letras
            if (txtPalabraIngresada.Text.Length == 5)
            {
                bool resultadoLetrasValidas = VerificaLetrasValidas(txtPalabraIngresada.Text);

                if (resultadoLetrasValidas == false)
                {
                    MessageBox.Show("La palabra solo puede tener letras. Intenta nuevamente");
                }
                else
                {
                    //Si la palabra tiene 5 letras, evaluamos la palabra
                    EvaluaPalabraIngresada(txtPalabraIngresada.Text.ToUpper());

                    //Actualizamos las casillas con estos resultados
                    ActualizaCasillasConResultados(txtPalabraIngresada.Text.ToUpper(),
                        intentoActual,
                        evaluacionLetras);

                    // - Validar si hay derrota
                    if (hayDerrota == true)
                    {
                        MessageBox.Show($"Fuiste derrotado! la palabra era {palabraBuscada}");
                    }
                    else
                    {
                        string resultadoValidacion = new string(evaluacionLetras);
                        if (resultadoValidacion == "VVVVV")
                        {
                            MessageBox.Show($"Lograte la victoria! encontraste la palabra {palabraBuscada}");
                        }
                    }                    
                }

            }
            else
            {
                MessageBox.Show("Palabra con longitud inválida!");
            }

            //Finalmente, reiniciamos el textbox de la palabra ingresada y le asignamos el foco
            txtPalabraIngresada.Text = "";
            this.ActiveControl = txtPalabraIngresada;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Inicializamos la lógica del juego
            InicializaLogicaJuego();

            //Inicializamos la presentación
            InicializaPresentacionJuego();
        }

        /// <summary>
        /// Compara la palabra buscada con la ingresada y genera
        /// un resultado de evaluación
        /// </summary>
        /// <param name="palabraIngresada"></param>
        private void EvaluaPalabraIngresada(string palabraIngresada)
        {
            //Las palabras convertidas en arreglo de caracteres
            char[] letrasPalabraBuscada = palabraBuscada.ToCharArray();
            char[] letrasPalabraIngresada = palabraIngresada.ToCharArray();

            //Inicializamos el resultado de la validación de letras
            evaluacionLetras = "-----".ToCharArray();

            /*
            Como se hace la validación?
            - Si no está en ninguna parte, se deja en "-"
            - Si está en la posición correcta, se coloca "V"
            - Si está pero en la posición equivocada, se coloca "A"
             */

            for (int i = 0; i < letrasPalabraBuscada.Length; i++)
            {
                for (int j = 0; j < letrasPalabraIngresada.Length; j++)
                {
                    if (letrasPalabraBuscada[i] == letrasPalabraIngresada[j])
                    {
                        //Posición coincide en la posición correcta y
                        //no se había identificado antes, V
                        if (i == j && evaluacionLetras[j] == '-')
                            evaluacionLetras[j] = 'V';

                        //Posición no coincide, pero está y
                        //no se había identificado antes, A
                        if (i != j && evaluacionLetras[j] == '-')
                            evaluacionLetras[j] = 'A';

                        //Posición coincide y previamente se había identificado como A, V
                        if (i == j && evaluacionLetras[j] == 'A')
                            evaluacionLetras[j] = 'V';
                    }
                }
            }

            //Finalmente incrementamos el intento actual y verificamos si hay derrota
            if (intentoActual < 6)
                intentoActual++;

            //Validamos si hay derrota
            string resultadoValidacion = new string(evaluacionLetras);
            if (intentoActual == 6 && resultadoValidacion != "VVVVV")
            {
                hayDerrota = true;
            }
        }

        private void activarColoresAltoContrasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiaColorAltoContraste();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Inicializamos la lógica del juego
            InicializaLogicaJuego();

            //Inicializamos la presentación
            InicializaPresentacionJuego();
        }

        private void InicializaMatrizCasillas()
        {
            matrizCasillas = new TextBox[6, 5];

            //La parte "maluca"...
            //Primera fila
            matrizCasillas[0, 0] = txtletra_intento1_posicion1;
            matrizCasillas[0, 1] = txtletra_intento1_posicion2;
            matrizCasillas[0, 2] = txtletra_intento1_posicion3;
            matrizCasillas[0, 3] = txtletra_intento1_posicion4;
            matrizCasillas[0, 4] = txtletra_intento1_posicion5;

            //Segunda fila
            matrizCasillas[1, 0] = txtletra_intento2_posicion1;
            matrizCasillas[1, 1] = txtletra_intento2_posicion2;
            matrizCasillas[1, 2] = txtletra_intento2_posicion3;
            matrizCasillas[1, 3] = txtletra_intento2_posicion4;
            matrizCasillas[1, 4] = txtletra_intento2_posicion5;

            //tercera fila
            matrizCasillas[2, 0] = txtletra_intento3_posicion1;
            matrizCasillas[2, 1] = txtletra_intento3_posicion2;
            matrizCasillas[2, 2] = txtletra_intento3_posicion3;
            matrizCasillas[2, 3] = txtletra_intento3_posicion4;
            matrizCasillas[2, 4] = txtletra_intento3_posicion5;

            //cuarta fila
            matrizCasillas[3, 0] = txtletra_intento4_posicion1;
            matrizCasillas[3, 1] = txtletra_intento4_posicion2;
            matrizCasillas[3, 2] = txtletra_intento4_posicion3;
            matrizCasillas[3, 3] = txtletra_intento4_posicion4;
            matrizCasillas[3, 4] = txtletra_intento4_posicion5;

            //quinta fila
            matrizCasillas[4, 0] = txtletra_intento5_posicion1;
            matrizCasillas[4, 1] = txtletra_intento5_posicion2;
            matrizCasillas[4, 2] = txtletra_intento5_posicion3;
            matrizCasillas[4, 3] = txtletra_intento5_posicion4;
            matrizCasillas[4, 4] = txtletra_intento5_posicion5;

            //sexta fila
            matrizCasillas[5, 0] = txtletra_intento6_posicion1;
            matrizCasillas[5, 1] = txtletra_intento6_posicion2;
            matrizCasillas[5, 2] = txtletra_intento6_posicion3;
            matrizCasillas[5, 3] = txtletra_intento6_posicion4;
            matrizCasillas[5, 4] = txtletra_intento6_posicion5;

            //Inicializamos todas las casillas, asignando para cada una de ellas
            //un color neutro y un contenido vacío
            foreach (TextBox unaCasilla in matrizCasillas)
            {
                unaCasilla.Text = "";
                unaCasilla.BackColor = Color.White;
                unaCasilla.ForeColor = Color.White;
                unaCasilla.Enabled = false;
            }
        }

        private void ActualizaCasillasConResultados(string palabraIngresada,
            int elIntento,
            char[] resultadoEvaluacion)
        {
            char[] letrasPalabraIngresada = palabraIngresada.ToCharArray();

            //Aqui recorremos la matriz de casillas y colocamos la letra en las casillas
            //correspondientes a la fila del intento

            for (int i = 0; i < letrasPalabraIngresada.Length; i++)
            {
                matrizCasillas[elIntento - 1, i].Text = letrasPalabraIngresada[i].ToString();

                switch (resultadoEvaluacion[i])
                {
                    case 'V':
                        matrizCasillas[elIntento - 1, i].BackColor = colorLetraCorrecta;
                        break;

                    case 'A':
                        matrizCasillas[elIntento - 1, i].BackColor = colorLetraDesubicada;
                        break;

                    case '-':
                        matrizCasillas[elIntento - 1, i].BackColor = colorLetraFallida;
                        break;
                }
            }
        }

        /// <summary>
        /// Verifica si la palabra solo tiene letras
        /// </summary>
        /// <param name="palabraIngresada"></param>
        /// <returns>true, si solo tiene letras</returns>
        private bool VerificaLetrasValidas(string palabraIngresada)
        {
            bool resultado = true;
            Regex patron = new Regex("[a-zA-ZñÑ]");
            char[] lasLetras = palabraIngresada.ToCharArray();

            foreach (char unaLetra in lasLetras)
            {
                if (patron.IsMatch(unaLetra.ToString()) == false)
                {
                    return false;
                }
            }

            return resultado;
        }

    }
}
