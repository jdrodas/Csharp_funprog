/*
Programa:       ex04_EncuentraParejasNumeros
Contacto:       Juan Dario Rodas - jdrodas @hotmail.com

Especificacionesde funcionamiento
=================================

Versión Orientada a Objetos del proyecto EncuentraParejasNumeros.
Separación Funcional en las clases Logica.cs (Lógica del juego) y Form1.cs (visualización)

Se ha implementado un juego de “Encuentre las parejas” que consiste en identificar 
la ubicación de 8 parejas de números distribuidas en 16 botones que el usuario debe 
presionar para revelar su ubicación.

Cada vez que el usuario presiona un botón, en el cuadro de texto “Estado”, se 
visualiza cual fue el botón presionado y que valor está allí. Cada vez que se presione 
dos botones de manera consecutivos, se visualiza una ventana emergente con información 
de la pareja revelada. Si los valores son iguales, se ha encontrado una pareja y se 
incrementará el contador respectivo. Sea que se encuentre o no, el contador de intentos 
también se incrementará.

En caso de que el jugador desee reiniciar el juego, el botón “Reiniciar el juego” 
distribuirá nuevamente los valores en ubicaciones diferentes y reiniciará los respectivos 
contadores.

Cuando se encuentren las 8 parejas, el programa indicará que se alcanzó la victoria.
*/


using System;
using System.Windows.Forms;

namespace ex04_EncuentraParejasNumeros
{
    public partial class Form1 : Form
    {
        //Aqui declaramos los atributos lógica del juego
        private Logica miLogica;

        private Button[] arregloBotones;

        public Form1()
        {
            InitializeComponent();

            //Inicializamos el atributo de la lógica del juego
            miLogica = new Logica();

            //Aqui inicializamos los atributos del juego
            InicializaAtributos();
        }

        private void InicializaAtributos()
        {
            //aqui inicializamos los atributos de la lógica
            miLogica.InicializaJuego();

            //Aqui invocamos las funciones de inicialización de arreglo
            InicializaArregloBotones();

            //Llevamos los valores de los atributos a los cuadros de texto
            textoTotalIntentos.Text = miLogica.TotalIntentos.ToString();
            textoParejasEncontradas.Text = miLogica.TotalParejas.ToString();
            textoEstado.Text = "Juego Inicializado.";
        }

        // Este método inicializa los Botones<s
        private void InicializaArregloBotones()
        {
            arregloBotones = new Button[16];

            arregloBotones[0] = button1;
            arregloBotones[1] = button2;
            arregloBotones[2] = button3;
            arregloBotones[3] = button4;
            arregloBotones[4] = button5;
            arregloBotones[5] = button6;
            arregloBotones[6] = button7;
            arregloBotones[7] = button8;
            arregloBotones[8] = button9;
            arregloBotones[9] = button10;
            arregloBotones[10] = button11;
            arregloBotones[11] = button12;
            arregloBotones[12] = button13;
            arregloBotones[13] = button14;
            arregloBotones[14] = button15;
            arregloBotones[15] = button16;

            //Finalmente, aqui ocultamos todas las etiquetas de los botones
            for (int i = 0; i < arregloBotones.Length; i++)
            {
                arregloBotones[i].Text = "X";
                arregloBotones[i].Enabled = true; //Los habilitamos
            }
        }

        private void botonReiniciar_Click(object sender, EventArgs e)
        {
            InicializaAtributos();
        }

        private void AnalizaBotonPresionado(int numeroBoton)
        {
            //Visualizamos el valor en el botón presionado
            arregloBotones[numeroBoton - 1].Text = miLogica.ObtieneValorEncontrado(numeroBoton).ToString();

            //Este es el núcleo del juego -- La lógica de identificar si se encontró la pareja
            miLogica.AnalizaValorEncontrado(numeroBoton);
            
            //Y también desactivamos el botón para que no se vuelva a usar mientras se
            //define la busqueda de la pareja
            arregloBotones[numeroBoton - 1].Enabled = false;

            //preparamos el texto para el texto de estado
            textoEstado.Text = "Presionaste el botón " +
                numeroBoton.ToString() + ", el valor aqui es: " +
                 miLogica.ObtieneValorEncontrado(numeroBoton).ToString();

            string mensaje; //El mensaje que se visualizará en el cuadro de diálogo

            //aqui decidimos que mensaje colocar si se han revelado las dos partes de la pareja

            if (miLogica.ParejaParteA != 0 && miLogica.ParejaParteB != 0)
            {
                mensaje = "Parte A: " + miLogica.ParejaParteA.ToString() +
                          "\nParte B: " + miLogica.ParejaParteB.ToString();

                if (miLogica.ParejaParteA == miLogica.ParejaParteB)
                {
                    //Se visualiza en un cuadro de dialogo que se ha encontrado una pareja
                    MessageBox.Show(mensaje, "Pareja encontrada!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Si el total de parejas es 8, la victoria se ha obtenido
                    if (miLogica.TotalParejas == 8)
                    {
                        textoEstado.Text = "Victoria Alcanzada!";
                    }
                }
                // De lo contrario, se vuelve a ocultar las etiquetas
                else
                {
                    //Se visualiza en un cuadro de dialogo los valores que se revelaron
                    MessageBox.Show(mensaje, "Valores revelados:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //Este método oculta las etiquetas de los valores no encontrados
                    ValidaEtiquetasBotones();
                }

                //reiniciamos los valores de las partes para el siguiente intento
                miLogica.ReiniciaPareja();

            }
             
            //Aqui actualizamos la información de los usuarios
            textoTotalIntentos.Text = miLogica.TotalIntentos.ToString();
            textoParejasEncontradas.Text = miLogica.TotalParejas.ToString();
        }

        //Este método se encarga de volver a esconder aquellos valores que no han sido
        //relacionados en parejas, colocando en el botón una X
        private void ValidaEtiquetasBotones()
        {
            int datoValor;

            //Se valida si el valor fue encontrado. Si no, se vuelve a colocar la X
            for (int i = 0; i < miLogica.ArregloValores.Length; i++)
            {
                datoValor = miLogica.ArregloValores[i];

                //Se identifica en el arreglo de valoresEncontrados si ya se identificó la pareja
                if (miLogica.ValoresEncontrados[datoValor - 1] == false)
                {
                    //Si el valor no fue encontrado, el botón se coloca con X
                    arregloBotones[i].Text = "X";
                    arregloBotones[i].Enabled = true; //se habilita nuevamente el botón
                }
            }

            textoEstado.Text = "";
        }

        #region ComportamientoBotones

        private void button1_Click(object sender, EventArgs e)
        {
            AnalizaBotonPresionado(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnalizaBotonPresionado(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnalizaBotonPresionado(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AnalizaBotonPresionado(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AnalizaBotonPresionado(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AnalizaBotonPresionado(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AnalizaBotonPresionado(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AnalizaBotonPresionado(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AnalizaBotonPresionado(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AnalizaBotonPresionado(10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AnalizaBotonPresionado(11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AnalizaBotonPresionado(12);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AnalizaBotonPresionado(13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            AnalizaBotonPresionado(14);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            AnalizaBotonPresionado(15);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AnalizaBotonPresionado(16);
        }

        #endregion ComportamientoBotones
    }
}
