/*
Programa:       SimRadioOO
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

Esta versión del proyecto tiene separada la funcionalidad de presentación y lógica en clases
independientes, Form1 y Radio. Es una versión mejorada del proyecto inicial que se encuentra aqui:

https://github.com/jdrodas/Csharp_funprog/tree/master/SimRadio

*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimRadioOO
{
    public partial class Form1 : Form
    {
        //Atributo de la clase
        private Radio miRadio;

        public Form1()
        {
            InitializeComponent();
            miRadio = new Radio();
        }

        private void botonEncendido_Click(object sender, EventArgs e)
        {
            //Cambiamos el estado de encendido del radio
            miRadio.CambiaEncendido();

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
            if (miRadio.Encendido == true)
            {
                botonEncendido.BackColor = Color.Green;
                etiquetaValorFrecuencia.Text = miRadio.Frecuencia.ToString();
                etiquetaValorVolumen.Text = miRadio.Volumen.ToString();

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
            miRadio.SubirVolumen();
            etiquetaValorVolumen.Text = miRadio.Volumen.ToString();
        }

        private void botonBajaVolumen_Click(object sender, EventArgs e)
        {
            miRadio.BajarVolumen();
            etiquetaValorVolumen.Text = miRadio.Volumen.ToString();

        }

        private void botonSubeFrecuencia_Click(object sender, EventArgs e)
        {
            miRadio.SubirFrecuencia();
            etiquetaValorFrecuencia.Text = miRadio.Frecuencia.ToString();
        }

        private void botonBajaFrecuencia_Click(object sender, EventArgs e)
        {
            miRadio.BajarFrecuencia();
            etiquetaValorFrecuencia.Text = miRadio.Frecuencia.ToString();
        }
    }
}
