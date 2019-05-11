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
        public Form1()
        {
            InitializeComponent();
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
            etiquetaEstado.Text = "Aplicación inicializada.";
            radioLinea.Checked = true;

            cuadroColorPrimario.BackColor = Color.Black;
            cuadroColorSecundario.BackColor = Color.White;

            cuadroDibujo.BackColor = Color.White;
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
            }
        }

        private void SeleccionaColorSecundario()
        {
            ColorDialog ventanaColor = new ColorDialog();

            if (ventanaColor.ShowDialog() == DialogResult.OK)
            {
                cuadroColorSecundario.BackColor = ventanaColor.Color;
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
            cuadroColorSecundario.BackColor = tmpColor;

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
                Font laLetra = ventanaLetra.Font;
                etiquetaEstado.Text = "Tipo de letra: " + laLetra.Name + ", " + laLetra.Size;
            }
        }
    }
}
