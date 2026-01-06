namespace TiendaBicicletasCSV
{
    public class GeneradorInventario
    {
        private readonly Random _aleatorio;
        private readonly string[] _tamaños = { "Gigante", "Grande", "Mediana", "Pequeña", "Infantil" };
        private readonly string[] _marcas = { "GW", "BMX", "Shimano", "Har", "Trek" };
        private readonly string[] _colores = { "Rosa", "Azul Eléctrico", "Blanco", "Negro", "Rojo Carmesí" };
        private readonly string[] _tracciones = { "Eléctrica", "Mecánica", "Híbrida" };

        public GeneradorInventario()
        {
            _aleatorio = new Random();
        }

        /// <summary>
        /// Genera una lista de bicicletas aleatorias
        /// </summary>
        /// <param name="cantidad">Número de bicicletas a generar</param>
        /// <returns>Lista de bicicletas generadas</returns>
        public List<Bicicleta> AbastecerInventario(int cantidad)
        {
            if (cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor a cero", nameof(cantidad));

            var bicicletas = new List<Bicicleta>();

            for (int i = 0; i < cantidad; i++)
            {
                var bicicleta = new Bicicleta
                {
                    Codigo = i+1,
                    Marca = _marcas[_aleatorio.Next(_marcas.Length)],
                    Tamaño = _tamaños[_aleatorio.Next(_tamaños.Length)],
                    Cambios = _aleatorio.Next(2, 11),
                    Color = _colores[_aleatorio.Next(_colores.Length)],
                    Traccion = _tracciones[_aleatorio.Next(_tracciones.Length)]
                };

                bicicletas.Add(bicicleta);
            }

            return bicicletas;
        }
    }
}
