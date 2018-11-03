/*
Programa:       EncuentraParejasNumeros
Contacto:       Juan Dario Rodas - jdrodas @hotmail.com

Especificacionesde funcionamiento
=================================

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

namespace EncuentraParejasNumeros
{
    public partial class Form1 : Form
    {
        //Aqui declaramos los atributos del juego
        private int totalIntentos;
        private int totalParejas;

        //Estos dos arreglos tienen tienen los valores y los botones
        private int[] arregloValores;
        private Button[] arregloBotones;
        private bool[] valoresEncontrados;

        //Estos atributos se refieren a la parte de la pareja a encontrar
        int parejaParteA, parejaParteB;

        public Form1()
        {
            InitializeComponent();

            //Aqui inicializamos los atributos del juego
            InicializaAtributos();

            //Llevamos los valores de los atributos a los cuadros de texto
            textoTotalIntentos.Text = totalIntentos.ToString();
            textoParejasEncontradas.Text = totalParejas.ToString();

        }

        private void InicializaAtributos()
        {
            totalIntentos = 0;
            totalParejas = 0;

            //Inicializamos las partes de la pareja
            parejaParteA = 0;
            parejaParteB = 0;

            //Aqui invocamos las funciones de inicialización de arreglo
            InicializaArregloBotones();
            InicializaArregloValores();
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

            //Llevamos los valores de los atributos a los cuadros de texto
            textoTotalIntentos.Text = totalIntentos.ToString();
            textoParejasEncontradas.Text = totalParejas.ToString();

            textoEstado.Text = "Juego reinicializado.";

        }

        private void AnalizaBotonPresionado(int numeroBoton)
        {
            //Aqui leemos el valor del dato correspondiente al boton presionado
            int datoValor = arregloValores[numeroBoton - 1];

            //Y también desactivamos el botón para que no se vuelva a usar mientras se
            //define la busqueda de la pareja
            arregloBotones[numeroBoton - 1].Enabled = false;

            //preparamos el texto para el texto de estado
            textoEstado.Text = "Presionaste el botón " +
                numeroBoton.ToString() + ", el valor aqui es: " +
                 datoValor.ToString();

            //Aqui identificamos si el valor presionado corresponde a la parte A o B
            if (parejaParteA == 0)
                //Luego almacenamos en la respectiva parte el valor del arreglo
                parejaParteA = datoValor;
            else // De lo contrario, lo almacenamos en la parteB
                parejaParteB = datoValor;

            //Luego visualizamos el valor en el botón presionado
            arregloBotones[numeroBoton - 1].Text = datoValor.ToString();

            string mensaje; //El mensaje que se visualizará en el cuadro de diálogo

            //Aqui se comparan las partes de la pareja
            //Primero se valida si las partes están ingresadas
            if (parejaParteA != 0 && parejaParteB != 0)
            {
                //Aqui colocamos un cuadro de Dialogo con los valores encontrados
                mensaje = "Parte A: " + parejaParteA.ToString() + 
                          "\nParte B: " + parejaParteB.ToString();

                // Si las partes son iguales, se encontró una pareja
                if (parejaParteA == parejaParteB)
                {
                    //Se visualiza en un cuadro de dialogo que se ha encontrado una pareja
                    MessageBox.Show(mensaje, "Pareja encontrada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    valoresEncontrados[datoValor - 1] = true;
                    EvaluarCondicionVictoria();
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
                parejaParteA = 0;
                parejaParteB = 0;

                //En cualquier caso, se incrementa el número de intentos
                totalIntentos++;
            }

            //Aqui actualizamos la información de los usuarios
            textoTotalIntentos.Text = totalIntentos.ToString();
            textoParejasEncontradas.Text = totalParejas.ToString();
        }

        //Aqui validamos la condición de victoria
        private void EvaluarCondicionVictoria()
        {
            //Reiniciamos el contador de parejas encontradas
            totalParejas = 0;

            for (int i = 0; i < valoresEncontrados.Length; i++)
            {
                if (valoresEncontrados[i] == true)
                    totalParejas++;
            }

            //Si el total de parejas es 8, la victoria se ha obtenido
            if (totalParejas == 8)
            {
                textoEstado.Text = "Victoria Alcanzada!";

                /*
                //Aqui se bloquean todos los botones para que no sigan activos
                for (int i = 0; i < arregloBotones.Length; i++)
                    arregloBotones[i].Enabled = false;
                */
            }
        }

        //Este método se encarga de volver a esconder aquellos valores que no han sido
        //relacionados en parejas, colocando en el botón una X
        private void ValidaEtiquetasBotones()
        {
            int datoValor;

            //Se valida si el valor fue encontrado. Si no, se vuelve a colocar la X
            for (int i = 0; i < arregloValores.Length; i++)
            {
                datoValor = arregloValores[i];

                //Se identifica en el arreglo de valoresEncontrados si ya se identificó la pareja
                if (valoresEncontrados[datoValor - 1] == false)
                {
                    //Si el valor no fue encontrado, el botón se coloca con X
                    arregloBotones[i].Text = "X";
                    arregloBotones[i].Enabled = true; //se habilita nuevamente el botón
                }
            }

            textoEstado.Text = "";
        }


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

    }
}
