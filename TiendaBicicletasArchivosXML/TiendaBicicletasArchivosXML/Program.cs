namespace TiendaBicicletasArchivosXML
{
    public class Program
    {
        static void Main(string[] args)
        {
            const int totalBicicletas = 8;
            const string nombreArchivo = "Inventario_bicicletas.xml";

            Console.WriteLine("=== Sistema de Inventario de Bicicletas (XML) ===\n");

            try
            {
                var generador = new GeneradorInventario();
                var bicicletas = generador.AbastecerInventario(totalBicicletas);

                MostrarInventario(bicicletas);

                var servicioGestionXML = new GestorArchivoXML();
                servicioGestionXML.GuardarBicicletas(bicicletas, nombreArchivo);

                Console.WriteLine("\n--- Verificando que el archivo se puede leer inmediatamente ---");
                var bicicletasCargadas = servicioGestionXML.CargarBicicletas(nombreArchivo);
                Console.WriteLine($"Se cargaron {bicicletasCargadas.Count} bicicletas del archivo XML.");

                Console.WriteLine("\n--- Contenido cargado desde XML ---");
                MostrarInventario(bicicletasCargadas);

                Console.WriteLine("\nComparando las bicicletas iniciales y leídas del archivo...");
                ComparaListaBicicletas(bicicletas, bicicletasCargadas);

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
        /// Compara dos colecciones de bicicletas para identificar si son iguales
        /// </summary>
        /// <param name="bicicletas"></param>
        /// <param name="bicicletasCargadas"></param>
        static void ComparaListaBicicletas(List<Bicicleta> bicicletas, List<Bicicleta> bicicletasCargadas)
        {
            if (bicicletas.Count != bicicletasCargadas.Count)
            {
                Console.WriteLine($"Las listas tienen diferente cantidad de elementos. Original: {bicicletas.Count}, Cargada: {bicicletasCargadas.Count}");
                return;
            }

            int totalDiferencias = 0;
            for (int i = 0; i < bicicletas.Count; i++)
                if (bicicletas[i] != bicicletasCargadas[i])
                    totalDiferencias++;

            if (totalDiferencias != 0)
            {
                Console.WriteLine($"Las listas tienen {totalDiferencias} elementos diferentes");
                return;
            }

            Console.WriteLine($"Las listas tienen la misma cantidad de elementos en el mismo orden.");
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