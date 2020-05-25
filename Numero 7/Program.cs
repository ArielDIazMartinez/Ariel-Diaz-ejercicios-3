using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear un programa que pida al usuario un número enteros y diga si es múltiplo
             de 4 o de 5. */

            int num1;

            Console.WriteLine("Ingrese un numero entero");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 5 == 0)
            {
                if (num1 % 4 == 0)
                {
                    Console.WriteLine("El numero es multiplo de 4 ");
                }
                else
                {
                    Console.WriteLine("El numero no es multiplo de 4 ");
                }

                Console.WriteLine("El numero es multiplo de 5 ");              
            }
            else
            {

                Console.WriteLine("El numero NO es multiplo de  5");

                if (num1 % 4 == 0)
                {
                    Console.WriteLine("El numero es multiplo de 4 ");
                }
                else
                {
                    Console.WriteLine("El numero no es multiplo de 4 ");
                }
            }

            Console.ReadKey();
        }
    }
}
