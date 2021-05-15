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
        //Atributos de la clase
        private Logica logicaDibujo;
        private bool mousePresionado;

        //Constructor de la clase
        public Form1()
        {
            InitializeComponent();
            logicaDibujo = new Logica();
            mousePresionado = false;
        }

        /// <summary>
        /// Evento asociado al cargue inicial de la forma
        /// </summary>
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

            //ocultamos los parametros para el dibujo de polígono
            selectorNumeroLados.Visible = false;
            etiquetaLados.Visible = false;

            cuadroColorPrimario.BackColor = Color.Black;
            cuadroColorSecundario.BackColor = Color.White;
            selectorGrosor.Value = logicaDibujo.GrosorLinea;

            cuadroDibujo.Image = logicaDibujo.ImagenDibujo;
            etiquetaPuntoInicial.Text = "Punto inicial:";
            etiquetaPuntoFinal.Text = "Punto final:";
        }

        /// <summary>
        /// Evento asociado al item de menú - Nuevo
        /// </summary>
        private void itemMenuNuevo_Click(object sender, EventArgs e)
        {
            InicializaInterfaz();
        }

        /// <summary>
        /// Evento asociado al item de menú - Salir
        /// </summary>
        private void itemMenuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Evento asociado al item de menú - "Acerca de" 
        /// </summary>
        private void itemMenuAcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Herramienta diseñada en el curso de Fundamentos de programación. UPB, Mayo 201",
                "Graficador simple v. 201");
        }

        /// <summary>
        /// Evento asociado al cuadro de color primario
        /// </summary>
        private void cuadroColorPrimario_Click(object sender, EventArgs e)
        {
            SeleccionaColorCuadro("Primario");
        }

        /// <summary>
        /// Evento asociado al cuadro de color secundario
        /// </summary>
        private void cuadroColorSecundario_Click(object sender, EventArgs e)
        {
            SeleccionaColorCuadro("Secundario");
        }

        /// <summary>
        /// Evento asociado al item de menu - Selección de color primario
        /// </summary>
        private void itemMenuColorPrimario_Click(object sender, EventArgs e)
        {
            SeleccionaColorCuadro("Primario");
        }

        /// <summary>
        /// Evento asociado al item de menu - Selección de color primario
        /// </summary>
        private void itemMenuColorSecundario_Click(object sender, EventArgs e)
        {
            SeleccionaColorCuadro("Secundario");
        }

        /// <summary>
        /// Selecciona un color para usar en los cuadros utilizando ColorDialog
        /// </summary>
        /// <param name="cuadroSeleccionado"></param>
        private void SeleccionaColorCuadro(string cuadroSeleccionado)
        {
            ColorDialog ventanaColor = new ColorDialog();

            if (ventanaColor.ShowDialog() == DialogResult.OK)
            {
                if (cuadroSeleccionado == "Primario")
                {
                    cuadroColorPrimario.BackColor = ventanaColor.Color;
                    logicaDibujo.ColorPrimario = ventanaColor.Color;

                    etiquetaEstado.Text = "Color primario seleccionado.";
                }

                if (cuadroSeleccionado == "Secundario")
                {
                    cuadroColorSecundario.BackColor = ventanaColor.Color;
                    logicaDibujo.ColorSecundario = ventanaColor.Color;

                    etiquetaEstado.Text = "Color secundario seleccionado.";
                }
            }
        }

        /// <summary>
        /// Intercambia de posición los colores en los cuadros de selección
        /// </summary>
        private void botonSwapColores_Click(object sender, EventArgs e)
        {
            Color tmpColor = cuadroColorPrimario.BackColor;

            cuadroColorPrimario.BackColor = cuadroColorSecundario.BackColor;
            logicaDibujo.ColorPrimario = cuadroColorSecundario.BackColor;

            cuadroColorSecundario.BackColor = tmpColor;
            logicaDibujo.ColorSecundario = tmpColor;

            etiquetaEstado.Text = "Colores intercambiados.";
        }

        /// <summary>
        /// Evento asociado al item de menú - Tipo de Letra
        /// </summary>
        private void itemMenuTipoLetra_Click(object sender, EventArgs e)
        {
            SeleccionaTipoLetra();
        }

        /// <summary>
        /// Evento asociado al Botón - Tipo de Letra
        /// </summary>
        private void BotonTipoLetra_Click(object sender, EventArgs e)
        {
            SeleccionaTipoLetra();
        }

        /// <summary>
        /// Selecciona el tipo de letra para utilizar con la herramienta Texto
        /// </summary>
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


        /// <summary>
        /// Selecciona el grosor de la linea a utilizar en las herramientas de dibujo
        /// </summary>
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

        private void cuadroDibujo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousePresionado)
            {
                etiquetaPuntoFinal.Text = "Punto final: (" +
                    e.X + "," +
                    e.Y + ")";
            }
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
                        tipoGradiente = "Diagonal Adelante";
                        break;

                    case 3:
                        tipoGradiente = "Diagonal Atrás";
                        break;
                }
            }

            //aqui se dibuja una linea
            if (radioLinea.Checked)
                logicaDibujo.DibujaLinea();

            //aqui se dibuja un rectángulo
            if (radioRectangulo.Checked)
                logicaDibujo.DibujaRectangulo(tipoRelleno,tipoGradiente);

            //aqui se dibuja una elipse
            if (radioElipse.Checked)
                logicaDibujo.DibujaElipse(tipoRelleno, tipoGradiente);

            //aqui se dibuja un texto
            if (radioTexto.Checked)
                logicaDibujo.DibujaFrase();

            //aqui se dibuja un poligono
            if (radioPoligono.Checked)
                logicaDibujo.DibujaPoligono(tipoRelleno, tipoGradiente);

            //finalmente actualizamos la imagen en el cuadro
            cuadroDibujo.Image = logicaDibujo.ImagenDibujo;
        }

        private void radioRellenoGradiente_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRellenoGradiente.Checked == true)
                listaGradientes.Visible = true;
            else
                listaGradientes.Visible = false;
        }

        private void itemMenuGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog miDialogo = new SaveFileDialog();
            miDialogo.Filter = "Imagen JPG (*.jpg)|*.jpg;*.jpeg | " +
                                "Imagen PNG (*.png)|*.png |" +
                                "Imagen BMP (*.bmp)|*.bmp |" +
                               "Todos los archivos (*.*)| *.*";

            if (miDialogo.ShowDialog() == DialogResult.OK)
            {
                etiquetaEstado.Text = "Archivo guardado en " + miDialogo.FileName;
                logicaDibujo.ImagenDibujo.Save(miDialogo.FileName);
            }
        }

        private void radioPoligono_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPoligono.Checked == true)
            {
                selectorNumeroLados.Visible = true;
                etiquetaLados.Visible = true;
            }
            else
            {
                selectorNumeroLados.Visible = false;
                etiquetaLados.Visible = false;
            }

        }

        private void selectorNumeroLados_ValueChanged(object sender, EventArgs e)
        {
            logicaDibujo.LadosPoligono = (int)selectorNumeroLados.Value;
            etiquetaEstado.Text = "Lados de polígono seleccionados: " + logicaDibujo.LadosPoligono;
        }
    }
}
