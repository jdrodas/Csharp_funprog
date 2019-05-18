using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraficadorSimple
{
    public partial class Form1 : Form
    {
        private Logica logicaDibujo;
        private bool mousePresionado;

        public Form1()
        {
            InitializeComponent();
            logicaDibujo = new Logica();
            mousePresionado = false;
        }

        private void itemMenuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InicializaInterfaz();
        }

        /// <summary>
        /// Inicializa los elementos de la Interfaz
        /// </summary>
        private void InicializaInterfaz()
        {
            logicaDibujo.InicializaLogica(cuadroDibujo.Width,
                cuadroDibujo.Height);

            textoFrase.Text = "";
            etiquetaEstado.Text = "Aplicación inicializada.";
            radioLinea.Checked = true;
            radioRellenoBorde.Checked = true;

            //ocultamos la lista de rellenos gradientes
            listaGradientes.Visible = false;
            listaGradientes.SelectedIndex = 0;

            cuadroColorPrimario.BackColor = Color.Black;
            cuadroColorSecundario.BackColor = Color.White;
            selectorGrosor.Value = logicaDibujo.GrosorLinea;

            cuadroDibujo.Image = logicaDibujo.ImagenDibujo;
            etiquetaPuntoInicial.Text = "Punto inicial:";
            etiquetaPuntoFinal.Text = "Punto final:";
        }

        private void itemMenuNuevo_Click(object sender, EventArgs e)
        {
            InicializaInterfaz();
        }

        private void cuadroColorPrimario_Click(object sender, EventArgs e)
        {
            SeleccionaColorPrimario();
        }

        private void itemMenuColorPrimario_Click(object sender, EventArgs e)
        {
            SeleccionaColorPrimario();
        }

        private void SeleccionaColorPrimario()
        {
            ColorDialog ventanaColor = new ColorDialog();

            if (ventanaColor.ShowDialog() == DialogResult.OK)
            {
                cuadroColorPrimario.BackColor = ventanaColor.Color;
                logicaDibujo.ColorPrimario = ventanaColor.Color;

                etiquetaEstado.Text = "Color primario seleccionado.";

            }
        }

        private void SeleccionaColorSecundario()
        {
            ColorDialog ventanaColor = new ColorDialog();

            if (ventanaColor.ShowDialog() == DialogResult.OK)
            {
                cuadroColorSecundario.BackColor = ventanaColor.Color;
                logicaDibujo.ColorSecundario = ventanaColor.Color;

                etiquetaEstado.Text = "Color secundario seleccionado.";
            }
        }

        private void itemMenuColorSecundario_Click(object sender, EventArgs e)
        {
            SeleccionaColorSecundario();
        }

        private void cuadroColorSecundario_Click(object sender, EventArgs e)
        {
            SeleccionaColorSecundario();
        }

        private void botonSwapColores_Click(object sender, EventArgs e)
        {
            Color tmpColor = cuadroColorPrimario.BackColor;

            cuadroColorPrimario.BackColor = cuadroColorSecundario.BackColor;
            logicaDibujo.ColorPrimario = cuadroColorSecundario.BackColor;

            cuadroColorSecundario.BackColor = tmpColor;
            logicaDibujo.ColorSecundario = tmpColor;

            etiquetaEstado.Text = "Colores intercambiados.";
        }

        private void itemMenuTipoLetra_Click(object sender, EventArgs e)
        {
            SeleccionaTipoLetra();
        }

        private void BotonTipoLetra_Click(object sender, EventArgs e)
        {
            SeleccionaTipoLetra();
        }

        private void SeleccionaTipoLetra()
        {
            FontDialog ventanaLetra = new FontDialog();

            if (ventanaLetra.ShowDialog() == DialogResult.OK)
            {
                logicaDibujo.TipoLetra = ventanaLetra.Font;
                etiquetaEstado.Text = "Tipo de letra: " + 
                    logicaDibujo.TipoLetra.Name + 
                    ", " + logicaDibujo.TipoLetra.Size;
            }
        }

        private void itemMenuAcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Herramienta diseñada en el curso de Fundamentos de programación. UPB, Mayo 2019",
                "Graficador simple v. 2019");
        }

        private void selectorGrosor_ValueChanged(object sender, EventArgs e)
        {
            logicaDibujo.GrosorLinea = (int)selectorGrosor.Value;
            etiquetaEstado.Text = "Grosor de línea asignado.";
        }

        private void textoFrase_Leave(object sender, EventArgs e)
        {
            logicaDibujo.Frase = textoFrase.Text;
            etiquetaEstado.Text = "Frase asignada.";
        }

        private void radioLinea_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLinea.Checked)
            {
                etiquetaEstado.Text = "Herramienta seleccionada: línea.";
            }
        }

        private void radioRectangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRectangulo.Checked)
            {
                etiquetaEstado.Text = "Herramienta seleccionada: rectángulo.";
            }
        }

        private void radioElipse_CheckedChanged(object sender, EventArgs e)
        {
            if (radioElipse.Checked)
            {
                etiquetaEstado.Text = "Herramienta seleccionada: elipse.";
            }
        }

        private void radioTexto_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTexto.Checked)
            {
                etiquetaEstado.Text = "Herramienta seleccionada: texto.";
            }
        }

        private void cuadroDibujo_MouseDown(object sender, MouseEventArgs e)
        {
            mousePresionado = true;

            logicaDibujo.PuntoInicial = new Point(e.X, e.Y);

            etiquetaPuntoInicial.Text = "Punto inicial: ("+
                logicaDibujo.PuntoInicial.X + "," +
                logicaDibujo.PuntoInicial.Y +")";

            etiquetaPuntoFinal.Text = "Punto Final:";
        }

        private void cuadroDibujo_MouseUp(object sender, MouseEventArgs e)
        {
            mousePresionado = false;

            logicaDibujo.PuntoFinal = new Point(e.X, e.Y);

            etiquetaPuntoFinal.Text = "Punto final: (" +
                logicaDibujo.PuntoFinal.X + "," +
                logicaDibujo.PuntoFinal.Y + ")";

            string tipoRelleno = "";
            string tipoGradiente = "";

            //Indicamos el tipo de relleno que se quiere
            if (radioRellenoBorde.Checked)
                tipoRelleno = "borde";

            if (radioRellenoSolido.Checked)
                tipoRelleno = "sólido";

            if (radioRellenoGradiente.Checked)
            { 
                tipoRelleno = "gradiente";

                switch (listaGradientes.SelectedIndex)
                {
                    case 0:
                        tipoGradiente = "Horizontal";
                        break;

                    case 1:
                        tipoGradiente = "Vertical";
                        break;

                    case 2:
                        tipoGradiente = "Diagonal";
                        break;
                }

                
            }

            //aqui se dibuja una linea
            if (radioLinea.Checked)
                logicaDibujo.DibujaLinea();

            if (radioRectangulo.Checked)
                logicaDibujo.DibujaRectangulo(tipoRelleno,tipoGradiente);

            if (radioElipse.Checked)
                logicaDibujo.DibujaElipse(tipoRelleno, tipoGradiente);

            if (radioTexto.Checked)
                logicaDibujo.DibujaFrase();

            //finalmente actualizamos la imagen en el cuadro
            cuadroDibujo.Image = logicaDibujo.ImagenDibujo;
        }

        private void cuadroDibujo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousePresionado)
            {
                etiquetaPuntoFinal.Text = "Punto final: (" +
                    e.X + "," +
                    e.Y + ")";
            }
        }

        private void radioRellenoGradiente_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRellenoGradiente.Checked == true)
                listaGradientes.Visible = true;
            else
                listaGradientes.Visible = false;
        }
    }
}
