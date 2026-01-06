using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace TiendaBicicletasCSV
{
    /// <summary>
    /// Servicio para manejar operaciones de lectura y escritura de archivos CSV
    /// </summary>
    public class GestorArchivoCSV
    {
        private readonly CsvConfiguration _configuracion;

        public GestorArchivoCSV()
        {
            _configuracion = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";"
            };
        }

        /// <summary>
        /// Guarda una lista de bicicletas en un archivo CSV
        /// </summary>
        /// <param name="bicicletas">Lista de bicicletas a guardar</param>
        /// <param name="rutaArchivo">Ruta del archivo CSV</param>
        /// <exception cref="IOException">Si hay un error al escribir el archivo</exception>
        public void GuardarBicicletas(List<Bicicleta> bicicletas, string rutaArchivo)
        {
            try
            {
                using var writer = new StreamWriter(rutaArchivo);
                using var csv = new CsvWriter(writer, _configuracion);

                csv.WriteRecords(bicicletas);

                Console.WriteLine($"Archivo CSV guardado exitosamente en: {rutaArchivo}");
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
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado al guardar el archivo: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Carga una lista de bicicletas desde un archivo CSV
        /// </summary>
        /// <param name="rutaArchivo">Ruta del archivo CSV</param>
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

                using var reader = new StreamReader(rutaArchivo);
                using var csv = new CsvReader(reader, _configuracion);

                var bicicletas = csv.GetRecords<Bicicleta>().ToList();

                Console.WriteLine($"Archivo CSV cargado exitosamente: {bicicletas.Count} registros");
                return bicicletas;
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error de I/O al cargar el archivo: {ex.Message}");
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
