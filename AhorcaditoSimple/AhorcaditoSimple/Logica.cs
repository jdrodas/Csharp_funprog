using System;

namespace AhorcaditoSimple
{
    class Logica
    {
        //Los atributos 
        private string[] diccionarioPalabras;

        //Propiedades para la clase
        public int TotalFallos { set; get; }
        public int TotalAciertos { set; get; }
        public string PalabraBuscada { set; get; }
        public string LetrasIngresadas { set; get; }

        //Constructor de la clase
        public Logica()
        {
            InicializaParametrosJuego();
        }

        public void InicializaParametrosJuego() 
        {
            TotalFallos = 0;
            TotalAciertos = 0;
            PalabraBuscada = "";
            LetrasIngresadas = "";

            //Inicializamos el Diccionario de palabras
            diccionarioPalabras = new string[] {
                "PALINDROMO",
                "COMBUSTION",
                "EMPANADITA",
                "ENERGUMENO",
                "BRASILEÑOS",
                "REVERENCIA",
                "ARQUITECTO",
                "VENGADORES",
                "FEMINISTAS",
                "AFGANISTAN",
                "EVALUACION",
                "PROLETARIO",
                "ICOSAEDROS",
                "CATASTROFE",
                "AHORCADITO",
                "MAMONCILLO",
                "JESUCRISTO",
                "CHONTADURO",
                "SERENDIPIA",
                "MURCIELAGO",
                "SACERDOTES",
                "ADIVINARAS",
                "SABANDIJAS",
                "PRIMAVERAL",
                "GIGANTESCO",
                "ARREPENTIR",
                "HABICHUELA",
                "ECLIPSABLE",
                "FABRICADOR",
                "YUGOSLAVIA",
                "COMUNISTAS",
                "GRABADORAS",
                "ABORIGENES",
                "FEUDALISMO",
                "SOVIETICOS"
            };
            
            Random aleatorio = new Random();
            PalabraBuscada = diccionarioPalabras[aleatorio.Next(diccionarioPalabras.Length)];

        }

        /// <summary>
        /// Evalua la situacion de la letra ingresada por el usuario
        /// </summary>
        /// <param name="laLetra">Letra ingresada</param>
        public void EvaluaLetra(string laLetra)
        {
            //Primero validamos si ya fue previamente ingresada
            bool yaFueIngresada = EvaluaIngresoPrevioLetra(laLetra);

            if (yaFueIngresada == false)
            {
                LetrasIngresadas += laLetra;

                //Validamos si la letra está en la palabra
                int estaEnPalabraBuscada = EvaluaLetraEnPalabraBuscada(laLetra);

                if (estaEnPalabraBuscada > 0)
                    TotalAciertos += estaEnPalabraBuscada;
                else
                    TotalFallos++;
            }
        }

        /// <summary>
        /// Verifica si la letra fue previamente ingresada en el juego
        /// </summary>
        /// <param name="unaLetra">LetraIngresada</param>
        /// <returns></returns>
        private bool EvaluaIngresoPrevioLetra(string unaLetra)
        {
            bool resultado = false;

            // Validamos si es la primera letra del juego
            if (LetrasIngresadas.Length > 0)
            {
                char[] arregloLetras = LetrasIngresadas.ToCharArray();

                for (int i = 0; i < arregloLetras.Length; i++)
                    if (arregloLetras[i].ToString() == unaLetra)
                        resultado = true;
            }

            return resultado;
        }

        /// <summary>
        /// Evalua si la letra está en la palabra buscada
        /// </summary>
        /// <param name="unaLetra"></param>
        /// <returns></returns>
        private int EvaluaLetraEnPalabraBuscada(string unaLetra)
        {
            int resultado = 0;

            char[] arregloLetras = PalabraBuscada.ToCharArray();

            for (int i = 0; i < arregloLetras.Length; i++)
                if (arregloLetras[i].ToString() == unaLetra)
                    resultado++;

            return resultado;
        }
    }
}
