namespace EjemploObjetos
{
    public class Persona
    {
        //Atributos
        private string? nombre;
        private int edad;
        private long telefono;
        private float estatura;

        //Constructor
        public Persona()
        {
            nombre = string.Empty;
            edad = 0;
            telefono = 0;
            estatura = 0;
        }

        //Metodos
        public string GetNombre()
        {
            return nombre!;
        }

        public void SetNombre(string valor)
        {
            nombre = valor;
        }

        public int GetEdad()
        {
            return edad;
        }

        public void SetEdad(int valor)
        {
            edad = valor;
        }

        public long GetTelefono()
        {
            return telefono;
        }

        public void SetTelefono(long valor)
        {
            telefono = valor;
        }

        public float GetEstatura()
        {
            return estatura;
        }

        public void SetEstatura(float valor)
        {
            estatura = valor;
        }

        //Propiedades
        public string Nombre
        {
            get { return nombre!; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public long Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public float Estatura
        {
            get { return estatura; }
            set { estatura = value; }
        }
    }
}