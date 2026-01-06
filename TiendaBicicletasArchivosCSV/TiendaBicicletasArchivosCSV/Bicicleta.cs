namespace TiendaBicicletasArchivosCSV
{
    /// <summary>
    /// Representa una bicicleta en el inventario de la tienda
    /// </summary>
    public class Bicicleta
    {
        public int Codigo { get; set; }
        public string? Marca { get; set; }
        public string? Tamaño { get; set; }
        public int Cambios { get; set; }
        public string? Color { get; set; }
        public string? Traccion { get; set; }

        public override string ToString()
        {
            return $"Código: {Codigo}\n" +
                $"\tMarca: {Marca}\n" +
                $"\tTamaño: {Tamaño}\n" +
                $"\tCambios: {Cambios}\n" +
                $"\tColor: {Color}\n" +
                $"\tTracción: {Traccion}";
        }
    }
}
