using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Crear un programa que multiplique dos números enteros de la siguiente forma:
            pedirá al usuario un primer número entero. Si el número que se que teclee es 0,
           escribirá en pantalla "El producto de 0 por cualquier número es 0";. Si se ha
           tecleado un número distinto de cero, se pedirá al usuario un segundo número y
           se mostrará el producto de ambos. */

            int num1;
            int num2;
            int Producto;

            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());

           

            

            if (num1 == 0)
            {
                Console.WriteLine("El producto de 0 por cualquier número es 0");
            }
            else
            {
                Console.WriteLine("Ingrese el Segundo numero");
                num2 = Convert.ToInt32(Console.ReadLine());

                Producto = num1 * num2;

                Console.WriteLine("El producto de la multiplicacion es igual a  " + Producto);
            }




            Console.ReadKey();
        }
    }
}
