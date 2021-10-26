using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_VacunacionEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para el registro de la vacunación escolar");
            Console.WriteLine("Se registrarán las vacunas de los visitantes según sean ");
            Console.WriteLine("(A)stra Zeneca, (S)inovac, (P)fizer, (J)enssen y (M)oderna");

            //Declaración inicial de variables
            float totalVacunados = 0, sumaVerificacion = 0;
            float vacunadosA=0, vacunadosS = 0, vacunadosP = 0, vacunadosJ = 0, vacunadosM = 0, vacunadosN = 0;
            float porcentajeA, porcentajeS, porcentajeP, porcentajeJ, porcentajeM, porcentajeN;

            //Variables tipo "flag" (bandera) para identificar si una acción se cumplió
            bool datoVacunadosCorrecto = false;
            bool datoVacunaCorrecto = false;

            while (datoVacunadosCorrecto == false)
            {
                try
                {
                    Console.Write("\nIngresa la cantidad de personas que se registrarán hoy: ");
                    totalVacunados = float.Parse(Console.ReadLine());

                    if (totalVacunados <= 0)
                        Console.WriteLine("La cantidad de personas debe ser un numero mayor que cero. Intenta nuevamente!");
                    else
                    {
                        // Cambiamos el estado de la bandera, el dato de vacunados ya es correctos
                        datoVacunadosCorrecto = true;

                        // Aqui comenzamos a leer los datos por vacuna
                        while (datoVacunaCorrecto == false)
                        {
                            try
                            {
                                Console.WriteLine($"\n\nIngresa los valores individuales por cada vacuna, los cuales en total deben sumar {totalVacunados}: ");
                                
                                Console.Write("Ingresa los vacunados con Astra-Zeneca: ");
                                vacunadosA = float.Parse(Console.ReadLine());

                                Console.Write("Ingresa los vacunados con Pfizer: ");
                                vacunadosP = float.Parse(Console.ReadLine());

                                Console.Write("Ingresa los vacunados con Moderna: ");
                                vacunadosM = float.Parse(Console.ReadLine());

                                Console.Write("Ingresa los vacunados con Sinovac: ");
                                vacunadosS = float.Parse(Console.ReadLine());

                                Console.Write("Ingresa los vacunados con Jenssen: ");
                                vacunadosJ = float.Parse(Console.ReadLine());

                                Console.Write("Ingresa los no vacunados: ");
                                vacunadosN = float.Parse(Console.ReadLine());

                                //Se hacen dos preguntas:
                                //Si los valores de de cada vacuna individual son mayores o igual que cero
                                //Si la suma de esos valores es igual a la cantidad inicial.
                                if (vacunadosA >= 0 && vacunadosP >= 0 && vacunadosM >= 0 && vacunadosS >= 0 && vacunadosJ >= 0 && vacunadosN >= 0)
                                {
                                    //Validamos la suma
                                    sumaVerificacion = vacunadosA + vacunadosP + vacunadosM + vacunadosS + vacunadosJ + vacunadosN;
                                    if (sumaVerificacion == totalVacunados)
                                    {
                                        // Cambiamos el estado de la bandera, los datos individuales de vacuna son correctos
                                        datoVacunaCorrecto = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Dijiste que el total de vacunados era {totalVacunados}, pero los valores ingresados suman {sumaVerificacion}");
                                        Console.WriteLine("Ingresa nuevamente los valores! :-(");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Las cantidades por vacuna deben ser mayores o iguales a cero. Intenta nuevamente!");
                                }
                            }
                            catch (FormatException error)
                            {
                                Console.WriteLine("El dato de la cantidad de vacunados por biológico debe ser número mayor que cero. Intenta nuevamente!");
                                Console.WriteLine($"El mensaje de la excepción: {error.Message} \n\n");
                            }
                        }

                        //Aqui calculamos los porcentajes
                        porcentajeA = (vacunadosA / totalVacunados) * 100;
                        porcentajeS = (vacunadosS / totalVacunados) * 100;
                        porcentajeP = (vacunadosP / totalVacunados) * 100;
                        porcentajeJ = (vacunadosJ / totalVacunados) * 100;
                        porcentajeM = (vacunadosM / totalVacunados) * 100;
                        porcentajeN = (vacunadosN / totalVacunados) * 100;

                        //Aqui visualizamos resultados:
                        Console.WriteLine("\n\nResultados del registro de vacunación para el dia:");
                        if (vacunadosA == 0)
                            Console.WriteLine("No se presentaron personas vacunadas con Astra Zeneca");
                        else
                            Console.WriteLine($"Se registraron con Astra Zeneca {vacunadosA} personas que son {porcentajeA.ToString("0.00")}%");

                        if (vacunadosS == 0)
                            Console.WriteLine("No se presentaron personas vacunadas con Sinovac");
                        else
                            Console.WriteLine($"Se registraron con Sinovac {vacunadosS} personas que son {porcentajeS.ToString("0.00")}%");

                        if (vacunadosP == 0)
                            Console.WriteLine("No se presentaron personas vacunadas con Pfizer");
                        else
                            Console.WriteLine($"Se registraron con Pfizer {vacunadosP} personas que son {porcentajeP.ToString("0.00")}%");

                        if (vacunadosJ == 0)
                            Console.WriteLine("No se presentaron personas vacunadas con Janssen");
                        else
                            Console.WriteLine($"Se registraron con Janssen {vacunadosJ} personas que son {porcentajeJ.ToString("0.00")}%");

                        if (vacunadosM == 0)
                            Console.WriteLine("No se presentaron personas vacunadas con Moderna");
                        else
                            Console.WriteLine($"Se registraron con Moderna {vacunadosM} personas que son {porcentajeM.ToString("0.00")}%");

                        if (vacunadosN == 0)
                            Console.WriteLine("No se presentaron personas sin vacunar");
                        else
                            Console.WriteLine($"Se registraron {vacunadosN} personas sin vacunar, que son {porcentajeN.ToString("0.00")}%");
                    }                    
                }
                catch (FormatException error)
                {
                    Console.WriteLine("El dato de la cantidad de vacunados debe ser número mayor que cero. Intenta nuevamente!");
                    Console.WriteLine($"El mensaje de la excepción: {error.Message} \n\n");
                }
            }

            Console.WriteLine("\n\nFin del programa.");

        }
    }
}
