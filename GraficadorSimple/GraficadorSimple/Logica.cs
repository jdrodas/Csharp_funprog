using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Media;
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
        private int ladosPoligono;
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
            ladosPoligono = 3; // mínimo número de lados

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

        public void DibujaRectangulo(string tipoRelleno, string tipoGradiente)
        {
            Pen lapiz = new Pen(colorPrimario, grosorLinea);

            int ancho = Math.Abs(PuntoFinal.X - PuntoInicial.X);
            int alto = Math.Abs(PuntoFinal.Y - PuntoInicial.Y);

            Point puntoOrigen = new Point(
                Math.Min(PuntoFinal.X, PuntoInicial.X),
                Math.Min(PuntoFinal.Y,PuntoInicial.Y));

            Rectangle miRectangulo = 
                new Rectangle(puntoOrigen.X, puntoOrigen.Y, ancho, alto);

            //Dibujamos según la opción de relleno
            //Si el relleno es con borde - sin relleno
            if(tipoRelleno=="borde")
                areaDibujo.DrawRectangle(lapiz, miRectangulo);

            if(tipoRelleno=="sólido")
            {
                Brush pincelSolido = new SolidBrush(colorSecundario);
                areaDibujo.FillRectangle(pincelSolido, miRectangulo);
                areaDibujo.DrawRectangle(lapiz, miRectangulo);
            }

            if (tipoRelleno == "gradiente")
            {
                if(tipoGradiente=="Horizontal")
                { 
                   Brush pincelGradiente= new LinearGradientBrush(miRectangulo,
                                            colorPrimario,
                                            colorSecundario,
                                            LinearGradientMode.Horizontal);

                    areaDibujo.FillRectangle(pincelGradiente, miRectangulo);
                }

                if (tipoGradiente == "Vertical")
                {
                    Brush pincelGradiente = new LinearGradientBrush(miRectangulo,
                                             colorPrimario,
                                             colorSecundario,
                                             LinearGradientMode.Vertical);

                    areaDibujo.FillRectangle(pincelGradiente, miRectangulo);
                }

                if (tipoGradiente == "Diagonal")
                {
                    Brush pincelGradiente = new LinearGradientBrush(miRectangulo,
                                             colorPrimario,
                                             colorSecundario,
                                             LinearGradientMode.BackwardDiagonal);

                    areaDibujo.FillRectangle(pincelGradiente, miRectangulo);
                }
            }
        }

        public void DibujaElipse(string tipoRelleno, string tipoGradiente)
        {
            Pen lapiz = new Pen(colorPrimario, grosorLinea);

            int ancho = Math.Abs(PuntoFinal.X - PuntoInicial.X);
            int alto = Math.Abs(PuntoFinal.Y - PuntoInicial.Y);

            Point puntoOrigen = new Point(
                Math.Min(PuntoFinal.X, PuntoInicial.X),
                Math.Min(PuntoFinal.Y, PuntoInicial.Y));

            Rectangle miRectangulo =
                new Rectangle(puntoOrigen.X, puntoOrigen.Y, ancho, alto);

            //Dibujamos según la opción de relleno
            //Si el relleno es con borde - sin relleno
            if (tipoRelleno == "borde")
                areaDibujo.DrawEllipse(lapiz, miRectangulo);

            if (tipoRelleno == "sólido")
            {
                Brush pincelSolido = new SolidBrush(colorSecundario);
                areaDibujo.FillEllipse(pincelSolido, miRectangulo);
                areaDibujo.DrawEllipse(lapiz, miRectangulo);                
            }

            if (tipoRelleno == "gradiente")
            {
                Brush pincelGradiente = new SolidBrush(colorSecundario);

                if (tipoGradiente == "Horizontal")
                {
                    pincelGradiente = new LinearGradientBrush(miRectangulo,
                                             colorPrimario,
                                             colorSecundario,
                                             LinearGradientMode.Horizontal);
                }

                if (tipoGradiente == "Vertical")
                {
                    pincelGradiente = new LinearGradientBrush(miRectangulo,
                                             colorPrimario,
                                             colorSecundario,
                                             LinearGradientMode.Vertical);
                }

                if (tipoGradiente == "Diagonal")
                {
                    pincelGradiente = new LinearGradientBrush(miRectangulo,
                                             colorPrimario,
                                             colorSecundario,
                                             LinearGradientMode.BackwardDiagonal);
                }

                areaDibujo.FillEllipse(pincelGradiente, miRectangulo);
            }
        }

        public void DibujaPoligono(string tipoRelleno, string tipoGradiente)
        {

            //calculamos el area que contendrá el polígono
            int ancho = Math.Abs(PuntoFinal.X - PuntoInicial.X);
            int alto = Math.Abs(PuntoFinal.Y - PuntoInicial.Y);

            // encontramos el punto origen para el rectángulo que contendrá el relleno
            Point puntoOrigen = new Point(
                Math.Min(PuntoFinal.X, PuntoInicial.X),
                Math.Min(PuntoFinal.Y, PuntoInicial.Y));

            //El centro del polígono
            Point puntoCentral = new Point(puntoOrigen.X + (int)(ancho / 2),
                                           puntoOrigen.Y + (int)(alto / 2));

            // El radio del polígono, la mitad del menor de los semiejes de la elipse que lo contiene
            int radio = (int)(Math.Min(ancho, alto) / 2);

            //Aqui calculamos los vertices, tantos como lados del polígono
            Point[] vertices = new Point[ladosPoligono];

            //esta es la separación en radianes de los vertices sobre la circunferencia que inscribe el polígono
            double arco = (2 * Math.PI / ladosPoligono);

            for (int i = 0; i < vertices.Length; i++)
            {
                vertices[i] = new Point();
                vertices[i].X = (int)(Math.Cos(arco * i) * radio + puntoCentral.X);
                vertices[i].Y = (int)(Math.Sin(-arco * i) * radio + puntoCentral.Y);
            }

            Pen lapiz = new Pen(colorPrimario, grosorLinea);

            //Dibujamos según la opción de relleno
            //Si el relleno es con borde - sin relleno
            if (tipoRelleno == "borde")
                areaDibujo.DrawPolygon(lapiz, vertices);

            if (tipoRelleno == "sólido")
            {
                Brush pincelSolido = new SolidBrush(colorSecundario);
                areaDibujo.FillPolygon(pincelSolido, vertices);
                areaDibujo.DrawPolygon(lapiz, vertices);
            }

            if (tipoRelleno == "gradiente")
            {
                // Se define un rectángulo que define el contenido del relleno
                Rectangle miRectangulo = new Rectangle(puntoOrigen.X, puntoOrigen.Y, ancho, alto);
                Brush pincelGradiente = new SolidBrush(colorSecundario);

                if (tipoGradiente == "Horizontal")
                {
                    pincelGradiente = new LinearGradientBrush(miRectangulo,
                                             colorPrimario,
                                             colorSecundario,
                                             LinearGradientMode.Horizontal);   
                }

                if (tipoGradiente == "Vertical")
                {
                    pincelGradiente = new LinearGradientBrush(miRectangulo,
                                             colorPrimario,
                                             colorSecundario,
                                             LinearGradientMode.Vertical);
                }

                if (tipoGradiente == "Diagonal")
                {
                    pincelGradiente = new LinearGradientBrush(miRectangulo,
                                             colorPrimario,
                                             colorSecundario,
                                             LinearGradientMode.BackwardDiagonal);
                }

                areaDibujo.FillPolygon(pincelGradiente, vertices);
            }
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

        public int LadosPoligono
        {
            set { ladosPoligono = value; }
            get { return ladosPoligono; }
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
            get { return grosorLinea; }
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
