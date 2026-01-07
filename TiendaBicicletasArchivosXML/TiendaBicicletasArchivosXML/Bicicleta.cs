using System.Xml.Serialization;

namespace TiendaBicicletasArchivosXML
{
    /// <summary>
    /// Representa una bicicleta en el inventario de la tienda
    /// </summary>
    public class Bicicleta : IEquatable<Bicicleta>
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

        public bool Equals(Bicicleta? otraBicicleta)
        {
            if (otraBicicleta is null) return false;
            if (ReferenceEquals(this, otraBicicleta)) return true;

            return Codigo == otraBicicleta.Codigo &&
                Marca == otraBicicleta.Marca &&
                Tamaño == otraBicicleta.Tamaño &&
                Cambios == otraBicicleta.Cambios &&
                Color == otraBicicleta.Color &&
                Traccion == otraBicicleta.Traccion;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Bicicleta);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(
                Codigo,
                Marca,
                Tamaño,
                Cambios,
                Color,
                Traccion);
        }
        public static bool operator ==(Bicicleta? izquierda, Bicicleta? derecha)
        {
            if (izquierda is null)
                return derecha is null;

            return izquierda.Equals(derecha);
        }

        public static bool operator !=(Bicicleta? izquierda, Bicicleta? derecha)
        {
            return !(izquierda == derecha);
        }

        public Bicicleta Clonar()
        {
            return new Bicicleta
            {
                Codigo = this.Codigo,
                Marca = this.Marca,
                Tamaño = this.Tamaño,
                Cambios = this.Cambios,
                Color = this.Color,
                Traccion = this.Traccion
            };
        }
    }
}