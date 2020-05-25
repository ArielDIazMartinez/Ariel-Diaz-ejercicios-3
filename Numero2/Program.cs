using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear un programa que pida al usuario dos números enteros y diga cuál es el
              mayor de ellos */
             
            int num1;
            int num2;

            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el SEGUNDO numero");
            num2 = Convert.ToInt32(Console.ReadLine());


            if (num1 == num2)
            {
                Console.WriteLine("LOS NUMEROS INGRESADOS SON IGUALES");
               
            }

            if (num1 > num2)
            {
                Console.WriteLine("El primer numero es mayor");
            }
            else if (num1 < num2 )
            {
                Console.WriteLine("El segundo numero es mayor");            
            }

           
            Console.ReadKey();

        }
    }
}
