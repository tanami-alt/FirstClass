using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7  // Biblioteca o clase a la que pertenece (DLL) Bibliioteca de clases
{
    internal class Program // Nivel de protección o modificador de acceso
        // Internal: accesible solo dentro del mismo ensamblado (proyecto). 
        // Public: accesible desde cualquier otro código.
        // Private: accesible solo dentro del mismo tipo o clase.
        // Protected: accesible dentro del mismo tipo o clase y en tipos derivados.
    {
        static void Main(string[] args) // Static: pertenece a la clase en sí, no a una instancia específica de la clase.
            // void: el método no devuelve ningún valor. 
            // Main: punto de entrada de la aplicación
            // string[] args: parámetro que recibe argumentos de línea de comandos como un array de cadenas.
            // args: nombre del parámetro que representa los argumentos de línea de comandos.
            // parametros de entrada
    
        {
            int n, contapar, contaimpar, num; // Variables:int, decimal, float (decimal más preciso), string, char, bool
            contapar = 0;
            contaimpar = 0;
            num = 0;

            Console.WriteLine("Digite la cantidad de números a evaluar: ");
            n = int.Parse(Console.ReadLine()); // Convertir la entrada del usuario a un entero

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite un número: ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0) // Operador módulo: devuelve el resto de la división
                {
                    contapar++;
                }
                else
                {
                    contaimpar++;
                }
            }
            Console.WriteLine("Cantidad de números pares: " + contapar);
            Console.WriteLine("Cantidad de números impares: " + contaimpar);

            Console.ReadKey(true); // Espera a que el usuario presione una tecla antes de cerrar la consola
        }
        }
    }  

