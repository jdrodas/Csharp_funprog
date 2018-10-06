/*
Programa:       SimRadio
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Enunciado al problema:
----------------------

Realice un programa en C# con interfaz gráfica en Windows Forms que simule 
el comportamiento de un radio FM.

El programa permitirá cambiar la frecuencia de la emisora a través de dos botones
(F+,F-) que realizarán incrementos de la frecuencia de a 1 MHz. Las frecuencias están
en el rango comprendido entre 88.9 y 107.9 MHz. El valor predeterminado para la frecuencia
actual cuando comienza el programa será de 88.9 MHz. Si se incrementa el valor 
por encima del límite superior, el valor siguiente será el de la frecuencia del límite 
inferior. De manera equivalente, si se decrementa por debajo del límite inferior, el valor
siguiente será el del límite superior. Con F+ y F- se podrá dar ciclos completos dentro
del rango de frecuencias especificado.

El programa permitirá cambiar el valor del volumen a través de dos botones (V+,V-), los cuales
realizarán incrementos de 1 unidad en un rango de valores entre 0 y 10. Si se llega a los
límites inferiores o superiores, los valores no podrán superar o decrementar dichos límites.
El valor predeterminado del volumen será 0.

El programa tendrá un botón de encendido y apagado, el cual no permitirá que las funciones
se ejecuten en caso de que el radio esté apagado. Cuando el radio está apagado, los valores
para la frecuencia y el volumen no se ven y los botones no funcionan 
*/

using System;

namespace SimRadio
{
    class Radio
    {
        // los atributos de la clase
        private bool estado;
        private float frecuencia;
        private int volumen;

        //Constructor de la clase
        public Radio()
        {
            estado = false;
            frecuencia = 88.9f;
            volumen = 0;
        }

        //propiedades para los atributos
        public bool Estado
        {
            get { return estado; }
        }

        public int Volumen
        {
            get { return volumen; }
            set
            {
                //solo se asigna valor si está en el rango [0;10]
                if (value >= 0 && value <= 10)
                    volumen = value;
            }
        }

        public float Frecuencia
        {
            get { return frecuencia; }
            set
            {
                //solo se asigna valor si está en el rango [88.9;17.9]
                if (value >= 88.9f && value <= 107.9f)
                    frecuencia = value;
            }
        }

        //Metodos para el cambio controlado de los atributos
        //Aqui se implementan las reglas de los requerimiento

        /// <summary>
        /// Cambia el estado del radio. Pasa de encendido a apagado según
        /// sea el caso
        /// </summary>
        public void CambiaEstado()
        {
            if (estado == true)
                estado = false;
            else
                estado = true;
        }

        /// <summary>
        /// Incrementa en una unidad el volumen solo hasta el valor máximo de 10
        /// </summary>
        public void IncrementaVolumen()
        {
            //sube el volumen si el volumen es menor que 10
            if (volumen < 10)
                volumen++;
        }

        public void DecrementaVolumen()
        {
            //baja el volumen si el volumen es mayor que 0
            if (volumen > 0)
                volumen--;
        }

        public void IncrementaFrecuencia()
        {
            //si se incrementa por encima del límite superior
            //se devuelve al inferior. De lo contrario, incrementa en 1 MHz.
            if (frecuencia >= 107.9f)
                frecuencia = 88.9f;
            else
                frecuencia++;
        }

        public void DecrementaFrecuencia()
        {
            if (frecuencia <= 88.9f)
                frecuencia = 107.9f;
            else
                frecuencia--;
        }

    }
}
