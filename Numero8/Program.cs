using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear un programa que pida al usuario dos números enteros y diga  "Uno de los
             números es positivo ", "Los dos números son positivos " o bien "Ninguno de los
                  números es positivo", según corresponda. */

            int num1;
            int num2;
            

            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el Segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 <= 1 && num2 <= 1)
            {
                Console.WriteLine("Ninguno de los numeros es positivo");
            }
            else
            {
                if (num1 <= 1 || num2 <= 1)
                {
                    Console.WriteLine("Uno de los números es positivo");

                }
                else
                {

                    Console.WriteLine("Los dos números son positivos");
                }
            }

           

       
            

            Console.ReadKey();


        }
    }
}
