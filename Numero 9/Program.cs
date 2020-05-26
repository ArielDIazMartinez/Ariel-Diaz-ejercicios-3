using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear un programa que pida al usuario tres números reales y muestre cuál es el
               mayor de los tres. */

            double num1;
            double num2;
            double num3;

            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el Segundo numero");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el Tercer numero");
            num3 = Convert.ToDouble(Console.ReadLine());

             if (num1 >= num2 && num1 >= num3)
                {
                    Console.WriteLine("El primer numero es el mayor");

                }

            else
            {
                if (num2 >= num3 && num2 >= num1)
                {
                    Console.WriteLine("El Segundo numero es el mayor");

                }
                else
                {
                     
                    if (num3 >= num1 && num3 >= num2)
                            {
                                Console.WriteLine("El Tercer numero es el mayor");
                            }
                }
                    
                      

            }
            Console.ReadKey();
            
        }       
    }
}
