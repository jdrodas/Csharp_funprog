using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficadorSimple
{
    class Logica
    {
        private Color colorPrimario, colorSecundario;
        private int grosorLinea;
        private Font tipoLetra;
        private string frase;
        private Point puntoInicial, puntoFinal;
        private Bitmap imagenDibujo;
        private Graphics areaDibujo;

        public Logica()
        {
            InicializaLogica(10,10); // un valor cualquiera
        }

        public void InicializaLogica(int anchoImagen, int altoImagen)
        {
            colorPrimario = Color.Black;
            colorSecundario = Color.White;

            grosorLinea = 1;
            tipoLetra = new Font("Arial", 12, FontStyle.Regular);
            frase = "";

            puntoInicial = new Point();
            puntoFinal = new Point();

            imagenDibujo = new Bitmap(anchoImagen, altoImagen);
            areaDibujo = Graphics.FromImage(imagenDibujo);

            //aqui le colocamos fondo blanco al area de dibujo
            Brush pincel = new SolidBrush(Color.White);

            areaDibujo.FillRectangle(pincel, 0, 0, anchoImagen, altoImagen);
        }

        public void DibujaLinea()
        {
            Pen lapiz = new Pen(colorPrimario, grosorLinea);
            areaDibujo.DrawLine(lapiz, puntoInicial, puntoFinal);
        }

        public void DibujaFrase()
        {
            Brush pincel = new SolidBrush(colorPrimario);
            areaDibujo.DrawString(frase, tipoLetra, pincel, puntoInicial);
        }

        public void DibujaRectangulo()
        {
            Pen lapiz = new Pen(colorPrimario, grosorLinea);

            int ancho = Math.Abs(PuntoFinal.X - PuntoInicial.X);
            int alto = Math.Abs(PuntoFinal.Y - PuntoInicial.Y);

            Point puntoOrigen = new Point(
                Math.Min(PuntoFinal.X, PuntoInicial.X),
                Math.Min(PuntoFinal.Y,PuntoInicial.Y));

            areaDibujo.DrawRectangle(lapiz, puntoOrigen.X, puntoOrigen.Y, ancho, alto);
        }

        public void DibujaElipse()
        {
            Pen lapiz = new Pen(colorPrimario, grosorLinea);

            int ancho = Math.Abs(PuntoFinal.X - PuntoInicial.X);
            int alto = Math.Abs(PuntoFinal.Y - PuntoInicial.Y);

            Point puntoOrigen = new Point(
                Math.Min(PuntoFinal.X, PuntoInicial.X),
                Math.Min(PuntoFinal.Y, PuntoInicial.Y));

            areaDibujo.DrawEllipse(lapiz, puntoOrigen.X, puntoOrigen.Y, ancho, alto);
        }

        public Bitmap ImagenDibujo
        {
            get { return imagenDibujo; }
        }

        public Point PuntoInicial
        {
            set { puntoInicial = value; }
            get { return puntoInicial; }
        }

        public Point PuntoFinal
        {
            set { puntoFinal = value; }
            get { return puntoFinal; }
        }

        public string Frase
        {
            set { frase = value; }
        }

        public Font TipoLetra
        {
            set { tipoLetra = value; }
            get { return tipoLetra; }
        }

        public int GrosorLinea
        {
            set { grosorLinea = value; }
        }

        public Color ColorSecundario
        {
            get { return colorSecundario; }
            set { colorSecundario = value; }
        }

        public Color ColorPrimario
        {
            get { return colorPrimario; }
            set { colorPrimario = value; }
        }
    }
}
