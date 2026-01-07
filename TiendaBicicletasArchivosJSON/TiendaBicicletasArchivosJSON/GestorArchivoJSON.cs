using System.Text.Json;
using System.Text.Json.Serialization;

namespace TiendaBicicletasArchivosJSON
{
    public class GestorArchivoJSON
    {
        private readonly JsonSerializerOptions _opciones;

        public GestorArchivoJSON()
        {
            _opciones = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = null,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                DefaultIgnoreCondition = JsonIgnoreCondition.Never
            };
        }

        /// <summary>
        /// Guarda una lista de bicicletas en un archivo JSON
        /// </summary>
        /// <param name="bicicletas">Lista de bicicletas a guardar</param>
        /// <param name="rutaArchivo">Ruta del archivo JSON</param>
        /// <exception cref="IOException">Si hay un error al escribir el archivo</exception>
        public void GuardarBicicletas(List<Bicicleta> bicicletas, string rutaArchivo)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(bicicletas, _opciones);
                File.WriteAllText(rutaArchivo, jsonString);

                Console.WriteLine($"Archivo JSON guardado exitosamente en: {rutaArchivo}");
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
            catch (JsonException ex)
            {
                Console.WriteLine($"Error de serialización JSON: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado al guardar el archivo: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Carga una lista de bicicletas desde un archivo JSON
        /// </summary>
        /// <param name="rutaArchivo">Ruta del archivo JSON</param>
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

                string jsonString = File.ReadAllText(rutaArchivo);

                var bicicletas = JsonSerializer.Deserialize<List<Bicicleta>>(jsonString, _opciones);

                if (bicicletas == null)
                {
                    Console.WriteLine($"Error: No se pudo deserializar el archivo JSON");
                    return new List<Bicicleta>();
                }

                Console.WriteLine($"Archivo JSON cargado exitosamente: {bicicletas.Count} registros");
                return bicicletas;
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error de I/O al cargar el archivo: {ex.Message}");
                throw;
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Error de deserialización JSON: {ex.Message}");
                Console.WriteLine($"   El archivo puede estar corrupto o tener un formato JSON inválido");
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
