/*
Programa:       ex03_BurgerMaster
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com


Formulación: 
------------

Burger Master – Totalización de Pedidos

Se aproxima la nueva versión del Burger Master, el evento que revoluciona la selección de las mejores hamburguesas 
disponibles en la ciudad. El organizador del evento debe prepararse para recolectar la opinión de los visitantes 
para identificar cuales fueron los ganadores en esta ocasión.

Para esta oportunidad, se tendrán 15 locales participantes los cuales deberán permitir que los visitantes construyan 
su pedido de la siguiente forma:
•	5 posibles hamburguesas.
•	3 posibles bebidas.
•	2 posibles postres.

Buscando la mejor manera de consolidar los resultados, el organizador del evento te solicita crear una aplicación de 
consola que le permita simular las posibles combinaciones que pueden hacer parte del pedido e identificar indicadores
importantes del evento.

Al comienzo de la ejecución de la aplicación, se preguntará por los 5 tipos de hamburguesas, los 3 tipos de bebidas y 
los 2 tipos de postres.

Has decidido hacer la aplicación usando objetos y has definido el objeto “Pedido” con los siguientes atributos:

•	codigoLocal: numérico entero
•	tipoHamburguesa: cadena de caracteres
•	tipoBebida: cadena de caracteres
•	tipoPostre: cadena de caracteres.

Has decidido hacer un arreglo de 10.000 pedidos donde aleatoriamente a cada posición del arreglo se le asignará los valores 
según las especificaciones previas.

La aplicación al final solamente visualizará:

•	El local que más pedidos vendió, indicando cuantos fueron los pedidos
•	El tipo de hamburguesa que más se vendió, indicando cuantos fueron los pedidos.
•	El tipo de bebida que más se vendió, indicando cuantos fueron los pedidos.
•	El tipo de postre que más se vendió, indicando cuantos fueron los pedidos.

*/


using System;


namespace ex03_BurgerMaster
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Burger Master - Totalización de pedidos\n\n");
            Console.WriteLine("Se simularán 10.000 pedidos de 15 locales distintos, 5 tipos de hamburguesa");
            Console.WriteLine("3 tipos de bebida y 2 tipos de postre");

            string[] lasHamburguesas = new string[5];
            string[] lasBebidas = new string[3];
            string[] losPostres = new string[2];
            int cantidadLocales = 15; //Locales participantes en la competencia

            Console.WriteLine("\nDefinición de tipos de Hamburguesa");
            for (int i = 0; i < lasHamburguesas.Length; i++)
            {
                Console.Write("Ingresa el nombre de la Hamburguesa # {0}: ", i + 1);
                lasHamburguesas[i] = Console.ReadLine();
            }

            Console.WriteLine("\nDefinición de tipos de Bebidas");
            for (int i = 0; i < lasBebidas.Length; i++)
            {
                Console.Write("Ingresa el nombre de la bebida # {0}: ", i + 1);
                lasBebidas[i] = Console.ReadLine();
            }

            Console.WriteLine("\nDefinición de tipos de Postre");
            for (int i = 0; i < losPostres.Length; i++)
            {
                Console.Write("Ingresa el nombre del postre # {0}: ", i + 1);
                losPostres[i] = Console.ReadLine();
            }

            Console.WriteLine("\n\nSe simularán 10.000 pedidos con las siguientes combinaciones:");

            Console.WriteLine("Hamburguesas:");
            for (int i = 0; i < lasHamburguesas.Length; i++)
                Console.WriteLine("\t" + lasHamburguesas[i]);

            Console.WriteLine("Bebidas:");
            for (int i = 0; i < lasBebidas.Length; i++)
                Console.WriteLine("\t" + lasBebidas[i]);

            Console.WriteLine("Postres:");
            for (int i = 0; i < losPostres.Length; i++)
                Console.WriteLine("\t" + losPostres[i]);

            //Se define aqui el arreglo de pedidos
            Pedido[] losPedidos = new Pedido[10000];

            Random aleatorio = new Random();

            //Inicializamos cada posición del arreglo
            for (int i = 0; i < losPedidos.Length; i++)
            {
                losPedidos[i] = new Pedido();
                losPedidos[i].CodigoLocal = aleatorio.Next(cantidadLocales);
                losPedidos[i].TipoHamburguesa = lasHamburguesas[aleatorio.Next(lasHamburguesas.Length)];
                losPedidos[i].TipoBebida = lasBebidas[aleatorio.Next(lasBebidas.Length)];
                losPedidos[i].TipoPostre = losPostres[aleatorio.Next(losPostres.Length)];
            }

            //Aqui implementamos las funciones para hallar los mayores
            int mayorVentas = EncuentraValorMayorLocal(losPedidos, cantidadLocales, "ValorMayor");
            int localGanador = EncuentraValorMayorLocal(losPedidos, cantidadLocales, "LocalGanador");

            int totalHamburguesaGanadora = EncuentraTotalesGanadores(losPedidos,lasHamburguesas, "Hamburguesa", "ValorMayor");
            int hamburguesaGanadora = EncuentraTotalesGanadores(losPedidos, lasHamburguesas, "Hamburguesa", "Ganador");

            int totalBebidaGanadora = EncuentraTotalesGanadores(losPedidos, lasBebidas, "Bebida", "ValorMayor"); ;
            int bebidaGanadora = EncuentraTotalesGanadores(losPedidos, lasBebidas, "Bebida", "Ganador"); ;

            int totalPostreGanador = EncuentraTotalesGanadores(losPedidos, losPostres, "Postre", "ValorMayor"); ;
            int postreGanador = EncuentraTotalesGanadores(losPedidos, losPostres, "Postre", "Ganador"); ;

            Console.WriteLine("\nResultados del Evento");
            Console.WriteLine("\tEl local ganador fue {0} que vendió {1} pedidos", localGanador, mayorVentas);
            Console.WriteLine("\tLa hamburguesa ganadora fue {0} que vendió {1} pedidos", lasHamburguesas[hamburguesaGanadora], totalHamburguesaGanadora);
            Console.WriteLine("\tLa bebida ganadora fue {0} que vendió {1} pedidos", lasBebidas[bebidaGanadora], totalBebidaGanadora);
            Console.WriteLine("\tEl postre ganador fue {0} que vendió {1} pedidos", losPostres[postreGanador], totalPostreGanador);

        }

        /// <summary>
        /// Función que totaliza y encuentra el ganador según el atributo especificado
        /// </summary>
        /// <param name="arregloPedidos">El arreglo de pedidos</param>
        /// <param name="arregloAtributos">El arreglo de atributos que se utilizarán</param>
        /// <param name="atributo">Cadena con el atributo que se utilizará para el cálculo</param>
        /// <param name="valorBuscado"> Indica si busca el total o el codigo del atributo ganador</param>
        /// <returns>El valor buscado</returns>
        static int EncuentraTotalesGanadores(Pedido[] arregloPedidos, string[] arregloAtributos, string atributo, string valorBuscado)
        {
            int cantidadAtributo, atributoGanador, resultado = 0;

            int[] totalesAtributo = new int[arregloAtributos.Length];


            for (int i = 0; i < totalesAtributo.Length; i++)
                totalesAtributo[i] = 0;

            //Aqui recorremos el arreglo de pedidos buscando totalizar el atributo indicado
            for (int i = 0; i < arregloPedidos.Length; i++)
            {
                for (int j = 0; j < arregloAtributos.Length; j++)
                {
                    //Si el atributo es Hamburguesa
                    if(atributo == "Hamburguesa")
                        if (arregloPedidos[i].TipoHamburguesa == arregloAtributos[j])
                            totalesAtributo[j]++;
                    
                    //Si el atributo es Bebida
                    if (atributo == "Bebida")
                        if (arregloPedidos[i].TipoBebida == arregloAtributos[j])
                            totalesAtributo[j]++;

                    //Si el atributo es Bebida
                    if (atributo == "Postre")
                        if (arregloPedidos[i].TipoPostre == arregloAtributos[j])
                            totalesAtributo[j]++;
                }
            }

            //Aqui encontramos la cantidad mayor del atributo y cual es el atributo ganador
            atributoGanador = 0;
            cantidadAtributo = totalesAtributo[0];

            for (int i = 1; i < totalesAtributo.Length; i++)
                if (totalesAtributo[i] > cantidadAtributo)
                {
                    cantidadAtributo = totalesAtributo[i];
                    atributoGanador = i;
                }

            //Finalmente identificamos que resultado queremos para devolver el necesario
            //Aqui devolvemos el resultado según el parametro del valorBuscado
            if (valorBuscado == "ValorMayor")
                resultado = cantidadAtributo;

            if (valorBuscado == "Ganador")
                resultado = atributoGanador; //Sin modificar para tomar después el nombre desde el arreglo

            return resultado;
        }

        /// <summary>
        /// Función que encuentra el total mayor para un atributo
        /// </summary>
        /// <param name="arregloPedidos">El arreglo con los objetos tipo Pedido</param>
        /// <param name="atributo">El atributo para totalizar</param>
        /// <param name="valorBuscado">Identifica si debe buscar el valor o el código del local</param>
        /// <returns>El valor mayor encontrado</returns>
        static int EncuentraValorMayorLocal(Pedido[] arregloPedidos, int datoCantidadLocales, string valorBuscado)
        {
            int valorMayor, localGanador, resultado = 0;


            int[] ventasLocales = new int[datoCantidadLocales];

            for (int i = 0; i < ventasLocales.Length; i++)
                ventasLocales[i] = 0;

            //Recorremos el arreglo de pedidos y totalizamos al local
            //Pregunta para ti: ¿Qué estoy haciendo aqui y cómo?
            for (int i = 0; i < arregloPedidos.Length; i++)
                ventasLocales[arregloPedidos[i].CodigoLocal]++;

            //Luego identifico el valor mayor
            valorMayor = ventasLocales[0];
            localGanador = 0;

            for (int i = 1; i < ventasLocales.Length; i++)
                if (ventasLocales[i] > valorMayor)
                { 
                    valorMayor = ventasLocales[i];
                    localGanador = i;
                }

            //Aqui devolvemos el resultado según el parametro del valorBuscado
            if (valorBuscado == "ValorMayor")
                resultado = valorMayor;

            if (valorBuscado == "LocalGanador")
                resultado = (localGanador +1); // Traducido a los humanos que contamos desde 1! ;-)

            return resultado;
        }
    }
}
