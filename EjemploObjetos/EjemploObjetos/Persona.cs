using System;

namespace EjemploObjetos
{
    class Persona
    {
        //zona de atributos
        private int edad, telefono;
        private string nombre;

        //Constructor de la clase
        public Persona()
        {
            edad = 0;
            telefono = 0;
            nombre = "";
        }

        //zona de los métodos

        /// <summary>
        /// Asigna el valor del atributo nombre
        /// </summary>
        /// <param name="datoNombre">dato para el atributo</param>
        public void SetNombre(string datoNombre)
        {
            nombre = datoNombre;
        }

        /// <summary>
        /// Obtiene el valor del atributo nombre
        /// </summary>
        /// <returns>el valor del atributo</returns>
        public string GetNombre()
        {
            return nombre;
        }

        /// <summary>
        /// Asigna el valor para el atributo edad
        /// </summary>
        /// <param name="datoEdad">valor a establecer para el atributo</param>
        public void SetEdad(int datoEdad)
        {
            edad = datoEdad;
        }


        /// <summary>
        /// Obtiene el valor del atributo edad
        /// </summary>
        /// <returns>Valor del atributo</returns>
        public int GetEdad()
        {
            return edad;
        }

        /// <summary>
        /// Asigna el valor para el atributo telefono
        /// </summary>
        /// <param name="datoTelefono">valor a establecer para el atributo</param>
        public void SetTelefono(int datoTelefono)
        {
            telefono = datoTelefono;
        }

        /// <summary>
        /// Obtiene el valor del atributo telefono
        /// </summary>
        /// <returns>Valor del atributo</returns>
        public int GetTelefono()
        {
            return telefono;
        }

        //propiedades para los atributos

        /// <summary>
        /// Obtiene o establece el valor de la edad
        /// </summary>
        public int Edad
        {
            set { edad = value; }
            get { return edad; }
        }


        /// <summary>
        /// Obtiene o establece el valor del atributo telefono
        /// </summary>
        public int Telefono
        {
            set { telefono = value; }
            get { return telefono; }
        }

        /// <summary>
        /// Obtiene o establece el valor del atributo nombre
        /// </summary>
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
    }
}
