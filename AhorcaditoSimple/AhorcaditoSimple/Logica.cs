using System;

namespace AhorcaditoSimple
{
    class Logica
    {

        //atributos necesarios para el programa
        private string[] diccionarioPalabras;
        private int totalFallos, totalAciertos;
        private string palabraBuscada, letrasColocadas;

        //Propiedades para la clase
        public string TotalFallos 
        { 
            get
            { 
                return totalFallos.ToString(); 
            }
        }
        public string TotalAciertos
        {
            get
            {
                return totalAciertos.ToString();
            }
        }
        public string PalabraBuscada
        {
            get
            {
                return palabraBuscada;
            }
        }
        public string LetrasColocadas
        {
            get
            {
                return letrasColocadas;
            }
        }



        public Logica()
        {
            InicializaParametrosJuego();
        }

        public void InicializaParametrosJuego() 
        {
            totalAciertos = 0;
            totalFallos = 0;
            palabraBuscada = "";
            letrasColocadas = "";

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
                "ECLIPSABLE"
            };

            Random aleatorio = new Random();
            palabraBuscada = diccionarioPalabras[aleatorio.Next(diccionarioPalabras.Length)];

        }

        public void EvaluaLetra(string laLetra)
        {
            //Primero validamos si ya fue previamente ingresada
            bool yaFueIngresada = EvaluaIngresoPrevioLetra(laLetra);

            if (yaFueIngresada == false)
            {
                letrasColocadas += laLetra;

                //Validamos si la letra está en la palabra
                bool estaEnPalabraBuscada = EvaluaLetraEnPalabraBuscada(laLetra);

                if (estaEnPalabraBuscada)
                    totalAciertos++;
                else
                    totalFallos++;
            }

        }

        private bool EvaluaIngresoPrevioLetra(string letraIngresada)
        {
            bool resultado = false;

            if (LetrasColocadas.Length > 0)
            {
                char[] lasLetrasIngresadas = LetrasColocadas.ToCharArray();

                for (int i = 0; i < lasLetrasIngresadas.Length; i++)
                    if (lasLetrasIngresadas[i].ToString() == letraIngresada)
                        resultado = true;
            }

            return resultado;
        }

        private bool EvaluaLetraEnPalabraBuscada(string letraIngresada)
        {
            bool resultado = false;

            char[] letrasPalabraBuscada = PalabraBuscada.ToCharArray();

            for (int i = 0; i < letrasPalabraBuscada.Length; i++)
                if (letrasPalabraBuscada[i].ToString() == letraIngresada)
                    resultado = true;

            return resultado;
        }
    }
}
