namespace TiendaBicicletasCSV
{
    public class Program
    {
        static void Main(string[] args)
        {
            const int totalBicicletas = 8;
            const string nombreArchivo = "Inventario_bicicletas.csv";

            Console.WriteLine("=== Sistema de Inventario de Bicicletas ===\n");

            try
            {
                var generador = new GeneradorInventario();
                var bicicletas = generador.AbastecerInventario(totalBicicletas);

                MostrarInventario(bicicletas);

                var servicioGestionCSV = new GestorArchivoCSV();
                servicioGestionCSV.GuardarBicicletas(bicicletas, nombreArchivo);

                
                Console.WriteLine("\n--- Verificando que el archivo se puede leer inmediatamente ---");
                var bicicletasCargadas = servicioGestionCSV.CargarBicicletas(nombreArchivo);
                Console.WriteLine($"Se cargaron {bicicletasCargadas.Count} bicicletas del archivo.");

                MostrarInventario(bicicletasCargadas);

                Console.WriteLine("\nProceso completado exitosamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError crítico en la aplicación: {ex.Message}");
                Console.WriteLine($"Detalles: {ex.StackTrace}");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        /// <summary>
        /// Muestra el inventario de bicicletas en la consola
        /// </summary>
        /// <param name="bicicletas">Lista de bicicletas a mostrar</param>
        static void MostrarInventario(List<Bicicleta> bicicletas)
        {
            if (bicicletas == null || bicicletas.Count == 0)
            {
                Console.WriteLine("El inventario está vacío.");
                return;
            }

            Console.WriteLine($"Total de entradas: {bicicletas.Count}\n");
            Console.WriteLine("Contenido del inventario:\n");

            foreach (Bicicleta bicicleta in bicicletas)
                Console.WriteLine($"{bicicleta}");            
        }
    }
}
