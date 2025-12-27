namespace ConcursoSushi
{
    internal class PedidoRollo
    {
        //Atributos
        private int restaurante;
        private string proteina;
        private string acabado;
        private string salsa;
        private string topping;

        //Constructor
        public PedidoRollo()
        {
            restaurante = 0;
            proteina = "";
            acabado = "";
            salsa = "";
            topping = "";
        }

        //Propiedades
        public string Proteina
        {
            get { return proteina; }
            set { proteina = value; }
        }
        public string Acabado
        {
            get { return acabado; }
            set { acabado = value; }
        }

        public int Restaurante
        {
            get { return restaurante; }
            set { restaurante = value; }
        }

        public string Salsa
        {
            get { return salsa; }
            set { salsa = value; }
        }
        public string Topping
        {
            get { return topping; }
            set { topping = value; }
        }

        //Metodos
        public string ObtieneInformacion()
        {
            string informacion = $"Este pedido se hizo al restaurante {restaurante}\n " +
                $"un rollo de proteina {proteina} en acabado {acabado}\n" +
                $"con salsa de {salsa} y topping de {topping}";

            return informacion;
        }
    }
}