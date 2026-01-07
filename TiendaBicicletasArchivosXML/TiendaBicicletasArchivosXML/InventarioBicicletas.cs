using System.Xml.Serialization;

namespace TiendaBicicletasArchivosXML
{
    [XmlRoot("Bicicletas")]
    public class InventarioBicicletas
    {
        [XmlElement("Bicicleta")]
        public List<Bicicleta> Lista { get; set; }

        public InventarioBicicletas()
        {
            Lista = new List<Bicicleta>();
        }

        public InventarioBicicletas(List<Bicicleta> bicicletas)
        {
            Lista = bicicletas ?? new List<Bicicleta>();
        }
    }
}
