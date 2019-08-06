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
sola clase, Form1.

Por favor busque la versión SimRadio_OO en el repositorio CSharp_pdoo para conocer esta 
implementación con separación funcional por clases.

https://github.com/jdrodas/Csharp_pdoo

*/


using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimRadio
{
    public partial class Form1 : Form
    {
        //atributo de la clase
        private bool estado;
        private float frecuencia;
        private int volumen;


        //Método que asigna valores iniciales, invocado por el constructor Form1()
        private void InicializaAtributos()
        {
            estado = false;
            frecuencia = 88.9f;
            volumen = 0;
        }

        //Metodos para el cambio controlado de los atributos
        //Aqui se implementan las reglas de los requerimiento

        /// <summary>
        /// Cambia el estado del radio. Pasa de encendido a apagado según sea el caso
        /// </summary>
        public void CambiaEstado()
        {
            if (estado == true)
                estado = false;
            else
                estado = true;
        }

        /// <summary>
        /// Incrementa en una unidad el volumen solo hasta el valor máximo de 10
        /// </summary>
        public void IncrementaVolumen()
        {
            //sube el volumen si el volumen es menor que 10
            if (volumen < 10)
                volumen++;
        }

        /// <summary>
        /// Decrementa en una unidad el volumen solo hasta el valor mínimo de 0
        /// </summary>
        public void DecrementaVolumen()
        {
            //baja el volumen si el volumen es mayor que 0
            if (volumen > 0)
                volumen--;
        }

        /// <summary>
        /// Incrementa el valor de la frecuencia actual en 1 MHz
        /// </summary>
        public void IncrementaFrecuencia()
        {
            //si se incrementa por encima del límite superior
            //se devuelve al inferior. De lo contrario, incrementa en 1 MHz.
            if (frecuencia >= 107.9f)
                frecuencia = 88.9f;
            else
                frecuencia++;
        }

        /// <summary>
        /// Decrementa el valor de la frecuencia actual en 1 MHz
        /// </summary>
        public void DecrementaFrecuencia()
        {
            if (frecuencia <= 88.9f)
                frecuencia = 107.9f;
            else
                frecuencia--;
        }

        // Funcionalidades de visualización - Windows Forms

        //El constructor de la clase Form1
        public Form1()
        {
            InitializeComponent();

            //inicializamos nuestros atributos
            InicializaAtributos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cuando el radio está apagado, nada se visualiza
            if (estado == false)
            {
                LabelFrecuencia.Text = "";
                LabelVolumen.Text = "";

                BotonFmas.Enabled = false;
                BotonFmenos.Enabled = false;
                BotonVmas.Enabled = false;
                BotonVmenos.Enabled = false;

                TrackVolumen.Enabled = false;
                TrackFrecuencia.Enabled = false;
                
                BotonEstado.BackColor = Color.Red;
                BotonEstado.Text = "Apagado";
            }
        }

        private void BotonEstado_Click(object sender, EventArgs e)
        {
            CambiaEstado();

            //Cuando el radio está apagado, nada se visualiza
            if (estado == false)
            {
                LabelFrecuencia.Text = "";
                LabelVolumen.Text = "";

                BotonFmas.Enabled = false;
                BotonFmenos.Enabled = false;
                BotonVmas.Enabled = false;
                BotonVmenos.Enabled = false;

                TrackVolumen.Enabled = false;
                TrackFrecuencia.Enabled = false;

                BotonEstado.BackColor = Color.Red;
                BotonEstado.Text = "Apagado";
            }
            else
            {
                LabelFrecuencia.Text = frecuencia + "MHz";
                LabelVolumen.Text = volumen.ToString();

                TrackVolumen.Value = volumen;
                TrackFrecuencia.Value = (int)(frecuencia * 10);

                BotonFmas.Enabled = true;
                BotonFmenos.Enabled = true;
                BotonVmas.Enabled = true;
                BotonVmenos.Enabled = true;

                TrackVolumen.Enabled = true;
                TrackFrecuencia.Enabled = true;

                BotonEstado.BackColor = Color.Green;
                BotonEstado.Text = "Encendido";
            }
        }

        /// <summary>
        /// Evento que incrementa el volumen a través del botón  y visualiza el valor resultante
        /// </summary>
        private void BotonVmas_Click(object sender, EventArgs e)
        {
            IncrementaVolumen();
            LabelVolumen.Text = volumen.ToString();
            TrackVolumen.Value = volumen;
        }

        /// <summary>
        /// Evento que decrementa el volumen a través del botón y visualiza el valor resultante
        /// </summary>
        private void BotonVmenos_Click(object sender, EventArgs e)
        {
            DecrementaVolumen();
            LabelVolumen.Text = volumen.ToString();
            TrackVolumen.Value = volumen;
        }

        /// <summary>
        /// Evento que modifica el valor del volumen a través del TrackBar y visualiza el valor resultante
        /// </summary>
        private void TrackVolumen_Scroll(object sender, EventArgs e)
        {
            volumen = TrackVolumen.Value;
            LabelVolumen.Text = volumen.ToString();
        }

        /// <summary>
        /// Evento que incrementa el valor de la frecuencia actual a través del botón y visualiza el valor resultante
        /// </summary>
        private void BotonFmas_Click(object sender, EventArgs e)
        {
            IncrementaFrecuencia();
            LabelFrecuencia.Text = frecuencia + " MHz";

            //Ajuste del valor del TrackFrecuencia
            TrackFrecuencia.Value = (int)(frecuencia * 10);
        }

        /// <summary>
        /// Evento que decrementa el valor de la frecuencia actual a través del botón y visualiza el valor resultante
        /// </summary>
        private void BotonFmenos_Click(object sender, EventArgs e)
        {
            DecrementaFrecuencia();
            LabelFrecuencia.Text = frecuencia + " MHz";

            //Ajuste del valor del TrackFrecuencia
            TrackFrecuencia.Value = (int)(frecuencia * 10);
        }

        /// <summary>
        /// Evento que modifica el valor del volumen a través del TrackBar y visualiza el valor resultante
        /// </summary>
        private void TrackFrecuencia_Scroll(object sender, EventArgs e)
        {
            //Solo nos interesa el cambio cuando la frecuencia termina en *.9 MHz
            //Si el residuo de dividir por 10 da 9, nos sirve y hacemos la acción
            if ((float)(TrackFrecuencia.Value) % 10 == 9)
            {
                frecuencia = (float)(TrackFrecuencia.Value) / 10;
                LabelFrecuencia.Text = frecuencia.ToString() + " MHz";
            }
        }
    }
}
