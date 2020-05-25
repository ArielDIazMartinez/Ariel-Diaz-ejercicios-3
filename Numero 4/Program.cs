using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Crear un programa que pida al usuario un número entero. Si es múltiplo de 10,
            se lo avisará al usuario y pedirá un segundo número, para decir a continuación
            si este segundo número también es múltiplo de 10. */

            int num1;
                                 

            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
          

            if (num1 % 10 == 0)
            {
                Console.WriteLine("El primer numero SI es multiplo de 10");

            }
            else
            {
                Console.WriteLine("El primer numero NO es multiplo de 10 ");
            }

            Console.ReadKey();

        }
    }
}
