using YamlDotNet.Core;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace TiendaBicicletasArchivosYAML
{
    public class GestorArchivoYAML
    {
        private readonly ISerializer _serializador;
        private readonly IDeserializer _deserializador;

        public GestorArchivoYAML()
        {
            _serializador = new SerializerBuilder()
                .WithNamingConvention(PascalCaseNamingConvention.Instance)
                .Build();

            _deserializador = new DeserializerBuilder()
                .WithNamingConvention(PascalCaseNamingConvention.Instance)
                .IgnoreUnmatchedProperties()
                .Build();
        }

        /// <summary>
        /// Guarda una lista de bicicletas en un archivo YAML
        /// </summary>
        /// <param name="bicicletas">Lista de bicicletas a guardar</param>
        /// <param name="rutaArchivo">Ruta del archivo YAML</param>
        /// <exception cref="IOException">Si hay un error al escribir el archivo</exception>
        public void GuardarBicicletas(List<Bicicleta> bicicletas, string rutaArchivo)
        {
            try
            {
                string yamlContent = _serializador.Serialize(bicicletas);
                File.WriteAllText(rutaArchivo, yamlContent);

                Console.WriteLine($"Archivo YAML guardado exitosamente en: {rutaArchivo}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error de I/O al guardar el archivo: {ex.Message}");
                throw;
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Error de permisos al guardar el archivo: {ex.Message}");
                throw;
            }
            catch (YamlException ex)
            {
                Console.WriteLine($"Error de serialización YAML: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado al guardar el archivo: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Carga una lista de bicicletas desde un archivo YAML
        /// </summary>
        /// <param name="rutaArchivo">Ruta del archivo YAML</param>
        /// <returns>Lista de bicicletas leídas del archivo</returns>
        public List<Bicicleta> CargarBicicletas(string rutaArchivo)
        {
            try
            {
                if (!File.Exists(rutaArchivo))
                {
                    Console.WriteLine($"El archivo no existe: {rutaArchivo}");
                    return new List<Bicicleta>();
                }

                string yamlContent = File.ReadAllText(rutaArchivo);

                var bicicletas = _deserializador.Deserialize<List<Bicicleta>>(yamlContent);

                if (bicicletas == null)
                {
                    Console.WriteLine($"Error: No se pudo deserializar el archivo YAML");
                    return new List<Bicicleta>();
                }

                Console.WriteLine($"Archivo YAML cargado exitosamente: {bicicletas.Count} registros");
                return bicicletas;
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error de I/O al cargar el archivo: {ex.Message}");
                throw;
            }
            catch (YamlDotNet.Core.YamlException ex)
            {
                Console.WriteLine($"Error de deserialización YAML: {ex.Message}");
                Console.WriteLine($"   El archivo puede estar corrupto o tener un formato YAML inválido");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado al cargar el archivo: {ex.Message}");
                throw;
            }
        }
    }
}
