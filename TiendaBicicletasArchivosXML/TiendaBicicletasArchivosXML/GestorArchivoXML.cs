using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace TiendaBicicletasArchivosXML
{
    public class GestorArchivoXML
    {
        private readonly XmlSerializer _serializador;

        public GestorArchivoXML()
        {            
            _serializador = new XmlSerializer(typeof(List<Bicicleta>));
        }

        /// <summary>
        /// Guarda una lista de bicicletas en un archivo XML
        /// </summary>
        /// <param name="bicicletas">Lista de bicicletas a guardar</param>
        /// <param name="rutaArchivo">Ruta del archivo XML</param>
        /// <exception cref="IOException">Si hay un error al escribir el archivo</exception>
        public void GuardarBicicletas(List<Bicicleta> bicicletas, string rutaArchivo)
        {
            try
            {
                var configuracionFormatoXML = new System.Xml.XmlWriterSettings
                {
                    Indent = true,
                    IndentChars = "  ",
                    NewLineOnAttributes = false
                };

                using var fileStream = new FileStream(rutaArchivo, FileMode.Create);
                using var xmlWriter = System.Xml.XmlWriter.Create(fileStream, configuracionFormatoXML);

                _serializador.Serialize(xmlWriter, bicicletas);
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
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error de serialización XML: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado al guardar el archivo: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Carga una lista de bicicletas desde un archivo XML
        /// </summary>
        /// <param name="rutaArchivo">Ruta del archivo XML</param>
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

                List<Bicicleta>? bicicletas = _serializador.Deserialize(reader) as List<Bicicleta>;

                if (bicicletas == null)
                {
                    Console.WriteLine($"Error: No se pudo deserializar el archivo XML");
                    return new List<Bicicleta>();
                }

                Console.WriteLine($"Archivo XML cargado exitosamente: {bicicletas.Count} registros");
                return bicicletas;
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error de I/O al cargar el archivo: {ex.Message}");
                throw;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error de deserialización XML: {ex.Message}");
                Console.WriteLine($"El archivo puede estar corrupto o tener un formato incorrecto");
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
