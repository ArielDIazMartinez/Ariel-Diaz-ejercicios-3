using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Crear un programa que pida al usuario dos números enteros y diga si el primero
            es múltiplo del segundo */

            int num1;
            int num2;
            int num3;
            
            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el primer numero");
            num2 = Convert.ToInt32(Console.ReadLine());       

            num3 = num1 % num2;           

            if (num3 == 0)
            {
                Console.WriteLine("El primero numero es Multiplo del segundo SU RESIDUO ES: " + num3);
              
            }
            else
            {
                Console.WriteLine("El PRIMER NUMERO  NO ES MULTIPLO DEL SEGUNDO ");
            }

            Console.ReadKey();

        }
    }
}
