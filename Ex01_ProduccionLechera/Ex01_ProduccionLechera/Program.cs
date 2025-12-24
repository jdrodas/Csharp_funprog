namespace Ex01_ProduccionLechera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para identificar producción lechera optima\n");

            //Variables que vamos a utilizar
            bool datosCorrectos = false;
            float litrosVaca = 0, litrosCabra = 0, litrosBufala = 0;

            do
            {
                try
                {
                    Console.Write("Ingresa la producción de leche de vaca: ");
                    litrosVaca = float.Parse(Console.ReadLine()!);

                    Console.Write("Ingresa la producción de leche de cabra: ");
                    litrosCabra = float.Parse(Console.ReadLine()!);

                    Console.Write("Ingresa la producción de leche de bufala: ");
                    litrosBufala = float.Parse(Console.ReadLine()!);

                    //Validamos que TODOS los datos sean positivos
                    if (litrosVaca >= 0 && litrosCabra >= 0 && litrosBufala >= 0)
                    {
                        datosCorrectos = true; //Sentencia de salida del ciclo Do - While
                    }
                    else
                    {
                        Console.WriteLine("Los datos deben ser mayores o iguales a cero. Intenta nuevamente.\n\n");
                    }

                }
                catch (FormatException elError)
                {
                    Console.WriteLine("Los datos deben ser numéricos. Intenta nuevamente.");
                    Console.WriteLine($"Error: {elError.Message} \n\n");
                }
            }
            while (datosCorrectos == false);

            //Calculamos porcentajes
            float produccionTotal = litrosBufala + litrosCabra + litrosVaca;

            float porcentajeVaca = (litrosVaca / produccionTotal) * 100;
            float porcentajeCabra = (litrosCabra / produccionTotal) * 100;
            float porcentajeBufala = (litrosBufala / produccionTotal) * 100;

            //Visualizamos resultados:
            Console.WriteLine($"\nProducción Total: {produccionTotal} lts.");
            Console.WriteLine($"Producción Vaca: {litrosVaca} lts que equivale al {porcentajeVaca}%.");
            Console.WriteLine($"El rango esperado está entre 40% y 45%\n");
            Console.WriteLine($"\nProducción Cabra: {litrosCabra} lts que equivale al {porcentajeCabra}%.");
            Console.WriteLine($"El rango esperado está entre 18% y 25%\n");
            Console.WriteLine($"\nProducción Bufala: {litrosBufala} lts que equivale al {porcentajeBufala}%.");
            Console.WriteLine($"El rango esperado está entre 30% y 40%\n");

            //Aqui validamos si los porcentajes están en los rangos esperados
            if (porcentajeVaca >= 40 && porcentajeVaca <= 45 &&
                porcentajeCabra >= 18 && porcentajeCabra <= 25 &&
                porcentajeBufala >= 30 && porcentajeBufala <= 40)
            {
                //Preguntamos si la producción supera el mínimo
                if (produccionTotal >= 100)
                {
                    Console.WriteLine("La Producción supera el mínimo de 100 litros.");
                    Console.WriteLine("Se obtuvo la producción optima.");
                }
                else
                {
                    Console.WriteLine("A pesar de cumplir los rangos, no supera el mínimo de 100 litros.");
                }
            }
            else
            {
                Console.WriteLine("Los porcentajes no cumplen los rangos establecidos.");
            }
        }
    }
}