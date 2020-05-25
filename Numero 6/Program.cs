using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear un programa que pida al usuario dos números enteros. Si el segundo no
           es cero, mostrará el resultado de dividir entre el primero y el segundo. Por el
           contrario, si el segundo número es cero, escribirá "Error: No se puede dividir
           entre cero" . */

            int num1;
            int num2;
            int divicion;

            Console.WriteLine("Ingrese el primero numero");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el Segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == 0 || num2 == 0)
            {
                Console.WriteLine("Error: No se puede dividir entre cero");
            }
            else
            {
                divicion = num1 / num2;

                Console.WriteLine("El resultado de la divicion es  " + divicion);
            }

            Console.ReadKey();
        }
    }
}
