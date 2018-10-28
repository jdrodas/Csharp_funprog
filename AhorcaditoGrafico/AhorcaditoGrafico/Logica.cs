/*
Programa:       AhorcaditoGrafico
Contacto:       Juan Dario Rodas - jdrodas @hotmail.com

Enunciado al problema:
----------------------
- Implementación de una aplicación para adivinar una palabra de 10 letras
- Cuenta los fallos y los aciertos y dibuja el personaje a medida que se incrementa los fallos
- Implementación en Windows Forms con lógica del juego en clase independiente.

- Se adivinará una sola palabra de 10 letras
- Se tendrán 10 intentos erróneos antes de perder
- No marcará error por letra repetida
- Tendrá un botón de reinicio de juego y selecciona una nueva palabra
- Se evaluará la condición de victoria si adivina la totalidad de las letras
- Contamos los aciertos y los fallos
- No tendrá en cuenta las tildes
- Visualizará las letras ingresadas.
- Dibujará el personaje a medida que se incrementen los fallos


*/

using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace AhorcaditoGrafico
{
    class Logica
    {
        //Atributos de la clase
        private string[] diccionarioPalabras;
        private int contadorFallos;
        private int contadorAciertos;
        private string palabraBuscada;
        private string letrasColocadas;
        private Bitmap imagenAhorcado;

        //El constructor de la clase
        public Logica()
        {
            InicializaDiccionario();
            ReiniciaJuego();
        }

        private void InicializaDiccionario()
        {
            diccionarioPalabras = new string[] {
            "EVALUACION",
            "PROLETARIO",
            "ICOSAEDROS",
            "AHORCADITO",
            "MAMONCILLO",
            "SERENDIPIA",
            "SACERDOTES",
            "ADIVINARAS",
            "SABANDIJAS",
            "GIGANTESCO",
            "ARREPENTIR",
            "HABICHUELA",
            "ECLIPSABLE"};


        }


        /// <summary>
        /// Método que reinicia los atributos de la clase
        /// </summary>
        public void ReiniciaJuego()
        {
            contadorFallos = 0;
            contadorAciertos = 0;
            letrasColocadas = "";

            //Seleccionamos una palabra aleatoriamente desde el diccionario
            Random aleatorio = new Random();
            palabraBuscada = diccionarioPalabras[aleatorio.Next(diccionarioPalabras.Length)];

            //aqui inicializamos la imagen
            //Las dimensiones deben corresponder al PictureBox de la interfaz
            imagenAhorcado = new Bitmap(230, 240);

            Graphics areaGrafica = Graphics.FromImage(imagenAhorcado);

            Rectangle areaRectangular = new Rectangle(0, 0,
                imagenAhorcado.Width, imagenAhorcado.Height);

            Brush pincel = new SolidBrush(Color.White);

            areaGrafica.FillRectangle(pincel, areaRectangular);
        }

        //Propiedades para los atributos
        public int ContadorFallos
        {
            get { return contadorFallos; }
        }

        public int ContadorAciertos
        {
            get { return contadorAciertos; }
        }

        public string PalabraBuscada
        {
            get { return palabraBuscada; }
        }

        public string LetrasColocadas
        {
            get { return letrasColocadas; }
        }

        public Bitmap ImagenAhorcado
        {
            get { return imagenAhorcado; }
        }


        //Metodos públicos de la clase
        public bool EvaluaLetra(string laLetra)
        {
            char[] arregloLetrasColocadas = letrasColocadas.ToCharArray();
            bool fueIngresada = false;
            bool fueEncontrada = false;

            //Si el tamaño del arreglo es mayor que cero
            //es porque previamente se han ingresado letras
            //y por lo tanto se puede comparar la letra actual
            if (arregloLetrasColocadas.Length > 0)
            {
                for (int i = 0; i < arregloLetrasColocadas.Length; i++)
                {
                    if (arregloLetrasColocadas[i].ToString() == laLetra)
                        fueIngresada = true;
                }
            }

            //Si la letra no ha sido ingresada, se pregunta si está en la
            //palabra buscada
            if (fueIngresada == false)
            {
                char[] arregloLetrasPalabraBuscada = palabraBuscada.ToCharArray();

                for (int i = 0; i < arregloLetrasPalabraBuscada.Length; i++)
                {
                    if (arregloLetrasPalabraBuscada[i].ToString() == laLetra)
                        fueEncontrada = true;
                }

                // Si no la encontró, incremente los fallos
                if (fueEncontrada == false)
                {
                    contadorFallos++;

                    //aqui invocamos la graficación de la victima
                    DibujaVictima();
                }
                else
                {
                    //si fue encontrada, entonces contamos cuantas veces
                    //está en la palabra
                    for (int i = 0; i < arregloLetrasPalabraBuscada.Length; i++)
                    {
                        if (arregloLetrasPalabraBuscada[i].ToString() == laLetra)
                            contadorAciertos++;
                    }
                }

                // Se agrega a las letras colocadas
                letrasColocadas += laLetra;

            }

            //después de la evaluación, devolvemos si la letra
            //fue encontrada o no
            return fueEncontrada;
        }

        /// <summary>
        /// Dibuja en el área gráfica los segmentos de la victima
        /// según la cantidad de fallos
        /// </summary>
        private void DibujaVictima()
        {
            Graphics areaGraficacion = Graphics.FromImage(imagenAhorcado);

            //aqui llenamos el area con el fondo blanco
            Rectangle areaRectangular = new Rectangle(0, 0,
                imagenAhorcado.Width, imagenAhorcado.Height);

            Brush pincel = new SolidBrush(Color.White);

            areaGraficacion.FillRectangle(pincel, areaRectangular);

            Pen lapiz = new Pen(Color.Black, 3);

            Rectangle cabeza = new Rectangle(115, 45, 50, 50);

            if (contadorFallos > 0)
                //aqui dibujamos la base de la horca
                areaGraficacion.DrawLine(lapiz, 60, 220, 180, 220);

            if (contadorFallos > 1)
                //aqui dibujamos la columna de la horca
                areaGraficacion.DrawLine(lapiz, 60, 25, 60, 220);

            if (contadorFallos > 2)
                //aqui dibujamos la viga de la horca
                areaGraficacion.DrawLine(lapiz, 140, 25, 60, 25);


            if (contadorFallos > 3)
                //aqui dibujamos la soga
                areaGraficacion.DrawLine(lapiz, 140, 45, 140, 25);

            if (contadorFallos > 4)
                //aqui dibujamos la cabeza
                areaGraficacion.DrawEllipse(lapiz, cabeza);

            if (contadorFallos > 5)
                //aqui dibujamos el torso
                areaGraficacion.DrawLine(lapiz, 140, 95, 140, 145);

            if (contadorFallos > 6)
                //aqui dibujamos la pierna izquierda
                areaGraficacion.DrawLine(lapiz, 140, 145, 130, 190);

            if (contadorFallos > 7)
                //aqui dibujamos la pierna derecha
                areaGraficacion.DrawLine(lapiz, 140, 145, 150, 190);

            if (contadorFallos > 8)
                //aqui dibujamos la brazo izquierdo
                areaGraficacion.DrawLine(lapiz, 140, 115, 120, 95);

            if (contadorFallos > 9)
                //aqui dibujamos el brazo derecha
                areaGraficacion.DrawLine(lapiz, 140, 115, 160, 95);
        }

        public bool FuimosDerrotados()
        {
            bool derrota = false;

            if (contadorFallos == 10)
                derrota = true;

            return derrota;
        }

        public bool FuimosVictoriosos()
        {
            bool victoria = false;

            if (contadorAciertos == 10)
                victoria = true;

            return victoria;
        }


    }
}
