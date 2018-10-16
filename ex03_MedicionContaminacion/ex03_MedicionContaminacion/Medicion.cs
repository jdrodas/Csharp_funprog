using System;

namespace ex03_MedicionContaminacion
{
    class Medicion
    {
        // Los atributos de la clase
        private int valorCO2, valorNO, valorCH4, valorSO2;
        private float[] porcentajes;
        private string mayorContaminante;

        //El constructor de la clase
        public Medicion()
        {
            valorCH4 = 0;
            valorCO2 = 0;
            valorNO = 0;
            valorSO2 = 0;

            mayorContaminante = "";

            porcentajes = new float[4];
        }

        //las propiedades para los atributos que serán accedidos externamente
        public int ValorCH4
        {
            set { valorCH4 = value; }
        }

        public int ValorCO2
        {
            set { valorCO2 = value; }
        }

        public int ValorNO
        {
            set { valorNO = value; }
        }

        public int ValorSO2
        {
            set { valorSO2 = value; }
        }

        public string MayorContaminante
        {
            get { return mayorContaminante; }
        }

        /// <summary>
        /// Calcula los porcentajes a partir de los valores ingresados
        /// </summary>
        public void CalculaPorcentajes()
        {
            //se valida primero que todos los valores para los agentes han sido ingresados
            if (valorCH4 != 0 && valorCO2 != 0 && valorNO != 0 && valorSO2 != 0)
            {
                //Calculamos el total
                int totalContaminantes = valorCH4 + valorCO2 + valorNO + valorSO2;

                //Calculamos los porcentajes y los incluimos en el arreglo
                porcentajes[0] = (float)valorCH4 / totalContaminantes;
                porcentajes[1] = (float)valorCO2 / totalContaminantes;
                porcentajes[2] = (float)valorNO / totalContaminantes;
                porcentajes[3] = (float)valorSO2 / totalContaminantes;

                //Hallamos el mayor Contaminante
                EncuentraMayorContaminante();
            }
        }

        /// <summary>
        /// Encuentra el mayor contaminante a partir de los porcentajes calculados
        /// </summary>
        private void EncuentraMayorContaminante()
        {
            /*
             Posiciones en el arreglo:
             0: CH4
             1: CO2
             2: NO
             3: SO2
             */

            //Validamos si es CH4
            if (porcentajes[0] > porcentajes[1] && porcentajes[0] > porcentajes[2] && porcentajes[0] > porcentajes[3])
                mayorContaminante = "CH4";


            //Validamos si es CO2
            if (porcentajes[1] > porcentajes[0] && porcentajes[1] > porcentajes[2] && porcentajes[1] > porcentajes[3])
                mayorContaminante = "CO2";


            //Validamos si es NO
            if (porcentajes[2] > porcentajes[1] && porcentajes[2] > porcentajes[0] && porcentajes[2] > porcentajes[3])
                mayorContaminante = "NO";

            //Validamos si es SO2
            if (porcentajes[3] > porcentajes[1] && porcentajes[3] > porcentajes[0] && porcentajes[3] > porcentajes[2])
                mayorContaminante = "SO2";

            //Si al menos un par de valores son iguales y son el mayor valor, 
            //el mayorContaminante es "varios"

            //ordenamos el arreglo
            Array.Sort(porcentajes);

            //y comparamos los dos últimos valores... sin son iguales..
            if(porcentajes[2]==porcentajes[3])
                mayorContaminante = "Varios";
        }
    }
}
