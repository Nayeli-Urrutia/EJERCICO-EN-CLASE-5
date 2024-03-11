using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_pareja
{
    internal class Program
    {

        static void Main(string[] args)
        {

        //EJERCICIO 1
            int numeroMayor = 0;
            int numeroMenor = 0;
            bool primerValor = true;

            while (true)
            {
                Console.WriteLine("Ingrese un valor positivo (0 para salir): ");

               
                try
                {
                    int valor = int.Parse(Console.ReadLine());

                    if (valor < 0)
                    {
                        Console.WriteLine("Error: Ingrese un valor positivo.");
                        continue;
                    }

                    if (valor == 0)
                    {
                        break;
                    }

                    
                    if (primerValor || valor > numeroMayor)
                    {
                        numeroMayor = valor;
                    }

                    if (primerValor || valor < numeroMenor)
                    {
                        numeroMenor = valor;
                    }

                    primerValor = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Ingrese un número válido.");
                    continue; 
                }
            }

            if (numeroMayor > 0)
            {
                Console.WriteLine("El número mayor es: {0}", numeroMayor);
                Console.WriteLine("El número menor es: {0}", numeroMenor);
            }
            else
            {
                Console.WriteLine("No se ingresaron valores positivos.");
            }     
            Console.ReadKey();
            Console.Clear();



            //EJERCICIO 2
            int resultado;
            Console.WriteLine("**********************************");
            Console.WriteLine("        Piense en un Número       ");
            Console.WriteLine("**********************************");
            Console.WriteLine("presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("**********************************");
            Console.WriteLine(" ese número Multipliquelo por 2");
            Console.WriteLine("**********************************");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("**********************************");
            Console.WriteLine("      al resultado sumele 8");
            Console.WriteLine("**********************************");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("**********************************");
            Console.WriteLine(" ahora al resultado multipliquelo por 5");
            Console.WriteLine("**********************************");
             Console.ReadKey();
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("****** Ingrese el resultado******");
            Console.ResetColor();
            resultado= int.Parse(Console.ReadLine());


           
           int numeroadivinado = resultado / 10;

            
            numeroadivinado -= 4;

            
            Console.WriteLine("¡Tu número secreto es:  "  + numeroadivinado);
            Console.ReadKey();
            Console.Clear();


            //EJERCICIO 3

            Console.WriteLine(" Ingrese una frase: ");
                string frase = Console.ReadLine();

               
                int numeroPalabras = 1;
                bool espacioAnterior = false;
                for (int i = 0; i < frase.Length; i++)
                {
                    if (frase[i] == ' ')
                    {
                        if (!espacioAnterior)
                        {
                            numeroPalabras++;
                        }
                        espacioAnterior = true;
                    }
                    else
                    {
                        espacioAnterior = false;
                    }
                }

                int numeroVocales = 0;
                string vocales = "aeiouáéíóúAEIOUÁÉÍÓÚ";
                for (int i = 0; i < frase.Length; i++)
                {
                    if (vocales.Contains(frase[i]))
                    {
                        numeroVocales++;
                    }
                }              
                Console.WriteLine("Número de palabras: {0}", numeroPalabras);
                Console.WriteLine("Número de vocales: {0}", numeroVocales);
                Console.ReadKey();
                Console.Clear();


            //EJERCICIO 4

          
                
                Console.WriteLine("Ingrese una palabra: ");
                string palabra = Console.ReadLine();

                
                palabra = palabra.ToLower();

                
                string palabraInvertida = "";
                for (int i = palabra.Length - 1; i >= 0; i--)
                {
                    palabraInvertida += palabra[i];
                }

                
                bool esPalindromo = palabra.Equals(palabraInvertida);

                
                if (esPalindromo)
                {
                    Console.WriteLine("¡La palabra es un palíndromo!");
                }
                else
                {
                    Console.WriteLine("La palabra no es un palíndromo.");
                }
            Console.ReadKey();
            Console.Clear();
        }
        }

    }


