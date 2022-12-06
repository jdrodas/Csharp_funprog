/*
Programa:       SimRadio
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Enunciado al problema:
----------------------

Realice un programa en C# con interfaz gráfica en Windows Forms que simule 
el comportamiento de un radio FM.

El programa permitirá cambiar la frecuencia de la emisora a través de dos botones
(F+,F-) que realizarán incrementos de la frecuencia de a 1 MHz. Las frecuencias están
en el rango comprendido entre 88.9 y 107.9 MHz. El valor predeterminado para la frecuencia
actual cuando comienza el programa será de 88.9 MHz. Si se incrementa el valor 
por encima del límite superior, el valor siguiente será el de la frecuencia del límite 
inferior. De manera equivalente, si se decrementa por debajo del límite inferior, el valor
siguiente será el del límite superior. Con F+ y F- se podrá dar ciclos completos dentro
del rango de frecuencias especificado.

El programa permitirá cambiar el valor del volumen a través de dos botones (V+,V-), los cuales
realizarán incrementos de 1 unidad en un rango de valores entre 0 y 10. Si se llega a los
límites inferiores o superiores, los valores no podrán superar o decrementar dichos límites.
El valor predeterminado del volumen será 0.

El programa tendrá un botón de encendido y apagado, el cual no permitirá que las funciones
se ejecuten en caso de que el radio esté apagado. Cuando el radio está apagado, los valores
para la frecuencia y el volumen no se ven y los botones no funcionan 

Nota Importante:
----------------

Esta versión del proyecto tiene mezclada la funcionalidad de presentación y lógica en una
sola clase, Form1. En una versión mejorada, debería existir una clase "Logica" con el 
comportamiento del radio y la forma solo quede con los elementos de visualización.

*/


using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimRadio
{
    public partial class Form1 : Form
    {
        //Atributo de la clase
        private float frecuencia;
        private int volumen;
        private bool encendido;

        public Form1()
        {
            InitializeComponent();

            volumen = 0;
            frecuencia = 88.9f;
            encendido = false;
        }
        private void botonEncendido_Click(object sender, EventArgs e)
        {
            //Cambiamos el estado de encendido del radio
            CambiaEncendido();

            //Aqui cambiamos el fondo del botón dependiendo del estado
            ValidaEstadoRadio();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ValidaEstadoRadio();
        }

        private void ValidaEstadoRadio()
        {
            //Aqui cambiamos el fondo del botón dependiendo del estado
            if (encendido == true)
            {
                botonEncendido.BackColor = Color.Green;
                etiquetaValorFrecuencia.Text = frecuencia.ToString();
                etiquetaValorVolumen.Text = volumen.ToString();

                botonSubeVolumen.Enabled = true;
                botonBajaVolumen.Enabled = true;

                botonSubeFrecuencia.Enabled = true;
                botonBajaFrecuencia.Enabled = true;
            }
            else
            {
                botonEncendido.BackColor = Color.Red;
                etiquetaValorFrecuencia.Text = "";
                etiquetaValorVolumen.Text = "";

                botonSubeVolumen.Enabled = false;
                botonBajaVolumen.Enabled = false;

                botonSubeFrecuencia.Enabled = false;
                botonBajaFrecuencia.Enabled = false;
            }
        }

        private void botonSubeVolumen_Click(object sender, EventArgs e)
        {
            SubirVolumen();
            etiquetaValorVolumen.Text = volumen.ToString();
        }

        private void botonBajaVolumen_Click(object sender, EventArgs e)
        {
            BajarVolumen();
            etiquetaValorVolumen.Text = volumen.ToString();

        }

        private void botonSubeFrecuencia_Click(object sender, EventArgs e)
        {
            SubirFrecuencia();
            etiquetaValorFrecuencia.Text = frecuencia.ToString();
        }

        private void botonBajaFrecuencia_Click(object sender, EventArgs e)
        {
            BajarFrecuencia();
            etiquetaValorFrecuencia.Text = frecuencia.ToString();
        }

        //Metodos
        public void SubirVolumen()
        {
            if (volumen != 10)
                volumen++;
        }

        public void BajarVolumen()
        {
            if (volumen != 0)
                volumen--;
        }

        public void SubirFrecuencia()
        {
            if (frecuencia != 107.9f)
                frecuencia++;
            else
                frecuencia = 88.9f;
        }

        public void BajarFrecuencia()
        {
            if (frecuencia != 88.9f)
                frecuencia--;
            else
                frecuencia = 107.9f;
        }

        public void CambiaEncendido()
        {
            if (encendido == true)
                encendido = false;
            else
                encendido = true;
        }
    }
}
