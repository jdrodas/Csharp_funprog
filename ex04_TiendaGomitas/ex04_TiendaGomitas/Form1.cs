/*
Programa:       ex04_TiendaGomitas
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
Examen 04 - Implementación Interfaz Gráfica y Objetos

- Evaluar conceptos de clase objeto, encapsulación, atributos, propiedades
- Crear un arreglo de objetos y utilizarlo como atributo de una clase
- Crear un arreglo multidimensional y generar mecanismos para recorrerlo

*/

using System;
using System.Windows.Forms;

namespace ex04_TiendaGomitas
{
    public partial class Form1 : Form
    {
        //atributos propios del problema
        private Logica logicaTienda;

        public Form1()
        {
            InitializeComponent();

            //inicializamos atributos propios del problema
            logicaTienda = new Logica();

            InicializaTienda();
        }

        private void InicializaTienda()
        {
            //Inicializamos la simulacion
            logicaTienda.InicializaSimulacion();
        }

        private void BotonInicio_Click(object sender, EventArgs e)
        {
            InicializaTienda();

            //aqui visualizamos los contenidos de información:
            lblFrecuencia.Text = logicaTienda.ObtieneMayorMenorFrecuencia();
            txtDetallePedido.Text = logicaTienda.ObtieneInfoDetallePedido();

            //aqui visualizamos los totales por sabores
            txtSaborChontaduro.Text = logicaTienda.ObtieneTotalAtributo("sabor",0).ToString();
            txtSaborMamoncillo.Text = logicaTienda.ObtieneTotalAtributo("sabor",1).ToString();
            txtSaborArracacha.Text = logicaTienda.ObtieneTotalAtributo("sabor", 2).ToString();

            //aqui visualizamos los totales por formas
            txtFormaPiramide.Text = logicaTienda.ObtieneTotalAtributo("forma", 0).ToString();
            txtFormaDragon.Text = logicaTienda.ObtieneTotalAtributo("forma", 1).ToString();
            txtFormaCondor.Text = logicaTienda.ObtieneTotalAtributo("forma", 2).ToString();

            //aqui visualizamos los totales por colores
            txtColorSalmon.Text = logicaTienda.ObtieneTotalAtributo("color", 0).ToString();
            txtColorEsmeralda.Text = logicaTienda.ObtieneTotalAtributo("color", 1).ToString();
            txtColorZafiro.Text = logicaTienda.ObtieneTotalAtributo("color", 2).ToString();
            txtColorMostaza.Text = logicaTienda.ObtieneTotalAtributo("color", 3).ToString();
            txtColorMagenta.Text = logicaTienda.ObtieneTotalAtributo("color", 4).ToString();
        }
    }
}
