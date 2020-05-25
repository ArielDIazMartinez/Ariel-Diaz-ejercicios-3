using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUmero_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que pida al usuario un número entero y diga si es par.

            int num;

            Console.WriteLine("Ingrese un numero");
            num = Convert.ToInt32(Console.ReadLine());

            if (num%2==0) 
            {
                Console.WriteLine("El numero es Par");  

            
            }
            else
            {
                Console.WriteLine("El Numero es Impar");
            }
            Console.ReadKey();
        }
    }
}
