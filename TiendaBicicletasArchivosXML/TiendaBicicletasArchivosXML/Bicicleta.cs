using System.Xml.Serialization;

namespace TiendaBicicletasArchivosXML
{
    /// <summary>
    /// Representa una bicicleta en el inventario de la tienda
    /// </summary>
    public class Bicicleta
    {
        [XmlElement("Codigo")]
        public int Codigo { get; set; }

        [XmlElement("Marca")]
        public string? Marca { get; set; }

        [XmlElement("Tamaño")]
        public string? Tamaño { get; set; }

        [XmlElement("Cambios")]
        public int Cambios { get; set; }

        [XmlElement("Color")]
        public string? Color { get; set; }

        [XmlElement("Traccion")]
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