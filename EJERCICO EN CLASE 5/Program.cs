using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICO_EN_CLASE_5
{
    internal class Program
    {

        //EJERCICO 1


        static void suma()
        {
            int respuesta, val1, val2 = 0;
            Console.WriteLine("ingrese valor 1:");
            val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese valor 2:");
            val2 = Convert.ToInt32(Console.ReadLine());
            respuesta = val1 + val2;
            Console.WriteLine("La suma = " + respuesta);
            Console.ReadKey();
        }
        static void datos()
        //EJERCICIO 2
        {
            Console.WriteLine("Cual es su nombre:");
            string Nombre = Console.ReadLine();
            Console.WriteLine("mucho gusto " + Nombre);
            Console.ReadKey();
        }
        //EJERCCIO 3
        static void calculoEdad()
        {
            Console.WriteLine("Ingrese su año de nacimiento");
            int año = int.Parse(Console.ReadLine());
            int edad = 2024 - año;
            Console.WriteLine("su edad es =" + edad);
            Console.ReadKey();

        }

        //EJERCICIO 4
        static int suma1 (int val1, int val2, int val3 )
        {
           return   val1 + val2+ val3;
            
        }
       
            static void Main(string[] args)

             {

            int opcion;

            try
            {

                do
                {
             
                    Console.WriteLine("1. Suma");
                    Console.WriteLine("2. Nombre");
                    Console.WriteLine("3. Edad");
                    Console.WriteLine("4. Salir");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            suma();
                            break;
                        case 2:
                            datos();
                            break;
                        case 3:
                            calculoEdad();
                            break;
                        case 4:
                            Console.WriteLine("Saliendo...");
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Seleccione del 1 al 4.");
                            break;
                    }
                } while (opcion != 4);
           

            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Ingrese un número válido.");
               
            }
            Console.ReadKey();

        }


    }


    }
    

