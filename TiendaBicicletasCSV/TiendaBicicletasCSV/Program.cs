using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace TiendaBicicletasCSV
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para almacenar el inventario de Bicicletas en un archivo CSV");

            string[] tamaños = ["Gigante", "Grande", "Mediana", "Pequeña", "Infantil"];
            string[] marcas = ["GW", "BMX", "Shimano", "Har", "Trek"];
            string[] colores = ["Rosa", "Azul Eléctrico", "Blanco", "Negro", "Rojo Carmesí"];
            string[] tracciones = ["Eléctrica", "Mecánica", "Hibrida"];

            // Generar diccionario
            int totalBicicletas = 8;
            Random random = new Random();
            var listaBicicletas = new List<Bicicleta>();
            Bicicleta unaBicicleta;


            for (int consecutivo = 1; consecutivo <= totalBicicletas; consecutivo++)
            {
                unaBicicleta = new Bicicleta()
                {
                    Marca = marcas[random.Next(marcas.Length)],
                    Tamaño = marcas[random.Next(marcas.Length)],
                    Cambios = random.Next(2, 11),
                    Color = colores[random.Next(colores.Length)],
                    Traccion = tracciones[random.Next(tracciones.Length)]
                };
                listaBicicletas.Add(unaBicicleta);
            }

            VisualizarListaBicicletas(listaBicicletas);

            // Guardar archivo CSV
            GuardarArchivoCSV(listaBicicletas, "Inventario_bicicletas.csv");
        }

        static void VisualizarListaBicicletas(List<Bicicleta> lasBicicletas)
        {
            Console.WriteLine($"\nTotal entradas: {lasBicicletas.Count}. Contenido del inventario:\n");

            int consecutivo = 1;
            foreach (var unaBicicleta in lasBicicletas)
            {
                Console.WriteLine($"Código: {consecutivo}");
                Console.WriteLine($"Detalle: \n{unaBicicleta} \n");
                consecutivo++;
            }
        }

        static void GuardarArchivoCSV(List<Bicicleta> lasBicicletas, string archivoCSV)
        {
            var configuracion = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";"
            };

            var writer = new StreamWriter(archivoCSV);
            var csv = new CsvWriter(writer, configuracion);

            csv.WriteRecords(lasBicicletas);

            Console.WriteLine($"Archivos CSV guardado en {archivoCSV}");
        }
    }
}